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
    public partial class ingresarProductos : Form
    {
        public ingresarProductos()
        {
            InitializeComponent();
        }

        private void ingresarAlInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ingresarProductos_Load(object sender, EventArgs e)
        {

        }

        private void limpiar() {
            codProd.Text = "";
            nomProd.Text = "";
            canProd.Text = "";
            preProd.Text = "";
            desProd.Text = "";
        }

        private void gUARDARPRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productosObj prod = new productosObj();

            prod.codigo = codProd.Text;
            prod.nombre = nomProd.Text;
            prod.cantidad = canProd.Text;
            prod.precio = preProd.Text;
            prod.descripcion = desProd.Text;

            StreamWriter wr;
            wr = File.AppendText("productos.txt");
            wr.WriteLine(prod.codigo + "-" + prod.nombre + "-" + prod.cantidad + "-" + prod.precio + "-" + prod.descripcion);
            wr.Close();
            MessageBox.Show("Registro ingresado exitosamente", "Agregar");
            limpiar();
        }
    }
}
