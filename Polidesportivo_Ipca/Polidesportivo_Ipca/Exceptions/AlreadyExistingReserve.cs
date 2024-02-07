using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polidesportivo_Ipca
{
    public class AlreadyExistingReserve : Exception
    {
        /// <summary>
        /// Mensagem da Execeção "AlreadyExistingReserve"
        /// </summary>
        public override string Message => "Já existe uma reserva nesse horário";
    }
}
