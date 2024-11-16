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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        VeriTabani vt = new VeriTabani();
        public Form4 anaform = new Form4();
        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var sonuc = vt.Select("select*from Hizmet");
            dataGridView1.DataSource = sonuc;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int HizmetID;
            if (int.TryParse(textBox5.Text, out HizmetID))
            {
                var sonuc = vt.UpdateDelete("DELETE FROM Hizmet WHERE HizmetID = " + HizmetID);
                button4_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Geçerli bir Ürün ID girin.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sonuc = vt.Insert("INSERT INTO Hizmet (Hizmet_ad, Hizmet_uzunluk, Hizmet_fiyat, TurID, CicekciID ) VALUES ('" + textBox1.Text + "'," + textBox2.Text + "," + textBox3.Text + "," + textBox4.Text + "," + textBox4.Text + ")");
            dataGridView1.DataSource = sonuc;
            button4_Click(sender, e);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
