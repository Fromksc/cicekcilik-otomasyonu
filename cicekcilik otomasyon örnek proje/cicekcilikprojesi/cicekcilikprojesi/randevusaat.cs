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
    public partial class randevusaat : UserControl
    {
        public randevusaat()
        {
            InitializeComponent();
        }
        public Form19 anaform = new Form19();


        private void randevusaat_Load(object sender, EventArgs e)
        {

        }
        public void SetSaat(string saat1, string saat2)
        {
            label1.Text = saat1;
            label2.Text = saat2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anaform.listBox1.Items.Add(label1.Text);
            anaform.listBox1.Items.Add(label2.Text);
            
        }
    }
}
