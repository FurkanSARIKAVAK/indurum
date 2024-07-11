using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İndürüm
{
    public partial class FormSiparisim : Form
    {
        private class Ürün
        {
            public string Ad { get; set; }
            public double Fiyat { get; set; }
            public TextBox TextBoxAdet { get; set; }
        }
        private List<Ürün> secilenUrunler;
        public FormSiparisim()
        {
            InitializeComponent();

            //Dürümler
            secilenUrunler = new List<Ürün>();

            secilenUrunler.Add(new Ürün { Ad = "Hatay Soslu Tavuk Dürüm", Fiyat = 53.75, TextBoxAdet = tBoxDürüm1Adet });
            secilenUrunler.Add(new Ürün { Ad = "Tavuk Dürüm", Fiyat = 42.50, TextBoxAdet = tBoxDürüm2Adet });
            secilenUrunler.Add(new Ürün { Ad = "Et Dürüm", Fiyat = 59.75, TextBoxAdet = tBoxDürüm3Adet });
            secilenUrunler.Add(new Ürün { Ad = "Zurna Tavuk Dürüm", Fiyat = 61, TextBoxAdet = tBoxDürüm4Adet });
            secilenUrunler.Add(new Ürün { Ad = "Zurna Et Dürüm", Fiyat = 69.25, TextBoxAdet = tBoxDürüm5Adet });
            secilenUrunler.Add(new Ürün { Ad = "Glutensiz Dürüm", Fiyat = 55, TextBoxAdet = tBoxDürüm6Adet });
            secilenUrunler.Add(new Ürün { Ad = "Vegan Dürüm", Fiyat = 53.75, TextBoxAdet = tBoxDürüm7Adet });

            //İçecekler
            secilenUrunler.Add(new Ürün { Ad = "Ayran", Fiyat = 10, TextBoxAdet = tBoxİçecek1Adet });
            secilenUrunler.Add(new Ürün { Ad = "Cola", Fiyat = 13.25, TextBoxAdet = tBoxİçecek2Adet });
            secilenUrunler.Add(new Ürün { Ad = "Fanta", Fiyat = 13.25, TextBoxAdet = tBoxİçecek3Adet });
            secilenUrunler.Add(new Ürün { Ad = "Şalgam", Fiyat = 10, TextBoxAdet = tBoxİçecek4Adet });
            secilenUrunler.Add(new Ürün { Ad = "Denizli Gazozu", Fiyat = 12.75, TextBoxAdet = tBoxİçecek5Adet });

            //Yan Ürünler
            secilenUrunler.Add(new Ürün { Ad = "Patates Kızartması", Fiyat = 29, TextBoxAdet = tBoxYanÜrün1Adet });
            secilenUrunler.Add(new Ürün { Ad = "Çıtır Tavuk Topları", Fiyat = 33, TextBoxAdet = tBoxYanÜrün2Adet });
            secilenUrunler.Add(new Ürün { Ad = "Rus Salatası", Fiyat = 32, TextBoxAdet = tBoxYanÜrün3Adet });
            secilenUrunler.Add(new Ürün { Ad = "Soğan Halkası", Fiyat = 29, TextBoxAdet = tBoxYanÜrün4Adet });

            //Tatlılar
            secilenUrunler.Add(new Ürün { Ad = "Çikolatalı Brownie", Fiyat = 29.50, TextBoxAdet = tBoxTatlı1Adet });
            secilenUrunler.Add(new Ürün { Ad = "Kıbrıs Tatlısı", Fiyat = 31, TextBoxAdet = tBoxTatlı2Adet });
            secilenUrunler.Add(new Ürün { Ad = "İrmik Helvası", Fiyat = 27.25, TextBoxAdet = tBoxTatlı3Adet });
            secilenUrunler.Add(new Ürün { Ad = "Profiterol", Fiyat = 32, TextBoxAdet = tBoxTatlı4Adet });
        }



        private void FormSiparisim_Load(object sender, EventArgs e)
        {

        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            double SepetTutari = 0;

            //Seçilen ürünleri işliyoruz
            foreach (var Ürün in secilenUrunler)
            {
                int adet = 0;
                if (int.TryParse(Ürün.TextBoxAdet.Text, out adet) && adet >= 0)
                {
                    //Sepet Tutarını Hesapla
                    SepetTutari += Ürün.Fiyat * adet;
                    //Sepet Tutarını Göster
                    lSepetTutar.Text = SepetTutari.ToString("c");

                    string urunBilgisi = $"{adet} adet {Ürün.Ad}";
                    listBoxSiparis.Items.Add(urunBilgisi);
                }
                else if (int.TryParse(Ürün.TextBoxAdet.Text, out adet) && adet < 0)
                {
                    //Müşteri hatalı bir değer girerse uyarı vermesini sağladık.
                    MessageBox.Show("Hata ! İptal edip tekrar deneyiniz.");
                }
            }

        }


        private void btnİptal_Click(object sender, EventArgs e)
        {
            //Burada İptal butonuna tıklandığında girilen değerlerin temizlenmesini sağladık.
            tBoxDürüm1Adet.Clear();
            tBoxDürüm2Adet.Clear();
            tBoxDürüm3Adet.Clear();
            tBoxDürüm4Adet.Clear();
            tBoxDürüm5Adet.Clear();
            tBoxDürüm6Adet.Clear();
            tBoxDürüm7Adet.Clear();
            tBoxİçecek1Adet.Clear();
            tBoxİçecek2Adet.Clear();
            tBoxİçecek3Adet.Clear();
            tBoxİçecek4Adet.Clear();
            tBoxİçecek5Adet.Clear();
            tBoxYanÜrün1Adet.Clear();
            tBoxYanÜrün2Adet.Clear();
            tBoxYanÜrün3Adet.Clear();
            tBoxYanÜrün4Adet.Clear();
            tBoxTatlı1Adet.Clear();
            tBoxTatlı2Adet.Clear();
            tBoxTatlı3Adet.Clear();
            tBoxTatlı4Adet.Clear();
            lSepetTutar.Text = "-";
            listBoxSiparis.Items.Clear();
        }

        private void btnSiparişiGönder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siparişiniz alınmıştır, lütfen bekleyiniz. Afiyet olsun :)");
        }

        
    }
}