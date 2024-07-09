using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Controlador
{
    public class ConstructorRecuperarConstraseña
    {
        public static string usuario { get; set; }

        public string clave { get; set; }

        public static string nombre { get; set; }

        public static int nivel { get; set; }

        public ConstructorRecuperarConstraseña(string usuario, string clave)
        {
            usuario = ConstructorRecuperarConstraseña.usuario;
            clave = this.clave;
        }
    }
}
