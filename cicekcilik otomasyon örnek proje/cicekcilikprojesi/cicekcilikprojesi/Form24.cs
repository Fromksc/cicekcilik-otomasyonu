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
    public partial class Form24 : Form
    {
        public Form24()
        {
            InitializeComponent();
        }
        VeriTabani vt = new VeriTabani();
        public Form4 anaform = new Form4();

        private void Form24_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            var sonuc = vt.Select("select*from rSatis");
            dataGridView1.DataSource = sonuc;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var sonuc = vt.Select("select*from Tur");
            dataGridView1.DataSource = sonuc;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var sonuc = vt.Select("select*from RezervastonMusteri");
            dataGridView1.DataSource = sonuc;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var sonuc = vt.Select("select*from Hizmet");
            dataGridView1.DataSource = sonuc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO rSatis (rMusteriID, TurID, Urun_fiyat, Satis_tarihi, Satis_notu, Satis_gerceklesti_mi) " +
                         "VALUES (" + textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + ",'" + textBox4.Text + "','" + textBox5.Text + "'," + textBox6.Text + ")";

            var sonuc2 = vt.Insert(sql);


            Form25 yeniform = new Form25();
            yeniform.anaform = this;
            yeniform.ShowDialog();
        }
    }
}
