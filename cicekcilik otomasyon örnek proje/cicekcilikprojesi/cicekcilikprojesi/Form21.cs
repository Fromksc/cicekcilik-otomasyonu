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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        VeriTabani vt = new VeriTabani();
        public Form4 anaform = new Form4();

        private void button4_Click(object sender, EventArgs e)
        {
            var sonuc = vt.Select("select*from Musteri");
            dataGridView1.DataSource = sonuc;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var sonuc = vt.Select("select*from BuketOlusturma");
            dataGridView1.DataSource = sonuc;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var sonuc = vt.Select("select*from Hizmet");
            dataGridView1.DataSource = sonuc;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var sonuc = vt.Select("select*from DigerUrunler");
            dataGridView1.DataSource = sonuc;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var sonuc = vt.Select("select*from Buket");
            dataGridView1.DataSource = sonuc;
        }

        private void Form21_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            var sonuc = vt.Select("select*from Tur");
            dataGridView1.DataSource = sonuc;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var sonuc = vt.Select("select*from Satis");
            dataGridView1.DataSource = sonuc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Satis (MusteriID, TurID, UrunKimligi, Urun_fiyat, Satis_tarihi, Satis_notu, SatisGerceklestiMi ) " +
                         "VALUES (" + textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + "," + textBox4.Text + ",'" + textBox6.Text + "','" + textBox7.Text + "'," + textBox5.Text + ")";

            var sonuc = vt.Insert(sql);

            MessageBox.Show("Satış veritabanına eklendi");
            Form25 yeniform = new Form25();
            yeniform.anaform1 = this;
            yeniform.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int SatisID;
            if (int.TryParse(textBox8.Text, out SatisID))
            {
                var sonuc = vt.UpdateDelete("DELETE FROM Satis WHERE SatisID = " + SatisID);
                button10_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Geçerli bir Satış ID girin.");
            }

        }
    }
}
