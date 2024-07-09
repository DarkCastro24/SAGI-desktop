using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Controlador;
using WindowsFormsApplication1.Modelo;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using WindowsFormsApplication1.Vista;

namespace WindowsFormsApplication1.Modelo
{
    public class ValidarPrimerUso
    {
        public static bool PrimerUso()

        {

            bool retorno = false;

            try
            {

                string query = "SELECT * FROM primeruso WHERE primero = 1";
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion.getConnection());
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());

                if (retorno == true)
                {
                    string query2 = "UPDATE primeruso SET primero = '2' WHERE id_primer = '1'";
                    MySqlCommand cmdselect2 = new MySqlCommand(query2, Conexion.getConnection());
                    retorno = Convert.ToBoolean(cmdselect2.ExecuteScalar());
                    
                    Primer_uso2 kk = new Primer_uso2();
                    kk.Show();
                    FrmIntermediario hide = new FrmIntermediario();
                    hide.Hide();

                }

                else
                {
                   
                    frmLogin login = new frmLogin();
                    login.Show();
                    FrmIntermediario hide = new FrmIntermediario();
                    hide.Close();

                }

                return retorno;
            }

            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion revise su conexion a internet");
                return retorno;
            }


        }
    }
}

  