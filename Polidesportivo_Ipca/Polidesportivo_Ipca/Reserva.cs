using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

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
        public Reserva()
        {
            this.Data = DateTime.Today;
        }
        /// <summary>
        /// Data de Reserva
        /// </summary>
        public DateTime Data { private get; set; }
        /// <summary>
        /// Hora do Inicio da Reserva
        /// </summary>
        public DateTime InicioReserva { get; set; }
        /// <summary>
        /// Hora do Fim da Reserva
        /// </summary>
        public DateTime FimReserva { get; set; }
        /// <summary>
        /// Este método permite guardar a lista de reservas em ficheiro
        /// </summary>
        public static void GuardarLista()
        {
            string save = JsonConvert.SerializeObject(lista);
            File.WriteAllText(Environment.CurrentDirectory + @"\listareservas.txt", save);

        }

    }

}
