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
    public partial class bketbilgi : UserControl
    {
        public bketbilgi()
        {
            InitializeComponent();
        }
        public Form14 anaform = new Form14();
        public Form15 anaform2 = new Form15();
        public Form16 anaform3 = new Form16();
        public Form18 anaform4 = new Form18();

        private void button1_Click(object sender, EventArgs e)
        {
            //anaform.listBox1.Items.Add(label1.Text);
            anaform2.listBox1.Items.Add(label1.Text);
            anaform3.listBox1.Items.Add(label1.Text);
            anaform4.listBox1.Items.Add(label1.Text);

            string buketAdi = label1.Text;
            string buketFiyati = label2.Text;

            // Buket adını ve fiyatını form14'deki Dictionary'ye ekle
            if (!anaform.BuketFiyatlari.ContainsKey(buketAdi))
            {
                anaform.BuketFiyatlari.Add(buketAdi, buketFiyati);
            }

            // ListBox'ı temizle
            anaform.listBox1.Items.Clear();

            // Buket adını ListBox'a ekle
            anaform.listBox1.Items.Add(buketAdi);

            // ListBox'ta yeni eklenen öğeyi seçili hale getir
            anaform.listBox1.SelectedItem = buketAdi;

            // Buket fiyatını anaformdaki yöntem aracılığıyla Label1'e ayarla
            anaform.GuncelleLabel1(buketFiyati);

            string urunAdi = label1.Text;
            string urunFiyati = label2.Text;
            if (!anaform2.urunFiyatlari.ContainsKey(urunAdi))
            {
                anaform2.urunFiyatlari.Add(urunAdi, urunFiyati);
            }
            anaform2.listBox1.Items.Clear();
            anaform2.listBox1.Items.Add(urunAdi);
            anaform2.GuncelleLabel1(urunFiyati);


            string hizmetAdi = label1.Text;
            string hizmetFiyati = label2.Text;
            if (!anaform4.hizmetFiyatlari.ContainsKey(hizmetAdi))
            {
                anaform4.hizmetFiyatlari.Add(hizmetAdi, hizmetFiyati);
            }
            anaform4.listBox1.Items.Clear();
            anaform4.listBox1.Items.Add(hizmetAdi);
            anaform4.GuncelleLabel5(hizmetFiyati);
        }

        private void bketbilgi_Load(object sender, EventArgs e)
        {

        }
    }
}
