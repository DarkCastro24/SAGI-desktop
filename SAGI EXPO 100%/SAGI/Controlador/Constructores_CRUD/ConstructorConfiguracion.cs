using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Controlador.Constructores_CRUD
{
    public class ConstructorConfiguracion
    {
        public static int ID_empleado { get; set; }
        public static string Usuario { get; set; }
        public static string Correo { get; set; }
        public static string Direccion { get; set; }
        public static string Profesion { get; set; }
        public static string Contraseña { get; set; }
        public static string imagenUsuario { get; set; }
        public static string respuesta1 { get; set; }
        public static string respuesta2 { get; set; }
        public static string respuesta3 { get; set; }
        public static int pregunta1 { get; set; }
        public static int pregunta2 { get; set; }
        public static int pregunta3 { get; set; }   
        public static string Validacion { get; set; }
        public ConstructorConfiguracion()
        {
            ConstructorConfiguracion.ID_empleado = ID_empleado;
            ConstructorConfiguracion.Usuario = Usuario;
            ConstructorConfiguracion.Contraseña = Contraseña;
            ConstructorConfiguracion.Correo = Correo;
            ConstructorConfiguracion.Direccion = Direccion;
            ConstructorConfiguracion.Profesion = Profesion;
            ConstructorConfiguracion.imagenUsuario = imagenUsuario;
            ConstructorConfiguracion.respuesta1 = respuesta1;
            ConstructorConfiguracion.respuesta2 = respuesta2;
            ConstructorConfiguracion.respuesta3 = respuesta3;
            ConstructorConfiguracion.pregunta1 = pregunta1;
            ConstructorConfiguracion.pregunta2 = pregunta2;
            ConstructorConfiguracion.pregunta3 = pregunta3;
        }
    }
}
