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
    public partial class FormDurumler : Form
    {
        public FormDurumler()
        {
            InitializeComponent();
        }
        // Burada FormDurumler kısmındaki "Geri" butonunu aktifleştirdik.
        private void btnGeriDurumler_Click(object sender, EventArgs e)
        {
            FormDurumler formDurumler = new FormDurumler();
            formDurumler.Close();
        }
    }
}
