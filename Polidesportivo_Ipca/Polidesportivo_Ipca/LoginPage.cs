using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polidesportivo_Ipca
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void lblSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if ((txtEmail.Text == "Admin") && (txtPass.Text == "Admin123"))
            {
                Menu menu = new Menu();
                menu.Show(this);
                this.Hide();

            }
            else
            {
                throw new Exception("Não existe esse Utilizador");
            }
           
        }

    }
}
