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
    public partial class modificarProductos : Form
    {
        public modificarProductos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cancelarProd_Click(object sender, EventArgs e)
        {

        }

        private void guardar_Click(object sender, EventArgs e)
        {

        }

        private void bUSCARPRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean encontrado = false;
            string linea = "";
            string[] m;
            StreamReader rd;
            rd = File.OpenText("productos.txt");
            linea = rd.ReadLine();
            while (linea != null)
            {
                m = linea.Split('-');
                if (codProd.Text == m[0])
                {
                    nomProd.Text = m[1];
                    canProd.Text = m[2];
                    preProd.Text = m[3];
                    desProd.Text = m[4];
                    encontrado = true;
                }
                linea = rd.ReadLine();
            }
            rd.Close();

            if (encontrado == false)
            {
                MessageBox.Show("Registro no encontrado", "Buscar");
                codProd.Text = "";
                nomProd.Text = "";
                canProd.Text = "";
                preProd.Text = "";
                desProd.Text = "";
            }
        }

        private void gUARDARPRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> li = new List<string>();
            string linea = "";
            string[] m;
            StreamReader rd;
            rd = File.OpenText("productos.txt");
            linea = rd.ReadLine();

            productosObj prod = new productosObj();

            while (linea != null)
            {
                m = linea.Split('-');

                if (codProd.Text == m[0])
                {
                    prod.nombre = nomProd.Text;
                    prod.cantidad = canProd.Text;
                    prod.precio = preProd.Text;
                    prod.descripcion = desProd.Text;

                    m[1] = prod.nombre;
                    m[2] = prod.cantidad;
                    m[3] = prod.precio;
                    m[4] = prod.descripcion;
                    MessageBox.Show("Registro Modificado");

                    codProd.Text = "";
                    nomProd.Text = "";
                    canProd.Text = "";
                    preProd.Text = "";
                    desProd.Text = "";
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
    }
}
