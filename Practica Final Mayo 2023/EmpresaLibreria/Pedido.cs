using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaLibreria
{
    public class Pedido
    {
        public double Valor { get; set; }
        public int Nro { get; set; }
        public DateTime FechaHora { get; set; }
        public string Detalle { get; set; }

        public Pedido(int nro, List<Producto> lista)
        {
            Nro = nro;
            FechaHora = DateTime.Now;
            for (int i = 0; i < lista.Count; i++)
            {
                Valor += lista[i].Precio(lista[i].CantidadKilos);
                Detalle += lista[i].Descripcion() + ",";
                Detalle += lista[i].CantidadKilos.ToString();
                Detalle += lista[i].Precio(1).ToString() + ",";
                Detalle += lista[i].Precio(lista[i].CantidadKilos).ToString() + ",";
            }
        }
        public string VerResumen()
        {
            string datos = "";
            datos += Nro.ToString()+",";
            datos += FechaHora.ToString("dd/MM/yyyy") + ",";
            datos += FechaHora.ToString("HH:mm") + ",";
            datos += Detalle;

            return datos;
        }



    }
}
