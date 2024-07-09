using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Controlador.Constructores
{
    class Constructor_Recuperaciones
    {
        // Datos a introducir
        public static string Usuario { get; set; }
        public static string Contraseña { get; set; }

        //Constructor para preguntas de Seguridad   
        public string respuesta1 { get; set; }
        public string respuesta2 { get; set; }
        public string respuesta3 { get; set; }       
        public static int pregunta1 { get; set; }
        public static int pregunta2 { get; set; }
        public static int pregunta3 { get; set; }
        public int codigo_correo { get; set; }

        // Constructor para recuperar contraseña por correo
        public static int Empresa { get; set; }
        public static string CorreoEmpresa { get; set; }
        public static string ContraseñaCorreoEmpresa { get; set; }
        public string cod { get; set; }
        public static string nombre { get; set; }
        public static string contraseñaCorreo { get; set; }
        public static string verificarcorreo { get; set; }

        // Constructor para recuperacion por ADMIN

        public string ContraseñaAdmin { get; set; }

        public Constructor_Recuperaciones()

        {
            Constructor_Recuperaciones.nombre = nombre;
            Constructor_Recuperaciones.contraseñaCorreo = contraseñaCorreo;
            Constructor_Recuperaciones.Contraseña = Contraseña;
            Constructor_Recuperaciones.pregunta1 = pregunta1;
            Constructor_Recuperaciones.pregunta2 = pregunta2;
            Constructor_Recuperaciones.pregunta3 = pregunta3;
        }
    }
}
