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
    public partial class buscarOrden : Form
    {
        public buscarOrden()
        {
            InitializeComponent();
        }

        private void buscarMenu_Click(object sender, EventArgs e)
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
                    ListViewItem it = new ListViewItem(lineaTemp[0]);

                    it.SubItems.Add(lineaTemp[2]);
                    it.SubItems.Add(lineaTemp[1]);
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

        private void limpiar_Click(object sender, EventArgs e)
        {
            lv.Items.Clear();
        }
    }
}
