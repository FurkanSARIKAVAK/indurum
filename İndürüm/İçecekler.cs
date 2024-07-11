using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İndürüm
{
    internal class İçecekler
    {
        public string Ad { get; set; }
        public double Fiyat { get; set; }

        public static void Main(string[] args, FormSiparisim formSiparisim)
        {
            İçecekler İçecek1 = new İçecekler();
            İçecek1.Ad = "Ayran";
            İçecek1.Fiyat = 10;
            formSiparisim.lİçecek1.Text = İçecek1.Fiyat.ToString();

            İçecekler İçecek2 = new İçecekler();
            İçecek2.Ad = "Cola";
            İçecek2.Fiyat = 13.25;
            formSiparisim.lİçecek2.Text = İçecek2.Fiyat.ToString();

            İçecekler İçecek3 = new İçecekler();
            İçecek3.Ad = "Fanta";
            İçecek3.Fiyat = 13.25;
            formSiparisim.lİçecek3.Text = İçecek3.Fiyat.ToString();

            İçecekler İçecek4 = new İçecekler();
            İçecek4.Ad = "Şalgam";
            İçecek4.Fiyat = 10;
            formSiparisim.lİçecek4.Text = İçecek4.Fiyat.ToString();

            İçecekler İçecek5 = new İçecekler();
            İçecek1.Ad = "Denizli Gazozu";
            İçecek1.Fiyat = 12.75;
            formSiparisim.lİçecek1.Text = İçecek5.Fiyat.ToString();

        }
    }
}
