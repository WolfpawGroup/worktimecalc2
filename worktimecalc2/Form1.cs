using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;
using iTextSharp.text.pdf;

namespace worktimecalc2
{
    public partial class Form1 : Form
    {

        public bool workdayReportOnly = false;

        public bool displayFlipped = false;
        public bool pm_minus = false;
        public TimeSpan daily = new TimeSpan();
        public obj_Times times = new obj_Times();

        public String userName = "";
        public bool forceUserName = false;
        public String assumedUserName = "";

        public bool showDiagram = true;

        public bool lockView = false;
        
        public String regx_proper = "(Hétf.|Kedd|Szerda|Csütörtök|Péntek|Szombat|Vasárnap) (\\d{4}-\\d{2}-\\d{2}) (\\d{2}:\\d{2}) - (\\d{2}:\\d{2})";
        public String regx_vacsic = "(Hétf.|Kedd|Szerda|Csütörtök|Péntek|Szombat|Vasárnap) (\\d{4}-\\d{2}-\\d{2}) 1";
        public String regx_daysoff = "(Hétf.|Kedd|Szerda|Csütörtök|Péntek|Szombat|Vasárnap) (\\d{4}-\\d{2}-\\d{2}) true";
        public String regx_nothing = "(Hétf.|Kedd|Szerda|Csütörtök|Péntek|Szombat|Vasárnap) (\\d{4}-\\d{2}-\\d{2}) 8";

        public String rx_proper, rx_vacsic, rx_daysoff, rx_nothing;

		List<string> breakobjects = new List<string>();

		public Form1(String[] args)
        {
            InitializeComponent();
            Load += Form1_Load;

            if (args.Length == 1)
            {
                if (File.Exists(args[0]))
                {
                    rtb_Report_01.Text = File.ReadAllText(args[0]);
                    button2_Click(null, null);
                    button2_Click(null, null);
                }
            }
        }

