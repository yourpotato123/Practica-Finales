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
        BinaryFormatter binaryFormatter = null;

        private List<Items> listaItems = new List<Items>();
        Factura f = null;
        public Form1()
        {
            InitializeComponent();
            
            ProdUnitario prod = new ProdUnitario(100, "cable bipolar", "metro");
            prod.PrecioUnidad = 2.25;
            listaItems.Add(prod);
            prod = new ProdUnitario (120, "cable 2,5mm", "metro");
            prod.PrecioUnidad = 1.25;
            listaItems.Add(prod);
            prod = new ProdUnitario(130, "soldador 40w", "unidad");
            prod.PrecioUnidad = 650.00;
            listaItems.Add(prod);
            for (int i = 0; i < listaItems.Count(); i++)
            {
                lbItems.Items.Add(listaItems[i].ToString());
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
            try
            {
                Items objeto = null;
                //var item = lbItems.SelectedItem;
                int index = lbItems.SelectedIndex;
                objeto = listaItems[index];
                f.AgregarItems(objeto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
            //f.ListaItems.Add(;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                binaryFormatter = new BinaryFormatter();
                string ruta = Path.Combine(Application.StartupPath, "Datos.bin");
                if (File.Exists(ruta))
                {
                    archivo = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                    f = (Factura)binaryFormatter.Deserialize(archivo);
                    archivo.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                string ruta = Path.Combine(Application.StartupPath, "Datos.bin");
                archivo = new FileStream(ruta, FileMode.OpenOrCreate,FileAccess.Write);
                binaryFormatter.Serialize(archivo, f);
                archivo.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
