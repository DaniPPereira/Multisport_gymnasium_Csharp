using Polidesportivo.Exceptions;
using Polidesportivo_Ipca.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Polidesportivo_Ipca
{
    public partial class LoginPage : Form
    {
        public static List<Utilizador> utilizadorList = new List<Utilizador>();

        public LoginPage()
        {
            InitializeComponent();
            Utilizador.DadosLista();
            Utilizador.GuardarListaUtilizador();
            Reserva.DadosLista();
            Reserva.GuardarListaReserva();
            Funcionario.DadosLista();
            Funcionario.GuardarListaFuncionario();
            Funcionario.CarregarListaFuncionario();
            Reserva.CarregarListaReserva();
            Utilizador.CarregarListaUtilizador();

        }
        private void PctBoxSair_Click(object sender, EventArgs e)
        {
            //Encerra a aplicação
            Environment.Exit(0);
        }
        /// <summary>
        /// Acontece quando o evento click é iniciado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotExistingUserException">Não existe esse utilizador</exception>
        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            Utilizador utilizador = new Utilizador();
            Reserva reserva= new Reserva();
            Funcionario funcionario = new Funcionario();
            Utilizador User = utilizador.UtilizadorLogin(TxtNrProcesso.Text,TxtPass.Text);
            Funcionario Func = funcionario.FuncionarioLogin(TxtNrProcesso.Text, TxtPass.Text);
            Reserva.userLogado = reserva.ReservaLogin(TxtNrProcesso.Text);
            if (User != null)//confirma se existe algum Utilizador
            {
                //Se existir
                Utilizador.userLogado = User;//Utilizador logado atualizado
                Pessoa.funcionarioLogado = null;//Funcionario logado é nulo
            }
            else
            {
                //Se não existir
                Funcionario.funcionarioLogado = Func; //Funcionário logado atualizado
                Pessoa.userLogado = null;//Utilizador logado é nulo
            }

            if (User != null || Func != null)//Se houve um Utilizador ou um Funcionário logado
            {
                //Abrir o form Menu
                new Menu().Show();
                //Esconder o form atual
                this.Hide();
            }
            //Se não 
            else throw new NotExistingUserException();//Atirar uma exceção


        }
        /// <summary>
        /// Acontece quando o evento linkclicked é iniciado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LinkLabelNovoUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new CriarUtilizador().Show();
            this.Hide();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
