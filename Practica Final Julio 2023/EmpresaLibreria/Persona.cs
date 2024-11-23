using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaLibreria
{
    public class Persona
    {
        private string nombre;
        private long cuit;
        public long Cuit
        {
            get
            {
                return cuit;
            }
            set
            {
                if (value.ToString().Length != 11)
                {
                    throw new CuitException("Cuit no valido");
                }

                cuit = value;
            }
        }

        public Persona(string nombre, long cuit)
        {
            this.nombre = nombre;
            this.cuit = cuit;
        }

        public override string ToString()
        {
            return $"{nombre} - {cuit}";
        }



    }
}
