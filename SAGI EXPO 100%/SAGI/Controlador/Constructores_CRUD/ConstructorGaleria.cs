using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Controlador.Constructor_CRUD
{
    public class ConstructorGaleria
    {
        public static int ID { get; set; }
        public static int id_terreno { get; set; }
        public static int id_apartamento { get; set; }
        public static int id_casa { get; set; }
        public static string imagen1 { get; set; }
        public static string imagen2 { get; set; }
        public static string imagen3 { get; set; }
        public static string imagen4 { get; set; }
        public static string direccion { get; set; }
        public static string Actualizar_Agregar { get; set; }

        public ConstructorGaleria()
        {
            ConstructorGaleria.id_apartamento = id_apartamento;
            ConstructorGaleria.id_casa = id_casa;
            ConstructorGaleria.id_terreno = id_terreno;
            ConstructorGaleria.imagen1 = imagen1;
            ConstructorGaleria.imagen2 = imagen2;
            ConstructorGaleria.imagen3 = imagen3;
            ConstructorGaleria.imagen4 = imagen4;
            ConstructorGaleria.direccion = direccion;
            ConstructorGaleria.ID = ID;
            ConstructorGaleria.Actualizar_Agregar = Actualizar_Agregar;
        }
    } 
}
