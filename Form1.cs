using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timerUygulamasi
{
    public partial class Form1 : Form
    {
        // Form1 class/sınıfının alanları burada tanımlanmalı
        // Sınıfın alanlarını otomatik olarak başlangıç değeri atanır. Sayılara 0, stringlere "", boolean false atanır.
        int saniye = 0;
        int saat;
        int dakika;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        // Form1 Class/Sınıfının Field/Alanı     say     global/genel değişken olsun
        // Field/Alanların class/sınıfın başında verilmeli
     
        private void timer1_Tick(object sender, EventArgs e)
        {// scope : kapsam. say lokal değişkeni sadece timer1_Tick metodunu kapsadığı alanda geçerli, dışında yok olur.
            label1.Text = "Saat: " + saat + " , Dakika: " + dakika + " , Saniye: " + saniye;
            saniye++;
            // timer1 tik olayı gerçekleştiğinde çağırılan metot
            //label1.Text += say + ".timer1 tik!" + Environment.NewLine;
            listBox1.Items.Add(saniye);


            // 24 saatlik bir kronometre yapalım
            if(saniye == 60)
            {
                dakika++;
                saniye = 0;
            }
            if (dakika == 60)
            {
                saat++;
                dakika = 0;
            }
            if (saat == 24)
                saat = 0; // 24 saatlik kronometre
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int interval = int.Parse(textBox1.Text);
            timer1.Interval = interval;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
