using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserFormUI
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void FormGetir(Form form)
        {
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(form);
            form.Show();
        }

        private void btn_cariEkle_Click(object sender, EventArgs e)
        {
            Cari cariEkle = new Cari();
            FormGetir(cariEkle);
        }

        private void btn_ürünEkle_Click(object sender, EventArgs e)
        {
            UrunEkle urunEkle = new UrunEkle();
            FormGetir(urunEkle);
        }
    }
}
