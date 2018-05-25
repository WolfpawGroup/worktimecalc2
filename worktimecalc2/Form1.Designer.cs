namespace worktimecalc2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.sc1 = new System.Windows.Forms.SplitContainer();
			this.sc2 = new System.Windows.Forms.SplitContainer();
			this.rtb_Report_02 = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tc1 = new System.Windows.Forms.TabControl();
			this.tp_Data = new System.Windows.Forms.TabPage();
			this.rtb_Report_01 = new System.Windows.Forms.RichTextBox();
			this.tp_Times = new System.Windows.Forms.TabPage();
			this.lv_Results_01 = new System.Windows.Forms.ListView();
			this.ch_Date_01 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_DayOfWeek_01 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_Arrival_01 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_Departure_01 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_AtWork_01 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_Diff_01 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_DayType_01 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lv_Results_02 = new System.Windows.Forms.ListView();
			this.ch_Date_02 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_DayOfWeek_02 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_Arrival_02 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_Departure_02 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_AtWork_02 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_Diff_02 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_DayType_02 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_Report_Txt = new System.Windows.Forms.Button();
			this.btn_Report_HTML = new System.Windows.Forms.Button();
			this.btn_Help = new System.Windows.Forms.Button();
			this.btn_Settings = new System.Windows.Forms.Button();
			this.btn_ReloadLast = new System.Windows.Forms.Button();
			this.btn_DisplayFlip = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.num_DailyH = new System.Windows.Forms.NumericUpDown();
			this.num_DailyM = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.num_CorrM = new System.Windows.Forms.NumericUpDown();
			this.num_CorrH = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.tb_Days = new System.Windows.Forms.TextBox();
			this.tb_Mean = new System.Windows.Forms.TextBox();
			this.tb_Diff = new System.Windows.Forms.TextBox();
			this.btn_Graph = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label12 = new System.Windows.Forms.Label();
			this.p_plusminus = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.btn_RemoveToday = new System.Windows.Forms.Button();
			this.lbl_ContainsToday = new System.Windows.Forms.Label();
			this.gb_SearchReplace = new System.Windows.Forms.GroupBox();
			this.cb_Replace = new System.Windows.Forms.CheckBox();
			this.btn_SearchReplace = new System.Windows.Forms.Button();
			this.tb_Replace = new System.Windows.Forms.TextBox();
			this.tb_Search = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.btn_OpenPDF = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.sc1)).BeginInit();
			this.sc1.Panel1.SuspendLayout();
			this.sc1.Panel2.SuspendLayout();
			this.sc1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sc2)).BeginInit();
			this.sc2.Panel1.SuspendLayout();
			this.sc2.Panel2.SuspendLayout();
			this.sc2.SuspendLayout();
			this.tc1.SuspendLayout();
			this.tp_Data.SuspendLayout();
			this.tp_Times.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_DailyH)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_DailyM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_CorrM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_CorrH)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.gb_SearchReplace.SuspendLayout();
			this.SuspendLayout();
			// 
			// sc1
			// 
			this.sc1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.sc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.sc1.Location = new System.Drawing.Point(0, 0);
			this.sc1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.sc1.Name = "sc1";
			this.sc1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// sc1.Panel1
			// 
			this.sc1.Panel1.Controls.Add(this.sc2);
			// 
			// sc1.Panel2
			// 
			this.sc1.Panel2.Controls.Add(this.lv_Results_02);
			this.sc1.Panel2.Controls.Add(this.label2);
			this.sc1.Size = new System.Drawing.Size(653, 423);
			this.sc1.SplitterDistance = 210;
			this.sc1.TabIndex = 0;
			// 
			// sc2
			// 
			this.sc2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sc2.Location = new System.Drawing.Point(0, 0);
			this.sc2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.sc2.Name = "sc2";
			// 
			// sc2.Panel1
			// 
			this.sc2.Panel1.Controls.Add(this.rtb_Report_02);
			this.sc2.Panel1.Controls.Add(this.label1);
			// 
			// sc2.Panel2
			// 
			this.sc2.Panel2.Controls.Add(this.tc1);
			this.sc2.Size = new System.Drawing.Size(651, 208);
			this.sc2.SplitterDistance = 231;
			this.sc2.TabIndex = 0;
			// 
			// rtb_Report_02
			// 
			this.rtb_Report_02.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtb_Report_02.Location = new System.Drawing.Point(0, 25);
			this.rtb_Report_02.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.rtb_Report_02.Name = "rtb_Report_02";
			this.rtb_Report_02.Size = new System.Drawing.Size(231, 183);
			this.rtb_Report_02.TabIndex = 1;
			this.rtb_Report_02.Text = "";
			this.rtb_Report_02.TextChanged += new System.EventHandler(this.rtb_Report_02_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(2, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Riport tartalma:";
			// 
			// tc1
			// 
			this.tc1.Controls.Add(this.tp_Data);
			this.tc1.Controls.Add(this.tp_Times);
			this.tc1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tc1.Location = new System.Drawing.Point(0, 0);
			this.tc1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.tc1.Name = "tc1";
			this.tc1.SelectedIndex = 0;
			this.tc1.Size = new System.Drawing.Size(416, 208);
			this.tc1.TabIndex = 0;
			// 
			// tp_Data
			// 
			this.tp_Data.Controls.Add(this.rtb_Report_01);
			this.tp_Data.Location = new System.Drawing.Point(4, 22);
			this.tp_Data.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.tp_Data.Name = "tp_Data";
			this.tp_Data.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.tp_Data.Size = new System.Drawing.Size(408, 182);
			this.tp_Data.TabIndex = 0;
			this.tp_Data.Text = "Riport tartalma";
			this.tp_Data.UseVisualStyleBackColor = true;
			// 
			// rtb_Report_01
			// 
			this.rtb_Report_01.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtb_Report_01.Location = new System.Drawing.Point(2, 3);
			this.rtb_Report_01.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.rtb_Report_01.Name = "rtb_Report_01";
			this.rtb_Report_01.Size = new System.Drawing.Size(404, 176);
			this.rtb_Report_01.TabIndex = 2;
			this.rtb_Report_01.Text = "";
			this.rtb_Report_01.TextChanged += new System.EventHandler(this.rtb_Report_01_TextChanged);
			// 
			// tp_Times
			// 
			this.tp_Times.Controls.Add(this.lv_Results_01);
			this.tp_Times.Location = new System.Drawing.Point(4, 22);
			this.tp_Times.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.tp_Times.Name = "tp_Times";
			this.tp_Times.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.tp_Times.Size = new System.Drawing.Size(408, 182);
			this.tp_Times.TabIndex = 1;
			this.tp_Times.Text = "Kiszámolt idő";
			this.tp_Times.UseVisualStyleBackColor = true;
			// 
			// lv_Results_01
			// 
			this.lv_Results_01.BackColor = System.Drawing.Color.LightYellow;
			this.lv_Results_01.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_Date_01,
            this.ch_DayOfWeek_01,
            this.ch_Arrival_01,
            this.ch_Departure_01,
            this.ch_AtWork_01,
            this.ch_Diff_01,
            this.ch_DayType_01});
			this.lv_Results_01.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lv_Results_01.FullRowSelect = true;
			this.lv_Results_01.GridLines = true;
			this.lv_Results_01.Location = new System.Drawing.Point(2, 3);
			this.lv_Results_01.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.lv_Results_01.Name = "lv_Results_01";
			this.lv_Results_01.Size = new System.Drawing.Size(404, 176);
			this.lv_Results_01.TabIndex = 0;
			this.lv_Results_01.UseCompatibleStateImageBehavior = false;
			this.lv_Results_01.View = System.Windows.Forms.View.Details;
			// 
			// ch_Date_01
			// 
			this.ch_Date_01.Text = "Dátum";
			// 
			// ch_DayOfWeek_01
			// 
			this.ch_DayOfWeek_01.Text = "Nap";
			// 
			// ch_Arrival_01
			// 
			this.ch_Arrival_01.Text = "Érkezés";
			// 
			// ch_Departure_01
			// 
			this.ch_Departure_01.Text = "Távozás";
			// 
			// ch_AtWork_01
			// 
			this.ch_AtWork_01.Text = "Idő";
			// 
			// ch_Diff_01
			// 
			this.ch_Diff_01.Text = "Különbség";
			// 
			// ch_DayType_01
			// 
			this.ch_DayType_01.Text = "-";
			// 
			// lv_Results_02
			// 
			this.lv_Results_02.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lv_Results_02.BackColor = System.Drawing.Color.LightYellow;
			this.lv_Results_02.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_Date_02,
            this.ch_DayOfWeek_02,
            this.ch_Arrival_02,
            this.ch_Departure_02,
            this.ch_AtWork_02,
            this.ch_Diff_02,
            this.ch_DayType_02});
			this.lv_Results_02.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lv_Results_02.FullRowSelect = true;
			this.lv_Results_02.GridLines = true;
			this.lv_Results_02.Location = new System.Drawing.Point(0, 25);
			this.lv_Results_02.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.lv_Results_02.Name = "lv_Results_02";
			this.lv_Results_02.Size = new System.Drawing.Size(651, 181);
			this.lv_Results_02.TabIndex = 2;
			this.lv_Results_02.UseCompatibleStateImageBehavior = false;
			this.lv_Results_02.View = System.Windows.Forms.View.Details;
			// 
			// ch_Date_02
			// 
			this.ch_Date_02.Text = "Dátum";
			// 
			// ch_DayOfWeek_02
			// 
			this.ch_DayOfWeek_02.Text = "Nap";
			// 
			// ch_Arrival_02
			// 
			this.ch_Arrival_02.Text = "Érkezés";
			this.ch_Arrival_02.Width = 92;
			// 
			// ch_Departure_02
			// 
			this.ch_Departure_02.Text = "Távozás";
			this.ch_Departure_02.Width = 88;
			// 
			// ch_AtWork_02
			// 
			this.ch_AtWork_02.Text = "Idő";
			this.ch_AtWork_02.Width = 63;
			// 
			// ch_Diff_02
			// 
			this.ch_Diff_02.Text = "Különbség";
			this.ch_Diff_02.Width = 112;
			// 
			// ch_DayType_02
			// 
			this.ch_DayType_02.Text = "-";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(2, 9);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Kiszámolt idő: ";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btn_OpenPDF);
			this.panel1.Controls.Add(this.btn_Report_Txt);
			this.panel1.Controls.Add(this.btn_Report_HTML);
			this.panel1.Controls.Add(this.btn_Help);
			this.panel1.Controls.Add(this.btn_Settings);
			this.panel1.Controls.Add(this.btn_ReloadLast);
			this.panel1.Controls.Add(this.btn_DisplayFlip);
			this.panel1.Location = new System.Drawing.Point(653, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(225, 30);
			this.panel1.TabIndex = 1;
			// 
			// btn_Report_Txt
			// 
			this.btn_Report_Txt.BackgroundImage = global::worktimecalc2.Properties.Resources.txt;
			this.btn_Report_Txt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btn_Report_Txt.Enabled = false;
			this.btn_Report_Txt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Report_Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn_Report_Txt.Location = new System.Drawing.Point(136, 1);
			this.btn_Report_Txt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btn_Report_Txt.Name = "btn_Report_Txt";
			this.btn_Report_Txt.Size = new System.Drawing.Size(25, 25);
			this.btn_Report_Txt.TabIndex = 4;
			this.btn_Report_Txt.UseVisualStyleBackColor = true;
			this.btn_Report_Txt.Click += new System.EventHandler(this.btn_Report_Txt_Click);
			// 
			// btn_Report_HTML
			// 
			this.btn_Report_HTML.BackgroundImage = global::worktimecalc2.Properties.Resources.html;
			this.btn_Report_HTML.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btn_Report_HTML.Enabled = false;
			this.btn_Report_HTML.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Report_HTML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn_Report_HTML.Location = new System.Drawing.Point(107, 1);
			this.btn_Report_HTML.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btn_Report_HTML.Name = "btn_Report_HTML";
			this.btn_Report_HTML.Size = new System.Drawing.Size(25, 25);
			this.btn_Report_HTML.TabIndex = 3;
			this.btn_Report_HTML.UseVisualStyleBackColor = true;
			this.btn_Report_HTML.Click += new System.EventHandler(this.btn_Report_HTML_Click);
			// 
			// btn_Help
			// 
			this.btn_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btn_Help.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn_Help.Location = new System.Drawing.Point(165, 1);
			this.btn_Help.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btn_Help.Name = "btn_Help";
			this.btn_Help.Size = new System.Drawing.Size(25, 25);
			this.btn_Help.TabIndex = 2;
			this.btn_Help.Text = "i";
			this.btn_Help.UseVisualStyleBackColor = true;
			this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
			// 
			// btn_Settings
			// 
			this.btn_Settings.BackgroundImage = global::worktimecalc2.Properties.Resources.cogs_15;
			this.btn_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btn_Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn_Settings.Location = new System.Drawing.Point(194, 1);
			this.btn_Settings.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btn_Settings.Name = "btn_Settings";
			this.btn_Settings.Size = new System.Drawing.Size(25, 25);
			this.btn_Settings.TabIndex = 1;
			this.btn_Settings.UseVisualStyleBackColor = true;
			this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
			// 
			// btn_ReloadLast
			// 
			this.btn_ReloadLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn_ReloadLast.Location = new System.Drawing.Point(28, 1);
			this.btn_ReloadLast.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btn_ReloadLast.Name = "btn_ReloadLast";
			this.btn_ReloadLast.Size = new System.Drawing.Size(25, 25);
			this.btn_ReloadLast.TabIndex = 0;
			this.btn_ReloadLast.Text = "R";
			this.btn_ReloadLast.UseVisualStyleBackColor = true;
			this.btn_ReloadLast.Click += new System.EventHandler(this.btn_ReloadLast_Click);
			// 
			// btn_DisplayFlip
			// 
			this.btn_DisplayFlip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn_DisplayFlip.Location = new System.Drawing.Point(1, 1);
			this.btn_DisplayFlip.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btn_DisplayFlip.Name = "btn_DisplayFlip";
			this.btn_DisplayFlip.Size = new System.Drawing.Size(25, 25);
			this.btn_DisplayFlip.TabIndex = 0;
			this.btn_DisplayFlip.Text = "↩";
			this.btn_DisplayFlip.UseVisualStyleBackColor = true;
			this.btn_DisplayFlip.Click += new System.EventHandler(this.button1_Click);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Cursor = System.Windows.Forms.Cursors.Default;
			this.label3.Location = new System.Drawing.Point(655, 44);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Napi munkaidő: ";
			// 
			// num_DailyH
			// 
			this.num_DailyH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.num_DailyH.Location = new System.Drawing.Point(748, 42);
			this.num_DailyH.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.num_DailyH.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
			this.num_DailyH.Name = "num_DailyH";
			this.num_DailyH.Size = new System.Drawing.Size(46, 20);
			this.num_DailyH.TabIndex = 3;
			// 
			// num_DailyM
			// 
			this.num_DailyM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.num_DailyM.Location = new System.Drawing.Point(809, 42);
			this.num_DailyM.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.num_DailyM.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
			this.num_DailyM.Name = "num_DailyM";
			this.num_DailyM.Size = new System.Drawing.Size(46, 20);
			this.num_DailyM.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(793, 49);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(13, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "h";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(854, 49);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(15, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "m";
			// 
			// num_CorrM
			// 
			this.num_CorrM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.num_CorrM.Location = new System.Drawing.Point(809, 70);
			this.num_CorrM.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.num_CorrM.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
			this.num_CorrM.Name = "num_CorrM";
			this.num_CorrM.Size = new System.Drawing.Size(46, 20);
			this.num_CorrM.TabIndex = 9;
			// 
			// num_CorrH
			// 
			this.num_CorrH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.num_CorrH.Location = new System.Drawing.Point(748, 70);
			this.num_CorrH.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.num_CorrH.Name = "num_CorrH";
			this.num_CorrH.Size = new System.Drawing.Size(46, 20);
			this.num_CorrH.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(854, 77);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(15, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "m";
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(793, 77);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(13, 13);
			this.label7.TabIndex = 10;
			this.label7.Text = "h";
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.Cursor = System.Windows.Forms.Cursors.Default;
			this.label8.Location = new System.Drawing.Point(655, 72);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(58, 13);
			this.label8.TabIndex = 7;
			this.label8.Text = "Korrekció: ";
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 24);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(80, 13);
			this.label9.TabIndex = 13;
			this.label9.Text = "Napok Száma: ";
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 49);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(54, 13);
			this.label10.TabIndex = 13;
			this.label10.Text = "Átlag idő: ";
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(6, 112);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(45, 13);
			this.label11.TabIndex = 13;
			this.label11.Text = "Eltérés: ";
			// 
			// btn_Exit
			// 
			this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn_Exit.Location = new System.Drawing.Point(748, 471);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(117, 33);
			this.btn_Exit.TabIndex = 14;
			this.btn_Exit.Text = "Kilépés";
			this.btn_Exit.UseVisualStyleBackColor = true;
			this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
			// 
			// tb_Days
			// 
			this.tb_Days.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_Days.Location = new System.Drawing.Point(92, 21);
			this.tb_Days.Name = "tb_Days";
			this.tb_Days.Size = new System.Drawing.Size(119, 20);
			this.tb_Days.TabIndex = 15;
			// 
			// tb_Mean
			// 
			this.tb_Mean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_Mean.Location = new System.Drawing.Point(92, 46);
			this.tb_Mean.Name = "tb_Mean";
			this.tb_Mean.Size = new System.Drawing.Size(119, 20);
			this.tb_Mean.TabIndex = 16;
			// 
			// tb_Diff
			// 
			this.tb_Diff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_Diff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.tb_Diff.Location = new System.Drawing.Point(92, 104);
			this.tb_Diff.Name = "tb_Diff";
			this.tb_Diff.Size = new System.Drawing.Size(119, 26);
			this.tb_Diff.TabIndex = 17;
			// 
			// btn_Graph
			// 
			this.btn_Graph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Graph.Location = new System.Drawing.Point(9, 72);
			this.btn_Graph.Name = "btn_Graph";
			this.btn_Graph.Size = new System.Drawing.Size(202, 23);
			this.btn_Graph.TabIndex = 18;
			this.btn_Graph.Text = "Grafikon Megjelenítése";
			this.btn_Graph.UseVisualStyleBackColor = true;
			this.btn_Graph.Click += new System.EventHandler(this.btn_Graph_Click);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button2.Location = new System.Drawing.Point(0, 423);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(653, 41);
			this.button2.TabIndex = 19;
			this.button2.Text = "Idők Kiszámolása";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.btn_Graph);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.tb_Diff);
			this.groupBox1.Controls.Add(this.tb_Days);
			this.groupBox1.Controls.Add(this.tb_Mean);
			this.groupBox1.Location = new System.Drawing.Point(658, 255);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(216, 137);
			this.groupBox1.TabIndex = 20;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Eredmény";
			// 
			// label12
			// 
			this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label12.AutoSize = true;
			this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label12.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label12.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.label12.Location = new System.Drawing.Point(-1, 498);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(74, 15);
			this.label12.TabIndex = 21;
			this.label12.Text = "By: WolfyD";
			this.label12.Click += new System.EventHandler(this.label12_Click);
			// 
			// p_plusminus
			// 
			this.p_plusminus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.p_plusminus.BackgroundImage = global::worktimecalc2.Properties.Resources.plus;
			this.p_plusminus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.p_plusminus.Cursor = System.Windows.Forms.Cursors.Hand;
			this.p_plusminus.Location = new System.Drawing.Point(718, 72);
			this.p_plusminus.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.p_plusminus.Name = "p_plusminus";
			this.p_plusminus.Size = new System.Drawing.Size(14, 15);
			this.p_plusminus.TabIndex = 12;
			this.p_plusminus.Click += new System.EventHandler(this.p_plusminus_Click);
			this.p_plusminus.MouseEnter += new System.EventHandler(this.p_plusminus_MouseEnter);
			this.p_plusminus.MouseLeave += new System.EventHandler(this.p_plusminus_MouseLeave);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button1.Location = new System.Drawing.Point(658, 407);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(220, 41);
			this.button1.TabIndex = 22;
			this.button1.Text = "Munkaidők lekérdezése";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// btn_RemoveToday
			// 
			this.btn_RemoveToday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_RemoveToday.Enabled = false;
			this.btn_RemoveToday.Location = new System.Drawing.Point(658, 111);
			this.btn_RemoveToday.Name = "btn_RemoveToday";
			this.btn_RemoveToday.Size = new System.Drawing.Size(216, 23);
			this.btn_RemoveToday.TabIndex = 23;
			this.btn_RemoveToday.Text = "Mai nap eltávolítása";
			this.btn_RemoveToday.UseVisualStyleBackColor = true;
			this.btn_RemoveToday.Click += new System.EventHandler(this.btn_RemoveToday_Click);
			// 
			// lbl_ContainsToday
			// 
			this.lbl_ContainsToday.AutoSize = true;
			this.lbl_ContainsToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lbl_ContainsToday.ForeColor = System.Drawing.Color.Red;
			this.lbl_ContainsToday.Location = new System.Drawing.Point(658, 95);
			this.lbl_ContainsToday.Name = "lbl_ContainsToday";
			this.lbl_ContainsToday.Size = new System.Drawing.Size(163, 16);
			this.lbl_ContainsToday.TabIndex = 24;
			this.lbl_ContainsToday.Text = "Mai napot tartalmazza!";
			this.lbl_ContainsToday.Visible = false;
			this.lbl_ContainsToday.VisibleChanged += new System.EventHandler(this.lbl_ContainsToday_VisibleChanged);
			// 
			// gb_SearchReplace
			// 
			this.gb_SearchReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.gb_SearchReplace.Controls.Add(this.cb_Replace);
			this.gb_SearchReplace.Controls.Add(this.btn_SearchReplace);
			this.gb_SearchReplace.Controls.Add(this.tb_Replace);
			this.gb_SearchReplace.Controls.Add(this.tb_Search);
			this.gb_SearchReplace.Controls.Add(this.label15);
			this.gb_SearchReplace.Controls.Add(this.label14);
			this.gb_SearchReplace.Enabled = false;
			this.gb_SearchReplace.Location = new System.Drawing.Point(658, 146);
			this.gb_SearchReplace.Name = "gb_SearchReplace";
			this.gb_SearchReplace.Size = new System.Drawing.Size(216, 101);
			this.gb_SearchReplace.TabIndex = 25;
			this.gb_SearchReplace.TabStop = false;
			this.gb_SearchReplace.Text = "Keresés / csere";
			// 
			// cb_Replace
			// 
			this.cb_Replace.AutoSize = true;
			this.cb_Replace.Location = new System.Drawing.Point(193, 53);
			this.cb_Replace.Name = "cb_Replace";
			this.cb_Replace.Size = new System.Drawing.Size(15, 14);
			this.cb_Replace.TabIndex = 38;
			this.cb_Replace.UseVisualStyleBackColor = true;
			// 
			// btn_SearchReplace
			// 
			this.btn_SearchReplace.Location = new System.Drawing.Point(149, 73);
			this.btn_SearchReplace.Name = "btn_SearchReplace";
			this.btn_SearchReplace.Size = new System.Drawing.Size(64, 23);
			this.btn_SearchReplace.TabIndex = 37;
			this.btn_SearchReplace.Text = "Indít";
			this.btn_SearchReplace.UseVisualStyleBackColor = true;
			this.btn_SearchReplace.Click += new System.EventHandler(this.btn_SearchReplace_Click);
			// 
			// tb_Replace
			// 
			this.tb_Replace.Location = new System.Drawing.Point(58, 49);
			this.tb_Replace.Name = "tb_Replace";
			this.tb_Replace.Size = new System.Drawing.Size(129, 20);
			this.tb_Replace.TabIndex = 36;
			// 
			// tb_Search
			// 
			this.tb_Search.Location = new System.Drawing.Point(58, 21);
			this.tb_Search.Name = "tb_Search";
			this.tb_Search.Size = new System.Drawing.Size(129, 20);
			this.tb_Search.TabIndex = 35;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(1, 52);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(40, 13);
			this.label15.TabIndex = 34;
			this.label15.Text = "Csere: ";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(1, 24);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(51, 13);
			this.label14.TabIndex = 33;
			this.label14.Text = "Keresés: ";
			// 
			// btn_OpenPDF
			// 
			this.btn_OpenPDF.BackgroundImage = global::worktimecalc2.Properties.Resources.pdf;
			this.btn_OpenPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btn_OpenPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_OpenPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn_OpenPDF.Location = new System.Drawing.Point(57, 2);
			this.btn_OpenPDF.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btn_OpenPDF.Name = "btn_OpenPDF";
			this.btn_OpenPDF.Size = new System.Drawing.Size(25, 25);
			this.btn_OpenPDF.TabIndex = 5;
			this.btn_OpenPDF.UseVisualStyleBackColor = true;
			this.btn_OpenPDF.Click += new System.EventHandler(this.btn_OpenPDF_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(877, 516);
			this.Controls.Add(this.gb_SearchReplace);
			this.Controls.Add(this.lbl_ContainsToday);
			this.Controls.Add(this.btn_RemoveToday);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btn_Exit);
			this.Controls.Add(this.p_plusminus);
			this.Controls.Add(this.num_CorrM);
			this.Controls.Add(this.num_CorrH);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.num_DailyM);
			this.Controls.Add(this.num_DailyH);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.sc1);
			this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.Name = "Form1";
			this.Text = "WolfPaw WorkTime Calculator 2";
			this.sc1.Panel1.ResumeLayout(false);
			this.sc1.Panel2.ResumeLayout(false);
			this.sc1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.sc1)).EndInit();
			this.sc1.ResumeLayout(false);
			this.sc2.Panel1.ResumeLayout(false);
			this.sc2.Panel1.PerformLayout();
			this.sc2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.sc2)).EndInit();
			this.sc2.ResumeLayout(false);
			this.tc1.ResumeLayout(false);
			this.tp_Data.ResumeLayout(false);
			this.tp_Times.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.num_DailyH)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_DailyM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_CorrM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_CorrH)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.gb_SearchReplace.ResumeLayout(false);
			this.gb_SearchReplace.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer sc1;
        private System.Windows.Forms.SplitContainer sc2;
        private System.Windows.Forms.TabControl tc1;
        private System.Windows.Forms.TabPage tp_Data;
        private System.Windows.Forms.TabPage tp_Times;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtb_Report_02;
        private System.Windows.Forms.RichTextBox rtb_Report_01;
        private System.Windows.Forms.ListView lv_Results_01;
        private System.Windows.Forms.ListView lv_Results_02;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_DisplayFlip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_DailyH;
        private System.Windows.Forms.NumericUpDown num_DailyM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown num_CorrM;
        private System.Windows.Forms.NumericUpDown num_CorrH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel p_plusminus;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox tb_Days;
        private System.Windows.Forms.TextBox tb_Mean;
        private System.Windows.Forms.TextBox tb_Diff;
        private System.Windows.Forms.Button btn_Graph;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Report_Txt;
        private System.Windows.Forms.Button btn_Report_HTML;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ColumnHeader ch_Date_01;
        private System.Windows.Forms.ColumnHeader ch_DayOfWeek_01;
        private System.Windows.Forms.ColumnHeader ch_Arrival_01;
        private System.Windows.Forms.ColumnHeader ch_Departure_01;
        private System.Windows.Forms.ColumnHeader ch_AtWork_01;
        private System.Windows.Forms.ColumnHeader ch_Diff_01;
        private System.Windows.Forms.ColumnHeader ch_DayType_01;
        private System.Windows.Forms.ColumnHeader ch_Date_02;
        private System.Windows.Forms.ColumnHeader ch_DayOfWeek_02;
        private System.Windows.Forms.ColumnHeader ch_Arrival_02;
        private System.Windows.Forms.ColumnHeader ch_Departure_02;
        private System.Windows.Forms.ColumnHeader ch_AtWork_02;
        private System.Windows.Forms.ColumnHeader ch_Diff_02;
        private System.Windows.Forms.ColumnHeader ch_DayType_02;
        private System.Windows.Forms.Button btn_ReloadLast;
        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btn_RemoveToday;
		private System.Windows.Forms.Label lbl_ContainsToday;
		private System.Windows.Forms.GroupBox gb_SearchReplace;
		private System.Windows.Forms.CheckBox cb_Replace;
		private System.Windows.Forms.Button btn_SearchReplace;
		private System.Windows.Forms.TextBox tb_Replace;
		private System.Windows.Forms.TextBox tb_Search;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button btn_OpenPDF;
	}
}

