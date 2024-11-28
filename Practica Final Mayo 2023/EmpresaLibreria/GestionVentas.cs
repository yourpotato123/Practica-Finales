using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EmpresaLibreria
{
    public class GestionVentas
    {
        List<Producto> lista = new List<Producto>();
        ArrayList listaClientes = new ArrayList();

        private Empresa dueño;
        private double montoFacturado;
        public DateTime inicioOperaciones { get; private set; }

        public GestionVentas(long cuit, string RazonSocial)
        {
            dueño = new Empresa(cuit, RazonSocial);

        }
        public void AgregarCliente(ClienteCuenta unCliente)
        {
            ClienteCuenta clientote = BuscarCliente(unCliente.Cuit);
            if (clientote == null)
            {
                listaClientes.Add(unCliente);
                listaClientes.Sort();
            }
        }
        public ClienteCuenta BuscarCliente(long cuit)
        {
            ClienteCuenta cliente = new ClienteCuenta(null, cuit, 0);
            int n = listaClientes.BinarySearch(cliente);
            if (n >= 0)
            {
                return cliente = (ClienteCuenta)listaClientes[n];
            }
            return null;
        }
        public Pedido GenerarPedido(int nro, List<Producto> lista)
        {
            Pedido pedido = new Pedido(nro, lista);
            return pedido;
        }

        public bool SumarPedido(ClienteCuenta cliente, Pedido nuevoPedido)
        {
            ClienteCuenta clientote = BuscarCliente(cliente.Cuit);
            if ((clientote != null) )
            {
                clientote.AgregarPedido(nuevoPedido);
                return true;
            }
            return false;
        }
        public bool AgregarPago(long cuit, double monto)
        {
            ClienteCuenta clientote = BuscarCliente(cuit);
            if (clientote != null)
            {
                clientote.AgregarPago(monto);
                return true;
            }
            return false;
        }
        public double VerSaldo(long cuit)
        {
            ClienteCuenta clientote = BuscarCliente(cuit);
            if (clientote != null)
            {
                return clientote.SaldoCuenta;
            }
            return 0;
        }






    }
}
