using Polidesportivo_Ipca.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Polidesportivo_Ipca.Forms
{
    public partial class VerPerfil : Form
    {
        //Construtor
        public VerPerfil()
        {
            InitializeComponent();
            Utilizador.Calculo calculoimc = new Utilizador.Calculo(Utilizador.CalculoIMC);//Utilizaçao do delegado calculo
            Utilizador.Calculo calculomm = new Utilizador.Calculo(Utilizador.CalculoMassaMagra);//Utilizaçao do delegado calculo
            foreach (Utilizador user in Utilizador.listaUtilizador)
            {
                user.IMC = calculoimc(user.Altura, user.Peso);
                user.MassaMagra = calculomm(user.Altura,user.Peso);
            }
            Utilizador.GuardarListaUtilizador();

            //Definição de visibilidade das labels
            #region
            labelAltura.Visible = false;
            labelAntebraco.Visible = false;
            labelBraco.Visible = false;
            labelCoxa.Visible = false;
            labelEnvergadura.Visible = false;
            labelGluteos.Visible = false;
            labelIMC.Visible = false;
            labelMassaCorporal.Visible = false;
            labelOmbros.Visible = false;
            labelPeso.Visible = false;
            labelEmail.Visible = false; 
            labelPassword.Visible = false;
            labelNome.Visible = false;
            labelTelemovel.Visible = false;
            labelNProcesso.Visible = false;
            #endregion
        }


        /// <summary>
        /// Acontece quando o evento click na Picture Box é ativado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PctBoxSair_Click(object sender, EventArgs e)
        {
            new Menu().Show();//Abre Form Menu
            this.Close();//Fecha o Form atual
        }
        /// <summary>
        /// Acontece quando o evento click na ToolStrip é ativado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotExistingReserveException"></exception>
        private void ToolStripVerReservas_Click(object sender, EventArgs e)
        {
            //Definição de visibilidade das labels
            #region
            ComboBoxUser.Visible = false;
            TxtPeso.Visible = false;
            TxtMassaCorporal.Visible = false;
            TxtAltura.Visible = false;
            TxtMassaCorporal.Visible = false;
            TxtAltura.Visible = false;
            TxtOmbros.Visible = false;
            TxtBraco.Visible = false;
            TxtAntebraco.Visible = false;
            TxtEnvergadura.Visible = false;
            TxtGluteos.Visible = false;
            TxtCoxa.Visible = false;
            TxtIMC.Visible = false;
            PctBoxLogo.Visible = false;
            TxtEmail.Visible = false;
            TxtNome.Visible = false;
            TxtNrTelemovel.Visible = false;
            TxtPassword.Visible = false;
            BtnAlterar.Visible = false;
            btnEliminarReserva.Visible = true;
            labelAltura.Visible = false;
            labelAntebraco.Visible = false;
            labelBraco.Visible = false;
            labelCoxa.Visible = false;
            labelEnvergadura.Visible = false;
            labelGluteos.Visible = false;
            labelIMC.Visible = false;
            labelMassaCorporal.Visible = false;
            labelOmbros.Visible = false;
            labelPeso.Visible = false;
            labelEmail.Visible = false;
            labelPassword.Visible = false;
            labelNome.Visible = false;
            labelTelemovel.Visible = false;
            labelNProcesso.Visible = false;
            BtnAlterarDados.Visible = false;
            #endregion
            LstReservas.Items.Clear();//Limpar Listview
            LstReservas.View = View.Details;//Mostrar detalhes da Listview
            LstReservas.Visible = true;//Definir Listiew como visivel
            Reserva reserva1 = new Reserva();//Criar nova reserva
            if(Pessoa.funcionarioLogado == null)//Verificar se é um funcionário ou utilizador logado
            {
                //Se for um utilizador
                List<Reserva> listareserva = reserva1.ListaReservas();//Receber a lista de reservas do utilizado logado
                if (listareserva.Count > 0)//Verificar se existe alguma reserva
                {
                    //Caso haja
                    foreach (Reserva reserva in listareserva)
                    {
                        //Adicionar lista de reservas na listview
                        LstReservas.Items.Add(Utilizador.userLogado.Nome);
                        LstReservas.Items[LstReservas.Items.Count - 1].SubItems.Add(reserva.Data.ToString("D"));
                        LstReservas.Items[LstReservas.Items.Count - 1].SubItems.Add(reserva.InicioReserva.ToString("HH:mm"));
                        LstReservas.Items[LstReservas.Items.Count - 1].SubItems.Add(reserva.FimReserva.ToString("HH:mm"));
                        LstReservas.Items[LstReservas.Items.Count - 1].SubItems.Add(reserva.Espaco.ToString());
                        LstReservas.Items[LstReservas.Items.Count - 1].SubItems.Add(reserva.Estado.ToString());
                    }
                }
                //Se não
                else throw new NotExistingReserveException();
                
            }
            else
            {
                //Se for um funcionário
                List<Reserva> listareserva = Reserva.lista;//Receber lista com todas as reservas existentes
                foreach (Reserva reserva in listareserva)
                {
                    //Adicionar lista de reservas na listview
                    LstReservas.Items.Add(reserva.NrProcesso);
                    LstReservas.Items[LstReservas.Items.Count - 1].SubItems.Add(reserva.Data.ToString("D"));
                    LstReservas.Items[LstReservas.Items.Count - 1].SubItems.Add(reserva.InicioReserva.ToString("HH:mm"));
                    LstReservas.Items[LstReservas.Items.Count - 1].SubItems.Add(reserva.FimReserva.ToString("HH:mm"));
                    LstReservas.Items[LstReservas.Items.Count - 1].SubItems.Add(reserva.Espaco.ToString());
                    LstReservas.Items[LstReservas.Items.Count - 1].SubItems.Add(reserva.Estado.ToString());
                }
            }

        }
        /// <summary>
        /// Acontece quando o evento click na ToolStrip é ativado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMudarInformacoes_Click(object sender, EventArgs e)
        {
            //Definição da visibilidade
            #region
            ComboBoxUser.Visible = false;
            btnEliminarReserva.Visible = false;
            TxtPeso.Visible = false;
            TxtMassaCorporal.Visible = false;
            TxtAltura.Visible = false;
            TxtMassaCorporal.Visible = false;
            TxtAltura.Visible = false;
            TxtOmbros.Visible = false;
            TxtBraco.Visible = false;
            TxtAntebraco.Visible = false;
            TxtEnvergadura.Visible = false;
            TxtGluteos.Visible = false;
            TxtCoxa.Visible = false;
            TxtIMC.Visible = false;
            LstReservas.Visible = false;
            PctBoxLogo.Visible = false;
            TxtEmail.Visible = true;
            TxtNome.Visible = true;
            TxtNrTelemovel.Visible = true;
            TxtPassword.Visible = true;
            BtnAlterar.Visible = true;
            labelNome.Visible = true;
            labelEmail.Visible = true;  
            labelPassword.Visible = true;
            labelTelemovel.Visible = true;
            labelAltura.Visible = false;
            labelAntebraco.Visible = false;
            labelBraco.Visible = false;
            labelCoxa.Visible = false;
            labelEnvergadura.Visible = false;
            labelGluteos.Visible = false;
            labelIMC.Visible = false;
            labelMassaCorporal.Visible = false;
            labelOmbros.Visible = false;
            labelPeso.Visible = false;
            labelNProcesso.Visible = false;
            #endregion
            if (Pessoa.userLogado == null)//Verificar se a pessoa logada é um funcionário ou um utilizador
            {
                //Se for funcionário
                //Preecher as TextBox com informações
                TxtNome.Text = Funcionario.funcionarioLogado.Nome;
                TxtPassword.Text = Funcionario.funcionarioLogado.Password;
                TxtNrTelemovel.Text = Funcionario.funcionarioLogado.NumeroTlm;
                TxtEmail.Text = Funcionario.funcionarioLogado.Email;
            }
            else
            {
                //Se for utilizador
                //Preecher as TextBox com informações
                TxtNome.Text = Utilizador.userLogado.Nome;
                TxtPassword.Text = Utilizador.userLogado.Password;
                TxtNrTelemovel.Text = Utilizador.userLogado.NumeroTlm;
                TxtEmail.Text = Utilizador.userLogado.Email;
            }
        }
        /// <summary>
        /// Acontece quando o evento click no botão alterar é ativado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (Pessoa.userLogado == null)//Verificar se a pessoa logada é um funcionário ou um utilizador
            {
                //Se for funcionário
                //Preecher o funcionario com as informações das TextBox
                Funcionario.funcionarioLogado.Nome = TxtNome.Text;
                Funcionario.funcionarioLogado.Email = TxtEmail.Text;
                Funcionario.funcionarioLogado.Password = TxtPassword.Text;
                Funcionario.funcionarioLogado.NumeroTlm = TxtNrTelemovel.Text;
                Funcionario.GuardarListaFuncionario();//Guardar a lista de funcionários
            }
            else
            {
                //Se for utilizador
                //Preecher o funcionario com as informações das TextBox
                Pessoa.userLogado.Nome = TxtNome.Text;
                Pessoa.userLogado.Email = TxtEmail.Text;
                Pessoa.userLogado.Password = TxtPassword.Text;
                Pessoa.userLogado.NumeroTlm = TxtNrTelemovel.Text;
                Utilizador.GuardarListaUtilizador();//Guardar a lista de utilizadores
            }
        }
        /// <summary>
        /// Acontece quando o evento click na ToolStrip é ativado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripConsultarFisico_Click(object sender, EventArgs e)
        {
            //Definiçao de visibilidade
            #region
            ComboBoxUser.Visible = false;
            TxtEmail.Visible = false;
            TxtNome.Visible = false;
            TxtNrTelemovel.Visible = false;
            TxtPassword.Visible = false;
            BtnAlterar.Visible = false;
            LstReservas.Visible = false;
            PctBoxLogo.Visible = false;
            TxtPeso.Visible = true;
            TxtMassaCorporal.Visible = true;
            TxtAltura.Visible = true;
            TxtMassaCorporal.Visible = true;
            TxtAltura.Visible = true;
            TxtOmbros.Visible = true;
            TxtBraco.Visible = true;
            TxtAntebraco.Visible = true;
            TxtEnvergadura.Visible = true;
            TxtGluteos.Visible = true;
            TxtCoxa.Visible = true;
            TxtIMC.Visible = true;
            btnEliminarReserva.Visible = false;
            labelAltura.Visible = true;
            labelAntebraco.Visible = true;
            labelBraco.Visible = true;
            labelCoxa.Visible = true;
            labelEnvergadura.Visible = true;
            labelGluteos.Visible = true;
            labelIMC.Visible = true;
            labelMassaCorporal.Visible = true;
            labelOmbros.Visible = true;
            labelPeso.Visible = true;
            labelEmail.Visible = false;
            labelPassword.Visible = false;
            labelNome.Visible = false;
            labelTelemovel.Visible = false;
#endregion

            List<string> utilizadores = Utilizador.ListaUtilizador();//Receber a lista com apenas o numero de processo
            this.ComboBoxUser.Items.AddRange(utilizadores.ToArray());//Adicionar o numero de processos dos utilizadores na ComboBox


            if (Pessoa.userLogado == null)//Verificar se a pessoa logada é um funcionário ou um utilizador
            {
                //Se for funcionário
                //Definição de visibilidade
                #region
                ComboBoxUser.Visible = true;
                BtnAlterarDados.Visible = true;
                TxtPeso.ReadOnly = false;
                TxtMassaCorporal.ReadOnly = false;
                TxtAltura.ReadOnly= false;
                TxtOmbros.ReadOnly = false;
                TxtBraco.ReadOnly = false;
                TxtAntebraco.ReadOnly= false;
                TxtEnvergadura.ReadOnly= false;
                TxtGluteos.ReadOnly= false;
                TxtCoxa.ReadOnly= false;
                TxtIMC.ReadOnly= false;
                labelNProcesso.Visible = true;
                #endregion
            }
            else
            {
                //Se for utilizador
                //Preencher as TextBox com informações do utilizador
                TxtPeso.Text = Utilizador.userLogado.Peso;
                TxtMassaCorporal.Text = Utilizador.userLogado.MassaMagra;
                TxtAltura.Text = Utilizador.userLogado.Altura;
                TxtOmbros.Text = Utilizador.userLogado.Ombros;
                TxtBraco.Text = Utilizador.userLogado.Braco;
                TxtAntebraco.Text = Utilizador.userLogado.Antebraco;
                TxtEnvergadura.Text = Utilizador.userLogado.Envergadura;
                TxtGluteos.Text = Utilizador.userLogado.Gluteos;
                TxtCoxa.Text = Utilizador.userLogado.Coxa;
                TxtIMC.Text = Utilizador.userLogado.IMC;
            }


        }
        /// <summary>
        /// Acontece quando o evento click no botão Eliminar reserva é ativado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEliminarReserva_Click(object sender, EventArgs e)
        {
            if (LstReservas.SelectedItems.Count > 0)//Verificar se está algum item selecionado
            {
                Reserva.lista.RemoveAt(LstReservas.SelectedIndices[0]);//Remover essa reserva da lista
                LstReservas.Items.Remove(LstReservas.SelectedItems[0]);//Remover essa reserva da ListView
            }
            Reserva.GuardarListaReserva();//Guardar a lista de reservas
        }
        /// <summary>
        /// Acontecer quando o evento SelectedIndexChanged da ComboBox é ativo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            string texto = ComboBoxUser.Text;
            List<Utilizador> utilizador = Utilizador.listaUtilizador;//Receber a lista de utilizadores
            foreach (Utilizador user in utilizador)
            {
                if(texto == user.NrProcessoEscola)//Verificar se o numero de processo da combobox é igual ao do utilizador
                {
                    
                    //Se sim, adicionar as informações à textbox
                    TxtPeso.Text = user.Peso;
                    TxtMassaCorporal.Text = user.MassaMagra;
                    TxtAltura.Text = user.Altura;
                    TxtOmbros.Text = user.Ombros;
                    TxtBraco.Text = user.Braco;
                    TxtAntebraco.Text = user.Antebraco;
                    TxtEnvergadura.Text = user.Envergadura;
                    TxtGluteos.Text = user.Gluteos;
                    TxtCoxa.Text = user.Coxa;
                    TxtIMC.Text = user.IMC;
                }
            }
        }
        /// <summary>
        /// Acontece quando o evento click no botão AlterarDados é ativado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAlterarDados_Click(object sender, EventArgs e)
        {
            string texto = ComboBoxUser.Text;
            List<Utilizador> utilizador = Utilizador.listaUtilizador;//Receber a lista de utilizadores
            foreach (Utilizador user in utilizador)
            {
                if (texto == user.NrProcessoEscola)//Verificar se o numero de processo da combobox é igual ao do utilizador
                {
                    //Se sim, atualizar os dados do utilizador
                    user.Peso = TxtPeso.Text;
                    user.MassaMagra = TxtMassaCorporal.Text;
                    user.Altura = TxtAltura.Text;
                    user.Ombros = TxtOmbros.Text;
                    user.Braco = TxtBraco.Text;
                    user.Antebraco = TxtAntebraco.Text;
                    user.Envergadura = TxtEnvergadura.Text;
                    user.Gluteos = TxtGluteos.Text;
                    user.Coxa = TxtCoxa.Text;
                    user.IMC = TxtIMC.Text;
                }
            }
            Utilizador.GuardarListaUtilizador(utilizador);//Guardar a lista de utilizadores 
        }

        private void LstReservas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
