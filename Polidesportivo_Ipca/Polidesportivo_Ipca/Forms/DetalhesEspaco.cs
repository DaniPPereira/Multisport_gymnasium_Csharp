using Polidesportivo_Ipca.Classes;
using Polidesportivo_Ipca.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Polidesportivo_Ipca
{
    public partial class DetalhesEspaco : Form
    {
        /// <summary>
        /// Varivavel espaços disponiveis
        /// </summary>
        public Espacos espacos;

        /// <summary>
        /// Construtor
        /// </summary>
        public DetalhesEspaco()
        {
            InitializeComponent();
            //Definir formato dos datetimepicker
            DataTimeInicio.CustomFormat = "HH:mm";
            DataTimeFim.CustomFormat = "HH:mm";
            //Mostrar detalhes da Listview
            LstHorasOcupadas.View = View.Details;
            //Garante que as datas das reservas só acontecem após 30 min no minimo da hora atual, e que a hora de fim de reserva é no minimo 30 min depois do inicio
            RegrasHorario();
            if (Pessoa.userLogado == null)//Verifica se é um utilizador logado
            {
                //Se não for, o botão reservar fica invisível
                BtnReservar.Visible = false;
            }
            
        }/// <summary>
        /// Acontece quando o evento click na picturebox ocorre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PctBoxSair_Click_1(object sender, EventArgs e)
        {
            new Menu().Show();//Abre o form menu
            this.Close();//Fecha o form atual
        }
        /// <summary>
        /// Acontece quando o evento click no botão reservar ocorre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="AlreadyExistingReserve">Exceção já existe essa reserva</exception>
        private void BtnReservar_Click(object sender, EventArgs e)
        {
            Reserva reserva = AdicionarReserva();//Adiciona nova reserva
            bool existereserva = Reserva.lista.Any(r => r.InicioReserva == reserva.InicioReserva);//Verifica se já existe uma reserva com esses dados
            if (existereserva==false)
            {
                    Reserva.lista.Add(reserva);//Adiciona na lista de reservas, a reserva criada
                    Reserva.GuardarListaReserva();//Guarda a lista de reservas em ficheiro
                    LstHorasOcupadas.Refresh();//Atualiza a listview
                
            }
            else throw new AlreadyExistingReserve();//Atira uma exceção a avisar que já existe uma reserva
        }
        /// <summary>
        /// Método que cria nova reserva com os dados do form
        /// </summary>
        /// <returns></returns>
        private Reserva AdicionarReserva()
        {
            Reserva reserva = new Reserva();
            reserva.NrProcesso = Utilizador.userLogado.NrProcessoEscola;
            reserva.Data = DataTimeData.Value;
            reserva.InicioReserva = DataTimeInicio.Value;
            reserva.FimReserva = DataTimeFim.Value;
            reserva.Espaco = espacos;
            return reserva;
        }
        /// <summary>
        /// Acontece quando o valor do inicio da reserva é alterado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataTimeInicio_ValueChanged(object sender, EventArgs e)
        {
            DataTimeFim.MinDate = DataTimeInicio.Value.AddMinutes(30);//Hora minima de Fim de Reserva é a Inicial mais 30 minutos
        }

        /// <summary>
        /// Metodo para garantir que não é possivel marcar reservas em horas anteriores às atuais e que cada reserva tem no minimo 30 minutos
        /// </summary>
        private void RegrasHorario()
        {
            DataTimeFim.MinDate = DataTimeInicio.Value;//Hora minima de Fim de Reserva é igual à hora de Inicio da Reserva
            DataTimeInicio.MinDate = DateTime.Now;//Hora minima de inicio é igual às horas do utilizador
            DataTimeInicio.MinDate = DateTime.Now.AddMinutes(30);//Hora minima de inicio de reserva é igual às horas do utilizador mais 30 minutos
            DataTimeData.MinDate = DateTime.Now;//Data minima possivel de reserva igual à data que o utilizador está a efetuar a reserva
        }

        private void DetalhesEspaco_Load(object sender, EventArgs e)
        {

        }
    }
}
