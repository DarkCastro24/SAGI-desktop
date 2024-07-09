using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Controlador;
using WindowsFormsApplication1.Controlador.Constructor_CRUD;

namespace WindowsFormsApplication1.Modelo.Funciones_CRUD
{
    class funcionesBusquedaFiltrada
    {
        public static bool ConseguirIDApartamento()
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(string.Format("SELECT * FROM apartamento WHERE direccion_apartamento = '{0}'", ConstructorGaleria.direccion), Conexion.getConnection());
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                if (retorno == true)
                {
                    MySqlDataReader _reader = cmdselect.ExecuteReader();
                    while (_reader.Read())
                    {
                        int validar = 0;
                        ConstructorGaleria.id_apartamento = _reader.GetInt16(0);
                        ConstructorGaleria.id_terreno = validar;
                        ConstructorGaleria.id_casa = validar;
                    }
                }
                else
                {
                    MessageBox.Show("Hubo un error al completar el proceso");
                }
                return retorno;
            }
            catch
            {

                MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
            finally
            {
                Conexion.getConnection().Close();
            }

        }

        public static bool ConseguirIDCasa()
        {
            bool retorno = false;
            try
            {               
                MySqlCommand cmdselect = new MySqlCommand(string.Format("SELECT * FROM casa WHERE direccion_casa = '{0}'", ConstructorGaleria.direccion), Conexion.getConnection());
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                if (retorno == true)
                {
                    MySqlDataReader _reader = cmdselect.ExecuteReader();
                    while (_reader.Read())
                    {
                        int validar = 0;
                        ConstructorGaleria.id_casa = _reader.GetInt16(0);
                        ConstructorGaleria.id_apartamento = validar;
                        ConstructorGaleria.id_terreno = validar;
                    }
                }
                else
                {
                    //MessageBox.Show("Hubo un error al completar el proceso");
                }
                return retorno;
            }
            catch
            {

                MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
            finally
            {
                Conexion.getConnection().Close();
            }
        }

        public static bool ConseguirIDTerreno()
        {
            bool retorno = false;
            try
            {               
                MySqlCommand cmdselect = new MySqlCommand(string.Format("SELECT * FROM terreno WHERE direccion_terreno = '{0}'", ConstructorGaleria.direccion), Conexion.getConnection());
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                if (retorno == true)
                {
                    MySqlDataReader _reader = cmdselect.ExecuteReader();
                    while (_reader.Read())
                    {
                        int validar = 0;
                        ConstructorGaleria.id_terreno = _reader.GetInt16(0);
                        ConstructorGaleria.id_apartamento = validar;
                        ConstructorGaleria.id_casa = validar;
                    }
                }
                else
                {
                    MessageBox.Show("Hubo un error al completar el proceso");
                }
                return retorno;
            }
            catch
            {

                MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }

        }

        public static int IngresarImagenApar()
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("UPDATE `apartamento` SET `imagen1`='{0}',`imagen2` ='{1}' ,`imagen3` ='{2}' ,`imagen4` ='{3}' WHERE id_apartamento = '{4}'", ConstructorGaleria.imagen1,ConstructorGaleria.imagen2,ConstructorGaleria.imagen3,ConstructorGaleria.imagen4,ConstructorGaleria.id_apartamento), Conexion.getConnection());
                retorno = Convert.ToInt32(cmdadd.ExecuteNonQuery());

