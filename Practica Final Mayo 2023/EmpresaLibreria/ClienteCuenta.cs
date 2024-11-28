using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaLibreria
{
    public class ClienteCuenta:IComparable<ClienteCuenta>
    {
        Queue<Pedido> listaPedidos;
        public string Nombre { get; set; }
        public long Cuit { get; set; }
        public double SaldoCuenta { get; set; }
        public double Tope { get; set; }



        public ClienteCuenta(string nombre, long cuit, double TopeCuenta)
        {
            Nombre = nombre;
            Cuit = cuit;
            Tope = TopeCuenta;
            SaldoCuenta = 0;
            listaPedidos = new Queue<Pedido>();
        }

        public double AgregarPedido(Pedido NuevoPedido)
        {
            SaldoCuenta += NuevoPedido.Valor;
            listaPedidos.Enqueue(NuevoPedido);
            return SaldoCuenta;
        }

        public Pedido RetirarPedido()
        {
          return listaPedidos.Dequeue();
        }

        public bool AgregarPago(double monto)
        {
            if (Tope >= SaldoCuenta)
            {
                return true;
            }
            return false;
        }

        public int CompareTo(ClienteCuenta other)
        {
            if (other != null)
            {
                return Cuit.CompareTo(other.Cuit);
            }
            return 1;
        }
    }
}
