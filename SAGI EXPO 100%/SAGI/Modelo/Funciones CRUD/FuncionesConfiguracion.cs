using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using WindowsFormsApplication1.Controlador;
using WindowsFormsApplication1.Controlador.Constructores;
using WindowsFormsApplication1.Controlador.Constructores_CRUD;

namespace WindowsFormsApplication1.Modelo.Funciones_CRUD
{
    class FuncionesConfiguracion
    {
        public static bool MostrarDatos()
        {
            bool retorno = false;
            MySqlCommand che = new MySqlCommand(string.Format("SELECT id_empleado,usuario,clave,correo_empl,direccion_empl,profesion,imagen,pregunta1,pregunta2,pregunta3,respuesta1,respuesta2,respuesta3 FROM empleados WHERE usuario ='{0}' ", Constructor_Login.usuario), Conexion.getConnection());

            try
            {
                MySqlDataReader _reader = che.ExecuteReader();
                while (_reader.Read())
                {
                    ConstructorConfiguracion.ID_empleado = _reader.GetInt16(0);
                    ConstructorConfiguracion.Usuario = _reader.GetString(1);
                    ConstructorConfiguracion.Contraseña = _reader.GetString(2);
                    ConstructorConfiguracion.Correo = _reader.GetString(3);
                    ConstructorConfiguracion.Direccion = _reader.GetString(4);
                    ConstructorConfiguracion.Profesion = _reader.GetString(5);
                    try
                    {
                        ConstructorConfiguracion.imagenUsuario = _reader.GetString(6);
                        ConstructorConfiguracion.pregunta1 = _reader.GetInt16(7);
                        ConstructorConfiguracion.pregunta2 = _reader.GetInt16(8);
                        ConstructorConfiguracion.pregunta3 = _reader.GetInt16(9);
                        ConstructorConfiguracion.respuesta1 = _reader.GetString(10);
                        ConstructorConfiguracion.respuesta2 = _reader.GetString(11);
                        ConstructorConfiguracion.respuesta3 = _reader.GetString(12);
                    }
                    catch (Exception)
                    {


                    }

                }

                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
            finally
            {
                Conexion.getConnection().Close();
            }
        }

        public static DataTable ObtenerPregunta1()
        {
            MySqlCommand che2 = new MySqlCommand(string.Format("SELECT * FROM preguntas WHERE id_pregunta ='{0}'", ConstructorConfiguracion.pregunta1), Conexion.getConnection());
            DataTable data = new DataTable();
            try
            {
                MySqlDataAdapter Adapter = new MySqlDataAdapter(che2);
                Adapter.Fill(data);
                return data;

            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }

        }
        public static DataTable ObtenerPregunta2()
        {
            MySqlCommand che2 = new MySqlCommand(string.Format("SELECT * FROM preguntas WHERE id_pregunta ='{0}'", ConstructorConfiguracion.pregunta2), Conexion.getConnection());
            DataTable data = new DataTable();
            try
            {
                MySqlDataAdapter Adapter = new MySqlDataAdapter(che2);
                Adapter.Fill(data);
                return data;

            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }

        }
        public static DataTable ObtenerPregunta3()
        {
            MySqlCommand che2 = new MySqlCommand(string.Format("SELECT * FROM preguntas WHERE id_pregunta ='{0}'", ConstructorConfiguracion.pregunta3), Conexion.getConnection());
            DataTable data = new DataTable();
            try
            {
                MySqlDataAdapter Adapter = new MySqlDataAdapter(che2);
                Adapter.Fill(data);
                return data;

            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }

        }


        public static int ActualizarContraseña(Constructor_Login che)
        {
            int retorno = 0;
            try
            {
                MySqlCommand che2 = new MySqlCommand(string.Format("UPDATE empleados SET clave = '{0}' WHERE id_empleado = '{1}'", che.clave, Constructor_Login.ID_Usuario), Conexion.getConnection());
                retorno = Convert.ToInt16(che2.ExecuteNonQuery());
                if (retorno == 1)
                {
                    MessageBox.Show("Datos actualizados correctamente", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return retorno;
                }
                return retorno;
            }
            catch (Exception)
            {

                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }
        
        public static int ActualizarDatosUsuario(Constructor_Usuarios add)
        {
            int retorno = 0;

            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM empleados WHERE binary usuario = '{0}'", Constructor_Login.usuario), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                if (row > 1)
                {
                    MessageBox.Show("El nombre de usuario ingresado ya existe en la base de datos","Ingrese otro nombre de usuario",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MySqlCommand agregar = new MySqlCommand(string.Format("UPDATE empleados SET `correo_empl`='{0}', `direccion_empl`='{1}', `profesion`='{2}', `usuario`='{3}' , `imagen`='{4}' WHERE id_empleado = '{5}'", add.Correo, add.Direccion_Usuario, add.profesion, Constructor_Login.usuario, add.imagenUsuario, Constructor_Login.ID_Usuario), Conexion.getConnection());
                    retorno = Convert.ToInt16(agregar.ExecuteNonQuery());

                    if (retorno == 1)
                    {
                        MessageBox.Show("Los datos de su usuario fueron actualizados exitosamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return retorno;
                    }
                }             
                return retorno;
            }                            

            catch
            {
                MessageBox.Show("Ooops! ha ocurrido un error, consulte con su administrador", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return retorno;
            }
        }

        public static int ActualizarPreguntasUsuario()
        {
            int retorno = 0;

            try
            {
                MySqlCommand agregar = new MySqlCommand(string.Format("UPDATE empleados SET pregunta1='{0}' ,pregunta2='{1}',pregunta3='{2}', respuesta1='{3}',respuesta2='{4}',respuesta3='{5}' WHERE id_empleado = '{6}'", ConstructorConfiguracion.pregunta1, ConstructorConfiguracion.pregunta2, ConstructorConfiguracion.pregunta3, ConstructorConfiguracion.respuesta1, ConstructorConfiguracion.respuesta2, ConstructorConfiguracion.respuesta3, ConstructorConfiguracion.ID_empleado), Conexion.getConnection());
                retorno = Convert.ToInt16(agregar.ExecuteNonQuery());
                return retorno;
            }

            catch
            {
                MessageBox.Show("Ooops! ha ocurrido un error, consulte con su administrador", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return retorno;
            }
        }

        public static bool ValidarClave(Constructor_Usuarios che)
        {
            bool retorno = false;
            try
            {
                MySqlCommand che2 = new MySqlCommand(string.Format("SELECT * FROM empleados WHERE id_empleado = '{0}' AND clave ='{1}'", Constructor_Login.ID_Usuario ,che.contraseña), Conexion.getConnection());
                retorno = Convert.ToBoolean(che2.ExecuteScalar());
                return retorno;
            }
            catch (Exception)
            {

                MessageBox.Show("Error critico de conexion", "Revise su conexion a internet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return retorno;
            }
        }
        public static DataTable ObtenerTodasLasPreguntas()
        {
            MySqlCommand che2 = new MySqlCommand(string.Format("SELECT * FROM preguntas"), Conexion.getConnection());
            DataTable data = new DataTable();
            try
            {
                MySqlDataAdapter Adapter = new MySqlDataAdapter(che2);
                Adapter.Fill(data);
                return data;

            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
        }
    }
}
