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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void insertarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ingresarProductos ingProd = new ingresarProductos();
            ingProd.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificarProductos modProd = new modificarProductos();
            modProd.Show();
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarProducto borrProd = new borrarProducto();
            borrProd.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscarProducto buscProd = new buscarProducto();
            buscProd.Show();
        }

        int lx, ly;
        int sw, sh;

        private void insertarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ingresarOrden ingOr = new ingresarOrden();
            ingOr.Show();
        }

        private void modificalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificarOrden modOrd = new modificarOrden();
            modOrd.Show();
        }

        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            buscarOrden buscar = new buscarOrden();
            buscar.Show();
        }

        private void borrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            eliminarOrden eliminar = new eliminarOrden();
            eliminar.Show();
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            crearFactura cf = new crearFactura();
            cf.Show();
        }

        public void pantallaCompleta()
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.pantallaCompleta();        }
    }
}
