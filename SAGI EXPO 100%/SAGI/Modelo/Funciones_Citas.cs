using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using WindowsFormsApplication1.Controlador;
using System.Windows.Forms;


namespace WindowsFormsApplication1.Modelo
{
    class Funciones_Citas
    {
        //Tablas y combobox
        #region
        public static DataTable comboEstado()
        {
            DataTable est;
            try
            {
                string query = "Select id_estadoCita, estado_cita From estado_cita";
                MySqlCommand estado = new MySqlCommand(query, Conexion.getConnection());                
                MySqlDataAdapter data = new MySqlDataAdapter(estado);
                est = new DataTable();
                data.Fill(est);

                return est;
            }
            catch (Exception es)
            {

                MessageBox.Show(""+es,"Error",MessageBoxButtons.OK);
                return est = new DataTable();
            }
            finally
            {
                Conexion.getConnection().Close();
            }
            
            
        }
        
        public static DataTable priori()
        {
            DataTable prior;
            try
            {
                string query = "Select id_prioridad,prioridad From prioridad";
                MySqlCommand estado = new MySqlCommand(query, Conexion.getConnection());
                MySqlDataAdapter data = new MySqlDataAdapter(estado);
                prior = new DataTable();
                data.Fill(prior);

                return prior;
            }
            catch (Exception es)
            {

                MessageBox.Show("" + es, "Error", MessageBoxButtons.OK);
                return prior = new DataTable();
            }
            finally
            {
                Conexion.getConnection().Close();
            }
        }
       

        public static DataTable cliente() {
            DataTable cln;
            try
            {
                string query = "Select id_cliente,nombre_client From cliente";
                MySqlCommand cli = new MySqlCommand(query, Conexion.getConnection());
                MySqlDataAdapter data = new MySqlDataAdapter(cli);
                cln = new DataTable();
                data.Fill(cln);

                return cln;
            }
            catch (Exception es)
            {

                MessageBox.Show("" + es, "Error", MessageBoxButtons.OK);
                return cln = new DataTable();
            }
            finally
            {
                Conexion.getConnection().Close();
            }
        }
        public static DataTable grid()
        {
            DataTable gr;
            try
            {
                string query = "Select * From cita";
                MySqlCommand grd = new MySqlCommand(query, Conexion.getConnection());
                MySqlDataAdapter data = new MySqlDataAdapter(grd);
                gr = new DataTable();
                data.Fill(gr);

                return gr;
            }
            catch (Exception es)
            {

                MessageBox.Show("" + es, "Error", MessageBoxButtons.OK);
                return gr = new DataTable();
            }
            finally
            {
                Conexion.getConnection().Close();
            }
        }
        #endregion 


    }
}
