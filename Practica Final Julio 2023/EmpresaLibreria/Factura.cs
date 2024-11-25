using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaLibreria
{
    [Serializable]
    public class Factura
    {
        private Persona cliente;
        private DateTime fechaHora;
        public double Iva {  get; set; }
        public double precioTotal;
        public int CantidadItems;
        static int NroFactura=0;

        List<Items>ListaItems=new List<Items>();


        public Factura(string nombre, long cuit)
        {
            cliente = new Persona(nombre, cuit);
            NroFactura = NroFactura + 1;
            fechaHora = DateTime.Now;
        }
        public void AgregarItems(Items linea) //terminar
        {
            precioTotal += linea.Precio();
            ListaItems.Add(linea);

        }
        public double PrecioSinIva()    //terminar
        {
            double d=0;
            return d;
        }

        public Items MostrarItems(int numero)   //terminar
        {
            return null;
        }
        public override string ToString()
        {
            string datos=$"Nº: {NroFactura} - Cliente: {cliente.ToString()} - Fecha:{fechaHora.ToString("dd/MM/yyyy HH:mm:ss")} - Precio: {precioTotal.ToString("F2")}";

            return $"{datos}";
        }
        public string ExportarCSV()
        {
            string datos = "";
            
            datos += $"{NroFactura};";
            datos += $"{cliente.ToString()};";
            datos += $"{fechaHora.ToString("dd/MM/yyyy HH:mm:ss")};";
            datos += $"{precioTotal.ToString("F2")};";

            return datos;
        }







    }
}
