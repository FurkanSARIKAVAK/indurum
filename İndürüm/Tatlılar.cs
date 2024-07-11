using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İndürüm
{
    internal class Tatlılar
    {
        public string Ad { get; set; }
        public double Fiyat { get; set; }

        public static void Main(string[] args, FormSiparisim formSiparisim)
        {
            Tatlılar Tatlı1 = new Tatlılar();
            Tatlı1.Ad = "Çikolatalı Brownie";
            Tatlı1.Fiyat = 29.50;
            formSiparisim.lTatlı1.Text = Tatlı1.Fiyat.ToString();

            Tatlılar Tatlı2 = new Tatlılar();
            Tatlı2.Ad = "Kıbrıs Tatlısı";
            Tatlı2.Fiyat = 31;
            formSiparisim.lTatlı2.Text = Tatlı2.Fiyat.ToString();

            Tatlılar Tatlı3 = new Tatlılar();
            Tatlı3.Ad = "İrmik Helvası";
            Tatlı3.Fiyat = 27.25;
            formSiparisim.lTatlı3.Text = Tatlı3.Fiyat.ToString();

            Tatlılar Tatlı4 = new Tatlılar();
            Tatlı4.Ad = "Proiterol";
            Tatlı4.Fiyat = 32;
            formSiparisim.lTatlı4.Text = Tatlı4.Fiyat.ToString();

        }
    }
}
