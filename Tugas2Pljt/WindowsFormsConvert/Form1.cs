using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryConvert;
namespace WindowsFormsConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        Terbilang convert = new Terbilang();
        private void button1_Click(object sender, EventArgs e)
        {
            var hasil = convert.TerbilangIndonesia(int.Parse(textBox1.Text));
            textBox2.Text = hasil.ToString();
        }
    }
}
