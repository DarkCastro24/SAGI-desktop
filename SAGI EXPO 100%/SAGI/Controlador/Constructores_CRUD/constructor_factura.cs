using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Controlador.Constructor_CRUD
{
    public class constructor_factura
    {
        /*Detalle*/
        public static int Id { get; set; }

        public int Id2 { get; set; }
        public int Id_apar { get; set; }

        public double iva { get; set; }

        public double subtotal { get; set; }

        public double comision { get; set; }


        /*Factura*/

        public int id_factura { get; set; }

        public static int id_cliente { get; set; }

        public static string cliente { get; set; }

        public int estado { get; set; }
        public static double total { get; set; }

        public string fecha { get; set; }

        public int detalle { get; set; }
    }
}
