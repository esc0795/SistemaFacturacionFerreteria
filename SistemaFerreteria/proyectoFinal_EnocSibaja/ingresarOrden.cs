using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace proyectoFinal_EnocSibaja
{
    public partial class ingresarOrden : Form
    {
        public ingresarOrden()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            codProd.Text = "";
            canProd.Text = "";
            fecProd.Text = "";
        }

        private void gUARDARPRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productosObj prod = new productosObj();
            ordenObj orden = new ordenObj();

            if (codProd.Text != "" && canProd.Text != "")
            {
                orden.codigo = codProd.Text;
                orden.cantidad = canProd.Text;
                orden.fecha = DateTime.Now;
                string dt = Convert.ToString(orden.fecha);

                fecProd.Text = dt;

                StreamWriter wr;
                wr = File.AppendText("ordenes.txt");
                wr.WriteLine(orden.codigo + "-" + orden.cantidad + "-" + orden.fecha);
                sumarCantidad(orden.codigo, orden.cantidad);
                wr.Close();

                MessageBox.Show("Registro ingresado exitosamente", "Agregar");
                limpiar();
            }
            else
            {
                MessageBox.Show("Informacion no ingresada. Verifique", "Agregar");
            }
        }

        private void sumarCantidad(string codigo, string cantidad)
        {
            List<string> li = new List<string>();
            bool encontrado = false;
            string linea = "";
            int cantOrden = Convert.ToInt32(cantidad);
            string[] m;
            StreamReader rd;
            rd = File.OpenText("productos.txt");
            linea = rd.ReadLine();
            m = linea.Split('-');

            productosObj prod = new productosObj();

            while (linea != null)
            {
                m = linea.Split('-');

                if (codigo == m[0])
                {
                    int cantProd = Convert.ToInt32(m[2]);
                    int nuevaCant = cantProd + cantOrden;
                    string cantTxt = Convert.ToString(nuevaCant);

                    m[2] = cantTxt;
                }

                li.Add(m[0] + "-" + m[1] + "-" + m[2] + "-" + m[3] + "-" + m[4]);
                linea = rd.ReadLine();
            }

            rd.Close();

            StreamWriter wr;
            wr = File.CreateText("productos.txt");

            for (int i = 0; i < li.Count; i++)
            {
                wr.WriteLine(li[i]);
            }
            wr.Close();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            Boolean encontrado = false;
            string lineaReg = "";
            string[] lineaTemp;
            StreamReader reader;
            reader = File.OpenText("productos.txt");
            lineaReg = reader.ReadLine();

            while (lineaReg != null)
            {
                lineaTemp = lineaReg.Split('-');

                if (codProd.Text == lineaTemp[0])
                {
                    MessageBox.Show("Codigo Valido! Producto: " + lineaTemp[1]);
                    encontrado = true;
                }

                lineaReg = reader.ReadLine();
            }

            reader.Close();

            if (encontrado == false)
            {
                MessageBox.Show("Registro no encontrado!", "Busqueda");
                codProd.Text = "";
            }
        }
    }
}

