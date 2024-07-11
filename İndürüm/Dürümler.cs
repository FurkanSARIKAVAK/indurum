using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace İndürüm
{
    internal class Dürümler
    {
        

        /* Bir class oluşturarak dürümlerimizin adlarını ve fiyatlarıı girdik.Bunları "Siparişim" kısmında yer alan "Fiyat" bölümünün altında yer alan 
başlıklarda (label) kullanacağız. */
        public string Ad { get; set; }
        public double Fiyat { get; set; }

        // FormSiparisim kısmında yerleştirdiğimiz nesneleri kullanabilmek için "FormSiparisim formSiparisim" şeklinde yeni bir tanımlama kullandık.
        public static void Main(string[] args, FormSiparisim formSiparisim)
        {
            Dürümler Dürüm1 = new Dürümler();
            Dürüm1.Ad = "Hatay Soslu Tavuk Dürüm";
            Dürüm1.Fiyat = 53.75;
            formSiparisim.lDürüm1.Text = Dürüm1.Fiyat.ToString();

            Dürümler Dürüm2 = new Dürümler();
            Dürüm2.Ad = "Tavuk Dürüm";
            Dürüm2.Fiyat = 42.50;
            formSiparisim.lDürüm2.Text = Dürüm2.Fiyat.ToString();

            Dürümler Dürüm3 = new Dürümler();
            Dürüm3.Ad = "Et Dürüm";
            Dürüm3.Fiyat = 59.75;
            formSiparisim.lDürüm3.Text = Dürüm3.Fiyat.ToString();

            Dürümler Dürüm4 = new Dürümler();
            Dürüm4.Ad = "Zurna Tavuk Dürüm";
            Dürüm4.Fiyat = 61;
            formSiparisim.lDürüm4.Text = Dürüm4.Fiyat.ToString();

            Dürümler Dürüm5 = new Dürümler();
            Dürüm5.Ad = "Zurna Et Dürüm";
            Dürüm5.Fiyat = 69.25;
            formSiparisim.lDürüm5.Text = Dürüm5.Fiyat.ToString();

            Dürümler Dürüm6 = new Dürümler();
            Dürüm6.Ad = "Glutensiz Dürüm";
            Dürüm6.Fiyat = 55;
            formSiparisim.lDürüm6.Text = Dürüm6.Fiyat.ToString();

            Dürümler Dürüm7 = new Dürümler();
            Dürüm7.Ad = "Vegan Dürüm";
            Dürüm7.Fiyat = 53.75;
            formSiparisim.lDürüm7.Text = Dürüm7.Fiyat.ToString();

        }
    }
    
}
