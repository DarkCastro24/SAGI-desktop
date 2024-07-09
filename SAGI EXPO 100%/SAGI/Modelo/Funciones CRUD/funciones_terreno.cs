using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WindowsFormsApplication1.Controlador;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using WindowsFormsApplication1.Controlador.Constructores;

namespace WindowsFormsApplication1.Modelo
{
    class funciones_terreno
    {
        public static DataTable Mostrar()
        {
            DataTable ds;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT id_terreno, tipo_relieve AS Relieve, tipo_terreno AS Terreno, departamento AS Departamento, descripcion_terreno AS Descripcion, estadopropiedad AS Estado, precio_terreno AS Precio, area_terreno AS Area, direccion_terreno AS Direccion, municipio AS Municipio FROM terreno INNER JOIN tiporelieve ON tiporelieve.id_tipoRelieve = terreno.tipoRelieve INNER JOIN tipoterreno ON tipoterreno.id_tipoTerreno = terreno.tipoTerreno INNER JOIN departamento ON departamento.id_departamento = terreno.id_departamento INNER JOIN estadopropiedad ON estadopropiedad.id_estado = terreno.estado INNER JOIN municipios ON municipios.id_municipio = terreno.municipio_ter", Conexion.getConnection());
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

        public static int Agregar(ConstructorTerrenos agregar)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(String.Format("SELECT direccion_terreno FROM terreno WHERE direccion_terreno = '{0}'", agregar.direccion), Conexion.getConnection());
                MySqlDataReader reader = cmdselect.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("El registro ya existe", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return retorno;
                }
                else
                {
                    MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO `terreno`(`id_terreno`, `tipoRelieve`, `tipoTerreno`, `id_departamento`, `estado`, `precio_terreno`, `area_terreno`, `direccion_terreno`, `municipio_ter`, `descripcion_terreno`, `id_cliente`, `id_empleado`) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}', '{8}', '{9}', '{10}', '{11}')", agregar.IdTerreno, agregar.TipoRelieve, agregar.TipoTerreno, agregar.departamento, agregar.Estado, agregar.Precio, agregar.Extension, agregar.direccion, agregar.municipio,agregar.Descripcion_terreno, agregar.id_cliente, ConstructorCambiarContraseña.ID_Usuario), Conexion.getConnection());
                    retorno = Convert.ToInt32(cmdadd.ExecuteScalar());
                    if (retorno <= 1)
                    {
                        MessageBox.Show("El terreno ha sido insertado correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                    MessageBox.Show("El terreno no pudo ser ingresado", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return retorno;
                }
            }
            catch
            {

                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }

        }

        public static int Actualizar(ConstructorTerrenos act)
        {
            int retorno = 0;

            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("UPDATE `terreno` SET `tipoRelieve`= '{0}',`tipoTerreno`= '{1}',`id_departamento`= '{2}',`estado`= '{3}',`precio_terreno`= '{4}',`area_terreno`= '{5}',`direccion_terreno`= '{6}',`municipio_ter`= '{7}' , `descripcion_terreno`= '{8}', `id_cliente`= '{9}' WHERE id_terreno = '{10}'", act.TipoRelieve, act.TipoTerreno, act.departamento, act.Estado, act.Precio, act.Extension, act.direccion, act.municipio, act.Descripcion_terreno, act.id_cliente,act.IdTerreno), Conexion.getConnection());
                retorno = Convert.ToInt32(cmdadd.ExecuteScalar());
                if (retorno <= 1)
                {
                   MessageBox.Show("El terreno ha sido actualizado correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }

        public static int Eliminar(ConstructorTerrenos del)
        {
            int retorno = 0;

            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("DELETE FROM terreno WHERE id_terreno = '{0}'", del.IdTerreno), Conexion.getConnection());
                retorno = Convert.ToInt32(cmdadd.ExecuteScalar());


                MessageBox.Show("Terreno eliminado correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }

        public static DataTable ObtenerTipoTerreno()
        {
            string query = "SELECT * FROM tipoterreno";
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

        public static DataTable Estado()
        {
            string query = "SELECT * FROM estadopropiedad";
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

        public static DataTable ObtenerTipoRelieve()
        {
            string query = "SELECT * FROM tiporelieve";
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
        public static DataTable ObtenerDepartamento()
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
                MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
            finally
            {
                Conexion.getConnection().Close();
            }
        }

        public static DataTable BusquedaPrecio(ConstructorTerrenos che)
        {
            DataTable ds = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand(String.Format("SELECT id_terreno, tipo_relieve AS Relieve, tipo_terreno AS Terreno, departamento AS Departamento, descripcion_terreno AS Descripcion, estadopropiedad AS Estado, precio_terreno AS Precio, area_terreno AS Area, direccion_terreno AS Direccion, municipio AS Municipio FROM terreno INNER JOIN tiporelieve ON tiporelieve.id_tipoRelieve = terreno.tipoRelieve INNER JOIN tipoterreno ON tipoterreno.id_tipoTerreno = terreno.tipoTerreno INNER JOIN departamento ON departamento.id_departamento = terreno.id_departamento INNER JOIN estadopropiedad ON estadopropiedad.id_estado = terreno.estado INNER JOIN municipios ON municipios.id_municipio = terreno.municipio_ter WHERE precio_terreno LIKE CONCAT('%',?precio,'%') and estado = 1"), Conexion.getConnection());
                cmd.Parameters.Add(new MySqlParameter("precio", che.Precio));
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

        public static DataTable BusquedaArea(ConstructorTerrenos che)
        {
            DataTable ds = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand(String.Format("SELECT id_terreno, tipo_relieve AS Relieve, tipo_terreno AS Terreno, departamento AS Departamento, descripcion_terreno AS Descripcion, estadopropiedad AS Estado, precio_terreno AS Precio, area_terreno AS Area, direccion_terreno AS Direccion, municipio AS Municipio FROM terreno INNER JOIN tiporelieve ON tiporelieve.id_tipoRelieve = terreno.tipoRelieve INNER JOIN tipoterreno ON tipoterreno.id_tipoTerreno = terreno.tipoTerreno INNER JOIN departamento ON departamento.id_departamento = terreno.id_departamento INNER JOIN estadopropiedad ON estadopropiedad.id_estado = terreno.estado INNER JOIN municipios ON municipios.id_municipio = terreno.municipio_ter WHERE area_terreno LIKE CONCAT('%',?area,'%') and estado = 1"), Conexion.getConnection());
                cmd.Parameters.Add(new MySqlParameter("area", che.Extension));
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

