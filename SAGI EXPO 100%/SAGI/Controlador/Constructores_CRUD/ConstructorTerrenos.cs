using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Controlador
{
    public class ConstructorTerrenos
    {
        public int IdTerreno { get; set; }

        public int id_cliente { get; set; }
        public string direccion { set; get; }
        public int municipio { set; get; }
        public int departamento { set; get; }
        public int TipoTerreno { set; get; }
        public int TipoRelieve { set; get; }
        public string Descripcion_terreno { set; get; }
        public int Estado { set; get; }
        public int Extension { set; get; }
        public float Precio { set; get; }
        public ConstructorTerrenos() { }
    }
}
