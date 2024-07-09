using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Controlador.Constructor_CRUD
{
    class ConstructorExpedienteEmpleados
    {
        public int id_empleado { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string correo { get; set; }
        public int empresa { get; set; }
        public string direccion { get; set; }
        public string profesion { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public string nacimiento { get; set; }
        public int genero { get; set; }
        public int tipo_usuario { get; set; }     
        public int estado { get; set; }

        public ConstructorExpedienteEmpleados() { }
    }
}
