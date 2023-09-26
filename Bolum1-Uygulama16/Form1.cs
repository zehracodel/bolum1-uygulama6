using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bolum1_Uygulama16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double turkceDogru, matDogru;
            double turkceYanlis, matYanlis;
            double turkceNet, matNet;
            turkceDogru = Convert.ToDouble(textBox7.Text);
            turkceYanlis = Convert.ToDouble(textBox8.Text);
            turkceNet=(turkceDogru-(turkceYanlis/4));
            textBox11.Text = turkceNet.ToString();
            matDogru = Convert.ToDouble(textBox9.Text);
            matYanlis = Convert.ToDouble(textBox10.Text);
            matNet = (matDogru - (matYanlis / 4));
            textBox12.Text = matNet.ToString();


        }
    }
}
