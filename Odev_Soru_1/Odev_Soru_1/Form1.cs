using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Odev_Soru_1
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
            string bolum = comboBox1.Text;
            switch (bolum)
            {
                case "Bilişim Teknolojileri":
                    listBox1.Items.Clear();

                    listBox1.Items.Add("And 10/B");
                    listBox1.Items.Add("Düz 10/B");
                    listBox1.Items.Add("And 11/B");
                    listBox1.Items.Add("Düz 11/B");
                    listBox1.Items.Add("And 12/B");
                    listBox1.Items.Add("Düz 12/B");
                    break;
                case "Muhasebe":
                    listBox1.Items.Clear();

                    listBox1.Items.Add("And 10/A");
                    listBox1.Items.Add("Düz 10/A");
                    listBox1.Items.Add("And 11/A");
                    listBox1.Items.Add("Düz 11/A");
                    listBox1.Items.Add("And 12/A");
                    listBox1.Items.Add("Düz 12/A");
                    break;
                case "Adalet":
                    listBox1.Items.Clear();

                    listBox1.Items.Add("10/A");
                    listBox1.Items.Add("10/B");
                    listBox1.Items.Add("11/A");
                    listBox1.Items.Add("11/B");
                    listBox1.Items.Add("12/A");
                    listBox1.Items.Add("12/B");
                    break;
                
                default:
                    listBox1.Items.Add("BÖYLE BİR BÖLÜM BULUNMAMAKTADIR LÜTFEN YENİDEN DENEYİNİZ");
                    break;
            }
        }

    }
}
