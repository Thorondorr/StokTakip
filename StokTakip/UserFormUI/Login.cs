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
    public partial class Login : Form
    {
        public bool LoginFormVisiblty { get; set; }
        public Login()
        {
            InitializeComponent();
           
            
        }


        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            ParametreEkranıAc();
        }

      

        private void ParametreEkranıAc()
        {
            ParametreEkranı parametreEkranı = new ParametreEkranı();
            parametreEkranı.Show();
            this.Hide();                                                       
        }

        

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
