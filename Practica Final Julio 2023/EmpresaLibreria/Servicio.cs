using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaLibreria
{
    [Serializable]
    public class Servicio : Items
    {
        private string detalle;
        private double precioHora;
        public int Tiempo { get; set; }

        public Servicio(int codigo, string detalle, double precioHora) : base()
        {
            this.Codigo= codigo;
            this.detalle= detalle;
            this.precioHora= precioHora;
        }

        public override string Descripcion()
        {
            return $"{Codigo} - {detalle} - {Tiempo}";
        }

        public override double Precio()
        {
            double preciofinal = 0;
            preciofinal = (precioHora*Tiempo);
            return preciofinal;
        }





    }
}
