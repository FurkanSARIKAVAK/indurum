using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İndürüm
{
    internal class YanÜrünler
    {
        public string Ad { get; set; }
        public double Fiyat { get; set; }

        public static void Main(string[] args, FormSiparisim formSiparisim)
        {
            YanÜrünler YanÜrün1 = new YanÜrünler();
            YanÜrün1.Ad = "Patates Kızartması";
            YanÜrün1.Fiyat = 29;
            formSiparisim.lYanÜrün1.Text = YanÜrün1.Fiyat.ToString();

            YanÜrünler YanÜrün2 = new YanÜrünler();
            YanÜrün2.Ad = "Çıtır Tavuk Topları";
            YanÜrün2.Fiyat = 33;
            formSiparisim.lYanÜrün2.Text = YanÜrün2.Fiyat.ToString();

            YanÜrünler YanÜrün3 = new YanÜrünler();
            YanÜrün3.Ad = "Rus Salatası";
            YanÜrün3.Fiyat = 32;
            formSiparisim.lYanÜrün3.Text = YanÜrün3.Fiyat.ToString();

            YanÜrünler YanÜrün4 = new YanÜrünler();
            YanÜrün4.Ad = "Soğan Halkası";
            YanÜrün4.Fiyat = 29;
            formSiparisim.lYanÜrün4.Text = YanÜrün4.Fiyat.ToString();

        }
    }
}
