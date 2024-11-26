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
using static DevExpress.Data.Filtering.Helpers.SubExprHelper.ThreadHoppingFiltering;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        FileStream archivo = null;
        StreamReader lector = null;
        StreamWriter escritor = null;
        BinaryFormatter binaryFormatter = null;
        List<Factura> listaFacturas = new List<Factura>();    
        private List<Items> listaItems = new List<Items>();
        Factura f = null;
        public Form1()
        {
            InitializeComponent();
            
            ProdUnitario prod = new ProdUnitario(100, "cable bipolar", "metro");
            prod.PrecioUnidad = 2.25;
            prod.Cantidad = 1;

            listaItems.Add(prod);
            prod = new ProdUnitario (120, "cable 2,5mm", "metro");
            prod.PrecioUnidad = 1.25;
            prod.Cantidad = 1;
            listaItems.Add(prod);
            prod = new ProdUnitario(130, "soldador 40w", "unidad");
            prod.PrecioUnidad = 650.00;
            prod.Cantidad = 1;

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

            lblNombre.Text += nombre;
            lblCuit.Text += cuit.ToString();
            lblTotal.Text += 0.ToString();
            
            f = new Factura(nombre, cuit);
            //lbFacturas.Items.Add(f);
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
                lblTotal.Text = f.precioTotal.ToString();
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
                    listaFacturas = (List<Factura>)binaryFormatter.Deserialize(archivo);
                    archivo.Close();
                }

                foreach (Factura factura in listaFacturas)
                {
                    lbFacturas.Items.Add(factura);
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
                archivo = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Write);
                binaryFormatter.Serialize(archivo, listaFacturas);
                archivo.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Title = "Seleccione la ruta para guardar el archivo...";
                saveFileDialog1.Filter = ".csv|*.csv*";
                
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string ruta = saveFileDialog1.FileName;
                    string extension = ".csv";
                    archivo = new FileStream(ruta+extension, FileMode.Create, FileAccess.Write);
                    escritor = new StreamWriter(archivo);
                    string lineas = "Nº Factura;Nombre y cuit;Fecha;Precio total";
                    escritor.WriteLine(lineas);
                    if (listaFacturas.Count > 0)
                    {
                        foreach (Factura factura in listaFacturas)
                        {
                            lineas = factura.ExportarCSV();
                            escritor.WriteLine(lineas);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fatal. Restableciendo base de datos: " + ex.Message);
            }
            finally 
            {
                escritor.Close();
                archivo.Close();
            }

        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Title = "Seleccione la ruta para abrir el archivo...";
                openFileDialog1.Filter = ".csv|*.csv*";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string ruta = openFileDialog1.FileName;
                    archivo = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                    lector = new StreamReader(archivo);
                    string[] vectorString;
                    string vector = "";
                    while (!lector.EndOfStream)
                    {
                        vector = lector.ReadLine();
                        if (!vector.Contains("Nº"))
                        {
                            vectorString = vector.Split(';');

                            Factura factura = new Factura();
                            factura.ImportarDesdeCSV(vectorString);

                            listaFacturas.Add(factura);
                            lbFacturas.Items.Add(factura);
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            lbFacturas.Items.Add(f);
            listaFacturas.Add(f);
            f = null;
            groupBox1.Enabled = false;
            lblNombre.Text = "Nombre:";
            lblCuit.Text = "Cuit:";
            lblTotal.Text = "Total:";
        }
    }
}
