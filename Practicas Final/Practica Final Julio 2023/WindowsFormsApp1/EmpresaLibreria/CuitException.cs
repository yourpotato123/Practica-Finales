using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaLibreria
{
    internal class CuitException:Exception
    {
        public CuitException() { }
        public CuitException(string message):base(message) { }

    }
}
