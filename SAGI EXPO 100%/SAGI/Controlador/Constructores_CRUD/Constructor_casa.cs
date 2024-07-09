using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Controlador
{
    public class Constructor_casa
    {
        public int id_casa { get; set; }

        public int id_cliente { get; set; }
        
        public int estado { get; set; }
        public int departamento { get; set; }

        public float precio { get; set; }

        public string direccion { get; set; }

        public string descripcion { get; set; }        

        public int municipio { get; set; }
        public int tipo_casa { get; set; }

        public int numero_baños { get; set; }

        public int numero_cuartos { get; set; }

        public int numero_pisos { get; set; }

        public int numero_garage { get; set; }
        public int numero_patio { get; set; }
        public string Descripcion_patio { get; set; }
        public string Descripcion_garage { get; set; }
        public decimal area_casa { get; set; }

        public decimal area_terreno { get; set; }

        public static int precio2 { get; set; }

        public static string descripcion2 { get; set; }
    }
}
