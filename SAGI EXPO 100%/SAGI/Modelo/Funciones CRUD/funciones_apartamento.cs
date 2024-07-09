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
using WindowsFormsApplication1.Controlador.Constructores;

namespace WindowsFormsApplication1.Modelo
{
    public class funciones_apartamento
    {
        public static DataTable Mostrar()
        {
            DataTable ds = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT id_apartamento AS ID, estadoPropiedad AS Estado, departamento AS Departamento, precio_apartamento AS Precio, descripcion_apar AS Descripcion, direccion_apartamento AS Direccion, municipio AS Municipio, numero_piso_apar AS Piso, numero_cuartos_apar AS Cuartos, numero_baños_apar AS Balneario, area_departamento AS Area, numero_edificio AS numero_Edificio, bloque_edificio AS Bloque, descripcion_edificio AS Edificio FROM apartamento INNER JOIN estadopropiedad ON estadopropiedad.id_estado = apartamento.estado INNER JOIN departamento ON departamento.id_departamento = apartamento.id_departamento INNER JOIN municipios ON municipios.id_municipio = apartamento.municipio_apar", Conexion.getConnection());
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

        public static DataTable ObtenerEstadoApar()
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

        public static DataTable ObtenerTipoApartamento()
        {
            string query = "SELECT * FROM tipo_apartamento";
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

        public static int Agregar(Constructor_apartamento agregar)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(string.Format("SELECT descripcion_apar FROM apartamento WHERE descripcion_apar = '{0}'", agregar.descripcion), Conexion.getConnection());
                MySqlDataReader reader = cmdselect.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("El registro ya existe", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return retorno;
                }
                else
                {
                    MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO `apartamento`(`id_apartamento`, `estado`, `id_departamento`, `precio_apartamento`, `descripcion_apar`, `direccion_apartamento`, `municipio_apar`, `numero_piso_apar`, `numero_cuartos_apar`, `numero_baños_apar`, `area_departamento`, `numero_edificio`, `bloque_edificio`, `tipo_apartamento`, `descripcion_edificio`, `id_cliente`, `id_empleado`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}','{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}')", ConstructorGaleria.id_apartamento, agregar.estado, agregar.departamento, agregar.precio, agregar.descripcion, agregar.direccion, agregar.municipio, agregar.piso, agregar.cuartos, agregar.baños, agregar.area, agregar.Numero_Edificio, agregar.Bloque_Edificio, agregar.tipo_Apartamento, agregar.edificio, agregar.id_cliente, ConstructorCambiarContraseña.ID_Usuario), Conexion.getConnection());
                    retorno = Convert.ToInt32(cmdadd.ExecuteScalar());

                    if (retorno <= 1)
                    {
                        MessageBox.Show("Apartamento Ingresado correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public static int Actualizar(Constructor_apartamento agregar)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("UPDATE `apartamento` SET `estado`='{0}',`id_departamento`='{1}',`precio_apartamento`='{2}',`descripcion_apar`='{3}',`direccion_apartamento`='{4}',`municipio_apar`='{5}',`numero_piso_apar`='{6}',`numero_cuartos_apar`='{7}',`numero_baños_apar`='{8}',`area_departamento`='{9}',`numero_edificio`='{10}', `bloque_edificio`='{11}', descripcion_edificio ='{12}', id_cliente ='{13}' WHERE id_apartamento = '{14}'", agregar.estado, agregar.departamento, agregar.precio, agregar.descripcion, agregar.direccion, agregar.municipio, agregar.piso, agregar.cuartos, agregar.baños, agregar.area, agregar.Numero_Edificio,agregar.Bloque_Edificio,agregar.edificio, agregar.id_cliente, ConstructorGaleria.id_apartamento), Conexion.getConnection());           
                retorno = Convert.ToInt32(cmdadd.ExecuteScalar());

                if (retorno <= 1)
                {
                    MessageBox.Show("Registro actualizado correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception w)
            {
                MessageBox.Show("Ha ocurrido un error" + w, "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }

        

        public static int Eliminar()
        {
            int retorno = 0;

            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("DELETE FROM apartamento WHERE id_apartamento = '{0}'", ConstructorGaleria.id_apartamento), Conexion.getConnection());
                retorno = Convert.ToInt32(cmdadd.ExecuteNonQuery());


                MessageBox.Show("Registro eliminado correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }     
        
        public static DataTable BusquedaFiltrada(Constructor_apartamento che)
        {
            DataTable ds = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand(String.Format("SELECT id_apartamento AS ID, estadopropiedad AS Estado, departamento AS Departamento, municipio AS Municipio, precio_apartamento AS Precio, descripcion_apar AS Descripcion, direccion_apartamento AS Direccion, numero_piso_apar AS Piso, numero_cuartos_apar AS Cuartos, numero_baños_apar AS Balneario, area_departamento AS Area, numero_edificio AS numero_Edificio , bloque_edificio AS Bloque FROM apartamento INNER JOIN estadopropiedad ON estadopropiedad.id_estado = apartamento.estado INNER JOIN departamento ON departamento.id_departamento = apartamento.id_departamento INNER JOIN municipios ON municipios.id_municipio = apartamento.municipio_apar WHERE precio_apartamento LIKE CONCAT ('%',?precio,'%') "), Conexion.getConnection());
                cmd.Parameters.Add(new MySqlParameter("precio", che.precio));
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

        public static DataTable BusquedaArea(Constructor_apartamento che)
        {
            DataTable ds = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand(String.Format("SELECT id_apartamento AS ID, estadoPropiedad AS Estado, departamento AS Departamento, precio_apartamento AS Precio, descripcion_apar AS Descripcion, direccion_apartamento AS Direccion, municipio_apar AS Municipio, numero_piso_apar AS Piso, numero_cuartos_apar AS Cuartos, numero_baños_apar AS Balneario, area_departamento AS Area, numero_edificio AS numero_Edificio, bloque_edificio AS Bloque, descripcion_edificio AS Edificio FROM apartamento INNER JOIN estadopropiedad ON estadopropiedad.id_estado = apartamento.estado INNER JOIN departamento ON departamento.id_departamento = apartamento.id_departamento WHERE area_departamento LIKE CONCAT ('%',?area,'%') "), Conexion.getConnection());
                cmd.Parameters.Add(new MySqlParameter("area",che.area));
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

        public static DataTable BusquedaDepar(Constructor_apartamento che)
        {
            DataTable ds = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand(String.Format("SELECT id_apartamento AS ID, estadoPropiedad AS Estado, departamento AS Departamento, descripcion_apar AS Descripcion, precio_apartamento AS Precio, direccion_apartamento AS Direccion, municipio_apar AS Municipio, numero_piso_apar AS Piso, numero_cuartos_apar AS Cuartos, numero_baños_apar AS Balneario, area_departamento AS Area, numero_edificio AS numero_Edificio, bloque_edificio AS Bloque, descripcion_edificio AS Edificio FROM apartamento INNER JOIN estadopropiedad ON estadopropiedad.id_estado = apartamento.estado INNER JOIN departamento ON departamento.id_departamento = apartamento.id_departamento WHERE numero_cuartos_apar LIKE CONCAT ('%',?cuartos,'%')"), Conexion.getConnection());
                cmd.Parameters.Add(new MySqlParameter("cuartos", che.cuartos));
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
