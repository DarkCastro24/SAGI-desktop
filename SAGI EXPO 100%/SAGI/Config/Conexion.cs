using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Controlador
{
    class Conexion
    {
        public static MySqlConnection getConnection()
        {
            MySqlConnection con;
            try
            {
                string server = "127.0.0.1";
                string user = "root";
                //string port = "3306";
                string database = "inmuebles";
                string password = " ";
                con = new MySqlConnection("server = " + server + ";database = " + database + ";Uid = " + user
                                                         + ";pwd = " + password  /*+ ";port=" + port*/);

                con.Open();

                return con;
            }
            catch (Exception)
            {
                MessageBox.Show("Error fatal", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con = new MySqlConnection();
                return con;
            }
        }
    }
}
