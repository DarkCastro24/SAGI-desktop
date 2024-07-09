using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Controlador;
using System.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1.Modelo
{
    public class funciones_apartamento
    {
        public static DataTable Mostrar()
        {
            DataTable ds = new DataTable();
            try
            {                
                MySqlCommand cmd = new MySqlCommand("SELECT id_apartamento AS ID, estado_apar AS Estado, departamento_apar AS Departamento, precio_apartamento AS Precio, descripcion_apar AS Descripcion, direccion_apartamento AS Direccion, municipio_apar AS Municipio, numero_piso_apar AS Piso, numero_cuartos_apar AS Cuartos, numero_baños_apar AS Balneario, area_departamento AS Area, edificio AS Edificio FROM apartamento INNER JOIN estadoapar ON estadoapar.id_estadoApar = apartamento.estado INNER JOIN departamentoapar ON departamentoapar.id_departamentoApar = apartamento.departamento", Conexion.getConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds);
                return ds;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ds = new DataTable();
            }
        }

        public static DataTable ObtenerEstadoApar()
        {
            string query = "SELECT * FROM estadoapar";
            DataTable data = new DataTable();
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion.getConnection());
                MySqlDataAdapter Adapter = new MySqlDataAdapter(cmdselect);
                Adapter.Fill(data);
                return data;

            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
            finally
            {
                Conexion.getConnection().Close();
            }
        }

        public static DataTable ObtenerDepartamento()
        {
            string query = "SELECT * FROM departamentoapar";
            DataTable data = new DataTable();
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion.getConnection());
                MySqlDataAdapter Adapter = new MySqlDataAdapter(cmdselect);
                Adapter.Fill(data);
                return data;

            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
            finally
            {
                Conexion.getConnection().Close();
            }
        }
    }
}
