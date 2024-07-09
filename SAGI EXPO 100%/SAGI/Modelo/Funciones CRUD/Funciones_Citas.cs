using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using WindowsFormsApplication1.Controlador;
using System.Windows.Forms;
using System.Globalization;


namespace WindowsFormsApplication1.Modelo
{
    class Funciones_Citas
    {
        //Tablas y combobox
        #region
        public static DataTable comboEstado()
        {
            DataTable est;
            try
            {
                string query = "Select id_estadoCita, estado_cita From estado_cita Where id_estadoCita = 1";
                MySqlCommand estado = new MySqlCommand(query, Conexion.getConnection());
                MySqlDataAdapter data = new MySqlDataAdapter(estado);
                est = new DataTable();
                data.Fill(est);

                return est;
            }
            catch (Exception es)
            {

                MessageBox.Show("" + es, "Error", MessageBoxButtons.OK);
                return est = new DataTable();
            }
            finally
            {
                Conexion.getConnection().Close();
            }


        }
        public static DataTable comboEstado2()
        {
            DataTable est;
            try
            {
                string query = "Select id_estadoCita, estado_cita From estado_cita";
                MySqlCommand estado = new MySqlCommand(query, Conexion.getConnection());
                MySqlDataAdapter data = new MySqlDataAdapter(estado);
                est = new DataTable();
                data.Fill(est);

                return est;
            }
            catch (Exception es)
            {

                MessageBox.Show("" + es, "Error", MessageBoxButtons.OK);
                return est = new DataTable();
            }
            finally
            {
                Conexion.getConnection().Close();
            }


        }
        public static DataTable priori()
        {
            DataTable prior;
            try
            {
                string query = "Select id_prioridad, prioridad From prioridad";
                MySqlCommand estado = new MySqlCommand(query, Conexion.getConnection());
                MySqlDataAdapter data = new MySqlDataAdapter(estado);
                prior = new DataTable();
                data.Fill(prior);

                return prior;
            }
            catch (Exception es)
            {

                MessageBox.Show("" + es, "Error", MessageBoxButtons.OK);
                return prior = new DataTable();
            }
            finally
            {
                Conexion.getConnection().Close();
            }
        }
        public static DataTable grid()
        {
            //string pend = "pendiente";
            DataTable gr;
            try
            {

                MySqlCommand grd = new MySqlCommand(String.Format("SELECT cita.id_cita AS id, estado_cita.estado_cita AS Estado, prioridad.prioridad AS Prioridad,cita.asunto AS Asunto, CONCAT(cliente.nombre_client,' ', cliente.apellido_cliente) AS Cliente, CONCAT (empleados.nombre_empl, ' ', empleados.apellido_empl) AS Solicitante, cita.lugar AS Lugar,cita.fecha AS Fecha,cita.hora AS Hora, cita.min AS Minuto,cita.periodo AS Periodo FROM cita INNER JOIN estado_cita ON cita.id_estado = estado_cita.id_estadoCita INNER JOIN empleados ON cita.empleado = empleados.id_empleado INNER JOIN cliente ON cita.cliente = cliente.id_cliente INNER JOIN prioridad ON cita.id_prioridad = prioridad.id_prioridad WHERE id_estadoCita = 1", Constructor_Citas.emp), Conexion.getConnection());
                MySqlDataAdapter data = new MySqlDataAdapter(grd);
                gr = new DataTable();
                data.Fill(gr);
                return gr;
            }
            catch (Exception es)
            {

                MessageBox.Show("" + es, "Error", MessageBoxButtons.OK);
                return gr = new DataTable();
            }
            finally
            {
                Conexion.getConnection().Close();
            }
        }
        public static DataTable grid2()
        {
            DataTable gr2;
            try
            {                
                MySqlCommand grd = new MySqlCommand(String.Format("SELECT cita.id_cita AS id, estado_cita.estado_cita AS Estado, prioridad.prioridad AS Prioridad,cita.asunto AS Asunto, CONCAT (cliente.nombre_client,' ',cliente.apellido_cliente) AS Cliente,CONCAT (empleados.nombre_empl, ' ' ,empleados.apellido_empl) AS Solicitante ,cita.lugar AS Lugar,cita.fecha AS Fecha,cita.hora AS Hora, cita.min AS Minuto, cita.periodo AS Periodo FROM cita INNER JOIN estado_cita ON cita.id_estado = estado_cita.id_estadoCita INNER JOIN empleados ON cita.empleado = empleados.id_empleado INNER JOIN cliente ON cita.cliente = cliente.id_cliente INNER JOIN prioridad ON cita.id_prioridad = prioridad.id_prioridad", Constructor_Citas.emp),Conexion.getConnection());
                MySqlDataAdapter data = new MySqlDataAdapter(grd);
                gr2 = new DataTable();
                data.Fill(gr2);

                return gr2;
            }
            catch (Exception es)
            {

                MessageBox.Show("" + es, "Error", MessageBoxButtons.OK);
                return gr2 = new DataTable();
            }
            finally
            {
                Conexion.getConnection().Close();
            }
        }
        #endregion

