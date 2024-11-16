using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cicekcilikprojesi
{
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        VeriTabani vt = new VeriTabani();
        public Form18 anaform = new Form18();

        public void SetDate(String date)
        {
            label1.Text = date;
        }

        private void Form19_Load(object sender, EventArgs e)
        {
           /*var gelen = vt.Select("select * from Buket");
            var saat = 9;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    randevusaat rs = new randevusaat();
                    rs.Location = new Point((i * 100 + 10), (j * 120 + 10));
                    this.Controls.Add(rs);

                    string saat1 = saat.ToString("00") + ":00";
                    string saat2 = (saat + 1).ToString("00") + ":00";
                    rs.SetSaat(saat1, saat2);

                    saat++;

                    
                }
            }
           */

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var gelen = vt.Select("select * from Buket");
            var saat = 9;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    randevusaat rs = new randevusaat();
                    rs.Location = new Point((i * 100 + 10), (j * 120 + 10));
                    this.Controls.Add(rs);

                    string saat1 = saat.ToString("00") + ":00";
                    string saat2 = (saat + 1).ToString("00") + ":00";
                    rs.SetSaat(saat1, saat2);


                    saat++;

                    rs.anaform = this;

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form23 yeniform = new Form23();
            yeniform.anaform = this;
            yeniform.ShowDialog();
        }
    }
}

