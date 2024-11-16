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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        VeriTabani vt = new VeriTabani();
        public Form4 anaform = new Form4();
        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var sonuc = vt.Select("select*from Tur");
            dataGridView1.DataSource = sonuc;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int TurID;
            if (int.TryParse(textBox5.Text, out TurID))
            {
                var sonuc = vt.UpdateDelete("DELETE FROM Tur WHERE TurID = " + TurID);
                button4_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Geçerli bir Tür ID girin.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sonuc = vt.Insert("INSERT INTO Tur (Tur_ad) VALUES ('" + textBox1.Text + "')");
            dataGridView1.DataSource = sonuc;
            button4_Click(sender, e);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
