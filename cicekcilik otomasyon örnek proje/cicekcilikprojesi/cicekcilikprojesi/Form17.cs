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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        VeriTabani vt = new VeriTabani();
        public Form14 anaform = new Form14();
        public Form15 anaform2 = new Form15();
        public Form16 anaform3 = new Form16();

        private void Form17_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql= "INSERT INTO Adres (Il, Ilce, Mahalle, Cadde, Sokak, BinaNo, KatNo, DaireNo ) " +
                         "VALUES ('" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "',"+ textBox12.Text + "," + textBox13.Text + "," + textBox14.Text + ")";

            var sonuc2 = vt.Insert(sql);

            
            Form20 yeniform = new Form20();
            yeniform.anaform = this;
            yeniform.ShowDialog();
        }
    }
}
