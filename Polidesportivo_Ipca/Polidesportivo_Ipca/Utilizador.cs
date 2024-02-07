using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polidesportivo_Ipca
{
    public class Utilizador
    {
        //Propriedades

        /// <summary>
        /// Nome do Utilizador
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Email do Utilizador
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Data de Nasicmento do Utilizador
        /// </summary>
        public DateTime DataNascimento { get; set; }
        /// <summary>
        /// Numero de Telemovel do Utilizador
        /// </summary>
        public int Numero { get; set; }
        /// <summary>
        /// Peso do Utilizador
        /// </summary>
        public float Peso { get; set; }
        /// <summary>
        /// Altura do Utilizador
        /// </summary>
        public int Altura { get; set; }
        /// <summary>
        /// Envergadura do Utilizador
        /// </summary>
        public int Envergadura { get; set; }

    }
}
