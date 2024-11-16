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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        VeriTabani vt = new VeriTabani();
        public Form17 anaform = new Form17();

        private void Form20_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Musteri (Musteri_ad, Musteri_soyad, Musteri_tel, Alici_ad, Alici_soyad, Alici_tel, AdresID) " +
                         "VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "'," + textBox7.Text + ")";

            var sonuc2 = vt.Insert(sql);


            Form22 yeniform = new Form22();
            yeniform.anaform = this;
            yeniform.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sonuc = vt.Select("select*from Adres");
            dataGridView1.DataSource = sonuc;

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
