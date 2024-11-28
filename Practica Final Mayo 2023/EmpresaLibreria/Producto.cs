using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaLibreria
{
    public abstract class Producto
    {
        protected string descripcion;
        protected double precioBaseA;
        public double CantidadKilos;

        public abstract double Precio(double kilo);

        public abstract string Descripcion();
    }
}
