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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        VeriTabani vt = new VeriTabani();
        public Form1 anaform = new Form1();

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sonuc = vt.Select("select * from adminGiris where admin = '" + textBox1.Text + "' and sifre = '" + textBox2.Text + "'");

            if (sonuc.Rows.Count > 0)
            {
                MessageBox.Show("GİRİŞ BAŞARILI.");
                Form4 yeniform = new Form4();
                yeniform.anaform = this;
                yeniform.ShowDialog();
            }
            else
            {
                MessageBox.Show("HATALI GİRİŞ YAPTINIZ!");

            }
        }
    }
}
