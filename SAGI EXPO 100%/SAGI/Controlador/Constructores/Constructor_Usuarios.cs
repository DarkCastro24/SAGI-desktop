using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Controlador.Constructores
{
    class Constructor_Usuarios
    {
        public int ID_empleado { get; set; }
        public string Nombre_Usuario { get; set; }
        public static string Usuario { get; set; }
        public string Apellido_Usuario { get; set; }
        public string Correo { get; set; }
        public int Empresa { get; set; }
        public string Direccion_Usuario { get; set; }
        public string profesion { get; set; }
        public string contraseña { get; set; }
        public string nacimiento { get; set; }
        public int genero { get; set; }
        public int tipo_usuario { get; set; }
        public int estado { get; set; }
        public string imagenUsuario { get; set; }
        public static int id_empresa { get; set; }
        public static string imagenEmpresa { get; set; }

        public Constructor_Usuarios()
        {
            Constructor_Usuarios.id_empresa = id_empresa;
            Constructor_Usuarios.imagenEmpresa = imagenEmpresa;
        }

    }
}
