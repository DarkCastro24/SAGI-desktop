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
    public class funciones_casa
    {
        public static DataTable ObtenerEstadoCasa()
        {
            string query = "SELECT * FROM estadocasa";
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
            string query = "SELECT * FROM departamentocasa";
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

        public static DataTable Mostrar()
        {
            DataTable ds;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT id_casa AS ID, estado_casa AS Estado, departamento_casa AS Departamento, precio_casa AS Precio, direccion_casa AS Direccion,	descripcion_casa AS descripcion,	municipio_casa AS Municipio,	numero_piso_casa AS Pisos,	numero_cuartos_casa AS Cuartos,	numero_baños_casa AS Balnearios,	area_casa AS Area,	area_terreno FROM `casa` INNER JOIN estadocasa ON estadocasa.id_estadoCasa = casa.estado INNER JOIN departamentocasa ON departamentocasa.id_departamentoCasa = casa.departamento", Conexion.getConnection());
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                ds = new DataTable();
                ad.Fill(ds);
                return ds;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ds = new DataTable();
            }
        }

        public static int Agregar(Constructor_casa agregar)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(string.Format("SELECT descripcion_casa FROM casa WHERE descripcion_casa = '{0}'", agregar.descripcion), Conexion.getConnection());
                MySqlDataReader reader = cmdselect.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("El registro ya existe", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return retorno;
                }
                else
                {
                    MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO `casa`(`id_casa`, `estado`, `departamento`, `precio_casa`, `direccion_casa`, `descripcion_casa`, `municipio_casa`, `numero_piso_casa`, `numero_cuartos_casa`, `numero_baños_casa`, `area_casa`, `area_terreno`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}')", agregar.id_casa, agregar.estado, agregar.departamento, agregar.precio, agregar.direccion, agregar.descripcion, agregar.municipio, agregar.numero_pisos, agregar.numero_cuartos, agregar.numero_baños, agregar.area_casa, agregar.area_terreno), Conexion.getConnection());
                    retorno = Convert.ToInt32(cmdadd.ExecuteScalar());

                    if (retorno <= 1)
                    {
                        MessageBox.Show("Cliente Ingresado correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public static int Actualizar(Constructor_casa agregar)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("UPDATE `casa` SET `estado`='{0}',`departamento`='{1}',`precio_casa`='{2}',`direccion_casa`='{3}',`descripcion_casa`='{4}',`municipio_casa`='{5}',`numero_piso_casa`='{6}',`numero_cuartos_casa`='{7}',`numero_baños_casa`='{8}',`area_casa`='{9}',`area_terreno`='{10}' WHERE id_casa='{11}'", agregar.estado, agregar.departamento, agregar.precio, agregar.direccion, agregar.descripcion, agregar.municipio, agregar.numero_pisos, agregar.numero_cuartos, agregar.numero_baños, agregar.area_casa, agregar.area_terreno, agregar.id_casa), Conexion.getConnection());
                retorno = Convert.ToInt32(cmdadd.ExecuteScalar());

                if (retorno <= 1)
                {
                    MessageBox.Show("Cliente actualizado correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cliente no pudo ser ingresado", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;

            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }

        public static int Eliminar(Constructor_casa del)
        {
            int retorno = 0;

            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("DELETE FROM casa WHERE id_casa = '{0}'", del.id_casa), Conexion.getConnection());
                retorno = Convert.ToInt32(cmdadd.ExecuteScalar());


                MessageBox.Show("Cliente eliminado correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
