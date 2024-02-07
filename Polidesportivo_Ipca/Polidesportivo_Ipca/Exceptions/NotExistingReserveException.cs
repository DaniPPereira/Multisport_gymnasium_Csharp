using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polidesportivo_Ipca
{
    public class NotExistingReserveException : Exception
    {
        /// <summary>
        /// Mensagem da Execeção "NotExistingReserve"
        /// </summary>
        public override string Message => "Esse Utilizador não tem Reservas";
    }
}