        public void getSettings()
        {
            regx_proper = Properties.Settings.Default.s_Regex_Proper;
            regx_daysoff = Properties.Settings.Default.s_Regex_DaysOff;
            regx_vacsic = Properties.Settings.Default.s_Regex_VacSic;
            regx_nothing = Properties.Settings.Default.s_Regex_Nothing;

            lockView = Properties.Settings.Default.s_LockView;

            forceUserName = Properties.Settings.Default.s_forceUserName;
            userName = Properties.Settings.Default.s_UserName;
            workdayReportOnly = Properties.Settings.Default.s_HideOFFDAYS;
            rtb_Report_01.Font = rtb_Report_02.Font = Properties.Settings.Default.s_rtfFont;
            lv_Results_01.Font = lv_Results_02.Font = Properties.Settings.Default.s_lvFont;
            showDiagram = Properties.Settings.Default.s_ShowDiagram;

            if (lockView)
            {
                btn_DisplayFlip.Enabled = false;
                displayFlipped = false;
            }
            else
            {
                btn_DisplayFlip.Enabled = true;
                displayFlipped = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
			if (!File.Exists("itextsharp.dll"))
			{
				File.WriteAllBytes("itextsharp.dll", Properties.Resources.itextsharp);
			}

			if (!File.Exists("SharpZipLib.dll"))
			{
				File.WriteAllBytes("SharpZipLib.dll", Properties.Resources.SharpZipLib);
			}

			Icon = Properties.Resources.logoclock;

            //Backups
            rx_proper = regx_proper;
            rx_vacsic = regx_vacsic;
            rx_daysoff = regx_daysoff;
            rx_nothing = regx_nothing;

            getSettings();

            flipDisplay();

            num_DailyH.Value = Properties.Settings.Default.s_LenOfWorkDayH;
            num_DailyM.Value = Properties.Settings.Default.s_LenOfWorkDayM;

            daily = new TimeSpan((int)num_DailyH.Value, (int)num_DailyM.Value, 0);
            
            if (!Properties.Settings.Default.s_LastStyleFlopped) { flipDisplay(); }

			breakobjects.AddRange(Properties.Settings.Default.s_dayNames.Split(','));
			breakobjects.Add("(óra)");
			breakobjects.Add("(nap)");
			breakobjects.Add("Betegszabadság");
			breakobjects.Add("Túlóra");
			breakobjects.Add("Nap Munkaórák");
			breakobjects.Add("Fizetési");
			breakobjects.Add("Alkalmazott");
			breakobjects.Add("száma");
			breakobjects.Add("Szabadság");
			breakobjects.Add("Felettes");
			breakobjects.Add("Készenlét");
			breakobjects.Add("Home Office");
			breakobjects.Add("Kiküldetés");
			breakobjects.Add("Összesen");
			breakobjects.Add("e-radius");
		}

        public void flipDisplay()
        {
            if (displayFlipped)
            {
                sc1.Panel2Collapsed = true;
                sc2.Panel1Collapsed = true;

            }
            else
            {
                sc1.Panel2Collapsed = false;
                sc2.Panel2Collapsed = true;
            }

            displayFlipped = !displayFlipped;
        }

		public bool ChangeText = true;

        private void rtb_Report_02_TextChanged(object sender, EventArgs e)
        {
			if (ChangeText)
			{
				ChangeText = false;

				rtb_Report_01.Text = rtb_Report_02.Text;

				string s = checkContainsToday();
				if (s != "")
				{
					lbl_ContainsToday.Show();
				}
				else
				{
					lbl_ContainsToday.Hide();
				}

				rtb_Report_02.Font = Properties.Settings.Default.s_rtfFont;

				rtb_Report_01.Font = Properties.Settings.Default.s_rtfFont;

				ChangeText = true;
			}
			
			Properties.Settings.Default.s_LastText = rtb_Report_02.Text;

			Properties.Settings.Default.Save();
			
        }

        private void rtb_Report_01_TextChanged(object sender, EventArgs e)
        {
			if (ChangeText)
			{
				ChangeText = false;

				rtb_Report_02.Text = rtb_Report_01.Text;

				string s = checkContainsToday();
				if (s != "")
				{
					lbl_ContainsToday.Show();
				}
				else
				{
					lbl_ContainsToday.Hide();
				}

				rtb_Report_01.Font = Properties.Settings.Default.s_rtfFont;

				rtb_Report_02.Font = Properties.Settings.Default.s_rtfFont;


				ChangeText = true;
			}
			
			Properties.Settings.Default.s_LastText = rtb_Report_01.Text;

			Properties.Settings.Default.Save();
			
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flipDisplay();

            Properties.Settings.Default.s_LastStyleFlopped = displayFlipped;
            Properties.Settings.Default.Save();
        }

        private void p_plusminus_Click(object sender, EventArgs e)
        {
            pm_minus = !pm_minus;
            p_plusminus.BackgroundImage = pm_minus ? Properties.Resources.minus : Properties.Resources.plus;
        }

        private void btn_Graph_Click(object sender, EventArgs e)
        {
            f_Graph graph = new f_Graph();
            graph.times = times;
            graph.workTime = daily.TotalHours;
            graph.ShowDialog();
        }

		#region Fields

		#region _numberOfCharsToKeep
		/// <summary>
		/// The number of characters to keep, when extracting text.
		/// </summary>
		private static int _numberOfCharsToKeep = 15;
		#endregion

		#endregion

		#region CheckToken
		/// <summary>
		/// Check if a certain 2 character token just came along (e.g. BT)
		/// </summary>
		/// <param name="search">the searched token</param>
		/// <param name="recent">the recent character array</param>
		/// <returns></returns>
		private bool CheckToken(string[] tokens, char[] recent)
		{
			foreach (string token in tokens)
			{
				if ((recent[_numberOfCharsToKeep - 3] == token[0]) &&
					(recent[_numberOfCharsToKeep - 2] == token[1]) &&
					((recent[_numberOfCharsToKeep - 1] == ' ') ||
					(recent[_numberOfCharsToKeep - 1] == 0x0d) ||
					(recent[_numberOfCharsToKeep - 1] == 0x0a)) &&
					((recent[_numberOfCharsToKeep - 4] == ' ') ||
					(recent[_numberOfCharsToKeep - 4] == 0x0d) ||
					(recent[_numberOfCharsToKeep - 4] == 0x0a))
					)
				{
					return true;
				}
			}
			return false;
		}
		#endregion

		#region ExtractTextFromPDFBytes
		/// <summary>
		/// This method processes an uncompressed Adobe (text) object 
		/// and extracts text.
		/// </summary>
		/// <param name="input">uncompressed</param>
		/// <returns></returns>
		private string ExtractTextFromPDFBytes(byte[] input)
		{
			if (input == null || input.Length == 0) return "";

			try
			{
				string resultString = "";

				// Flag showing if we are we currently inside a text object
				bool inTextObject = false;

				// Flag showing if the next character is literal 
				// e.g. '\\' to get a '\' character or '\(' to get '('
				bool nextLiteral = false;

				// () Bracket nesting level. Text appears inside ()
				int bracketDepth = 0;

				// Keep previous chars to get extract numbers etc.:
				char[] previousCharacters = new char[_numberOfCharsToKeep];
				for (int j = 0; j < _numberOfCharsToKeep; j++) previousCharacters[j] = ' ';


				for (int i = 0; i < input.Length; i++)
				{
					char c = (char)input[i];

					if (inTextObject)
					{
						// Position the text
						if (bracketDepth == 0)
						{
							if (CheckToken(new string[] { "TD", "Td" }, previousCharacters))
							{
								resultString += "\n\r";
							}
							else
							{
								if (CheckToken(new string[] { "'", "T*", "\"" }, previousCharacters))
								{
									resultString += "\n";
								}
								else
								{
									if (CheckToken(new string[] { "Tj" }, previousCharacters))
									{
										resultString += " ";
									}
								}
							}
						}

						// End of a text object, also go to a new line.
						if (bracketDepth == 0 &&
							CheckToken(new string[] { "ET" }, previousCharacters))
						{

							inTextObject = false;
							resultString += " ";
						}
						else
						{
							// Start outputting text
							if ((c == '(') && (bracketDepth == 0) && (!nextLiteral))
							{
								bracketDepth = 1;
							}
							else
							{
								// Stop outputting text
								if ((c == ')') && (bracketDepth == 1) && (!nextLiteral))
								{
									bracketDepth = 0;
								}
								else
								{
									// Just a normal text character:
									if (bracketDepth == 1)
									{
										// Only print out next character no matter what. 
										// Do not interpret.
										if (c == '\\' && !nextLiteral)
										{
											nextLiteral = true;
										}
										else
										{
											if (((c >= ' ') && (c <= '~')) ||
												((c >= 128) && (c < 255)))
											{
												resultString += c.ToString();
											}

											nextLiteral = false;
										}
									}
								}
							}
						}
					}

					// Store the recent characters for 
					// when we have to go back for a checking
					for (int j = 0; j < _numberOfCharsToKeep - 1; j++)
					{
						previousCharacters[j] = previousCharacters[j + 1];
					}
					previousCharacters[_numberOfCharsToKeep - 1] = c;

					// Start of a text object
					if (!inTextObject && CheckToken(new string[] { "BT" }, previousCharacters))
					{
						inTextObject = true;
					}
				}
				return resultString;
			}
			catch
			{
				return "";
			}
		}
		#endregion
		
		public void parsePDF(string inFileName)
		{
			//TODO: ParsePDF
			PdfReader reader = new PdfReader(inFileName);
			int totalLen = 68;
			float charUnit = ((float)totalLen) / (float)reader.NumberOfPages;

			string pages = "";

			for (int page = 1; page <= reader.NumberOfPages; page++)
			{
				pages += ExtractTextFromPDFBytes(reader.GetPageContent(page)) + " ";
			}

			foreach (string s in breakobjects)
			{
				pages = pages.ToLower().Replace(s.ToLower(), "\r\n" + s);
			}

			rtb_Report_01.Text = pages;

			//File.WriteAllText("test.txt", pages);

			/*
			PDFParser pdfp = new PDFParser();
			pdfp.ExtractText(inFileName, "test2.txt");
			*/

			
		}

        private void p_plusminus_MouseEnter(object sender, EventArgs e)
        {
            p_plusminus.BorderStyle = BorderStyle.FixedSingle;
        }

        private void p_plusminus_MouseLeave(object sender, EventArgs e)
        {
            p_plusminus.BorderStyle = BorderStyle.None;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                start();
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message + "\r\n\r\nLehet, hogy elírtad a RegEx-et?");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void start()
        {
            btn_Report_HTML.Enabled = btn_Report_Txt.Enabled = true;

            times = new obj_Times();

            TimeSpan addTime = new TimeSpan();
            TimeSpan remTime = new TimeSpan();

            if (num_CorrH.Value + num_CorrM.Value > 0)
            {
                addTime += new TimeSpan((int)num_CorrH.Value, (int)num_CorrM.Value, 0);
                remTime += new TimeSpan((int)num_CorrH.Value * -1, (int)num_CorrM.Value * -1, 0);
            }

            lv_Results_01.Items.Clear();
            lv_Results_02.Items.Clear();

            DateTime arr = new DateTime();
            DateTime dep = new DateTime();
            DateTime n = DateTime.Now;

            TimeSpan time = new TimeSpan();
            TimeSpan dif = new TimeSpan();
            TimeSpan tDiff = new TimeSpan(0, 0, 0);
            TimeSpan tWork = new TimeSpan(0, 0, 0);

            int numOfDays = 0;

            List<String> lines = new List<string>();

            if (rtb_Report_01.Text != "" && rtb_Report_02.Text == rtb_Report_01.Text)
            {

                tc1.SelectedIndex = 1;

                foreach (String s in rtb_Report_01.Lines)
                {
                    foreach (String ss in Properties.Settings.Default.s_dayNames.Split(','))
                    {
                        if (s.ToLower().StartsWith(ss.ToLower()))
                            lines.Add(s);
                    }
                }
            }

            Regex r_proper = new Regex(regx_proper);
            Regex r_daysOff = new Regex(regx_daysoff);
            Regex r_vacsic = new Regex(regx_vacsic);
            Regex r_nothing = new Regex(regx_nothing);
            MatchCollection mc = null;
            CaptureCollection cc = null;

			try
			{
				assumedUserName = rtb_Report_01.Lines[Properties.Settings.Default.s_UseLine];
			}
			catch {
				assumedUserName = "Unknown User";
			}

			if (forceUserName && userName != "")
			{
				Text = "WolfPaw WorkTime Calculator 2 - " + userName;
			}
			else if (forceUserName && userName == "")
			{
				Text = "WolfPaw WorkTime Calculator 2 - Unknown user";
			}
			else
			{
				Text = "WolfPaw WorkTime Calculator 2 - " + assumedUserName;
			}

			foreach (String s in lines)
            {
                ListViewItem lvi = new ListViewItem();

                ListViewItem.ListViewSubItem lvsi1 = new ListViewItem.ListViewSubItem();
                ListViewItem.ListViewSubItem lvsi2 = new ListViewItem.ListViewSubItem();
                ListViewItem.ListViewSubItem lvsi3 = new ListViewItem.ListViewSubItem();
                ListViewItem.ListViewSubItem lvsi4 = new ListViewItem.ListViewSubItem();
                ListViewItem.ListViewSubItem lvsi5 = new ListViewItem.ListViewSubItem();
                ListViewItem.ListViewSubItem lvsi6 = new ListViewItem.ListViewSubItem();


                if (r_daysOff.IsMatch(s))
                {
                    mc = r_daysOff.Matches(s);
                    cc = mc[0].Captures;
                    lvi.Text = mc[0].Groups[2].Value;
                    lvsi1.Text = mc[0].Groups[1].Value;
                    lvsi6.Text = "Munkaszüneti Nap";
                    lvi.BackColor = Color.LightGray;
                }
                else if (r_vacsic.IsMatch(s))
                {
                    mc = r_vacsic.Matches(s);
                    cc = mc[0].Captures;
                    lvi.Text = mc[0].Groups[2].Value;
                    lvsi1.Text = mc[0].Groups[1].Value;
                    lvsi6.Text = "Szabadság / Betegség";
                    lvi.BackColor = Color.LightGreen;
                }
                else if (r_nothing.IsMatch(s))
                {
                    mc = r_nothing.Matches(s);
                    cc = mc[0].Captures;
                    lvi.Text = mc[0].Groups[2].Value;
                    lvsi1.Text = mc[0].Groups[1].Value;
                    lvsi6.Text = " - ";
                    lvi.BackColor = Color.LightYellow;
                }
                else if (r_proper.IsMatch(s))
                {
                    lvi.UseItemStyleForSubItems = false;

                    lvsi1.BackColor =
                    lvsi2.BackColor =
                    lvsi3.BackColor =
                    lvsi4.BackColor =
                    lvsi5.BackColor =
                    lvsi6.BackColor = Color.LightYellow;

                    lvsi1.Font =
                    lvsi2.Font =
                    lvsi3.Font =
                    lvsi4.Font =
                    lvsi5.Font =
                    lvsi6.Font = Properties.Settings.Default.s_lvFont;

                    numOfDays++;

                    int ah = 0, am = 0, dh = 0, dm = 0;

                    mc = r_proper.Matches(s);
                    cc = mc[0].Captures;
                    lvi.Text = mc[0].Groups[2].Value;
                    lvsi1.Text = mc[0].Groups[1].Value;
                    lvsi2.Text = mc[0].Groups[3].Value;
                    lvsi3.Text = mc[0].Groups[4].Value;
                    
                    ah = Convert.ToInt32(lvsi2.Text.Split(':')[0]);
                    am = Convert.ToInt32(lvsi2.Text.Split(':')[1]);

                    //lvsi4.Text = mc[0].Groups[5].Value;

                    dh = Convert.ToInt32(lvsi3.Text.Split(':')[0]);
                    dm = Convert.ToInt32(lvsi3.Text.Split(':')[1]);

                    arr = new DateTime(n.Year, n.Month, n.Day, ah, am, 0);
                    dep = new DateTime(n.Year, n.Month, n.Day, dh, dm, 0);

                    time = dep.TimeOfDay - arr.TimeOfDay;

                    lvsi4.Text = time.Hours.ToString().PadLeft(2, '0') + ":" + time.Minutes.ToString().PadLeft(2, '0');

                    dif = time - daily;

                    String tme = "";

                    tme = dif.ToString().Substring(0, dif.ToString().Length - 3);

                    lvsi5.Text = tme;

                    if (dif.TotalMinutes > 0)
                    {
                        lvsi5.Text = " " + lvsi5.Text;
                        lvsi5.Text += " ↑";
                        lvsi5.BackColor = Color.Green;
                    }
                    else if (dif.TotalMinutes < 0)
                    {
                        lvsi5.Text += " ↓";

                        lvsi5.BackColor = Color.LightPink;

                        if (dif.TotalMinutes <= -30)
                        {
                            lvsi5.BackColor = Color.OrangeRed;
                        }
                        if (dif.TotalMinutes <= -60)
                        {
                            lvsi5.BackColor = Color.Red;
                        }
                    }
                    else
                    {
                        lvsi5.Text += " =";
                    }

                    lvsi6.Text = "";
                    lvi.BackColor = Color.LightYellow;

                    tDiff += dif;
                    tWork += time;


                    times.addItem(numOfDays, Convert.ToDateTime(mc[0].Groups[2].Value), Convert.ToDateTime(mc[0].Groups[3].Value), Convert.ToDateTime(mc[0].Groups[4].Value), time);

                }

                if (lvsi1.Text.ToLower() == "hétfo") { lvsi1.Text = lvsi1.Text.Replace("o", "ő"); }

                lvi.SubItems.Add(lvsi1);
                lvi.SubItems.Add(lvsi2);
                lvi.SubItems.Add(lvsi3);
                lvi.SubItems.Add(lvsi4);
                lvi.SubItems.Add(lvsi5);
                lvi.SubItems.Add(lvsi6);

                if (!lockView)
                {
                    lv_Results_02.Items.Add(lvi);
                    
                }

                ListViewItem lvi2 = (ListViewItem)lvi.Clone();

                lvi2.Font = Properties.Settings.Default.s_lvFont;

                lv_Results_01.Items.Add(lvi2);

                
            }

            if (!lockView)
            {
                ch_Arrival_02.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
                ch_AtWork_02.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
                ch_Date_02.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
                ch_DayOfWeek_02.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
                ch_DayType_02.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
                ch_Departure_02.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
                ch_Diff_02.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }

            ch_Arrival_01.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            ch_AtWork_01.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            ch_Date_01.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            ch_DayOfWeek_01.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            ch_DayType_01.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            ch_Departure_01.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            ch_Diff_01.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);

            lv_Results_01.Font = Properties.Settings.Default.s_lvFont;
            lv_Results_02.Font = Properties.Settings.Default.s_lvFont;


            if (num_CorrH.Value + num_CorrM.Value > 0)
            {
                if (pm_minus)
                {
                    tDiff += remTime;
                    tWork += remTime;
                }
                else
                {
                    tDiff += addTime;
                    tWork += addTime;
                }
            }

            try
            {
                tb_Diff.Text = tDiff.ToString().Substring(0, tDiff.ToString().Length - 3);
                tb_Mean.Text = new TimeSpan(0, ((int)tWork.TotalMinutes / numOfDays), 0).ToString();
                tb_Days.Text = numOfDays + "";
            }
            catch { }

            if (tDiff.TotalMinutes < 0)
            {
                tb_Diff.BackColor = Color.LightPink;
                tb_Diff.Text += " ↓";
            }
            else if (tDiff.TotalMinutes > 0)
            {
                tb_Diff.BackColor = Color.LightGreen;
                tb_Diff.Text += " ↑";
            }
            else
            {
                tb_Diff.BackColor = Color.LightYellow;
                tb_Diff.Text += " =";
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Report_Txt_Click(object sender, EventArgs e)
        {
            string un = "";

            if (forceUserName && userName != "")
            {
                un = userName;
            }
            else if (forceUserName && userName == "")
            {
                un = "Unknown user";
            }
            else
            {
                un = assumedUserName;
            }

            String str = "";

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Generate TXT report.";
            sfd.Filter = "TXT File|*.txt";

            sfd.FileName = "WorkTimeCalc TXT Report - " + DateTime.Now.Date.ToShortDateString();

            str = "WorkTimeCalc Report - " + un + "\r\n\t" + DateTime.Now.Date.ToShortDateString() + "\r\n\r\n";

            str += "Összegzés:\r\n";
            str += "Ledolgozott napok száma: " + tb_Days.Text + " nap\r\n" +
                   "Átlag munkában töltött idő: " + tb_Mean.Text + "\r\n" +
                   "Eltérés a ledolgozandó időtől: " + tb_Diff.Text + "\r\n\r\n------------------------------------------------\r\n\r\nRészletezés:\r\n";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                foreach (ListViewItem lvi in lv_Results_01.Items)
                {
                    if (workdayReportOnly)
                    {
                        if (lvi.SubItems[6].Text == "")
                            str += lvi.Text + " " + lvi.SubItems[1].Text.PadRight(10, ' ') + " | " + lvi.SubItems[2].Text.PadRight(5, ' ') + " - " + lvi.SubItems[3].Text.PadRight(5, ' ') + " | " + lvi.SubItems[4].Text.PadRight(5, ' ') + " - " + lvi.SubItems[5].Text.PadRight(10, ' ') + "\r\n";
                    }
                    else
                    {
                        str += lvi.Text + " " + lvi.SubItems[1].Text.PadRight(10, ' ') + " | " + lvi.SubItems[2].Text.PadRight(5, ' ') + " - " + lvi.SubItems[3].Text.PadRight(5, ' ') + " | " + lvi.SubItems[4].Text.PadRight(5, ' ') + " - " + lvi.SubItems[5].Text.PadRight(10, ' ') + (lvi.SubItems[6].Text != "" ? " | " + lvi.SubItems[6].Text : "") + "\r\n";
                    }
                }
                File.WriteAllText(sfd.FileName, str);
            }
        }

        private void btn_Report_HTML_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Generate HTML report.";
            sfd.Filter = "HTML File|*.html";

            sfd.FileName = "WorkTimeCalc HTML Report - " + DateTime.Now.Date.ToShortDateString();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, generateHTML());
            }


        }

        public String generateHTML()
        {
            string un = "";

            if (forceUserName && userName != "")
            {
                un = userName;
            }
            else if (forceUserName && userName == "")
            {
                un = "Unknown user";
            }
            else
            {
                un = assumedUserName;
            }

            String img = "";

            if (showDiagram)
            {
                img = "<img id='img' src='data:image/bmp;base64," + generateGraph() + "'/>";
            }

            String str = "";
            String str2 = "";


            str = "<html><head><meta charset='UTF-8'><title>" + "WorkTimeCalc HTML Report - " + DateTime.Now.Date.ToShortDateString() + "</title>" +
                "<style>" +
                "th { font-size: 1.5em; padding: 2px; border: 1px solid black; background: #888 }" +
                "td { padding:5px; border:1px solid black; border-collapse:collapse; }" +
                ".pink { background: lightpink; }" +
                ".lightred { background: #DD4444; }" +
                ".red { background: #FF0000; }" +
                ".lightgreen { background: lightgreen; }" +
                ".green { background: green; }" +
                ".yellow { background: lightyellow; }" +
                ".gray { background: lightgray; }" +
                "#img { position:absolute; right: 30px; top: 200px; width: 300px; }" +
                "#img:hover { width:auto; }" +
                "#img:active { width: 90%;}" +
                "</style>" +
                "</head>" +
                "<body style='background: lightblue; position:relative;'><h1>WorkTimeCalc Report - " + un + "<br />\t" + DateTime.Now.Date.ToShortDateString() + "</h1><br /><br />";



            str += "<table style='cell-padding:5px; border:1px solid black; border-collapse:collapse;'><tr><th>Dátum</th><th>Érkezés</th><th>Indulás</th><th>Munkában töltött idő</th><th>Eltérés</th><th>-</th></tr>";

            foreach (ListViewItem lvi in lv_Results_01.Items)
            {
                if (workdayReportOnly)
                {
                    if (lvi.SubItems[6].Text == "")
                        str2 += "<tr•class='yellow'><td>" + lvi.Text + " " + lvi.SubItems[1].Text + "</td><td>" + lvi.SubItems[2].Text + "</td><td>" + lvi.SubItems[3].Text + "</td><td>" + lvi.SubItems[4].Text + "</td><td>" + lvi.SubItems[5].Text + "</td><td></tr>\r\n";
                }
                else
                {
                    str2 += "<tr•class='" + (lvi.SubItems[6].Text == "" ? "yellow" : lvi.SubItems[6].Text == "Munkaszüneti Nap" ? "gray" : "lightgreen") + "'><td>" + lvi.Text + " " + lvi.SubItems[1].Text + "</td><td>" + lvi.SubItems[2].Text + "</td><td>" + lvi.SubItems[3].Text + "</td><td>" + lvi.SubItems[4].Text + "</td>" + getColor(lvi.SubItems[5].Text) + "</td><td>" + (lvi.SubItems[6].Text != "" ? lvi.SubItems[6].Text : "") + "</td></tr>\r\n";
                }
            }

            str2 = str2.Replace(" ", "&nbsp;");
            str2 = str2.Replace("•", " ");
            str += str2;

            str += "</table><br /><br /><br />";

            str += "<table style='border-collapse:collapse; background: white; position:absolute; right:50px; top: 50px;'>" +

                "<tr><td>Ledolgozott napok száma:</td><td>" + tb_Days.Text + " nap</td></tr>" +
                "<tr><td>Átlag munkában töltött idő: </td><td>" + tb_Mean.Text + " </td></tr>" +
                "<tr class='" + (tb_Diff.Text.Contains("↓") ? "pink" : "lightgreen") + "'><td>Eltérés a ledolgozandó időtől: </td><td>" + tb_Diff.Text + "</td></tr>";

            str += "</table>";

            str += img;

            str += "</body></html>";

            return str;
        }


        int multiplyTimes = 4;
        int graphEdge = 400;

        public String generateGraph()
        {
            graphEdge = 250;

            int days = times.getDays();
            Bitmap bmp = new Bitmap((int)(2 + (days * 12) * multiplyTimes) + graphEdge, ((24 * 100) / 24) * multiplyTimes);

            double mean = 0;
            int i = 0;

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.LightGreen);

                int m = 0;
                int d = 0;

                for (int i2 = 1; i2 < 25; i2++)
                {
                    if (i2 == 8)
                    {
                        g.DrawLine(Pens.White, 0, bmp.Height - (((i2 * 100) / 24) * multiplyTimes), bmp.Width, bmp.Height - (((i2 * 100) / 24) * multiplyTimes));
                        g.DrawString("08:00", new Font("Consolas", 12, FontStyle.Regular), Brushes.Black, bmp.Width - 50, (int)(bmp.Height - ((((i2 + 0.5) * 100) / 24) * multiplyTimes)));
                    }
                    else if (i2 != 12)
                    {
                        g.DrawLine(Pens.Black, 0, bmp.Height - (((i2 * 100) / 24) * multiplyTimes), bmp.Width, bmp.Height - (((i2 * 100) / 24) * multiplyTimes));
                    }
                    else
                    {
                        g.DrawLine(Pens.DarkRed, 0, bmp.Height - (((i2 * 100) / 24) * multiplyTimes), bmp.Width, bmp.Height - (((i2 * 100) / 24) * multiplyTimes));
                        g.DrawString("12:00", new Font("Consolas", 12, FontStyle.Regular), Brushes.Black, bmp.Width - 50, (int)(bmp.Height - ((((i2 + 0.5) * 100) / 24) * multiplyTimes)));
                    }
                }


                if (times != null)
                {
                    foreach (object[] obj in times.getTimes())
                    {
                        DateTime date = (DateTime)obj[0];
                        DateTime arrival = (DateTime)obj[1];
                        DateTime departure = (DateTime)obj[2];
                        TimeSpan atwork = (TimeSpan)obj[3];

                        mean += atwork.TotalHours;
                        i++;

                        Rectangle r = new Rectangle((int)(10 + ((i - 1) * (12 * multiplyTimes))), bmp.Height - ((int)(atwork.TotalHours * 100) / 24) * multiplyTimes, 10 * multiplyTimes, ((int)(atwork.TotalHours * 100) / 24) * multiplyTimes);
                        g.FillRectangle(Brushes.LightBlue, r);
                        g.DrawRectangle(Pens.Black, r);

                        //g.RotateTransform(-90);
                        //g.DrawString(atwork.TotalHours.ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, 10 + ((i - 1) * 25), bmp.Height - 15);
                        //g.DrawString(atwork.TotalHours.ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, bmp.Height - 15, 10 + ((i - 1) * 25));
                        //g.Save();
                        //g.RotateTransform(90);
                    }

                    mean /= i;

                }

                int mm = (int)(mean * 60);

                TimeSpan ts = new TimeSpan(0, mm, 0);

                d = (int)((daily.TotalHours * 100) / 24) * multiplyTimes;

                m = (int)((mean * 100) / 24) * multiplyTimes;

                int w = 0;
                int ind = 0;

                while (w < bmp.Width - graphEdge)
                {
                    if (ind % 2 == 0)
                    {
                        g.DrawLine(Pens.Red, w, bmp.Height - (m + 1), w + (4 * multiplyTimes), bmp.Height - (m + 1));
                        g.DrawLine(Pens.Red, w, bmp.Height - m, w + (4 * multiplyTimes), bmp.Height - m);
                    }
                    else
                    {
                        g.DrawLine(Pens.Black, w, bmp.Height - d, w + (4 * multiplyTimes), bmp.Height - d);
                        g.DrawLine(Pens.Black, w, bmp.Height - (d - 1), w + (4 * multiplyTimes), bmp.Height - (d - 1));
                    }

                    w += 4 * multiplyTimes;
                    ind++;
                }

                g.FillRectangle(Brushes.White, bmp.Width - graphEdge, 5, bmp.Width - graphEdge, 100);
                g.DrawRectangle(Pens.Black, bmp.Width - graphEdge, 5, bmp.Width - graphEdge, 100);


                g.DrawString("Átlag: " + ts.Hours.ToString().PadLeft(2, '0') + ":" + ts.Minutes.ToString().PadLeft(2, '0'), new Font("Arial", 16, FontStyle.Regular), Brushes.Red, bmp.Width - graphEdge + 10, 15);
                g.DrawString("Munkaidő: " + daily.ToString().Substring(0, daily.ToString().Length - 3), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, bmp.Width - graphEdge + 10, 40);

                g.FillRectangle(Brushes.LightBlue, bmp.Width - graphEdge + 16, 65, 20, 20);
                g.DrawRectangle(Pens.Black, bmp.Width - graphEdge + 16, 65, 20, 20);
                g.DrawString(": Napi Munka", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, bmp.Width - graphEdge + 35, 65);


                g.DrawLine(Pens.Black, 0, 0, 0, bmp.Height);
                g.DrawLine(Pens.Black, 1, 0, 1, bmp.Height);
                g.DrawLine(Pens.Black, 2, 0, 2, bmp.Height);
                g.DrawLine(Pens.Black, 0, bmp.Height, bmp.Width, bmp.Height);
                g.DrawLine(Pens.Black, 0, bmp.Height - 1, bmp.Width, bmp.Height - 1);
                g.DrawLine(Pens.Black, 0, bmp.Height - 2, bmp.Width, bmp.Height - 2);
            }



            return ImageToBase64(bmp, System.Drawing.Imaging.ImageFormat.Bmp);

        }

        public string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        public Image Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0,
              imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        public String getColor(String txt)
        {

            int times = 1;

            string ret = "";

            ret = txt;

            if (txt != "")
            {
                txt = txt.Replace("↑", "").Replace("↓", "").Replace("=", "");
                txt = txt.Trim();

                if (txt.StartsWith("-"))
                {
                    txt = txt.Replace("-", "");
                    times = -1;
                }

                TimeSpan spn = new TimeSpan(Convert.ToInt32(txt.Split(':')[0]), Convert.ToInt32(txt.Split(':')[1]), 0);
                if (times == -1) { spn = spn.Negate(); }

                if (times > 0)
                {
                    ret = "<td•class='green'>" + ret;
                }
                else
                {
                    //MessageBox.Show(spn.TotalMinutes.ToString());

                    if (spn.TotalMinutes <= -60)
                    {
                        ret = "<td•class='red'>" + ret;
                    }
                    else if (spn.TotalMinutes <= -30)
                    {
                        ret = "<td•class='lightred'>" + ret;
                    }
                    else if (spn.TotalMinutes < 0)
                    {
                        ret = "<td•class='pink'>" + ret;
                    }
                    else if (spn.TotalMinutes == 0)
                    {
                        ret = "<td•class='yellow'>" + ret;
                    }
                }


                //MessageBox.Show(spn.ToString());
            }
            else
            {
                return "<td>";
            }

            return ret;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.a-ve.hu/wolfpawstudios/ref/");
        }

        string startd = "";
        string endd = "";
        string offdays = "";

        private void button1_Click_1(object sender, EventArgs e)
        {
            offdays = "";
            ListView lv = null;

            if (sc1.Panel1Collapsed)
            { lv = lv_Results_02; }
            else
            { lv = lv_Results_01; }


            int i = 0;
            foreach (ListViewItem lvi in lv.Items)
            {
                if (i == 0) { startd = lvi.Text; }
                if(lvi.SubItems[6].Text == "Szabadság / Betegség" || lvi.SubItems[6].Text.Trim() == "-")
                {
                    offdays += lvi.Text + ",";
                }
                if(i == lv.Items.Count - 1) { endd = lvi.Text; }

                i++;
            }

            offdays = offdays.Trim(',',' ');

            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "timetrack.exe";
            p.StartInfo.Arguments = string.Format("{0} {1} {2}", startd, endd, offdays);
            p.Start();
        }

		public string checkContainsToday()
		{
			string ret = "";

			for (int i = 0; i < rtb_Report_01.Lines.Length; i++)
			{
				String s = rtb_Report_01.Lines[i];

				try
				{
					DateTime t = DateTime.Now;
					if (!("0123456789".ToCharArray().Contains(s[0])))
					{
						if (s.Contains(t.Year + "-" + t.Month.ToString().PadLeft(2, '0') + "-" + t.Day.ToString().PadLeft(2, '0'))) { ret = s; }
					}
				}
				catch { }
			}

			return ret;
		}

		private void btn_RemoveToday_Click(object sender, EventArgs e)
		{
			string s = checkContainsToday();
			if(s != "")
			{
				 rtb_Report_02.Text = rtb_Report_01.Text = rtb_Report_01.Text.Replace(s, ""); 
			}
		}

		private void lbl_ContainsToday_VisibleChanged(object sender, EventArgs e)
		{
			try { btn_RemoveToday.Enabled = lbl_ContainsToday.Visible; } catch { }
		}

		private void btn_SearchReplace_Click(object sender, EventArgs e)
		{
			RichTextBox rtb = displayFlipped ? rtb_Report_02 : rtb_Report_01;

			rtb.SelectionBackColor = Color.White;

			if (cb_Replace.Checked)
			{

			}
			else
			{
				//todo: use text instead of control for search
			}
		}

		private void btn_Help_Click(object sender, EventArgs e)
		{
			f_Help fh = new f_Help();
			fh.ShowDialog();
		}

		private void btn_OpenPDF_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			if(ofd.ShowDialog() == DialogResult.OK)
			{
				parsePDF(ofd.FileName);
			}
		}

		private void btn_ReloadLast_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.s_LastText != "")
            {
                rtb_Report_01.Text = Properties.Settings.Default.s_LastText;
            }
        }

        private void btn_Report_PDF_Click(object sender, EventArgs e)
        {
            /*
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Generate PDF report";
            sfd.Filter = "BITMAP File|*.bmp";
            sfd.FileName = "WorkTimeCalc PDF Report - " + DateTime.Now.Date.ToShortDateString();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                
                TheArtOfDev.HtmlRenderer.PdfSharp.PdfGenerateConfig cnfg = new TheArtOfDev.HtmlRenderer.PdfSharp.PdfGenerateConfig();

                Rectangle rec = Screen.GetBounds(this);
                TheArtOfDev.HtmlRenderer.PdfSharp.HtmlContainer hcont = new TheArtOfDev.HtmlRenderer.PdfSharp.HtmlContainer();
                hcont.SetHtml(generateHTML());


                //cnfg.PageOrientation = PdfSharp.PageOrientation.Landscape;
                cnfg.ManualPageSize = new PdfSharp.Drawing.XSize(rec.Width, rec.Height);
                //cnfg.PageSize = PdfSharp.PageSize.A4;
                //cnfg.PageSize = PdfSharp.PageSize.Undefined;
                
                PdfSharp.Pdf.PdfDocument pdoc = TheArtOfDev.HtmlRenderer.PdfSharp.PdfGenerator.GeneratePdf(hcont.GetHtml(), cnfg);
                
            }
            */
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            f_Settingscs fs = new f_Settingscs();

            fs.regx_proper = rx_proper;
            fs.regx_vacsic = rx_vacsic;
            fs.regx_daysoff = rx_daysoff;
            fs.regx_nothing = rx_nothing;

            fs.ShowDialog();

            

            getSettings();
        }
    }
}
