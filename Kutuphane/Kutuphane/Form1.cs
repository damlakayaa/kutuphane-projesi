using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class Form1 : Form
    {
        List<Yazar> yazarlar = new List<Yazar>();
        List<Kategori> Kategoriler = new List<Kategori>();
        List<Ogrenci> Ogrenciler = new List<Ogrenci>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KategoriDoldur();
            YazarDoldur();
            YazarListesiniDoldur();
            OgrenciDoldur();
        }


        public void KitapDoldur()
        {
            Yazar y = new Yazar();
            y.Ad = "aaaa";
            y.Soyad="bbb";
            y.Uyruk="Ankara";

            Yazar y2 = yazarlar.Where(x => x.Ad == "Halide Edip").Single();

            Kitap k = new Kitap();
            k.Ad = "Sinekli Bakkal";
            k.Barkod = "1312312312";
            k.Dil = "Türkçe";
            k.SayfaSayisi = 333;
            k.Yazari = y;
            k.Kategoriler = new List<Kategori>();
           
        }


        public void KategoriDoldur()
        {
            
            Kategori k = new Kategori();
            k.Adi = "Tarih";
            Kategoriler.Add(k);

            Kategori k2 = new Kategori()
            {
                Adi = "Korku"
            };
            Kategoriler.Add(k2);

            Kategori k3 = new Kategori()
            {
                Adi = "Çocuk"
            };
            Kategoriler.Add(k3);   
        }

        public void YazarDoldur()
        {
            
            Yazar y1 = new Yazar();
            y1.Ad = "Mehmet Akif";
            y1.Soyad = "Ersoy";
            y1.Uyruk = "Türk";
            Yazar y2 = new Yazar();
            y2.Ad = "Halide Edip";
            y2.Soyad = "Adivar";
            y2.Uyruk = "Türk";
            yazarlar.Add(y1);
            yazarlar.Add(y2);
        }

        public void YazarListesiniDoldur()
        {
            foreach (var y in yazarlar)
            {
                lstYazarlar.Items.Add(y.Ad + " " + y.Soyad + " - " + y.Uyruk);
            }
        }

        public void OgrenciDoldur()
        {
            Ogrenci o = new Ogrenci();
            o.Ad = "ali";
            o.Soyad = "al";
            o.TCNo = "12312312312";
            o.Tel = "555 1231231";
            o.Bolum = "Bilgisayar Mühendisliği";
            o.Eposta = "aliAl@gmail.com";
            Ogrenciler.Add(o);
        
        }

        private void btnYazarEkle_Click(object sender, EventArgs e)
        {
            Yazar y = new Yazar();
            y.Ad =txtYazarAd.Text;
            y.Soyad = txtYazarSoyad.Text;
            y.Uyruk = txtYazarUyruk.Text;
            yazarlar.Add(y);
            lstYazarlar.Items.Add(y.Ad + " " + y.Soyad + " - " + y.Uyruk);
            txtYazarAd.Text = "";
            txtYazarSoyad.Text = "";
            txtYazarUyruk.Text = "";
            //MessageBox.Show("Eklendi.");
            //MessageBox.Show("Yazar Eklendi.");
            MessageBox.Show(y.Ad + " " + y.Soyad + " adlı yazar eklendi ");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtYazarAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
