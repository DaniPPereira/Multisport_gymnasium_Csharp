using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polidesportivo.Exceptions
{
    public class NotExistingUserException : Exception
    {
        public override string Message => "Não Existe Esse Utilizador";
    }
}
