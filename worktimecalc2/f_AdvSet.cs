using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace worktimecalc2
{
    public partial class f_AdvSet : Form
    {
        public String regx_proper { get; set; }
        public String regx_vacsic { get; set; }
        public String regx_daysoff { get; set; }
        public String regx_nothing { get; set; }

        public f_AdvSet()
        {
            InitializeComponent();
        }

        private void f_AdvSet_Load(object sender, EventArgs e)
        {
            rtb_proper.Text = Properties.Settings.Default.s_Regex_Proper;
            rtb_dayoff.Text = Properties.Settings.Default.s_Regex_DaysOff;
            rtb_vacsic.Text = Properties.Settings.Default.s_Regex_VacSic;
            rtb_nothing.Text = Properties.Settings.Default.s_Regex_Nothing;

            rtb_DayNames.Text = Properties.Settings.Default.s_dayNames;

            cb_LockView.Checked = Properties.Settings.Default.s_LockView;

            numericUpDown1.Value = Properties.Settings.Default.s_UseLine;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            rtb_proper.Text = regx_proper;
            rtb_dayoff.Text = regx_daysoff;
            rtb_vacsic.Text = regx_vacsic;
            rtb_nothing.Text = regx_nothing;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.s_Regex_Proper = rtb_proper.Text;
            Properties.Settings.Default.s_Regex_DaysOff = rtb_dayoff.Text;
            Properties.Settings.Default.s_Regex_VacSic = rtb_vacsic.Text;
            Properties.Settings.Default.s_Regex_Nothing = rtb_nothing.Text;

            Properties.Settings.Default.s_dayNames = rtb_DayNames.Text;

            Properties.Settings.Default.s_UseLine = (int)numericUpDown1.Value;

            Properties.Settings.Default.s_LockView = cb_LockView.Checked;

            Properties.Settings.Default.Save();

            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool bw = false;

        private void btn_BW_Click(object sender, EventArgs e)
        {
            Color bc = new Color();
            Color fc = new Color();

            if (bw)
            {
                btn_BW.BackgroundImage = Properties.Resources.bw1;

                bc = Color.White;
                fc = Color.Black;
            }
            else
            {
                btn_BW.BackgroundImage = Properties.Resources.bw2;

                bc = Color.Black;
                fc = Color.White;
            }

            bw = !bw;

            rtb_dayoff.BackColor = rtb_nothing.BackColor = rtb_proper.BackColor = rtb_vacsic.BackColor = bc;
            rtb_dayoff.ForeColor= rtb_nothing.ForeColor = rtb_proper.ForeColor = rtb_vacsic.ForeColor = fc;

        }
    }
}
