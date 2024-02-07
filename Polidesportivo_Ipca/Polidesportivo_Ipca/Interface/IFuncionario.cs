using Polidesportivo_Ipca.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polidesportivo_Ipca
{
    interface IFuncionario
    {
        /// <summary>
        /// Metodo para filtrar o primeiro funcionario que valida a condição
        /// </summary>
        /// <param name="nrprocesso">Numero de Processo do funcionário</param>
        /// <param name="pass">Password do funcionario</param>
        /// <returns></returns>
        Funcionario FuncionarioLogin(string nrprocesso, string pass);
    }
}