        //CRUD
        #region
        public static int Insertar(Constructor_Citas insert)
        {
            int ins = 0;
            try
            {
                MySqlCommand cmdin = new MySqlCommand(string.Format("INSERT INTO `cita` (`empleado`, `cliente`, `id_prioridad`,`id_estado`, `asunto`, `lugar`, `fecha`, `hora`, `min`, periodo) VALUES ( '{1}', '{2}', '{3}','{0}','{4}', '{5}','{6}','{7}','{8}','{9}')", insert.det, Constructor_Citas.emp, insert.cli, insert.priori, insert.asunto, insert.lugar, insert.fecha, insert.hora, insert.min,insert.per), Conexion.getConnection());
                ins = Convert.ToInt32(cmdin.ExecuteNonQuery());
                MessageBox.Show("Cita añadida exitosamente", "¡Bien!", MessageBoxButtons.OK);
                return ins;

            }
            catch (Exception ex)
            {

                MessageBox.Show("La cita no a sido añadida" + ex, "Oops!", MessageBoxButtons.OK);
                return ins;
            }

        }
        public static int actualizar(Constructor_Citas upd)
        {
            int ins = 0;
            try
            {
                MySqlCommand cmdupd = new MySqlCommand(string.Format("UPDATE `cita` SET `id_estado`='{0}',`empleado`='{1}',`cliente`='{2}',`id_prioridad`='{3}',`asunto`='{4}',`lugar`='{5}', `fecha` = '{6}', `hora` = '{7}', `min` = '{8}', `periodo`= '{9}'  WHERE id_cita = '{10}'", upd.det, Constructor_Citas.emp, upd.cli, upd.priori, upd.asunto, upd.lugar, upd.fecha, upd.hora, upd.min,upd.per, upd.id), Conexion.getConnection());
                ins = Convert.ToInt32(cmdupd.ExecuteNonQuery());
                MessageBox.Show("Cita actualizada exitosamente", "¡Bien!", MessageBoxButtons.OK);
                return ins;

            }
            catch (Exception ex)
            {

                MessageBox.Show("La cita no a sido añadida" + ex, "Oops!", MessageBoxButtons.OK);
                return ins;
            }
        }
        public static int Cancelar(Constructor_Citas upd)
        {
            int ins = 0;
            try
            {
                MySqlCommand cmdupd = new MySqlCommand(string.Format("UPDATE cita SET id_estado ='3' WHERE id_cita ='{0}'", upd.id), Conexion.getConnection());
                ins = Convert.ToInt32(cmdupd.ExecuteNonQuery());
                MessageBox.Show("Cita cancelada, registro enviado al historial", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return ins;

            }
            catch (Exception ex)
            {

                MessageBox.Show("La cita no a sido añadida" + ex, "Oops!", MessageBoxButtons.OK);
                return ins;
            }
        }
        public static bool borrar(int id)
        {
            bool brrd = false;
            try
            {
                MySqlCommand brr = new MySqlCommand(string.Format("DELETE FROM `cita` WHERE id_cita = '{0}'", id), Conexion.getConnection());
                brrd = Convert.ToBoolean(brr.ExecuteScalar());
                if (brrd == true)
                {
                    MessageBox.Show("Elemento borrado del historial", "Eliminado", MessageBoxButtons.OK);
                }
                return brrd;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex, "Error", MessageBoxButtons.OK);
                return brrd;
            }
        }
        #endregion
        //Funciones extras
        #region
        public static bool Historial()
        {
            bool brrd = false;
            try
            {
                MySqlCommand brr = new MySqlCommand(string.Format("DELETE FROM `cita`"), Conexion.getConnection());
                brrd = Convert.ToBoolean(brr.ExecuteScalar());
                if (brrd == true)
                {
                    MessageBox.Show("Elemento borrado del historial", "Eliminado", MessageBoxButtons.OK);
                }
                return brrd;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex, "Error", MessageBoxButtons.OK);
                return brrd;
            }
        }
        
        public static int empleado(Constructor_Citas empleeado)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmde = new MySqlCommand(String.Format("SELECT * FROM empleados WHERE usuario ='{0}'", empleeado.nom), Conexion.getConnection());
                MySqlDataReader _reader = cmde.ExecuteReader();
                if (_reader.Read())
                {
                    Constructor_Citas.emp = _reader.GetInt16(0);
                    retorno = _reader.GetInt16(0);
                }

