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
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }

        VeriTabani vt = new VeriTabani();
        public Form19 anaform = new Form19();

        private void Form23_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO RezervastonMusteri (Musteri_ad, Musteri_soyad, Musteri_tel ) " +
                         "VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";

            var sonuc2 = vt.Insert(sql);


            Form22 yeniform = new Form22();
            yeniform.anaform1 = this;
            yeniform.ShowDialog();
        }
    }
}
