using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetotlarGeriyedondurmeyen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void temizle() //metod textboxların içeriğini temizler
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }
        void renklendir() //textbox renklerini çevirir 
        {
            textBox1.BackColor = ColorTranslator.FromHtml("#ffeaa7"); 
            textBox2.BackColor = ColorTranslator.FromHtml("#6c5ce7");
            textBox3.BackColor = ColorTranslator.FromHtml("#fd79a8");
            textBox4.BackColor = ColorTranslator.FromHtml("#00b894") ;

        }
        void yazdir() //textbox verileri yazdırır.
        {
            textBox1.Text = "Doğan";
            textBox2.Text = "AY";
            textBox3.Text = "Bilgisayar Mühendisi";
            textBox4.Text = "Software Intern";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            renklendir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yazdir();
        }
    }
}
