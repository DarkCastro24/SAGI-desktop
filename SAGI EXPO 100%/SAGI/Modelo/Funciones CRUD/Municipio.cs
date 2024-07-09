using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using WindowsFormsApplication1.Controlador;

namespace WindowsFormsApplication1.Modelo.Funciones_CRUD
{
    public class Municipio
    {
        public static DataTable ObtenerDepartamentos()
        {
            string query = "SELECT * FROM departamento";
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
                MessageBox.Show("Ah ocurrido un error al obtener los tipos de usuario", "Error critico de conexion");
                return data;
            }
            finally
            {
                Conexion.getConnection().Close();
            }
        }

        public static DataTable Ahuachapan()
        {
            string query = "SELECT * FROM municipios WHERE id_departamento = '1'";
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
                MessageBox.Show("Ah ocurrido un error al obtener los tipos de usuario", "Error critico de conexion");
                return data;
            }
            finally
            {
                Conexion.getConnection().Close();
            }
        }

        public static DataTable Cabañas()
        {
            string query = "SELECT * FROM municipios WHERE id_departamento = '2'";
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
                MessageBox.Show("Ah ocurrido un error al obtener los tipos de usuario", "Error critico de conexion");
                return data;
            }
            finally
            {
                Conexion.getConnection().Close();
            }
        }

        public static DataTable Chalatenango()
        {
            string query = "SELECT * FROM municipios WHERE id_departamento = '3'";
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
                MessageBox.Show("Ah ocurrido un error al obtener los tipos de usuario", "Error critico de conexion");
                return data;
            }
            finally
            {
                Conexion.getConnection().Close();
            }
        }

        public static DataTable Cuscatlan()
        {
            string query = "SELECT * FROM municipios WHERE id_departamento = '4'";
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
                MessageBox.Show("Ah ocurrido un error al obtener los tipos de usuario", "Error critico de conexion");
                return data;
            }
            finally
            {
                Conexion.getConnection().Close();
            }
        }

        public static DataTable LaLibertad()
        {
            string query = "SELECT * FROM municipios WHERE id_departamento = '5'";
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
                MessageBox.Show("Ah ocurrido un error al obtener los tipos de usuario", "Error critico de conexion");
                return data;
            }
            finally
            {
                Conexion.getConnection().Close();
            }
        }

        public static DataTable LaPaz()
        {
            string query = "SELECT * FROM municipios WHERE id_departamento = '6'";
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
                MessageBox.Show("Ah ocurrido un error al obtener los tipos de usuario", "Error critico de conexion");
                return data;
            }
            finally
            {
                Conexion.getConnection().Close();
            }
        }

        public static DataTable LaUnion()
        {
            string query = "SELECT * FROM municipios WHERE id_departamento = '7'";
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
                MessageBox.Show("Ah ocurrido un error al obtener los tipos de usuario", "Error critico de conexion");
                return data;
            }
            finally
            {
                Conexion.getConnection().Close();
            }
        }

        public static DataTable Morazan()
        {
            string query = "SELECT * FROM municipios WHERE id_departamento = '8'";
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
                MessageBox.Show("Ah ocurrido un error al obtener los tipos de usuario", "Error critico de conexion");
                return data;
            }
            finally
            {
                Conexion.getConnection().Close();
            }
        }

        public static DataTable SanMiguel()
        {
            string query = "SELECT * FROM municipios WHERE id_departamento = '9'";
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
                MessageBox.Show("Ah ocurrido un error al obtener los tipos de usuario", "Error critico de conexion");
                return data;
            }
            finally
            {
                Conexion.getConnection().Close();
            }
        }

        public static DataTable SanSalvador()
        {
            string query = "SELECT * FROM municipios WHERE id_departamento = '10'";
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
                MessageBox.Show("Ah ocurrido un error al obtener los tipos de usuario", "Error critico de conexion");
                return data;
            }
            finally
            {
                Conexion.getConnection().Close();
            }
        }

        public static DataTable SanVicente()
        {
            string query = "SELECT * FROM municipios WHERE id_departamento = '11'";
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
                MessageBox.Show("Ah ocurrido un error al obtener los tipos de usuario", "Error critico de conexion");
                return data;
            }
            finally
            {
                Conexion.getConnection().Close();
            }
        }

        public static DataTable SantaAna()
        {
            string query = "SELECT * FROM municipios WHERE id_departamento = '12'";
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
                MessageBox.Show("Ah ocurrido un error al obtener los tipos de usuario", "Error critico de conexion");
                return data;
            }
            finally
            {
                Conexion.getConnection().Close();
            }
        }

        public static DataTable Sonsonate()
        {
            string query = "SELECT * FROM municipios WHERE id_departamento = '13'";
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
                MessageBox.Show("Ah ocurrido un error al obtener los tipos de usuario", "Error critico de conexion");
                return data;
            }
            finally
            {
                Conexion.getConnection().Close();
            }
        }

        public static DataTable Usulutan()
        {
            string query = "SELECT * FROM municipios WHERE id_departamento = '14'";
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
                MessageBox.Show("Ah ocurrido un error al obtener los tipos de usuario", "Error critico de conexion");
                return data;
            }
            finally
            {
                Conexion.getConnection().Close();
            }
        }
    }
}

