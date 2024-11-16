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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        VeriTabani vt = new VeriTabani();
        public Form4 anaform = new Form4();

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sonuc = vt.Insert("INSERT INTO Cicek (Cicek_ad, Cicek_bilgi, Cicek_renk, Cicek_fiyat) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "'," + textBox4.Text + ")");
            dataGridView1.DataSource = sonuc;
            button4_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var sonuc = vt.Select("select*from Cicek");
            dataGridView1.DataSource = sonuc;
        }

        private void button3_Click(object sender, EventArgs e)

        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int CicekID;
            if (int.TryParse(textBox5.Text, out CicekID))
            {
                var sonuc = vt.UpdateDelete("DELETE FROM Cicek WHERE CicekID = " + CicekID);
                button4_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Geçerli bir Çiçek ID girin.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
