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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        VeriTabani vt = new VeriTabani();
        public Form2 anaform = new Form2();

        private void Form4_Load(object sender, EventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 yeniform = new Form5();
            yeniform.anaform = this;
            yeniform.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 yeniform = new Form6();
            yeniform.anaform = this;
            yeniform.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 yeniform = new Form7();
            yeniform.anaform = this;
            yeniform.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 yeniform = new Form8();
            yeniform.anaform = this;
            yeniform.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form9 yeniform = new Form9();
            yeniform.anaform = this;
            yeniform.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form10 yeniform = new Form10();
            yeniform.anaform = this;
            yeniform.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form21 yeniform = new Form21();
            yeniform.anaform = this;
            yeniform.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form24 yeniform = new Form24();
            yeniform.anaform = this;
            yeniform.ShowDialog();
        }
    }
}
