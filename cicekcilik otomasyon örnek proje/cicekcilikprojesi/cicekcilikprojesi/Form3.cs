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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        VeriTabani vt = new VeriTabani();
        public Form1 anaform = new Form1();

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11 yeniform = new Form11();
            yeniform.anaform = this;
            yeniform.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form12 yeniform = new Form12();
            yeniform.anaform = this;
            yeniform.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form13 yeniform = new Form13();
            yeniform.anaform = this;
            yeniform.ShowDialog();
        }
    }
}
