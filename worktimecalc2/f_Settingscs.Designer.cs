namespace worktimecalc2
{
    partial class f_Settingscs
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
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.tb_RepFont = new System.Windows.Forms.TextBox();
            this.tb_ListFont = new System.Windows.Forms.TextBox();
            this.tb_UserName = new System.Windows.Forms.TextBox();
            this.cb_ForceUserName = new System.Windows.Forms.CheckBox();
            this.cb_Graph = new System.Windows.Forms.CheckBox();
            this.cb_DontShow = new System.Windows.Forms.CheckBox();
            this.btn_Advanced = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Szöveg betütípusa: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lista betütípusa: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Riportból szabadnapok kihagyása: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "HTML Riportba grafikon beillesztése: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Megadott felhasználónév használata: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Felhasználónév: ";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(15, 265);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Mentés";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(310, 265);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Mégse";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // tb_RepFont
            // 
            this.tb_RepFont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_RepFont.Location = new System.Drawing.Point(206, 18);
            this.tb_RepFont.Name = "tb_RepFont";
            this.tb_RepFont.Size = new System.Drawing.Size(179, 20);
            this.tb_RepFont.TabIndex = 6;
            this.tb_RepFont.Click += new System.EventHandler(this.tb_RepFont_Click);
            // 
            // tb_ListFont
            // 
            this.tb_ListFont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_ListFont.Location = new System.Drawing.Point(206, 58);
            this.tb_ListFont.Name = "tb_ListFont";
            this.tb_ListFont.Size = new System.Drawing.Size(179, 20);
            this.tb_ListFont.TabIndex = 7;
            this.tb_ListFont.Click += new System.EventHandler(this.tb_ListFont_Click);
            // 
            // tb_UserName
            // 
            this.tb_UserName.Location = new System.Drawing.Point(206, 218);
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.Size = new System.Drawing.Size(179, 20);
            this.tb_UserName.TabIndex = 8;
            // 
            // cb_ForceUserName
            // 
            this.cb_ForceUserName.AutoSize = true;
            this.cb_ForceUserName.Location = new System.Drawing.Point(206, 181);
            this.cb_ForceUserName.Name = "cb_ForceUserName";
            this.cb_ForceUserName.Size = new System.Drawing.Size(15, 14);
            this.cb_ForceUserName.TabIndex = 9;
            this.cb_ForceUserName.UseVisualStyleBackColor = true;
            // 
            // cb_Graph
            // 
            this.cb_Graph.AutoSize = true;
            this.cb_Graph.Location = new System.Drawing.Point(206, 141);
            this.cb_Graph.Name = "cb_Graph";
            this.cb_Graph.Size = new System.Drawing.Size(15, 14);
            this.cb_Graph.TabIndex = 10;
            this.cb_Graph.UseVisualStyleBackColor = true;
            // 
            // cb_DontShow
            // 
            this.cb_DontShow.AutoSize = true;
            this.cb_DontShow.Location = new System.Drawing.Point(206, 101);
            this.cb_DontShow.Name = "cb_DontShow";
            this.cb_DontShow.Size = new System.Drawing.Size(15, 14);
            this.cb_DontShow.TabIndex = 11;
            this.cb_DontShow.UseVisualStyleBackColor = true;
            // 
            // btn_Advanced
            // 
            this.btn_Advanced.Location = new System.Drawing.Point(103, 265);
            this.btn_Advanced.Name = "btn_Advanced";
            this.btn_Advanced.Size = new System.Drawing.Size(194, 23);
            this.btn_Advanced.TabIndex = 12;
            this.btn_Advanced.Text = "Haladó Beállítások";
            this.btn_Advanced.UseVisualStyleBackColor = true;
            this.btn_Advanced.Click += new System.EventHandler(this.btn_Advanced_Click);
            // 
            // f_Settingscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 301);
            this.Controls.Add(this.btn_Advanced);
            this.Controls.Add(this.cb_DontShow);
            this.Controls.Add(this.cb_Graph);
            this.Controls.Add(this.cb_ForceUserName);
            this.Controls.Add(this.tb_UserName);
            this.Controls.Add(this.tb_ListFont);
            this.Controls.Add(this.tb_RepFont);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "f_Settingscs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Beállítások";
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
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox tb_RepFont;
        private System.Windows.Forms.TextBox tb_ListFont;
        private System.Windows.Forms.TextBox tb_UserName;
        private System.Windows.Forms.CheckBox cb_ForceUserName;
        private System.Windows.Forms.CheckBox cb_Graph;
        private System.Windows.Forms.CheckBox cb_DontShow;
        private System.Windows.Forms.Button btn_Advanced;
    }
}