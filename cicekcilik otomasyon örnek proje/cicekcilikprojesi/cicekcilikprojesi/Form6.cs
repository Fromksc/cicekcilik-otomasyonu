using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace cicekcilikprojesi
{

    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        VeriTabani vt = new VeriTabani();
        public Form4 anaform = new Form4();

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var sonuc = vt.Select("select*from Buket");
            dataGridView1.DataSource = sonuc;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int BuketID;
            if (int.TryParse(textBox5.Text, out BuketID))
            {
                var sonuc = vt.UpdateDelete("DELETE FROM Buket WHERE BuketID = " + BuketID);
                button4_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Geçerli bir Buket ID girin.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sonuc = vt.Insert("INSERT INTO Buket (Buket_ad, Buket_bilgi, Buket_fiyat, TurID, CicekciID ) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + "," + textBox4.Text + "," + textBox4.Text + ")");
            dataGridView1.DataSource = sonuc;
            button4_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            int BuketID;
            if (int.TryParse(textBox7.Text, out BuketID))
            {
                // Buket bilgilerini veritabanından al
                var buket = vt.Select("SELECT * FROM Buket WHERE BuketID = " + BuketID);

                // Eğer buket varsa, bilgileri textbox'lara yerleştir
                if (buket != null && buket.Rows.Count > 0)
                {
                    textBox1.Text = buket.Rows[0]["Buket_ad"].ToString();
                    textBox2.Text = buket.Rows[0]["Buket_bilgi"].ToString();
                    textBox3.Text = buket.Rows[0]["Buket_fiyat"].ToString();
                    textBox4.Text = buket.Rows[0]["TurID"].ToString();
                    textBox6.Text = buket.Rows[0]["CicekciID"].ToString();
                }
                else
                {
                    MessageBox.Show("Böyle bir Buket ID bulunamadı.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Geçerli bir Buket ID girin.");
                return;
            } 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int BuketID;
            if (!int.TryParse(textBox7.Text, out BuketID))
            {
                MessageBox.Show("Geçerli bir Buket ID girin.");
                return;
            }

            // Güncellenecek buketin yeni bilgilerini al
            string yeniAd = textBox1.Text;
            string yeniBilgi = textBox2.Text;
            decimal yeniFiyat;
            if (!decimal.TryParse(textBox3.Text, out yeniFiyat))
            {
                MessageBox.Show("Geçerli bir fiyat girin.");
                return;
            }
            int yeniTurID;
            if (!int.TryParse(textBox4.Text, out yeniTurID))
            {
                MessageBox.Show("Geçerli bir Tur ID girin.");
                return;
            }
            int yeniCicekciID;
            if (!int.TryParse(textBox6.Text, out yeniCicekciID))
            {
                MessageBox.Show("Geçerli bir Cicekci ID girin.");
                return;
            }

            // Veritabanında buketi güncelle
            string updateQuery = "UPDATE Buket SET Buket_ad = '" + yeniAd + "', Buket_bilgi = '" + yeniBilgi + "', Buket_fiyat = " + yeniFiyat + ", TurID = " + yeniTurID + ", CicekciID = " + yeniCicekciID + " WHERE BuketID = " + BuketID;
            var sonuc = vt.UpdateDelete(updateQuery);
            if (sonuc != null)
            {
                MessageBox.Show("Buket başarıyla güncellendi.");
            }
            else
            {
                MessageBox.Show("Buket güncellenirken bir hata oluştu.");
            }

        }


    }
}
