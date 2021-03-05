using Business.Concrete;
using DataAcces.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipUI.UserControls
{
    public partial class UC_Tahsilat : UserControl
    {
        TahsilatManager tahsilatManager = new TahsilatManager(new EfTahsilatDal());
        public UC_Tahsilat()
        {
            InitializeComponent();
            RefleshDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RefleshDataGridView()
        {
            var result = tahsilatManager.GetAll();
            dataGridView1.DataSource = result.Data;
        }
    }
}
