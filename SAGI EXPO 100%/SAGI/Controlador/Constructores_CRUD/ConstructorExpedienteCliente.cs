using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Controlador
{
    public class ConstructorExpedienteCliente
    {
        public int Id { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string direccion { get; set; }
        public string correo { get; set; }
        public string dui { get; set; }
        public string Nacimiento { get; set; }
        public string EstadoCivil { get; set; }
        public string genero { get; set; }
        public string estado { get; set; }
        public string telefono { get; set; }
        public string tipoCliente { get; set; }
        public ConstructorExpedienteCliente() { }
    }
}
