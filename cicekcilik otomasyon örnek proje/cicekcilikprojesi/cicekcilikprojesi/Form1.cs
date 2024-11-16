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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        VeriTabani vt = new VeriTabani();

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 yeniform = new Form2();
            yeniform.anaform = this;
            yeniform.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 yeniform = new Form3();
            yeniform.anaform = this;
            yeniform.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
