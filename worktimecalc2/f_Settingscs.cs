using System;
using System.Drawing;
using System.Windows.Forms;

namespace worktimecalc2
{
    public partial class f_Settingscs : Form
    {
        public String regx_proper { get; set; }
        public String regx_vacsic { get; set; }
        public String regx_daysoff { get; set; }
        public String regx_nothing { get; set; }

        public f_Settingscs()
        {
            InitializeComponent();

            Load += F_Settingscs_Load;
        }

        private void F_Settingscs_Load(object sender, EventArgs e)
        {
            Font fd = Properties.Settings.Default.s_rtfFont;
            tb_RepFont.Text = fd.FontFamily + " - " + fd.Size + " - " + fd.Style;
            tb_RepFont.Tag = fd;
            fd = Properties.Settings.Default.s_lvFont;
            tb_ListFont.Text = fd.FontFamily + " - " + fd.Size + " - " + fd.Style;
            tb_ListFont.Tag = fd;
            cb_DontShow.Checked = Properties.Settings.Default.s_HideOFFDAYS;
            cb_ForceUserName.Checked = Properties.Settings.Default.s_forceUserName;
            cb_Graph.Checked = Properties.Settings.Default.s_ShowDiagram;
            tb_UserName.Text = Properties.Settings.Default.s_UserName;
        }

        private void tb_RepFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                tb_RepFont.Text = fd.Font.FontFamily + " - " + fd.Font.Size + " - " + fd.Font.Style;
                tb_RepFont.Tag = fd.Font;
            }
        }

        private void tb_ListFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                tb_ListFont.Text = fd.Font.FontFamily + " - " + fd.Font.Size + " - " + fd.Font.Style;
                tb_ListFont.Tag = fd.Font;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.s_lvFont = tb_RepFont.Tag as Font;
            Properties.Settings.Default.s_rtfFont = tb_ListFont.Tag as Font;
            Properties.Settings.Default.s_ShowDiagram = cb_Graph.Checked;
            Properties.Settings.Default.s_UserName = tb_UserName.Text;
            Properties.Settings.Default.s_HideOFFDAYS = cb_DontShow.Checked;
            Properties.Settings.Default.s_forceUserName = cb_ForceUserName.Checked;

            Properties.Settings.Default.Save();

            this.Close();
        }

        private void btn_Advanced_Click(object sender, EventArgs e)
        {
            f_AdvSet ass = new f_AdvSet();
            ass.regx_proper = regx_proper;
            ass.regx_vacsic = regx_vacsic;
            ass.regx_daysoff = regx_daysoff;
            ass.regx_nothing = regx_nothing;
            ass.ShowDialog();
        }
    }
}
