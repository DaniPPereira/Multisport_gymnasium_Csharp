using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Polidesportivo_Ipca.Classes
{
    public class Pessoa
    {
        //Variaveis
        /// <summary>
        /// Declaração da variavel para verificar se o utilizador está logado
        /// </summary>
        public static Utilizador userLogado;
        /// <summary>
        /// Declaração da variavel para verificar se o funcionario está logado
        /// </summary>
        public static Funcionario funcionarioLogado;

        //Propriedades

        /// <summary>
        /// Nome da Pessoa
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Password da Pessoa
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Email da Pessoa
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Data de Nascimento da Pessoa
        /// </summary>
        public DateTime DataNascimento { get; set; }
        /// <summary>
        /// Numero de telemovel da pessoa
        /// </summary>
        public string NumeroTlm { get; set; }
    }
}
