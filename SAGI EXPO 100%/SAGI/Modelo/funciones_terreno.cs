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
    class funciones_terreno
    {
        public DataTable Mostrar()
        {
            DataTable ds;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT id_terreno, tipo_relieve AS Relieve, tipo_terreno AS Terreno, departamento_terr AS Departamento, estado_terr AS Estado, precio_terreno AS Precio, area_terreno AS Area, direccion_terreno AS Direccion, municipio_ter AS Municipio FROM terreno INNER JOIN tiporelieve ON tiporelieve.id_tipoRelieve = terreno.tipoRelieve INNER JOIN tipoterreno ON tipoterreno.id_tipoTerreno = terreno.tipoTerreno INNER JOIN departamentoterreno ON departamentoterreno.id_departamentoTerr = terreno.departamento INNER JOIN estadoterreno ON estadoterreno.id_estadoTerr = terreno.estado", Conexion.getConnection());
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
                    MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO terreno(tipoRelieve, tipoTerreno, departamento, estado, precio_terreno, area_terreno, direccion_terreno, municipio_ter) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','´{7}')", agregar.TipoRelieve, agregar.TipoTerreno, agregar.departamento, agregar.Estado, agregar.Precio, agregar.Extension, agregar.direccion, agregar.municipio), Conexion.getConnection());
                    retorno = Convert.ToInt32(cmdadd.ExecuteScalar());
                    if (retorno <= 1)
                    {
                        MessageBox.Show("El terreno ha sido insertado correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MySqlCommand cmdadd = new MySqlCommand(string.Format("UPDATE `terreno` SET `tipoRelieve`= '{0}',`tipoTerreno`= '{1}',`departamento`= '{2}',`estado`= '{3}',`precio_terreno`= '{4}',`area_terreno`= '{5}',`direccion_terreno`= '{6}',`municipio_ter`= '{7}' WHERE id_terreno = '{8}'", act.TipoRelieve, act.TipoTerreno, act.departamento, act.Estado, act.Precio, act.Extension, act.direccion, act.municipio, act.IdTerreno), Conexion.getConnection());
                    retorno = Convert.ToInt32(cmdadd.ExecuteScalar());
                    if (retorno <= 1)
                    {
                        MessageBox.Show("El terreno ha sido actualizado correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }

        public static DataTable Buscar(ConstructorTerrenos che)
        {
            DataTable ds;
            try
            {
                MySqlCommand cmd = new MySqlCommand(String.Format("SELECT tipo_relieve, tipo_terreno, departamento_terr, estado_terr, precio_terreno, area_terreno, direccion_terreno, municipio_ter FROM terreno INNER JOIN tiporelieve ON tiporelieve.id_tipoRelieve = terreno.tipoRelieve INNER JOIN tipoterreno ON tipoterreno.id_tipoTerreno = terreno.tipoTerreno INNER JOIN departamentoterreno ON departamentoterreno.id_departamentoTerr = terreno.departamento INNER JOIN estadoterreno ON estadoterreno.id_estadoTerr = terreno.estado WHERE departamento = '{0}' XOR tipo_relieve = '{1}' XOR tipo_terreno = '{2}' XOR estado_terr = '{3}'", che.departamento, che.TipoRelieve, che.TipoTerreno, che.Estado), Conexion.getConnection());
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
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
            finally
            {
                Conexion.getConnection().Close();
            }
        }

        public static DataTable Estado()
        {
            string query = "SELECT id_estadoTerr, estado_terr FROM estadoterreno";
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
            string query = "SELECT * FROM departamentoterreno";
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

