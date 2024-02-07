using Polidesportivo_Ipca.Classes;
using Polidesportivo_Ipca.Forms;
using Polidesportivo_Ipca.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polidesportivo_Ipca
{
    public partial class Menu : Form
    {
        //Variaveis
        DetalhesEspaco campo = new DetalhesEspaco();

        //Construtor
        public Menu()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Acontece quando o Form Menu é carregado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Menu_Load(object sender, EventArgs e)
        {
            if (Pessoa.userLogado == null)//Verificar se a pessoa logada é um utilizador ou funcionário
            {
                //Se for um funcionário
                LblVerPerfil.Text = $"Bem-Vindo, {Pessoa.funcionarioLogado.Nome}";
                string label = "Ver agenda";
                Pessoa.userLogado = null;
                BtnCampo11.Text = label;
                BtnCampo7.Text = label;
                BtnGinasio.Text = label;
                BtnPavilhao.Text = label;
            }
            else
            {
                //Se for um utilizador
                LblVerPerfil.Text = $"Bem-Vindo,{Pessoa.userLogado.Nome}";
                Pessoa.funcionarioLogado = null;
            } 
        }
        /// <summary>
        /// Acontece quando o evento click na Picture Box é ativado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PctBoxSair_Click(object sender, EventArgs e)
        {
            new LoginPage().Show();//Abre o Form Login Page
            this.Close();//Fecha o form atual
        }
        /// <summary>
        /// Acontece quando o evento click no Botao Campo de 7 é ativado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCampo7_Click(object sender, EventArgs e)
        {
            campo.Show();//Mostra o forms Detalhes Campo
            campo.PctBoxImagem.Image = Resources.Campode7;//Altera a imagem para a que está no caminho indicado
            campo.LblInfo.Text= "Nome: Campo de Futebol de 7\nCapacidade: 14 pessoas\nPreço/hora: 50€ ";
            AdicionarEmListview("CampoFutebol7");//Adiciona a Lista de reservas no campo à Listview passando o espaço por paramentro
            campo.espacos = Enums.Espacos.CampoFutebol7;
            this.Hide();//Esconder o form Menu
        }

        private void BtnCampo11_Click(object sender, EventArgs e)
        {
            campo.Show();//Mostra o forms Detalhes Campo
            campo.PctBoxImagem.Image = Resources.pexels_mike_1171084;//Altera a imagem para a que está no caminho indicado
            campo.LblInfo.Text = "Nome: Campo de Futebol de 7\nCapacidade: 22 pessoas\nPreço/hora: 70€ ";
            AdicionarEmListview("CampoFutebol11");//Adiciona a Lista de reservas no campo à Listview passando o espaço por paramentro
            campo.espacos = Enums.Espacos.CampoFutebol11;
            this.Hide();//Esconder o form Menu
        }

        private void BtnPavilhao_Click(object sender, EventArgs e)
        {
            campo.Show();//Mostra o forms Detalhes Campo
            campo.PctBoxImagem.Image = Resources.Imagem4_1000x600;//Altera a imagem para a que está no caminho indicado
            campo.LblInfo.Text = "Nome: Pavilhão\nCapacidade: 10 pessoas\nPreço/hora: 40€ ";
            campo.espacos = Enums.Espacos.Pavilhao;//Adiciona a Lista de reservas no campo à Listview passando o espaço por paramentro
            AdicionarEmListview("Pavilhao");
            this.Hide();//Esconder o form Menu
        }

        private void BtnGinasio_Click(object sender, EventArgs e)
        {
            campo.Show();//Mostra o forms Detalhes Campo
            campo.PctBoxImagem.Image = Resources.image;//Altera a imagem para a que está no caminho indicado
            campo.LblInfo.Text = "Nome: Ginasio\nPreço/hora: 5€ ";
            campo.espacos = Enums.Espacos.Ginasio;//Adiciona a Lista de reservas no campo à Listview passando o espaço por paramentro
            AdicionarEmListview("Ginasio");
            this.Hide();//Esconder o form Menu
        }
        /// <summary>
        /// Este método insire todos os dados na ListView
        /// </summary>
        /// <param name="espaco"></param>
        private void AdicionarEmListview(string espaco)
        {
            Reserva reserva1 = new Reserva();
            List<Reserva> listareserva = reserva1.Lista(espaco);
            foreach (Reserva reserva in listareserva)
            {
                campo.LstHorasOcupadas.Items.Add(reserva.Data.ToString("D"));
                campo.LstHorasOcupadas.Items[campo.LstHorasOcupadas.Items.Count - 1].SubItems.Add(reserva.InicioReserva.ToString("HH:mm"));
                campo.LstHorasOcupadas.Items[campo.LstHorasOcupadas.Items.Count - 1].SubItems.Add(reserva.FimReserva.ToString("HH:mm"));
            }
        }
        /// <summary>
        /// Acontece quando o evento click na Picture Box é ativado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PctBoxPerfil_Click(object sender, EventArgs e)
        {
            new VerPerfil().Show();//Mostra o Forms VerPerfil
            this.Close();//Fecha o Forms Atual
        }
    }
}
