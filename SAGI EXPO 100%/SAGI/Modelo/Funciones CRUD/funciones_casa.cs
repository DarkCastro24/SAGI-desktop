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
    public class funciones_casa
    {
        public static DataTable ObtenerEstadoCasa()
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

        public static DataTable ObtenerTipoCasa()
        {
            string query = "SELECT * FROM tipo_casa";
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

        public static DataTable Mostrar()
        {
            DataTable ds;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT id_casa AS ID, estadopropiedad AS Estado, departamento AS Departamento, precio_casa AS Precio, direccion_casa AS Direccion, descripcion_casa AS descripcion, municipio AS Municipio, numero_pisos_casa AS Pisos, numero_cuartos_casa AS Cuartos, numero_baños_casa AS Baños, area_casa AS Area, area_terreno AS Area_Construida, numero_garage AS Numero_Garage, numero_patio AS Numero_Patios , descripcion_garage AS Descripcion_Garage, descripcion_patio AS Descripcion_Patio , tipo_casa AS Tipo_Casa FROM `casa` INNER JOIN estadopropiedad ON estadopropiedad.id_estado = casa.estado INNER JOIN departamento ON departamento.id_departamento = casa.id_departamento INNER JOIN municipios ON municipios.id_municipio = casa.municipio_casa INNER JOIN tipo_casa ON tipo_casa.id_tipoCasa = casa.tipoCasa WHERE estado = 1", Conexion.getConnection());
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
                    MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO `casa`(`id_casa`, `estado`, `id_departamento`, `precio_casa`, `direccion_casa`, `descripcion_casa`, `municipio_casa`, `numero_pisos_casa`, `numero_cuartos_casa`, `numero_baños_casa`, `area_casa`, `area_terreno`, `tipoCasa`,numero_patio,numero_garage,descripcion_patio,descripcion_garage, `id_cliente`, `id_empleado`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}')", agregar.id_casa, agregar.estado, agregar.departamento, agregar.precio, agregar.direccion, agregar.descripcion, agregar.municipio, agregar.numero_pisos, agregar.numero_cuartos, agregar.numero_baños, agregar.area_casa, agregar.area_terreno,agregar.tipo_casa,agregar.numero_patio,agregar.numero_garage,agregar.Descripcion_patio,agregar.Descripcion_garage, agregar.id_cliente, ConstructorCambiarContraseña.ID_Usuario), Conexion.getConnection());
                    retorno = Convert.ToInt32(cmdadd.ExecuteNonQuery());

                    if (retorno >= 1)
                    {
                        MessageBox.Show("Casa Ingresada correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public static int Actualizar(Constructor_casa agregar)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("UPDATE `casa` SET `estado`='{0}',`id_departamento`='{1}',`precio_casa`='{2}',`direccion_casa`='{3}',`descripcion_casa`='{4}',`municipio_casa`='{5}',`numero_pisos_casa`='{6}',`numero_cuartos_casa`='{7}',`numero_baños_casa`='{8}',`area_casa`='{9}',`area_terreno`='{10}',`numero_patio`='{11}',`numero_garage`='{12}',`descripcion_patio`='{13}',`descripcion_garage`='{14}', `id_cliente`='{15}' WHERE id_casa='{16}'", agregar.estado, agregar.departamento, agregar.precio, agregar.direccion, agregar.descripcion, agregar.municipio, agregar.numero_pisos, agregar.numero_cuartos, agregar.numero_baños, agregar.area_casa, agregar.area_terreno, agregar.numero_patio , agregar.numero_garage, agregar.Descripcion_patio , agregar.Descripcion_garage, agregar.id_cliente, agregar.id_casa), Conexion.getConnection());
                retorno = Convert.ToInt32(cmdadd.ExecuteScalar());

                if (retorno <= 1)
                {
                    MessageBox.Show("Casa actualizado correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Casa no pudo ser ingresado", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


                MessageBox.Show("Casa eliminada correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }

        public static DataTable BusquedaPrecio(Constructor_casa che)
        {
            DataTable ds = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand(String.Format("SELECT id_casa AS ID, estadopropiedad AS Estado, departamento AS Departamento, precio_casa AS Precio, direccion_casa AS Direccion, descripcion_casa AS descripcion, municipio AS Municipio, numero_pisos_casa AS Pisos, numero_cuartos_casa AS Cuartos, numero_baños_casa AS Balnearios, area_casa AS Area, area_terreno AS Area_Construida, numero_garage AS Numero_Garage, numero_patio AS Numero_Patios , descripcion_garage AS Descripcion_Garage, descripcion_patio AS Descripcion_Patio , tipo_casa AS Tipo_Casa FROM `casa` INNER JOIN estadopropiedad ON estadopropiedad.id_estado = casa.estado INNER JOIN departamento ON departamento.id_departamento = casa.id_departamento INNER JOIN municipios ON municipios.id_municipio = casa.municipio_casa INNER JOIN tipo_casa ON tipo_casa.id_tipoCasa = casa.tipoCasa WHERE precio_casa LIKE CONCAT ('%',?precio,'%') and estado = 1"), Conexion.getConnection());
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

        public static DataTable BusquedaArea(Constructor_casa che)
        {
            DataTable ds = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand(String.Format("SELECT id_casa AS ID, estadopropiedad AS Estado, departamento AS Departamento, precio_casa AS Precio, direccion_casa AS Direccion, descripcion_casa AS descripcion, municipio AS Municipio, numero_pisos_casa AS Pisos, numero_cuartos_casa AS Cuartos, numero_baños_casa AS Balnearios, area_casa AS Area, area_terreno AS Area_Construida, numero_garage AS Numero_Garage, numero_patio AS Numero_Patios , descripcion_garage AS Descripcion_Garage, descripcion_patio AS Descripcion_Patio , tipo_casa AS Tipo_Casa FROM `casa` INNER JOIN estadopropiedad ON estadopropiedad.id_estado = casa.estado INNER JOIN departamento ON departamento.id_departamento = casa.id_departamento INNER JOIN municipios ON municipios.id_municipio = casa.municipio_casa INNER JOIN tipo_casa ON tipo_casa.id_tipoCasa = casa.tipoCasa WHERE area_casa LIKE CONCAT ('%',?area,'%') and estado = 1"), Conexion.getConnection());
                cmd.Parameters.Add(new MySqlParameter("area", che.area_casa));
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


        public static DataTable BusquedaCuartos(Constructor_casa che)
        {
            DataTable ds = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand(String.Format("SELECT id_casa AS ID, estadopropiedad AS Estado, departamento AS Departamento, precio_casa AS Precio, direccion_casa AS Direccion, descripcion_casa AS descripcion, municipio AS Municipio, numero_pisos_casa AS Pisos, numero_cuartos_casa AS Cuartos, numero_baños_casa AS Balnearios, area_casa AS Area, area_terreno AS Area_Construida, numero_garage AS Numero_Garage, numero_patio AS Numero_Patios , descripcion_garage AS Descripcion_Garage, descripcion_patio AS Descripcion_Patio , tipo_casa AS Tipo_Casa FROM `casa` INNER JOIN estadopropiedad ON estadopropiedad.id_estado = casa.estado INNER JOIN departamento ON departamento.id_departamento = casa.id_departamento INNER JOIN municipios ON municipios.id_municipio = casa.municipio_casa INNER JOIN tipo_casa ON tipo_casa.id_tipoCasa = casa.tipoCasa WHERE numero_cuartos_casa LIKE CONCAT ('%',?cuartos,'%')"), Conexion.getConnection());
                cmd.Parameters.Add(new MySqlParameter("cuartos", che.numero_cuartos));
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

        public static DataTable BusquedaPisos(Constructor_casa che)
        {
            DataTable ds = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand(String.Format("SELECT id_casa AS ID, estadopropiedad AS Estado, departamento AS Departamento, precio_casa AS Precio, direccion_casa AS Direccion, descripcion_casa AS descripcion, municipio AS Municipio, numero_pisos_casa AS Pisos, numero_cuartos_casa AS Cuartos, numero_baños_casa AS Balnearios, area_casa AS Area, area_terreno AS Area_Construida, numero_garage AS Numero_Garage, numero_patio AS Numero_Patios , descripcion_garage AS Descripcion_Garage, descripcion_patio AS Descripcion_Patio , tipo_casa AS Tipo_Casa FROM `casa` INNER JOIN estadopropiedad ON estadopropiedad.id_estado = casa.estado INNER JOIN departamento ON departamento.id_departamento = casa.id_departamento INNER JOIN municipios ON municipios.id_municipio = casa.municipio_casa INNER JOIN tipo_casa ON tipo_casa.id_tipoCasa = casa.tipoCasa WHERE numero_pisos_casa LIKE CONCAT ('%',?pisos,'%')"), Conexion.getConnection());
                cmd.Parameters.Add(new MySqlParameter("pisos", che.numero_pisos));
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
