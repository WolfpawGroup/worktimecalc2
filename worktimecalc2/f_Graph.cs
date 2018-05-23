using System;
using System.Windows.Forms;

namespace worktimecalc2
{
    public partial class f_Graph : Form
    {
        public obj_Times times { get; set; }
        public double workTime {get;set;}

        double mean = 0;

        public f_Graph()
        {
            InitializeComponent();

            Load += F_Graph_Load; 
        }

        private void F_Graph_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.logoclock;

            int i = 0;

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

                    chart1.Series[1].Points.Add(workTime);
                    chart1.Series[0].Points.Add(atwork.TotalHours);
                }

                mean /= i;

                chart2.Series[0].Points.Add(0);
                chart2.Series[1].Points.Add(workTime);
                chart2.Series[0].Points.Add(mean);
                chart2.Series[1].Points.Add(workTime);
                chart2.Series[0].Points.Add(0);
                chart2.Series[1].Points.Add(workTime);
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
