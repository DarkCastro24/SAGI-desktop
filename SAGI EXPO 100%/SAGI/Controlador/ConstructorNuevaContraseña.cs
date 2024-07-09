using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Controlador
{
    public class ConstructorNuevaContraseña
    {
        public static string usuario { get; set; }

        public static int nivel { get; set; }

        public ConstructorNuevaContraseña(string usuario)
        {
            usuario = ConstructorNuevaContraseña.usuario;
        }
    }
}
