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
    public partial class Form15 : Form
    {
        public Dictionary<string, string> urunFiyatlari = new Dictionary<string, string>();

        public Form15()
        {
            InitializeComponent();
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }

        VeriTabani vt = new VeriTabani();
        public Form11 anaform = new Form11();

        private void Form15_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;

            var gelen = vt.Select("select * from DigerUrunler");

            for (int i = 0; i < 2; i++)
            {

                for (int j = 0; j < 1; j++)
                {
                    bketbilgi bb = new bketbilgi();
                    bb.Location = new Point((i * 220 + 10), (j * 320 + 10));
                    bb.label1.Text = gelen.Rows[i]["DigerUrunler_Ad"].ToString();
                    bb.label2.Text = gelen.Rows[i]["DigerUrunler_fiyat"].ToString();
                    bb.label3.Text = gelen.Rows[i]["DigerUrunler_bilgi"].ToString();
                    bb.anaform2 = this;

                    string DigerUrunlerID = gelen.Rows[i]["DigerUrunlerID"].ToString();
                    string resimYolu = $@"C:\Users\fromk\Desktop\eftalyaçiçekçiresim\diğer ürünler\{DigerUrunlerID}.jpg";
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form17 yeniform2 = new Form17();
            yeniform2.anaform2 = this;
            yeniform2.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listBox1.SelectedItem != null)
            {
                string urunAdi = listBox1.SelectedItem.ToString();

                if (urunFiyatlari.TryGetValue(urunAdi, out string urunFiyati))
                {
                    label1.Text = urunFiyati;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void GuncelleLabel1(string urunFiyati)
        {
            label1.Text = urunFiyati;
        }
    }
  }

