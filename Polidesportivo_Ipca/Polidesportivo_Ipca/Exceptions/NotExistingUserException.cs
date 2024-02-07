using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polidesportivo.Exceptions
{
    public class NotExistingUserException : Exception
    {
        /// <summary>
        /// Mensagem da Execeção "NotExistingUserException"
        /// </summary>
        public override string Message => "Não Existe Esse Utilizador";
    }
}
