using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polidesportivo_Ipca
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            LoginPage Login = new LoginPage();
            Login.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reserva.lista.Add(new Reserva()
            {
                InicioReserva = dateTimePicker1.Value,
                FimReserva = dateTimePicker2.Value,
            });
            Reserva.GuardarLista();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
