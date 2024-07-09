using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Controlador.Constructor_CRUD
{
    public class ConstructorCompras
    {
        public int IdTerreno { get; set; }
        public string direccion { set; get; }
        public string municipio { set; get; }
        public int departamento { set; get; }
        public int TipoTerreno { set; get; }
        public int TipoRelieve { set; get; }
        public int Estado { set; get; }
        public int Extension { set; get; }
        public int Precio { set; get; }
        public ConstructorCompras() { }
    }
}
