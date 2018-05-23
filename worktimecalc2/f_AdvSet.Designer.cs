namespace worktimecalc2
{
    partial class f_AdvSet
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rtb_proper = new System.Windows.Forms.RichTextBox();
            this.rtb_dayoff = new System.Windows.Forms.RichTextBox();
            this.rtb_vacsic = new System.Windows.Forms.RichTextBox();
            this.rtb_nothing = new System.Windows.Forms.RichTextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_BW = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_LockView = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rtb_DayNames = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Itt beállíthatod a különböző Reguláris kifejezéseket ami alapján a program feldol" +
    "gozza a kapott adatokat.\r\nA program az itt látható sorrendben dolgozik:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ledolgozott munkanap: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nem munkanap: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Betegség / Szabadság: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adat nélküli nap: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Egyéb";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(12, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "RegEx";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(376, 26);
            this.label8.TabIndex = 7;
            this.label8.Text = "Itt beállíthatod, hogy a program a PDF tartalmának hányadik sorát használja a \r\nf" +
    "elhasználónév kikövetkeztetésekor +egyéb beállítások";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 471);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Sorszám: ";
            // 
            // rtb_proper
            // 
            this.rtb_proper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_proper.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtb_proper.Location = new System.Drawing.Point(151, 72);
            this.rtb_proper.Name = "rtb_proper";
            this.rtb_proper.Size = new System.Drawing.Size(361, 51);
            this.rtb_proper.TabIndex = 9;
            this.rtb_proper.Text = "";
            // 
            // rtb_dayoff
            // 
            this.rtb_dayoff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_dayoff.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtb_dayoff.Location = new System.Drawing.Point(151, 128);
            this.rtb_dayoff.Name = "rtb_dayoff";
            this.rtb_dayoff.Size = new System.Drawing.Size(361, 51);
            this.rtb_dayoff.TabIndex = 10;
            this.rtb_dayoff.Text = "";
            // 
            // rtb_vacsic
            // 
            this.rtb_vacsic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_vacsic.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtb_vacsic.Location = new System.Drawing.Point(151, 184);
            this.rtb_vacsic.Name = "rtb_vacsic";
            this.rtb_vacsic.Size = new System.Drawing.Size(361, 51);
            this.rtb_vacsic.TabIndex = 11;
            this.rtb_vacsic.Text = "";
            // 
            // rtb_nothing
            // 
            this.rtb_nothing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_nothing.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtb_nothing.Location = new System.Drawing.Point(151, 240);
            this.rtb_nothing.Name = "rtb_nothing";
            this.rtb_nothing.Size = new System.Drawing.Size(361, 51);
            this.rtb_nothing.TabIndex = 12;
            this.rtb_nothing.Text = "";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(151, 469);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(72, 20);
            this.numericUpDown1.TabIndex = 13;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(15, 559);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 14;
            this.btn_Save.Text = "Mentés";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.Location = new System.Drawing.Point(437, 559);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 15;
            this.btn_Cancel.Text = "Mégse";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Reset.Location = new System.Drawing.Point(16, 302);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(496, 39);
            this.btn_Reset.TabIndex = 16;
            this.btn_Reset.Text = "Eredeti értékek visszaállítása";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_BW
            // 
            this.btn_BW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BW.BackgroundImage = global::worktimecalc2.Properties.Resources.bw1;
            this.btn_BW.Location = new System.Drawing.Point(508, 3);
            this.btn_BW.Name = "btn_BW";
            this.btn_BW.Size = new System.Drawing.Size(20, 20);
            this.btn_BW.TabIndex = 17;
            this.btn_BW.UseVisualStyleBackColor = true;
            this.btn_BW.Click += new System.EventHandler(this.btn_BW_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 514);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 26);
            this.label10.TabIndex = 18;
            this.label10.Text = "Nézetváltás kikapcsolása:\r\n(Lassabb gép esetén)";
            // 
            // cb_LockView
            // 
            this.cb_LockView.AutoSize = true;
            this.cb_LockView.Location = new System.Drawing.Point(151, 513);
            this.cb_LockView.Name = "cb_LockView";
            this.cb_LockView.Size = new System.Drawing.Size(15, 14);
            this.cb_LockView.TabIndex = 19;
            this.cb_LockView.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 358);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Napok nevei: ";
            // 
            // rtb_DayNames
            // 
            this.rtb_DayNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_DayNames.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtb_DayNames.Location = new System.Drawing.Point(151, 351);
            this.rtb_DayNames.Name = "rtb_DayNames";
            this.rtb_DayNames.Size = new System.Drawing.Size(361, 51);
            this.rtb_DayNames.TabIndex = 21;
            this.rtb_DayNames.Text = "hétfo,kedd,szerda,csütörtök,péntek,szombat,vasárnap";
            // 
            // f_AdvSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 592);
            this.Controls.Add(this.rtb_DayNames);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cb_LockView);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_BW);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.rtb_nothing);
            this.Controls.Add(this.rtb_vacsic);
            this.Controls.Add(this.rtb_dayoff);
            this.Controls.Add(this.rtb_proper);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(10000, 631);
            this.MinimumSize = new System.Drawing.Size(547, 631);
            this.Name = "f_AdvSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Haladó Beállítások";
            this.Load += new System.EventHandler(this.f_AdvSet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox rtb_proper;
        private System.Windows.Forms.RichTextBox rtb_dayoff;
        private System.Windows.Forms.RichTextBox rtb_vacsic;
        private System.Windows.Forms.RichTextBox rtb_nothing;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_BW;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cb_LockView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox rtb_DayNames;
    }
}