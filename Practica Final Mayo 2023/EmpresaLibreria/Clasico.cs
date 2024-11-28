using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaLibreria
{
    public class Clasico : Producto
    {
        public Clasico(double precio, string descripcion)
        {
            precioBaseA = precio; 
            this.descripcion = descripcion;
        }

        public override string Descripcion()
        {
            return descripcion;
        }

        public override double Precio(double kilo)
        {
            return (50 + (precioBaseA * 1.4))*kilo; 
        }

        //public override string ToString()
        //{
        //    return;
        //}
    }
}
