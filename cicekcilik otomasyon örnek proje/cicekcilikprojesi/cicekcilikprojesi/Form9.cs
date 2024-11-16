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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        VeriTabani vt = new VeriTabani();
        public Form4 anaform = new Form4();
        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var sonuc = vt.Select("select*from Cicekci");
            dataGridView1.DataSource = sonuc;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int CicekciID;
            if (int.TryParse(textBox5.Text, out CicekciID))
            {
                var sonuc = vt.UpdateDelete("DELETE FROM Cicekci WHERE CicekciID = " + CicekciID);
                button4_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Geçerli bir Çiçekçi ID girin.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sonuc = vt.Insert("INSERT INTO Cicekci (Cicekci_ad, AdresID) VALUES ('" + textBox1.Text + "'," + textBox2.Text + ")");
            dataGridView1.DataSource = sonuc;
            button4_Click(sender, e);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
