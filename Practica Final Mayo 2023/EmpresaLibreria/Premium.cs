using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaLibreria
{
    public class Premium : Producto
    {
        private double precioBaseB;

        public Premium(string descripcion, double PrecioA, double PrecioB)
        {
            this.descripcion = descripcion;
            precioBaseA = PrecioA;
            precioBaseB = PrecioB;
        }

        public override string Descripcion()
        {
            return descripcion;
        }

        public override double Precio(double kilo)
        {
            return (70 + ((precioBaseA * 0.85) + (precioBaseB * 0.15))*1.8) * kilo;
        }

        //public override string ToString()
        //{
        //    return;
        //}
    }
}
