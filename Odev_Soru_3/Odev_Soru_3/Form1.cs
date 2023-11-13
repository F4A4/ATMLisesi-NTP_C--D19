using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Odev_Soru_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {       
            int KucukSayı = Int32.Parse(textBox1.Text);
            int BuyukSayı = Int32.Parse(textBox2.Text);

            int toplam = 0;
            int sayac = 0;
            
            while (KucukSayı<=BuyukSayı)
            {

                KucukSayı++;
                toplam += KucukSayı;
                sayac++;
            }
            textBox3.Text = toplam.ToString();
            int ort =toplam / sayac;
            textBox4.Text = ort.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
