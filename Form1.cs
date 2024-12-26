using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TREDYOL_WEB_PROJESİ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TRENDYOL trendyol1 = new TRENDYOL(); 
        private void button1_Click(object sender, EventArgs e)
        {
            Ürünler eklenecekürün = new Ürünler();
            eklenecekürün.ID = Convert.ToInt32(textBox1.Text);
            eklenecekürün.ÜrünAdı = textBox2.Text;
            eklenecekürün.Fiyat = Convert.ToInt32(textBox3.Text);
            eklenecekürün.Bedeni = textBox4.Text;
            trendyol1.Ekleme(eklenecekürün);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
       
            var liste = trendyol1.Listeleme();
            foreach (var ürün in liste)
            {
                listBox1.Items.Add("ID :  " + ürün.ID + " Ürün Adı " + ürün.ÜrünAdı + " Ürünün Fiyati " + ürün.Fiyat + " Ürünün Bedeni " + ürün.Bedeni);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            trendyol1.ÜrünleriSil(id);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ürünler gücelenecekürün = new Ürünler();
            gücelenecekürün.ID = Convert.ToInt32(textBox1.Text);
            gücelenecekürün.ÜrünAdı = textBox2.Text;
            gücelenecekürün.Fiyat = Convert.ToInt32(textBox3.Text);
            gücelenecekürün.Bedeni = textBox4.Text;
            trendyol1.Güncelle(gücelenecekürün);
           
        }
    }
}
