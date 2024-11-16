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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        VeriTabani vt = new VeriTabani();
        public Form3 anaform = new Form3();

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            Form18 yeniform = new Form18();
            yeniform.SetSelectedDate(selectedDate);
            yeniform.anaform = this;
            yeniform.ShowDialog();
        }
    }
}
