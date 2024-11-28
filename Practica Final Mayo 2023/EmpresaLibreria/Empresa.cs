using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaLibreria
{
    public class Empresa
    {
        private long cuit;
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }

        public Empresa (long cuit, string RazonSocial)
        {
            this.cuit = cuit;
            this.RazonSocial = RazonSocial;
        }

        public override string ToString()
        {
            return $"{cuit} - {RazonSocial}";
        }


    }
}
