using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaLibreria
{
    public class ProdUnitario:Items
    {
        private string nombre;
        private string unidadDeMedida;
        public double Cantidad {  get; set; }
        public double PrecioUnidad { get; set; }

        public ProdUnitario(int codigo, string nombre, string unidad)
        {
            this.Codigo = codigo;
            this.nombre = nombre;
            unidadDeMedida = unidad;
        }
        public override string Descripcion()
        {
            return $"{Codigo} - {nombre} - {unidadDeMedida} - {PrecioUnidad} - {Cantidad}";
        }

        public override double Precio()
        {
            double preciofinal = 0;
            preciofinal = (Cantidad * PrecioUnidad) * 1.07;
            return preciofinal;
        }
        public override string ToString()
        {
            return $"{Codigo} - {nombre} - {unidadDeMedida} - {PrecioUnidad}";
        }



    }
}
