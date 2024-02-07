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
    public partial class CriarUtilizador : Form
    {
        public CriarUtilizador()
        {
            InitializeComponent();
        }

        private void BtnReservar_Click(object sender, EventArgs e)
        {
            Utilizador utilizador = new Utilizador();
            string[] users = Utilizador.ListaUtilizador().ToArray();
            utilizador.Nome = TxtNome.Text;
            utilizador.NrProcessoEscola = TxtNrProcesso.Text;
            utilizador.Email = TxtEmail.Text;
            utilizador.Password = TxtPassword.Text;
            utilizador.NumeroTlm = TxtNrTelemovel.Text;
            bool existeuser = users.Contains(utilizador.NrProcessoEscola);
            if (existeuser)
            {
                throw new AlreadyExistingUser();
            }
            else
            {
                Utilizador.listaUtilizador.Add(utilizador);
                MessageBox.Show("Utilizador Criado com Sucesso");
            }
            Utilizador.GuardarListaUtilizador();
        }

        private void PctBoxSair_Click(object sender, EventArgs e)
        {
            new LoginPage().Show();
            this.Close();
        }
    }
}
