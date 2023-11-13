using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KararDöngüleri
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
            int sayi =Int32.Parse(textBox1.Text);
            int sayi2 = Int32.Parse(textBox2.Text);
            int tpl = sayi;
            while (sayi<=sayi2)
            {
                sayi++;
                //tpl += sayi;
                listBox1.Items.Add(sayi);
                //listBox2.Items.Add(tpl);
            }
            do
            {
                sayi++;
                if (sayi%5==0)
                {
                    sayi = sayi + 5;

                }
                
                
                listBox2.Items.Add(sayi);
                
                
            } while (sayi<=sayi2);

        }
    }
}
