using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Controlador.Constructores;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Modelo
{
    public class Conexion_correo: referencia_correo
    {
        public Conexion_correo()
        {
                string correo = Constructor_Recuperaciones.CorreoEmpresa;
                string contraseña = Constructor_Recuperaciones.ContraseñaCorreoEmpresa;     
                sendermail = "frajo1505@gmail.com";
                password = "pacoloco2019";
                host = "smtp.gmail.com";
                port = 587;
                ssl = true;

                initializesmtpclient();                         
        }
    }
}
