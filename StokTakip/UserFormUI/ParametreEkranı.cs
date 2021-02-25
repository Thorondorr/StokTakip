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
    public partial class ParametreEkranı : Form
    {
        public ParametreEkranı()
        {
            InitializeComponent();
        }

        private void ParametreEkranı_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginScreenShow();

        }

        private static void LoginScreenShow()
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "Login")
                {
                    frm.Show();
                }
            };
        }

        private void ParametreEkranı_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
