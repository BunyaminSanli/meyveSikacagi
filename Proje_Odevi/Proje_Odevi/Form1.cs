using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Odevi
{
    public partial class Form1 : Form
    {
        //geriye doğru sayması için değişken tanımlanır
        int saniyeTut = 60;
        public Form1()
        {
            InitializeComponent();
        }

        //sınıflardan nesneler üretilir
        MeyveKati meyveKati = new MeyveKati();
        MeyveSivi meyveSivi = new MeyveSivi();

        MeyveKati elma = new MeyveKati();
        MeyveKati armut = new MeyveKati();
        MeyveKati cilek = new MeyveKati();

        MeyveSivi greyfurt = new MeyveSivi();
        MeyveSivi mandalina = new MeyveSivi();
        MeyveSivi portakal = new MeyveSivi();

        SikacakKati sikacakKati = new SikacakKati();
        SikacakSivi sikacakSivi = new SikacakSivi();

        //toplam değerler tanımlanır
        int pure = 0;
        int sivi = 0;
        int vitA = 0;
        int vitC = 0;

        //random nesnesi ve bir değişken oluşturulur 
        Random rst = new Random();
        int rndMeyve;
        //üretilen random sayıya göre bir switch icine girer meyve nesnesinin değişkenlerine atamalar yapar ve nesneyi geri döndürür
        private Meyve NesneOlustur()
        {
            rndMeyve = rst.Next(6);

            switch (rndMeyve)
            {
                case 0:
                    elma.Ad = "Elma";
                    elma.Id = 2;
                    elma.Gram = elma.GramOlustur();
                    elma.ResimYol = "elma.jpg";
                    elma.Verim = sikacakKati.VerimHesapla();
                    elma.VitaminA = 54;
                    elma.VitaminC = 5;
                    pictureBox1.ImageLocation = elma.ResimYol;

                    textBox2.Text = elma.Ad;
                    textBox3.Text = elma.Gram.ToString();
                    return elma;

                case 1:
                    armut.Ad = "Armut";
                    armut.Id = 2;
                    armut.Gram = armut.GramOlustur();
                    armut.ResimYol = "armut.jpg";
                    armut.Verim = sikacakKati.VerimHesapla();
                    armut.VitaminA = 25;
                    armut.VitaminC = 5;
                    pictureBox1.ImageLocation = armut.ResimYol;

                    textBox2.Text = armut.Ad;
                    textBox3.Text = armut.Gram.ToString();
                    return armut;

                case 2:
                    cilek.Ad = "Cilek";
                    cilek.Id = 2;
                    cilek.Gram = cilek.GramOlustur();
                    cilek.ResimYol = "cilek.jpg";
                    cilek.Verim = sikacakKati.VerimHesapla();
                    cilek.VitaminA = 12;
                    cilek.VitaminC = 60;
                    pictureBox1.ImageLocation = cilek.ResimYol;

                    textBox2.Text = cilek.Ad;
                    textBox3.Text = cilek.Gram.ToString();
                    return cilek;

                case 3:
                    greyfurt.Ad = "Greyfurt";
                    greyfurt.Id = 1;
                    greyfurt.Gram = greyfurt.GramOlustur();
                    greyfurt.ResimYol = "greyfurt.jpg";
                    greyfurt.Verim = sikacakSivi.VerimHesapla();
                    greyfurt.VitaminA = 3;
                    greyfurt.VitaminC = 44;
                    pictureBox1.ImageLocation = greyfurt.ResimYol;

                    textBox2.Text = greyfurt.Ad;
                    textBox3.Text = greyfurt.Gram.ToString();
                    return greyfurt;

                case 4:
                    mandalina.Ad = "Mandalina";
                    mandalina.Id = 1;
                    mandalina.Gram = greyfurt.GramOlustur();
                    mandalina.ResimYol = "mandalina.jpg";
                    mandalina.Verim = sikacakSivi.VerimHesapla();
                    mandalina.VitaminA = 681;
                    mandalina.VitaminC = 26;
                    pictureBox1.ImageLocation = mandalina.ResimYol;

                    textBox2.Text = mandalina.Ad;
                    textBox3.Text = mandalina.Gram.ToString();
                    return mandalina;

                case 5:
                    portakal.Ad = "Portakal";
                    portakal.Id = 1;
                    portakal.Gram = portakal.GramOlustur();
                    portakal.ResimYol = "portakal.jpg";
                    portakal.Verim = sikacakSivi.VerimHesapla();
                    portakal.VitaminA = 225;
                    portakal.VitaminC = 45;

                    pictureBox1.ImageLocation = portakal.ResimYol;
                    textBox2.Text = portakal.Ad;
                    textBox3.Text = portakal.Gram.ToString();
                    return portakal;

                default:
                    return mandalina;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //timerın saniyede bir çalışması ve değişkeni bir azaltarak ilgili textboxa yazdırma işlemi
            if (saniyeTut>0)
            {
                timer1.Interval = 1000;
                saniyeTut--;
                textBox1.Text = saniyeTut+ "";
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //basla butonuna basıldıgı zaman timer başlatlır butonlar aktif hale getirilir ve nesneolustur metodu çağırılır
            if (saniyeTut > 0)
            {
                timer1.Start();
                NesneOlustur();
                button1.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //o an üretilen meyve sıvı  ise sadece narenciye sıkacağında işlem görür
            //ve saniye 0 olmadığı sürece
            if (saniyeTut > 0 && (rndMeyve == 3 || rndMeyve == 4 || rndMeyve == 5))
            {
                sivi += sikacakSivi.GramajHesapla(NesneOlustur());
                vitA += meyveSivi.VitaminHesaplaA(NesneOlustur());
                vitC += meyveSivi.VitaminHesaplaC(NesneOlustur());

                textBox6.Text = sivi + " GR";
                textBox5.Text = vitA + " IU";
                textBox4.Text = vitC + " MG";

                NesneOlustur();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //o an üretilen meyve katı  ise sadece katı sıkacağında işlem görür
            //ve saniye 0 olmadığı sürece
            if (saniyeTut > 0 && (rndMeyve == 0 || rndMeyve == 1 || rndMeyve == 2))
            {
                pure += sikacakKati.GramajHesapla(NesneOlustur());
                vitA += meyveKati.VitaminHesaplaA(NesneOlustur());
                vitC += meyveKati.VitaminHesaplaC(NesneOlustur());

                textBox7.Text = pure + " GR";
                textBox5.Text = vitA + " IU";
                textBox4.Text = vitC + " MG";

                NesneOlustur();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
