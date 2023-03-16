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
    public partial class borrarProducto : Form
    {
        public borrarProducto()
        {
            InitializeComponent();
        }

        private void bUSCARPRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
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
                    ListViewItem it = new ListViewItem(lineaTemp[0]);

                    it.SubItems.Add(lineaTemp[1]);
                    it.SubItems.Add(lineaTemp[2]);
                    it.SubItems.Add(lineaTemp[3] + ".00");
                    it.SubItems.Add(lineaTemp[4]);
                    lv.Items.Add(it);
                    encontrado = true;
                    codProd.Text = "";
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

        private void lIMPIARBUSQUEDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lv.Items.Clear();
        }

        private void gUARDARPRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> li = new List<string>();
            string linea = "";
            string[] m;
            StreamReader rd;
            rd = File.OpenText("productos.txt");
            linea = rd.ReadLine();

            while (linea != null)
            {
                m = linea.Split('-');

                if (codProd.Text != m[0])
                {
                    li.Add(m[0] + "-" + m[1] + "-" + m[2] + "-" + m[3] + "-" + m[4]);
                }

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
            MessageBox.Show("Registro Eliminado");
            lv.Items.Clear();
            codProd.Text = "";
        }
    }
}
