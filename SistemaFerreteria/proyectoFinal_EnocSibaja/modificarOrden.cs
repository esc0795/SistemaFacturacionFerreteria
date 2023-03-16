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
    public partial class modificarOrden : Form
    {
        public modificarOrden()
        {
            InitializeComponent();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            Boolean encontrado = false;
            string lineaReg = "";
            string[] lineaTemp;
            StreamReader reader;
            reader = File.OpenText("ordenes.txt");
            lineaReg = reader.ReadLine();

            while (lineaReg != null)
            {
                lineaTemp = lineaReg.Split('-');

                if (codProd.Text == lineaTemp[0])
                {
                    MessageBox.Show("Codigo Valido!");
                    encontrado = true;
                    canProd.Text = lineaTemp[1];
                    fecProd.Text = lineaTemp[2];
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

        private void gUARDARPRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> li = new List<string>();
            string linea = "";
            string[] m;
            StreamReader rd;
            rd = File.OpenText("ordenes.txt");
            linea = rd.ReadLine();

            ordenObj orden = new ordenObj();

            while (linea != null)
            {
                m = linea.Split('-');

                if (codProd.Text == m[0])
                {
                    orden.cantidad = canProd.Text;

                    m[1] = orden.cantidad;
                    MessageBox.Show("Registro Modificado");

                    codProd.Text = "";
                    canProd.Text = "";
                    fecProd.Text = "";
                }

                li.Add(m[0] + "-" + m[1] + "-" + m[2]);
                linea = rd.ReadLine();
            }

            rd.Close();

            StreamWriter wr;
            wr = File.CreateText("ordenes.txt");

            for (int i = 0; i < li.Count; i++)
            {
                wr.WriteLine(li[i]);
            }
            wr.Close();
        }
    }
}
