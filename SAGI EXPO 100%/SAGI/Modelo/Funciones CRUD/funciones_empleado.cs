using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Controlador;
using System.Data;
using MySql.Data.MySqlClient;
using WindowsFormsApplication1.Controlador.Constructor_CRUD;

namespace WindowsFormsApplication1.Modelo
{
    class funciones_empleado
    {
        public static DataTable Mostrar()
        {
            DataTable ds = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT id_empleado AS ID, genero AS Genero, tipo_usuario AS TipoUsuario, nombre_empl AS Nombre, apellido_empl AS Apellido, nacimiento_empl AS Nacimiento, correo_empl AS Correo, direccion_empl AS Direccion, profesion AS Profesion, usuario AS Usuario, empresa AS Empresa FROM empleados INNER JOIN tbgenero ON tbgenero.id_genero = empleados.id_genero INNER JOIN tipoUsuario ON tipoUsuario.id_tipoUsuario = empleados.tipoUsuario INNER JOIN empresa ON empresa.id_empresa = empleados.id_empresa WHERE id_tipoUsuario >= 2", Conexion.getConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds);
                return ds;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ds = new DataTable();
            }
        }

        public static DataTable ObtenerGenero()
        {
            string query = "SELECT * FROM tbgenero";
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
                MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
            finally
            {
                Conexion.getConnection().Close();
            }
        }

        public static DataTable ObtenerEmpresa()
        {
            string query = "SELECT * FROM empresa";
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
                MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
            finally
            {
                Conexion.getConnection().Close();
            }
        }

        public static DataTable ObtenerTipoUsuario2()
        {
            string query = "SELECT * FROM tipousuario WHERE id_tipoUsuario >= 2";
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
                MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
            finally
            {
                Conexion.getConnection().Close();
            }
        }
        public static int Ingresar(ConstructorExpedienteEmpleados agregar)
        {

            int retorno = 0;
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(String.Format("SELECT usuario FROM empleados WHERE usuario = '{0}' OR correo_empl = '{1}' ", agregar.usuario, agregar.correo), Conexion.getConnection());
                MySqlDataReader reader = cmdselect.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("El registro ya existe", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return retorno;
                }
                else
                {
                    string contraseña = "efAdsX436aQfSUcxfwNEbBolhN0="; //"primeruso"
                    agregar.contraseña = contraseña; 

                    MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO `empleados` (`id_genero`, `estado`, `tipoUsuario`, `nombre_empl`, `apellido_empl`, `nacimiento_empl`, `correo_empl`, `direccion_empl`, `profesion`, `usuario`, `clave`, id_empresa) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}')", agregar.genero, agregar.estado, agregar.tipo_usuario, agregar.nombre, agregar.apellido, agregar.nacimiento, agregar.correo, agregar.direccion, agregar.profesion, agregar.usuario, agregar.contraseña,agregar.empresa), Conexion.getConnection());
                    retorno = Convert.ToInt16(cmdadd.ExecuteScalar());
                    if (retorno == 1)
                    {
                        MessageBox.Show("El usuario debera utilizar la contraseña *primeruso* la proxima vez que ingrese al sistema", "Usuario Ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        return retorno;
                    }
                    return retorno;
                }
                

            }
            
            catch
            {
                MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }

        }

        public static int ClaveDefault(ConstructorExpedienteEmpleados agregar)
        {

            int retorno = 0;
            try
            {                   
                    MySqlCommand cmdadd = new MySqlCommand(string.Format("UPDATE empleados SET clave='{0}' WHERE id_empleado = '{1}'", agregar.contraseña,agregar.id_empleado), Conexion.getConnection());
                    retorno = Convert.ToInt16(cmdadd.ExecuteNonQuery());
                    if (retorno >= 1)
                    {
                        MessageBox.Show("El usuario debera utilizar la contraseña *primeruso* la proxima vez que ingrese al sistema", "La contraseña ha sido restaurada al valor default", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return retorno;
                    }
                    else
                    {
                    MessageBox.Show("La contraseña no pudo ser reseteada");
                    }
                    return retorno;
            }

            catch
            {
                MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }

        }

        public static int Actualizar(ConstructorExpedienteEmpleados agregar)
        {

            int retorno = 0;
            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("UPDATE `empleados` SET id_genero = '{0}', estado = '{1}', tipoUsuario = '{2}', `nombre_empl` = '{3}', `apellido_empl` = '{4}', `nacimiento_empl` = '{5}', `correo_empl` = '{6}', `direccion_empl` = '{7}', `profesion` = '{8}', `usuario` = '{9}', `clave` = '{10}', `id_empresa` = '{11}' WHERE id_empleado = '{12}'", agregar.genero, agregar.estado, agregar.tipo_usuario, agregar.nombre, agregar.apellido, agregar.nacimiento, agregar.correo, agregar.direccion, agregar.profesion, agregar.usuario, agregar.contraseña, agregar.empresa,agregar.id_empleado), Conexion.getConnection());
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
                MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }



        public static int Eliminar(ConstructorExpedienteEmpleados del)
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
                MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }


        public static DataTable Buscar_Correo(ConstructorExpedienteEmpleados che)
        {
            DataTable ds = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand(String.Format("SELECT id_empleado AS ID, genero AS Genero, tipo_usuario AS TipoUsuario, nombre_empl AS Nombre, apellido_empl AS Apellido, nacimiento_empl AS Nacimiento, correo_empl AS Correo, direccion_empl AS Direccion, profesion AS Profesion, usuario AS Usuario, empresa AS Empresa FROM empleados INNER JOIN tbgenero ON tbgenero.id_genero = empleados.id_genero INNER JOIN tipoUsuario ON tipoUsuario.id_tipoUsuario = empleados.tipoUsuario INNER JOIN empresa ON empresa.id_empresa = empleados.id_empresa WHERE id_tipoUsuario >= 2 AND correo_empl LIKE CONCAT ('%',?correo,'%')"), Conexion.getConnection());
                cmd.Parameters.Add(new MySqlParameter("correo", che.correo));
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                ad.Fill(ds);
                return ds;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ds;
            }
        }

        public static DataTable Buscar_usuario(ConstructorExpedienteEmpleados che)
        {
            DataTable ds = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand(String.Format("SELECT id_empleado AS ID, genero AS Genero, tipo_usuario AS TipoUsuario, nombre_empl AS Nombre, apellido_empl AS Apellido, nacimiento_empl AS Nacimiento, correo_empl AS Correo, direccion_empl AS Direccion, profesion AS Profesion, usuario AS Usuario, empresa AS Empresa FROM empleados INNER JOIN tbgenero ON tbgenero.id_genero = empleados.id_genero INNER JOIN tipoUsuario ON tipoUsuario.id_tipoUsuario = empleados.tipoUsuario INNER JOIN empresa ON empresa.id_empresa = empleados.id_empresa WHERE id_tipoUsuario >= 2 AND usuario LIKE CONCAT ('%',?usuario,'%')"), Conexion.getConnection());
                cmd.Parameters.Add(new MySqlParameter("usuario", che.usuario));
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                ad.Fill(ds);
                return ds;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ds;
            }
        }
    }
}
