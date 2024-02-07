using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polidesportivo_Ipca
{
    interface IUtilizador
    {
        /// <summary>
        /// Metodo para filtrar o primeiro utilizador que valida a condição
        /// </summary>
        /// <param name="nrprocesso">Numero de Processo do Utilizador</param>
        /// <param name="password">Password do Utilizador</param>
        /// <returns>Retorna Utilizador que valida as condições</returns>
        Utilizador UtilizadorLogin(string nrprocesso, string password);
    }
}
