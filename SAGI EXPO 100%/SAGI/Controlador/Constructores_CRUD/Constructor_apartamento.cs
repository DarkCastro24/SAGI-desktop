using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Controlador
{
    public class Constructor_apartamento
    {
        public static int id_apar { get; set; }

        public int id_cliente { get; set; }
        public int estado { get; set; }

        public int departamento { get; set; }

        public float precio { get; set; }

        public string descripcion { get; set; }

        public string direccion { get; set; }

        public int municipio { get; set; }

        public int piso { get; set; }

        public int cuartos { get; set; }
        public string Bloque_Edificio { get; set; }
        public int Numero_Edificio { get; set; }

        public int baños { get; set; }

        public decimal area { get; set; }

        public string edificio { get; set; }
        public int tipo_Apartamento { get; set; }

        public static string imagen { get; set; }
        public static string imagen2 { get; set; }
        public static string imagen3 { get; set; }
        public static string imagen4 { get; set; }

        public static int precio2 { get; set; }

        public static string descripcion2 { get; set; }

        public Constructor_apartamento()
        {
            Constructor_apartamento.id_apar = id_apar;
            Constructor_apartamento.imagen = imagen;
            Constructor_apartamento.imagen2 = imagen2;
            Constructor_apartamento.imagen3 = imagen3;
            Constructor_apartamento.imagen4 = imagen4;
        }

    }
}
