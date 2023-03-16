using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinal_EnocSibaja
{
    class factura
    {
        public string numero { get; set; }
        public DateTime fecha { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public string nombre { get; set; }
        public string impuesto { get; set; }
        public string subtotal { get; set; }
        public string totalFinal { get; set; }
    }
}