                if (retorno <= 1)
                {
                    MessageBox.Show("Las imagenes si pudieron ser ingresadas", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch
            {
                MessageBox.Show("Funciones Apartamento", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
            finally
            {
                Conexion.getConnection().Close();
            }
        }

        public static int IngresarImagenCasa()
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("UPDATE `casa` SET `imagen1`='{0}',`imagen2` ='{1}' ,`imagen3` ='{2}' ,`imagen4` ='{3}' WHERE id_casa = '{4}'", ConstructorGaleria.imagen1, ConstructorGaleria.imagen2, ConstructorGaleria.imagen3, ConstructorGaleria.imagen4, ConstructorGaleria.id_casa), Conexion.getConnection());
                retorno = Convert.ToInt32(cmdadd.ExecuteNonQuery());

                if (retorno <= 1)
                {
                    MessageBox.Show("Las imagenes si pudieron ser ingresadas", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch
            {
                MessageBox.Show("Funciones Apartamento", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }

        public static int IngresarImagenTerreno()
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("UPDATE `terreno` SET `imagen1`='{0}',`imagen2` ='{1}' ,`imagen3` ='{2}' ,`imagen4` ='{3}' WHERE id_terreno = '{4}'", ConstructorGaleria.imagen1, ConstructorGaleria.imagen2, ConstructorGaleria.imagen3, ConstructorGaleria.imagen4, ConstructorGaleria.id_terreno), Conexion.getConnection());
                retorno = Convert.ToInt32(cmdadd.ExecuteNonQuery());

                if (retorno <= 1)
                {
                    MessageBox.Show("Las imagenes si pudieron ser ingresadas", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch
            {
                MessageBox.Show("Funciones Apartamento", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }      

        

        public static DataTable BusquedaFiltradaCompletaTerreno(ConstructorBusquedaFiltrada che)
        {
            DataTable data = new DataTable();
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(string.Format("SELECT * FROM terreno WHERE precio_terreno like '%{0}%'", che.precio), Conexion.getConnection());
                MySqlDataAdapter Adapter = new MySqlDataAdapter(cmdselect);
                Adapter.Fill(data);
                return data;

            }
            catch (Exception)
            {
                //MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
            finally
            {
                Conexion.getConnection().Close();
            }
        }

        public static DataTable MostrarTerrenos()
        {
            DataTable ds;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT id_terreno, tipo_relieve AS Relieve, tipo_terreno AS Terreno, departamento AS Departamento, descripcion_terreno AS Descripcion, estadopropiedad AS Estado, precio_terreno AS Precio, area_terreno AS Area, direccion_terreno AS Direccion, municipio AS Municipio FROM terreno INNER JOIN tiporelieve ON tiporelieve.id_tipoRelieve = terreno.tipoRelieve INNER JOIN tipoterreno ON tipoterreno.id_tipoTerreno = terreno.tipoTerreno INNER JOIN departamento ON departamento.id_departamento = terreno.id_departamento INNER JOIN estadopropiedad ON estadopropiedad.id_estado = terreno.estado INNER JOIN municipios ON municipios.id_municipio = terreno.municipio_ter WHERE estado = 1", Conexion.getConnection());
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

        public static DataTable MostrarApartamentos()
        {
            DataTable ds;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT id_apartamento AS ID, estadoPropiedad AS Estado, departamento AS Departamento, precio_apartamento AS Precio, descripcion_apar AS Descripcion, direccion_apartamento AS Direccion, municipio_apar AS Municipio, numero_piso_apar AS Piso, numero_cuartos_apar AS Cuartos, numero_baños_apar AS Balneario, area_departamento AS Area, numero_edificio AS numero_Edificio, bloque_edificio AS Bloque, descripcion_edificio AS Edificio FROM apartamento INNER JOIN estadopropiedad ON estadopropiedad.id_estado = apartamento.estado INNER JOIN departamento ON departamento.id_departamento = apartamento.id_departamento where estado = 1", Conexion.getConnection());
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

        public static DataTable ObtenerCasas()
        {
            string query = "SELECT id_casa AS ID, estadopropiedad AS Estado, departamento AS Departamento, precio_casa AS Precio, direccion_casa AS Direccion, descripcion_casa AS descripcion, municipio AS Municipio, numero_pisos_casa AS Pisos, numero_cuartos_casa AS Cuartos, numero_baños_casa AS Baños, area_casa AS Area, area_terreno AS Area_Construida, numero_garage AS Numero_Garage, numero_patio AS Numero_Patios , descripcion_garage AS Descripcion_Garage, descripcion_patio AS Descripcion_Patio , tipo_casa AS Tipo_Casa FROM `casa` INNER JOIN estadopropiedad ON estadopropiedad.id_estado = casa.estado INNER JOIN departamento ON departamento.id_departamento = casa.id_departamento INNER JOIN municipios ON municipios.id_municipio = casa.municipio_casa INNER JOIN tipo_casa ON tipo_casa.id_tipoCasa = casa.tipoCasa where estado = 1";
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

        public static bool ConseguirImagenesApar()
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(string.Format("SELECT * FROM apartamento WHERE id_apartamento = '{0}'", ConstructorGaleria.ID), Conexion.getConnection());
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                if (retorno == true)
                {
                    MySqlDataReader _reader = cmdselect.ExecuteReader();
                    try
                    {
                        while (_reader.Read())
                        {
                            ConstructorGaleria.imagen1 = _reader.GetString(14);
                            ConstructorGaleria.imagen2 = _reader.GetString(15);
                            ConstructorGaleria.imagen3 = _reader.GetString(16);
                            ConstructorGaleria.imagen4 = _reader.GetString(17);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No se han encontrado imagenes", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        retorno = false;
                    }
                }
                return retorno;
            }
            catch
            {

                MessageBox.Show("No se han encontrado imagenes", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return retorno;
            }

        }

        public static bool ConseguirImagenesCasa()
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(string.Format("SELECT * FROM casa WHERE id_casa = '{0}'", ConstructorGaleria.ID), Conexion.getConnection());
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                if (retorno == true)
                {
                    MySqlDataReader _reader = cmdselect.ExecuteReader();
                    try
                    {
                        while (_reader.Read())
                        {
                            ConstructorGaleria.imagen1 = _reader.GetString(17);
                            ConstructorGaleria.imagen2 = _reader.GetString(18);
                            ConstructorGaleria.imagen3 = _reader.GetString(19);
                            ConstructorGaleria.imagen4 = _reader.GetString(20);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No se han encontrado imagenes", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        retorno = false;
                    }
                    
                }
                return retorno;
            }
            catch
            {

                MessageBox.Show("No se han encontrado imagenes", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return retorno;
            }

        }

        public static bool ConseguirImagenesTerreno()
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(string.Format("SELECT * FROM terreno WHERE id_terreno = '{0}'", ConstructorGaleria.ID), Conexion.getConnection());
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                if (retorno == true)
                {
                    MySqlDataReader _reader = cmdselect.ExecuteReader();
                    try
                    {
                        while (_reader.Read())
                        {
                            ConstructorGaleria.imagen1 = _reader.GetString(9);
                            ConstructorGaleria.imagen2 = _reader.GetString(10);
                            ConstructorGaleria.imagen3 = _reader.GetString(11);
                            ConstructorGaleria.imagen4 = _reader.GetString(12);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No se han encontrado imagenes", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        retorno = false;
                    }              
                }
                return retorno;
            }
            catch
            {

                MessageBox.Show("No se han encontrado imagenes", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return retorno;
            }

        }

        public static int EliminarProgresoApar()
        {
            int retorno = 0;

            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("DELETE FROM apartamento WHERE id_apartamento = '{0}'", ConstructorGaleria.id_apartamento), Conexion.getConnection());
                retorno = Convert.ToInt32(cmdadd.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }

        public static int EliminarProgresoCasa()
        {
            int retorno = 0;

            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("DELETE FROM casa WHERE id_casa = '{0}'", ConstructorGaleria.id_casa), Conexion.getConnection());
                retorno = Convert.ToInt32(cmdadd.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }

        public static int EliminarProgresoTerreno()
        {
            int retorno = 0;

            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("DELETE FROM terreno WHERE id_terreno = '{0}'", ConstructorGaleria.id_terreno), Conexion.getConnection());
                retorno = Convert.ToInt32(cmdadd.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
    }
}
