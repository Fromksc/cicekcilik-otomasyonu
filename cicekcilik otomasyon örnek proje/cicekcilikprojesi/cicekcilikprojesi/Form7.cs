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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        VeriTabani vt = new VeriTabani();
        public Form4 anaform = new Form4();

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var sonuc = vt.Select("select*from DigerUrunler");
            dataGridView1.DataSource = sonuc;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int DigerUrunlerID;
            if (int.TryParse(textBox5.Text, out DigerUrunlerID))
            {
                var sonuc = vt.UpdateDelete("DELETE FROM DigerUrunler WHERE DigerUrunlerID = " + DigerUrunlerID);
                button4_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Geçerli bir Ürün ID girin.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sonuc = vt.Insert("INSERT INTO DigerUrunler (DigerUrunler_Ad, DigerUrunler_bilgi, DigerUrunler_fiyat, TurID) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + "," + textBox4.Text + "," + textBox4.Text + ")");
            dataGridView1.DataSource = sonuc;
            button4_Click(sender, e);
        }
    }
}
