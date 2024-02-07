using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Polidesportivo_Ipca.Enums;
using System.Xml.Linq;

namespace Polidesportivo_Ipca
{
    public class Reserva 
    {
        /// <summary>
        /// Criação da lista reserva
        /// </summary>
        public static List<Reserva> lista = new List<Reserva> { };
        /// <summary>
        /// Construtor da clase Reserva
        /// </summary>
       
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

        

        public Reserva()
        {
            
        }

        public static void DadosLista()
        {
            lista.Add(new Reserva()
            {
                Data = new DateTime(2022,12,13),
                InicioReserva = new DateTime(2022,12,13,13,30,20),
                FimReserva = new DateTime(2022, 12, 13, 15, 30, 20),
                Espaco = Espacos.CampoFutebol7,
            });
            lista.Add(new Reserva()
            {
                Data = DateTime.Now,
                InicioReserva = DateTime.Now,
                FimReserva = DateTime.Now,
                Espaco = Espacos.CampoFutebol11,
            });
            lista.Add(new Reserva()
            {
                Data = DateTime.Now,
                InicioReserva = DateTime.Now,
                FimReserva = DateTime.Now,
                Espaco = Espacos.Ginasio,
            });
            lista.Add(new Reserva()
            {
                Data = DateTime.Now,
                InicioReserva = DateTime.Now,
                FimReserva = DateTime.Now,
                Espaco = Espacos.Pavilhao,
            });
            lista.Add(new Reserva()
            {
                Data = DateTime.Now,
                InicioReserva = DateTime.Now,
                FimReserva = DateTime.Now,
                Espaco = Espacos.CampoFutebol7
            });
        }

        public List<Reserva> Lista(string espaco)
        {
            
            Espacos espaco2;
            Enum.TryParse(espaco, out espaco2 );
            List<Reserva> reservas = lista.Where(r => r.Espaco.Equals(espaco2)).ToList();
            return reservas;
        }

        /// <summary>
        /// Este método permite guardar a lista de reservas em ficheiro
        /// </summary>
        public static void GuardarLista()
        {
            string save = JsonConvert.SerializeObject(lista);
            File.WriteAllText(Environment.CurrentDirectory + @"\listareservas.txt", save);

        }
        /// <summary>
        /// Este método permite carregar o ficheiro lista de reservas na aplicaçao
        /// </summary>
        public static void CarregarLista()
        {
            if (File.Exists(Environment.CurrentDirectory + @"\listareservas.txt"))
                lista = JsonConvert.DeserializeObject<List<Reserva>>(File.ReadAllText(Environment.CurrentDirectory + @"\listareservas.txt"));
            else
                File.WriteAllText(Environment.CurrentDirectory + @"\listareservas.txt", "[]");
        }

    }

}
