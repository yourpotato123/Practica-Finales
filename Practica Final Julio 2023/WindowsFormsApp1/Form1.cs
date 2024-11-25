using EmpresaLibreria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        FileStream archivo = null;
        StreamReader lector = null;
        StreamWriter escritor = null;
        BinaryFormatter binaryFormater = null;

        List<Items> items = new List<Items>();
        Factura f = null;
        public Form1()
        {
            InitializeComponent();
            
            ProdUnitario prod = new ProdUnitario(100, "cable bipolar", "metro");
            prod.PrecioUnidad = 2.25;
            items.Add(prod);
            prod = new ProdUnitario (120, "cable 2,5mm", "metro");
            prod.PrecioUnidad = 1.25;
            items.Add(prod);
            prod = new ProdUnitario(130, "soldador 40w", "unidad");
            prod.PrecioUnidad = 650.00;
            items.Add(prod);
            for (int i = 0; i < items.Count(); i++)
            {
                lbItems.Items.Add(items[i].ToString());
            }            
        }


        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string nombre = txNombre.Text;
            long cuit = Convert.ToInt64(numCuit.Value);
            f = new Factura(nombre, cuit);
            groupBox1.Enabled = true;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            Items objeto = null;
            objeto = ((Items)lbItems.SelectedItem);
            f.AgregarItems(objeto);
            
            //f.ListaItems.Add(;


        }




    }
}