                return retorno;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar empleado" + ex, "Error de obtención de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return retorno;
            }
        }
        public static string cli(int clie)
        {
            string retorno = "";
            try
            {
                MySqlCommand cmde = new MySqlCommand(String.Format("SELECT CONCAT(nombre_client,',',apellido_cliente) AS Cliente FROM cliente WHERE id_cliente ='{0}'", clie), Conexion.getConnection());
                MySqlDataReader _reader = cmde.ExecuteReader();
                if (_reader.Read())
                {

                    retorno = _reader.GetString(0);
                }

                return retorno;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar empleado" + ex, "Error de obtención de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return retorno;
            }
        }

        public static string buscar(string buscador)
        {
            Constructor_Citas nn = new Constructor_Citas();
            string retorno = "";
            try
            {
                MySqlCommand bs = new MySqlCommand(String.Format("SELECT CONCAT(nombre_client,',',apellido_cliente)AS Cliente FROM cliente WHERE nombre_client LIKE '{0}' OR apellido_cliente LIKE '{0}'", buscador), Conexion.getConnection());
                MySqlDataReader _reader = bs.ExecuteReader();

                while (_reader.Read())
                {

                    retorno = _reader.GetString(0);

                }
                _reader.Close();

                return retorno;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Fallo en la busqueda automática " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return retorno;
            }


        }
        public static int buscarID()
        {

            int retorno = 0;
            try
            {
                MySqlCommand bs = new MySqlCommand(String.Format("SELECT `id_cliente` FROM cliente WHERE nombre_client ='{0}' && apellido_cliente = '{1}'", Constructor_Citas.trozo1, Constructor_Citas.trozo2), Conexion.getConnection());
                MySqlDataReader _reader = bs.ExecuteReader();

                while (_reader.Read())
                {

                    retorno = _reader.GetInt16(0);

                }
                _reader.Close();

                return retorno;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Fallo en la busqueda automática " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return retorno;
            }


        }
        public static bool verificarFecha(Constructor_Citas kk)
        {
            bool ret = false;


            try
            {
                MySqlCommand fech = new MySqlCommand(String.Format("SELECT * FROM cita WHERE fecha ='{0}' AND hora='{1}' AND min = '{2}' AND periodo = '{3}'", kk.fecha, kk.hora, kk.min,kk.per), Conexion.getConnection());
                ret = Convert.ToBoolean(fech.ExecuteScalar());

                return ret;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex, "ERROR", MessageBoxButtons.OK);
                return ret;
            }
        }

        public static int carga()
        {
            DateTime fech = DateTime.Today;
            string fecha = fech.ToString("yyy-MM-dd");
            DateTime now = DateTime.Now;
            int hora = Convert.ToInt16(now.ToString("hh", new CultureInfo("en-US")));
            int min = Convert.ToInt16(now.ToString("mm", new CultureInfo("en-US")));
            string per = now.ToString("tt", new CultureInfo("en-US"));
            int ret = 0;
            try
            {
                MySqlCommand fec = new MySqlCommand(String.Format("UPDATE cita SET id_estado ='3' WHERE fecha <= '{0}' AND hora <= '{1}' AND min <= '{2}' AND periodo = '{3}'", fecha, hora, min,per), Conexion.getConnection());
                ret = Convert.ToInt16(fec.ExecuteNonQuery());
                return ret;
            }
            catch (Exception ex)
            {

                MessageBox.Show("..." + ex, "Error", MessageBoxButtons.OK);
                return ret;
            }
        }
        public static int alarma()
        {
            DateTime fec = DateTime.Today;
            string fecha = fec.ToString("yyy-MM-dd");
            DateTime now = DateTime.Now;
            int hora = Convert.ToInt16(now.AddMinutes(-30).ToString("hh", new CultureInfo("en-US")));
            int min = Convert.ToInt16(now.AddMinutes(-30).ToString("mm", new CultureInfo("en-US")));
            string per = now.ToString("tt", new CultureInfo("en-US"));
            int retono = 0;

            try
            {
                MySqlCommand tick = new MySqlCommand(String.Format("SELECT * FROM cita WHERE fecha = '{0}' AND hora = '{1}' AND min = '{2}' AND periodo = '{3}'", fecha, hora, min,per), Conexion.getConnection());
                retono = Convert.ToInt16(tick.ExecuteNonQuery());
                return retono;
            }
            catch (Exception ex)
            {

                MessageBox.Show("..." + ex, "Error", MessageBoxButtons.OK);
                return retono;
            }
        }
        #endregion

    }
}
