using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using Polidesportivo_Ipca.Enums;

namespace Polidesportivo_Ipca
{
    public class Reserva
    {
        //Construtor
        /// <summary>
        /// Inicição do construtor
        /// </summary>
        public Reserva()
        {
            //Coloca todas as reservas como ativas 
            this.Estado = Estado.Ativa;
            //Verifica o estado das reservas em relação à data
            EstadoReserva(lista);
        }

        //Variaveis

        /// <summary>
        /// Variavel para verificar o utilizador logado
        /// </summary>
        public static Reserva userLogado;
        /// <summary>
        /// Criação da lista reserva
        /// </summary>
        public static List<Reserva> lista = new List<Reserva> { };

        //Propriedades

        /// <summary>
        /// Numero de Processo da reserva
        /// </summary>
        public string NrProcesso { get; set; }
        /// <summary>
        /// Data de Reserva
        /// </summary>
        public DateTime Data { get; set; }
        /// <summary>
        /// Hora do Inicio da Reserva
        /// </summary>
        public DateTime InicioReserva { get; set; }
        /// <summary>
        /// Hora do Fim da Reserva
        /// </summary>
        public DateTime FimReserva { get; set; }
        /// <summary>
        /// Espaço escolhido para a Reserva
        /// </summary>
        public Espacos Espaco { get; set; }
        /// <summary>
        /// Estado da Reserva
        /// </summary>
        public Estado Estado { get; set; }

        //Metodos
        
        /// <summary>
        /// Adicionar dados à lista localmente
        /// </summary>
        public static void DadosLista()
        {
            lista.Add(new Reserva()
            {
                NrProcesso = "23507",
                Data = new DateTime(2022, 12, 19),
                InicioReserva = new DateTime(2022, 01, 01, 13, 30, 20),
                FimReserva = new DateTime(2022, 01, 01, 15, 30, 20),
                Espaco = Espacos.CampoFutebol7,
            });
            lista.Add(new Reserva()
            {
                NrProcesso = "23507",
                Data = new DateTime(2022, 12, 21),
                InicioReserva = new DateTime(2022, 01, 01, 14, 30, 20),
                FimReserva = new DateTime(2022, 01, 01, 16, 00, 20),
                Espaco = Espacos.CampoFutebol7,
            });
            lista.Add(new Reserva()
            {
                NrProcesso = "23507",
                Data = new DateTime(2022, 12, 19),
                InicioReserva = DateTime.Now,
                FimReserva = DateTime.Now,
                Espaco = Espacos.CampoFutebol11,
            });
            lista.Add(new Reserva()
            {
                NrProcesso = "23507",
                Data = new DateTime(2022, 12, 19),
                InicioReserva = DateTime.Now,
                FimReserva = DateTime.Now,
                Espaco = Espacos.Ginasio,
            });
            lista.Add(new Reserva()
            {
                NrProcesso = "23507",
                Data = new DateTime(2022, 12, 19),
                InicioReserva = DateTime.Now,
                FimReserva = DateTime.Now,
                Espaco = Espacos.Pavilhao,
            });
            lista.Add(new Reserva()
            {
                NrProcesso = "23502",
                Data = new DateTime(2022, 12, 21),
                InicioReserva = new DateTime(2022,12,31,15,00,00),
                FimReserva = new DateTime(2022, 12, 31, 16, 00, 00),
                Espaco = Espacos.CampoFutebol7
            });
        }

        /// <summary>
        /// Metodo que filtra a reserva do utilizador logado a partir do seu numero de processo
        /// </summary>
        /// <returns>Lista de reservas do utilizador logado</returns>
        public List<Reserva> ListaReservas()
        {
            List<Reserva> reservas = lista.Where(r => r.NrProcesso == userLogado.NrProcesso).ToList();
            return reservas;
        }
        
        /// <summary>
        /// Metodo que filtra a lista de reservas em funçao do espaço dado por parametro
        /// </summary>
        /// <param name="espaco">Espaço escolhido em string</param>
        /// <returns>Lista de reservas</returns>
        public List<Reserva> Lista(string espaco)
        {
            Espacos espaco2;
            Enum.TryParse(espaco, out espaco2);
            List<Reserva> reservas = lista.Where(r => r.Espaco.Equals(espaco2)).ToList();
            return reservas;
        }

        /// <summary>
        /// Metodo que retorna a primeira reserva onde o numero de processo da reserva é igual à string passada por paramentro 
        /// </summary>
        /// <param name="nrprocesso">Numero de processo em string</param>
        /// <returns></returns>
        public Reserva ReservaLogin(string nrprocesso)
        {
            Reserva reservado = lista.FirstOrDefault(r => r.NrProcesso.Equals(nrprocesso));
            return reservado;
        }

        /// <summary>
        /// Metodo que verifica o estado da reserva
        /// </summary>
        /// <param name="lista"></param>
        public void EstadoReserva(List<Reserva> lista)
        {
            foreach (Reserva reserva in lista)
            {
                if (DateTime.Compare(reserva.Data.AddMinutes(29), DateTime.Now) < 0)
                {
                    reserva.Estado = Estado.Utilizada;
                }
                else if (DateTime.Compare(reserva.Data, DateTime.Now) == 0)
                {
                    reserva.Estado = Estado.Ativa;
                }
                else
                {
                    reserva.Estado = Estado.Ativa;
                }
                
            }
        }

        public int Randomizer()
        {
            //Atribui um codigo de cacifo à reserva
            Random rdm = new Random();
            int random = rdm.Next(1000, 9999);
            return random;
        }
        /// <summary>
        /// Este método permite guardar a lista de reservas em ficheiro
        /// </summary>
        public static void GuardarListaReserva()
        {
            string save = JsonConvert.SerializeObject(lista);
            File.WriteAllText(Environment.CurrentDirectory + @"\listareservas.txt", save);

        }
        /// <summary>
        /// Este método permite carregar o ficheiro lista de reservas na aplicaçao
        /// </summary>        
        public static void CarregarListaReserva()
        {
            if (File.Exists(Environment.CurrentDirectory + @"\listareservas.txt"))
                lista = JsonConvert.DeserializeObject<List<Reserva>>(File.ReadAllText(Environment.CurrentDirectory + @"\listareservas.txt"));
            else
                File.WriteAllText(Environment.CurrentDirectory + @"\listareservas.txt", "[]");
        }
    }

}
