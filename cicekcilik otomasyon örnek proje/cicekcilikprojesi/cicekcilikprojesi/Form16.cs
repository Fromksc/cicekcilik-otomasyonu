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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        VeriTabani vt = new VeriTabani();
        public Form11 anaform = new Form11();

        private void Form16_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;

            var gelen = vt.Select("select * from Cicek");

            for (int i = 0; i < 2; i++)
            {

                for (int j = 0; j < 1; j++)
                {
                    bketbilgi bb = new bketbilgi();
                    bb.Location = new Point((i * 220 + 10), (j * 320 + 10));
                    bb.label1.Text = gelen.Rows[i]["Cicek_ad"].ToString();
                    bb.label2.Text = gelen.Rows[i]["Cicek_fiyat"].ToString();
                    bb.label3.Text = gelen.Rows[i]["Cicek_renk"].ToString();
                    bb.anaform3 = this;

                    string CicekID = gelen.Rows[i]["CicekID"].ToString();
                    string resimYolu = $@"C:\Users\fromk\Desktop\eftalyaçiçekçiresim\cicekler\{CicekID}.jpg";
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
            Form17 yeniform3 = new Form17();
            yeniform3.anaform3 = this;
            yeniform3.ShowDialog();
        }
    }
}
