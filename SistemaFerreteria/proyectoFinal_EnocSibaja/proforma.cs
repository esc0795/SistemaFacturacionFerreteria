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
    public partial class proforma : Form
    {
        public proforma()
        {
            InitializeComponent();
        }

        public void llenarFactura(string id) {

            Boolean encontrado = false;
            string lineaReg = "";
            string[] lineaTemp;
            StreamReader reader;
            reader = File.OpenText("facturas.txt");
            lineaReg = reader.ReadLine();

            while (lineaReg != null)
            {
                lineaTemp = lineaReg.Split('-');

                if (id == lineaTemp[0])
                {
                    numFac.Text = lineaTemp[0];
                    cliente.Text = lineaTemp[2];
                    fecha.Text = lineaTemp[1];
                    correo.Text = lineaTemp[3];
                    telefono.Text = lineaTemp[4];
                    subtotal.Text = lineaTemp[6];
                    impuestos.Text = lineaTemp[5];
                    total.Text = lineaTemp[7];
                }

                lineaReg = reader.ReadLine();
            }

            reader.Close();
        }

        public void llenarLv() {
            Boolean encontrado = false;
            string lineaReg = "";
            string[] lineaTemp;
            StreamReader reader;
            reader = File.OpenText("detalles.txt");
            lineaReg = reader.ReadLine();

            while (lineaReg != null)
            {
                lineaTemp = lineaReg.Split('-');

                ListViewItem it = new ListViewItem(lineaTemp[0]);

                it.SubItems.Add(lineaTemp[1]);
                it.SubItems.Add(lineaTemp[2]);
                it.SubItems.Add(lineaTemp[3] + ".00");
                lvFac.Items.Add(it);
                encontrado = true;

                lineaReg = reader.ReadLine();
            }

            reader.Close();
        }

        private void proforma_Load(object sender, EventArgs e)
        {
            llenarFactura(numFac.Text);
            llenarLv();
            File.Delete("detalles.txt");
        }
    }
}
