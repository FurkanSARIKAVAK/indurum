using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace İndürüm
{
    public partial class FormAnaEkran : Form
    {
        public FormAnaEkran()
        {
            InitializeComponent();
        }

    

        // Burada ana ekranda yer alan butonların görevlerini atadık.
        private void btnSiparisim_Click(object sender, EventArgs e)
        {
            FormSiparisim formSiparisim = new FormSiparisim();
            formSiparisim.Show();
        }

        private void btnDurumler_Click(object sender, EventArgs e)
        {
            FormDurumler formDurumler = new FormDurumler();
            formDurumler.Show();
        }

        private void btnIcecekler_Click(object sender, EventArgs e)
        {
            FormIcecekler formIcecekler = new FormIcecekler();
            formIcecekler.Show();
        }

        private void btnYanUrunler_Click(object sender, EventArgs e)
        {
            FormYanUrunler formYanUrunler = new FormYanUrunler();
            formYanUrunler.Show();
        }

        private void btnTatlilar_Click(object sender, EventArgs e)
        {
            FormTatlilar formTatlilar = new FormTatlilar();
            formTatlilar.Show();
        }

        private void btnGarsonCagır_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Garsonumuz siparişiniz için yanınıza gelecektir.Lütfen bekleyiniz...");
        }
    }
}
