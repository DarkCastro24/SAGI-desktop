using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Controlador.Constructor_CRUD
{
    public class ConstructorBusquedaFiltrada
    {
        public int estado { get; set; }
        public int departamento { get; set; }

        public int precio { get; set; }

        public string direccion { get; set; }

        public string descripcion { get; set; }

        public string municipio { get; set; }

        public int numero_baños { get; set; }

        public int numero_cuartos { get; set; }

        public int numero_pisos { get; set; }

        public decimal area_casa { get; set; }
        public int Area_Apartamento { get; set; }

        public decimal area_terreno { get; set; }
        public int piso { get; set; }
        public int TipoTerreno { set; get; }
        public int TipoRelieve { set; get; }
        public int Extension { set; get; }
        public string edificio { get; set; }
        public int tipo_Apartamento { get; set; }
        public int tipo_Casa { get; set; }
        public static int id { get; set; }
        public static string imagen { get; set; }
        public static string imagen2 { get; set; }
        public static string imagen3 { get; set; }
        public static string imagen4 { get; set; }

        public ConstructorBusquedaFiltrada()
        {
            Constructor_apartamento.id_apar = id;
            Constructor_apartamento.imagen = imagen;
            Constructor_apartamento.imagen2 = imagen2;
            Constructor_apartamento.imagen3 = imagen3;
            Constructor_apartamento.imagen4 = imagen4;
        }
    }
}
