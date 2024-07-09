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
    class funciones_empleado
    {
        public static DataTable Mostrar()
        {
            DataTable ds = new DataTable();
            try
            {                
                MySqlCommand cmd = new MySqlCommand("SELECT id_empleado AS ID, genero_empl AS Genero, estado_usuario AS Estado, tipo_usuario AS TipoUsuario, nombre_empl AS Nombre, apellido_empl AS Apellido, nacimiento_empl AS Nacimiento, correo_empl AS Correo, direccion_empl AS Direccion, profesion AS Profesion, usuario AS Usuario, clave AS Clave FROM empleados INNER JOIN generoempl ON generoempl.id_generoEmpl = empleados.genero INNER JOIN estadousuario ON estadousuario.id_estado = empleados.estado INNER JOIN tipoUsuario ON tipoUsuario.id_tipoUsuario = empleados.tipoUsuario", Conexion.getConnection());
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
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
            finally
            {
                Conexion.getConnection().Close();
            }
        }
        public static int Ingresar(ConstructorNuevoUsuario agregar)
        {

            int retorno = 0;
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(String.Format("SELECT clave FROM cliente WHERE clave = '{0}'", agregar.contraseña), Conexion.getConnection());
                MySqlDataReader reader = cmdselect.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("El registro ya existe", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return retorno;
                }
                else
                {
                    MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO `empleados` (`genero`, `estado`, `tipoUsuario`, `nombre_empl`, `apellido_empl`, `nacimiento_empl`, `correo_empl`, `direccion_empl`, `profesion`, `usuario`, `clave`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')", agregar.genero, agregar.estado, agregar.tipo_usuario, agregar.nombre, agregar.apellido, agregar.nacimiento, agregar.correo, agregar.direccion, agregar.profesion, agregar.usuario, agregar.contraseña), Conexion.getConnection());
                    retorno = Convert.ToInt16(cmdadd.ExecuteScalar());
                    if (retorno >= 1)
                    {
                        MessageBox.Show("Usuario Ingresado correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return retorno;
                    }
                    else
                    {
                        MessageBox.Show("Usuario no pudo ser ingresado", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return retorno;
                    }
                }


            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }

        }

        public static int Actualizar(ConstructorNuevoUsuario agregar)
        {

            int retorno = 0;
            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("UPDATE `empleados` SET genero = '{0}', estado = '{1}', tipoUsuario = '{2}', `nombre_empl` = '{4}', `apellido_empl` = '{4}', `nacimiento_empl` = '{5}', `correo_empl` = '{6}', `direccion_empl` = '{7}', `profesion` = '{8}', `usuario` = '{9}', `clave` = '{10}' WHERE id_empleado = '{11}'", agregar.genero, agregar.estado, agregar.tipo_usuario, agregar.nombre, agregar.apellido, agregar.nacimiento, agregar.correo, agregar.direccion, agregar.profesion, agregar.usuario, agregar.contraseña, agregar.id_empleado), Conexion.getConnection());
                retorno = Convert.ToInt16(cmdadd.ExecuteScalar());
                if (retorno >= 1)
                {
                    MessageBox.Show("Usuario actualizado correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return retorno;
                }
                return retorno;
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }



    public static int Eliminar(ConstructorNuevoUsuario del)
        {
            int retorno = 0;

            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("DELETE FROM empleados WHERE id_empleado = '{0}'", del.id_empleado), Conexion.getConnection());
                retorno = Convert.ToInt32(cmdadd.ExecuteScalar());

                MessageBox.Show("Usuario eliminado correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
    }
}
