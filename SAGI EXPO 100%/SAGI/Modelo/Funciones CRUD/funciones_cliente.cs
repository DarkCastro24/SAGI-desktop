using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WindowsFormsApplication1.Controlador;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Modelo
{
    class funciones_cliente
    {
        public static int Agregar(ConstructorExpedienteCliente agregar)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(String.Format("SELECT dui FROM cliente WHERE dui = '{0}' OR telefono = '{1}'",agregar.dui, agregar.telefono),Conexion.getConnection());
                MySqlDataReader reader = cmdselect.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("El registro ya existe", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return retorno;
                }
                else
                {
                    MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO `cliente` (`id_genero`, `tipoCliente`, `estadoCivil`, `id_estado`, `nombre_client`, `apellido_cliente`, `dui`, `nacimiento_cliente`, `correo_cliente`, `direccion_cliente`, `telefono`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')", agregar.genero, agregar.tipoCliente, agregar.EstadoCivil, agregar.estado, agregar.nombres, agregar.apellidos, agregar.dui, agregar.Nacimiento, agregar.correo, agregar.direccion, agregar.telefono), Conexion.getConnection());
                    retorno = Convert.ToInt32(cmdadd.ExecuteScalar());

                    if (retorno <= 1)
                    {
                        MessageBox.Show("Cliente Ingresado correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cliente no pudo ser ingresado", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        public static DataTable Mostrar()
        {
            DataTable ds;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT id_cliente AS ID, tipo_Cliente AS Tipo_Cliente, genero AS Genero, estado_cliente AS Estado, estado_Civil AS Estado_Civil, nombre_client AS Nombre, apellido_cliente AS Apellidos, dui AS DUI, nacimiento_cliente AS Nacimiento, correo_cliente AS Correo, direccion_cliente AS Direccion, telefono AS Telefono FROM cliente INNER JOIN tipoCliente ON tipoCliente.id_tipoCliente = cliente.tipoCliente INNER JOIN estadoCivil ON estadoCivil.id_estadoCivil = cliente.estadoCivil INNER JOIN tbgenero ON tbgenero.id_genero = cliente.id_genero INNER JOIN estadoclien ON estadoClien.id_estado = cliente.id_estado", Conexion.getConnection());
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                ds = new DataTable();
                ad.Fill(ds);
                return ds;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ds = new DataTable();
            }
        }

        public static int Eliminar(ConstructorExpedienteCliente del)
        {
            int retorno = 0;

            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("DELETE FROM cliente WHERE id_cliente = '{0}'", del.Id), Conexion.getConnection());
                retorno = Convert.ToInt32(cmdadd.ExecuteScalar());


                MessageBox.Show("Cliente eliminado correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }

        public static int Actualizar(ConstructorExpedienteCliente act)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("UPDATE `cliente` SET `id_genero`='{0}',`tipoCliente`='{1}',`estadoCivil`='{2}',`id_estado`='{3}',`nombre_client`='{4}',`apellido_cliente`='{5}',`dui`='{6}',`nacimiento_cliente`='{7}',`correo_cliente`='{8}',`direccion_cliente`='{9}',`telefono`='{10}' WHERE id_cliente = '{11}'", act.genero, act.tipoCliente, act.EstadoCivil, act.estado, act.nombres, act.apellidos, act.dui, act.Nacimiento, act.correo, act.direccion, act.telefono, act.Id), Conexion.getConnection());
                retorno = Convert.ToInt32(cmdadd.ExecuteScalar());

                if (retorno <= 1)
                {
                    MessageBox.Show("Cliente actualizado correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch
            {

                MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static DataTable ObtenerEstadoCivil()
        {
            string query = "SELECT * FROM estadocivil";
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

        public static DataTable ObtenerEstado()
        {
            string query = "SELECT id_estado, estado_cliente FROM estadoclien";
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
        public static DataTable ObtenerTipoCliente()
        {
            string query = "SELECT * FROM tipocliente";
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

        public static DataTable BuscarCliente(ConstructorExpedienteCliente che)
        {
            DataTable ds = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand(String.Format("SELECT id_cliente AS ID, tipo_Cliente AS Tipo_Cliente, genero AS Genero, estado_cliente AS Estado, estado_Civil AS Estado_Civil, nombre_client AS Nombre, apellido_cliente AS Apellidos, dui AS DUI, nacimiento_cliente AS Nacimiento, correo_cliente AS Correo, direccion_cliente AS Direccion, telefono AS Telefono FROM cliente INNER JOIN tipoCliente ON tipoCliente.id_tipoCliente = cliente.tipoCliente INNER JOIN estadoCivil ON estadoCivil.id_estadoCivil = cliente.estadoCivil INNER JOIN tbgenero ON tbgenero.id_genero = cliente.id_genero INNER JOIN estadoclien ON estadoClien.id_estado = cliente.id_estado WHERE dui LIKE CONCAT ('%',?dui,'%')"), Conexion.getConnection());
                cmd.Parameters.Add(new MySqlParameter("dui", che.dui));
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


        public static DataTable BuscarTelefono(ConstructorExpedienteCliente che)
        {
            DataTable ds = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand(String.Format("SELECT id_cliente AS ID, tipo_Cliente AS Tipo_Cliente, genero AS Genero, estado_cliente AS Estado, estado_Civil AS Estado_Civil, nombre_client AS Nombre, apellido_cliente AS Apellidos, dui AS DUI, nacimiento_cliente AS Nacimiento, correo_cliente AS Correo, direccion_cliente AS Direccion, telefono AS Telefono FROM cliente INNER JOIN tipoCliente ON tipoCliente.id_tipoCliente = cliente.tipoCliente INNER JOIN estadoCivil ON estadoCivil.id_estadoCivil = cliente.estadoCivil INNER JOIN tbgenero ON tbgenero.id_genero = cliente.id_genero INNER JOIN estadoclien ON estadoClien.id_estado = cliente.id_estado WHERE telefono LIKE CONCAT ('%',?telefono,'%')"), Conexion.getConnection());
                cmd.Parameters.Add(new MySqlParameter("telefono", che.telefono));
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