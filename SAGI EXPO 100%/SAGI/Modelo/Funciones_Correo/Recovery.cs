using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Controlador.Constructores;

namespace WindowsFormsApplication1.Modelo
{
    class Recovery
    {
        public string recovery(string solicitud)
        {
                return ValidarRecuperacion.recover(solicitud);           
        }
    }
}
