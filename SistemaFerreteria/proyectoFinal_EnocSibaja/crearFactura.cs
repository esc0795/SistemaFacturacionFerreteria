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
    public partial class crearFactura : Form
    {
        public crearFactura()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void limpiarCampos() {
            numFac.Text = "";
            fecFac.Text = "";
            nom.Text = "";
            corrFac.Text = "";
            telFac.Text = "";
            impuesto.Text = "";
            subTot.Text = "";
            totFin.Text = "";
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            factura fac = new factura();
            proforma pf = new proforma();

            if (numFac.Text != "" && corrFac.Text != "" && telFac.Text != "")
            {
                fac.numero = numFac.Text;
                fac.correo = corrFac.Text;
                fac.telefono = telFac.Text;
                fac.fecha = DateTime.Now;
                fac.nombre = nom.Text;
                fac.impuesto = impuesto.Text;
                fac.subtotal = subTot.Text;
                fac.totalFinal = totFin.Text;
                string dt = Convert.ToString(fac.fecha);

                fecFac.Text = dt;

                StreamWriter wr;
                wr = File.AppendText("facturas.txt");
                wr.WriteLine(fac.numero + "-" + dt + "-" + fac.nombre + "-" + fac.correo + "-" + fac.telefono + "-" + fac.impuesto + "-" + fac.subtotal + "-" + fac.totalFinal);
                wr.Close();

                MessageBox.Show("Factura cerrada!", "Facturacion");
                limpiarCampos();
                lv.Items.Clear();

                proforma pro = new proforma();
                pro.llenarFactura(fac.numero);
                this.Hide();
                pro.ShowDialog();
            }
            else
            {
                MessageBox.Show("Informacion no ingresada. Verifique", "Agregar");
            }
        }

        private void lIMPIARBUSQUEDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            lv.Items.Clear();
        }

        private void buscarMenu_Click(object sender, EventArgs e)
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

                if (idArt.Text == lineaTemp[0] && canProd.Text != "")
                {
                    encontrado = true;
                    int canIng = Convert.ToInt32(canProd.Text);
                    int canDisp = Convert.ToInt32(lineaTemp[2]);

                    if (canIng <= canDisp)
                    {
                        ListViewItem it = new ListViewItem(canProd.Text);

                        int precio = Convert.ToInt32(lineaTemp[3]);
                        int can = Convert.ToInt32(canProd.Text);
                        int total = precio * can;
                        String totTxt = Convert.ToString(total);

                        it.SubItems.Add(lineaTemp[1]);
                        it.SubItems.Add(lineaTemp[3] + ".00");
                        it.SubItems.Add(totTxt + ".00");
                        lv.Items.Add(it);
                        string cantDetalle = canProd.Text;
                        idArt.Text = "";
                        canProd.Text = "";
                        double suma = 0;

                        foreach (ListViewItem item in lv.Items)
                        {
                            suma += Convert.ToDouble(item.SubItems[3].Text);
                        }

                        string sumTxt = Convert.ToString(suma);
                        double totImp = suma * 0.13;
                        string totImpTxt = Convert.ToString(totImp);
                        double totFinal = totImp + suma;
                        string totFinTxt = Convert.ToString(totFinal);

                        guardarDetalle(lineaTemp[0], cantDetalle, lineaTemp[1], lineaTemp[3]);

                        subTot.Text = sumTxt + ".00";
                        impuesto.Text = totImpTxt + ".00";
                        totFin.Text = totFinTxt + ".00";
                    } else {
                        MessageBox.Show("Cantidad de producto insuficiente: Disponibilidad: " + lineaTemp[2] + " Unidades");
                    }
                }

                lineaReg = reader.ReadLine();
            }

            reader.Close();

            if (encontrado == false)
            {
                MessageBox.Show("Registro no encontrado!", "Busqueda");
                idArt.Text = "";
                canProd.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void guardarDetalle(string codigo, string cantidad, string nombre, string precio) {
            StreamWriter wr;
            wr = File.AppendText("detalles.txt");
            wr.WriteLine(codigo + "-" + cantidad + "-" + nombre + "-" + precio);
            wr.Close();
        }

        private void canProd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
