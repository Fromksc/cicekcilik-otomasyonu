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
    public partial class Form18 : Form
    {
        public Dictionary<string, string> hizmetFiyatlari = new Dictionary<string, string>();
        public Form18()
        {
            InitializeComponent();
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }

        VeriTabani vt = new VeriTabani();
        public Form12 anaform = new Form12();

        public void SetSelectedDate(DateTime date)
        {
            label5.Text = date.ToString("dd/MM/yyyy"); 
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            

       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            Form19 yeniform = new Form19();
            yeniform.SetDate(label1.Text);
            yeniform.anaform = this;
            yeniform.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var gelen = vt.Select("select * from Hizmet");

            for (int i = 0; i < 2; i++)
            {

                for (int j = 0; j < 1; j++)
                {
                    bketbilgi bb = new bketbilgi();
                    bb.Location = new Point((i * 220 + 10), (j * 320 + 10));
                    bb.label1.Text = gelen.Rows[i]["Hizmet_ad"].ToString();
                    bb.label2.Text = gelen.Rows[i]["Hizmet_fiyat"].ToString();
                    bb.label3.Text = gelen.Rows[i]["Hizmet_uzunluk"].ToString() + " dakika sürüyor";
                    bb.anaform4 = this;

                    string HizmetID = gelen.Rows[i]["HizmetID"].ToString();
                    string resimYolu = $@"C:\Users\fromk\Desktop\eftalyaçiçekçiresim\hizmetler\{HizmetID}.jpg";
                    if (System.IO.File.Exists(resimYolu))
                    {
                        bb.pictureBox1.Image = Image.FromFile(resimYolu);
                    }

                    this.Controls.Add(bb);

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string hizmetAdi = listBox1.SelectedItem.ToString();

                if (hizmetFiyatlari.TryGetValue(hizmetAdi, out string hizmetFiyati))
                {
                    label5.Text = hizmetFiyati;
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public void GuncelleLabel5(string hizmetFiyati)
        {
            label1.Text = hizmetFiyati;
        }
    }
}
