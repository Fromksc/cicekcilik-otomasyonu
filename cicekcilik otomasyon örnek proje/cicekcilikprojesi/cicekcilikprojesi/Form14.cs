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
    public partial class Form14 : Form
    {
        // Buket adlarını ve fiyatlarını saklamak için Dictionary tanımlayın
        public Dictionary<string, string> BuketFiyatlari = new Dictionary<string, string>();


        public Form14()
        {
            InitializeComponent();

            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;

        }

        VeriTabani vt = new VeriTabani();
        public Form11 anaform = new Form11();


        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;

            var gelen = vt.Select("select * from Buket");

            for (int i = 0; i < 2; i++)
            {

                for (int j = 0; j < 1; j++)
                {
                    bketbilgi bb = new bketbilgi();
                    bb.Location = new Point((i * 220 + 10), (j * 320 + 10));
                    bb.label1.Text = gelen.Rows[i]["Buket_ad"].ToString();
                    bb.label2.Text = gelen.Rows[i]["Buket_fiyat"].ToString();
                    bb.label3.Text = gelen.Rows[i]["Buket_bilgi"].ToString();
                    bb.anaform = this;

                    string BuketID = gelen.Rows[i]["BuketID"].ToString();
                    string resimYolu = $@"C:\Users\fromk\Desktop\eftalyaçiçekçiresim\buketler\{BuketID}.jpg";
                    if (System.IO.File.Exists(resimYolu))
                    {
                        bb.pictureBox1.Image = Image.FromFile(resimYolu);
                    }
                   
                    this.Controls.Add(bb);

                }
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Form14_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form17 yeniform = new Form17();
            yeniform.anaform = this;
            yeniform.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçili öğe varsa, buket fiyatını Label1'e ayarlayın
            if (listBox1.SelectedItem != null)
            {
                string buketAdi = listBox1.SelectedItem.ToString();

                // Dictionary'den buket fiyatını al ve Label1'e ayarla
                if (BuketFiyatlari.TryGetValue(buketAdi, out string buketFiyati))
                {
                    label1.Text = buketFiyati;
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void GuncelleLabel1(string buketFiyati)
        {
            label1.Text = buketFiyati;
        }

    }
}
