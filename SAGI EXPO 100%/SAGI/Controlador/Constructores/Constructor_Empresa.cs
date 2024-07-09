using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Controlador.Constructores
{
    class Constructor_Empresa
    {
        public static int ID_empresa { get; set; }
        public string nit { get; set; }
        public string Nombre_Empresa { get; set; }
        public string direccion { get; set; }
        public string representante { get; set; }
        public int id_tipo_empresa { get; set; }
        public string imagen { get; set; }
        public static string correoEmpresarial { get; set; }
        public static string clavecorreo { get; set; }
    }
}
