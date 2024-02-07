using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polidesportivo_Ipca
{
    public class AlreadyExistingUser : Exception
    {
        /// <summary>
        /// Mensagem da Execeção "AlreadyExistingUser"
        /// </summary>
        public override string Message => "Esse Utilizador já existe";
    }
}
