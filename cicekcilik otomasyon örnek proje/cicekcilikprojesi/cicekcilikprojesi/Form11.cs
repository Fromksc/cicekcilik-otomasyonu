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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        VeriTabani vt = new VeriTabani();
        public Form3 anaform = new Form3();

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form14 yeniform = new Form14();
            yeniform.anaform = this;
            yeniform.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form15 yeniform = new Form15();
            yeniform.anaform = this;
            yeniform.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form16 yeniform = new Form16();
            yeniform.anaform = this;
            yeniform.ShowDialog();
        }
    }
}
