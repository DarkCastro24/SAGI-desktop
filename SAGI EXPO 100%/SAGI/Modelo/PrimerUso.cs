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
    class PrimerUso
    {
        public static DataTable ObtenerGenero()
        {
            string query = "SELECT * FROM generoempl";
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

        public static DataTable ObtenerTipoUsuario()
        {
            string query = "SELECT * FROM tipousuario";
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

        public static DataTable ObtenerEstado()
        {
            string query = "SELECT * FROM estadousuario";
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
        public static int NuevoUsuario(ConstructorNuevoUsuario agregar)
        {

            int retorno = 0;
            try
            {

                MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO `empleados` (`genero`, `estado`, `tipoUsuario`, `nombre_empl`, `apellido_empl`, `nacimiento_empl`, `correo_empl`, `direccion_empl`, `profesion`, `usuario`, `clave`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')", agregar.genero,agregar.estado,agregar.tipo_usuario,agregar.nombre,agregar.apellido,agregar.nacimiento,agregar.correo,agregar.direccion,agregar.profesion,agregar.usuario,agregar.contraseña),Conexion.getConnection());
                retorno = Convert.ToInt16(cmdadd.ExecuteScalar());
                MessageBox.Show("Usuario Ingresado correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return retorno;


            }
            catch
            {
                MessageBox.Show("Usuario no pudo ser ingresado", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return retorno;
            }

        }

        public static int Empresa(Constructor_empresa agregar)
        {

            int retorno = 0;
            try
            {

                MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO empresa(nombre, logo,domicilio, telefono, primero) VALUES ({0},{1},{2},{3},{4})", agregar.nombre,agregar.domicilio,agregar.domicilio,agregar.telefono), Conexion.getConnection());
                retorno = Convert.ToInt16(cmdadd.ExecuteScalar());
                MessageBox.Show("Usuario Ingresado correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return retorno;


            }
            catch
            {
                MessageBox.Show("Usuario no pudo ser ingresado", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return retorno;
            }

        }



    }
}
