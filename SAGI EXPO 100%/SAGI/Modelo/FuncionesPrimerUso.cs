using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using WindowsFormsApplication1.Controlador;
using WindowsFormsApplication1.Controlador.Constructores;

namespace WindowsFormsApplication1.Modelo.Funciones_Primer_Uso
{
    class FuncionesPrimerUso
    {
        //Verificación
        #region
        public static bool VerificarEmpresa() // Verificar existencia de empresa PRIMER USO
        {
            bool retorno = false;
            string query = "SELECT * FROM empresa";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion.getConnection());
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al momento de validar el primer uso, verifique su conexion a internet" + ex.Message, "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return retorno;
            }
            finally
            {
                Conexion.getConnection().ClearAllPoolsAsync();
            }
        }

        public static bool VerificarUsuario() // Verificar si existe un usuario PRIMER USO
        {
            bool retorno = false;
            string query = "SELECT * FROM empleados";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion.getConnection());
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al momento de validar el primer uso, verifique su conexion a internet" + ex.Message, "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return retorno;
            }
            finally
            {
                Conexion.getConnection().ClearAllPoolsAsync();
            }
        }

        public static bool VerificarPreguntas() // Verificar si se ingresaron las preguntas PRIMER USO
        {
            bool retorno = false;
            string query = "SELECT * FROM empleados WHERE  codigo = '1'";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion.getConnection());
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar()); 
                return retorno;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al momento de validar el primer uso, verifique su conexion a internet" + ex.Message, "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return retorno;
            }
            finally
            {
                Conexion.getConnection().ClearAllPoolsAsync();
            }
        }
        #endregion
        public static int NuevoUsuario(Constructor_Usuarios agregar)
        {
            int retorno = 0;
            int codigo = 1;
            try
            {               
                    MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO `empleados` (`id_empleado`, `id_genero`, `estado`, `tipoUsuario`, `nombre_empl`, `apellido_empl`, `nacimiento_empl`, `correo_empl`, `direccion_empl`, `profesion`, `usuario`, `clave`, `id_empresa`, `imagen`, `codigo`) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}','{14}')", agregar.ID_empleado,agregar.genero,agregar.estado,agregar.tipo_usuario,agregar.Nombre_Usuario,agregar.Apellido_Usuario,agregar.nacimiento, agregar.Correo,agregar.Direccion_Usuario,agregar.profesion, Constructor_Usuarios.Usuario,agregar.contraseña ,agregar.Empresa,agregar.imagenUsuario,codigo), Conexion.getConnection());
                    retorno = Convert.ToInt16(cmdadd.ExecuteNonQuery());
                    if (retorno >= 1)
                    {
                        MessageBox.Show("Usuario Ingresado correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El usuario no pudo ser ingresado", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                    return retorno;          
            }
            catch
            {
                MessageBox.Show("Usuario no pudo ser ingresado", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return retorno;
            }

        } // AGREGAR LOS DATOS DEL PRIMER USUARIO

        public static int IngresarDatos(Constructor_Recuperaciones add)
        {
            int retorno = 0;

            try
            {
                bool Validar = false;
                MySqlCommand che = new MySqlCommand(string.Format("SELECT * FROM empleados"),Conexion.getConnection());
                Validar = Convert.ToBoolean(che.ExecuteScalar());

                if (Validar == true)
                {
                    MySqlCommand agregar = new MySqlCommand(string.Format("UPDATE empleados SET pregunta1='{0}' ,pregunta2='{1}',pregunta3='{2}',codigo='{3}',respuesta1='{4}',respuesta2='{5}',respuesta3='{6}' WHERE usuario = '{7}'", Constructor_Recuperaciones.pregunta1, Constructor_Recuperaciones.pregunta2, Constructor_Recuperaciones.pregunta3, add.codigo_correo, add.respuesta1, add.respuesta2, add.respuesta3, Constructor_Usuarios.Usuario), Conexion.getConnection());
                    retorno = Convert.ToInt16(agregar.ExecuteNonQuery());

                    if (retorno >= 1)
                    {
                        MessageBox.Show("Hemos terminado de configurar el primer usuario del sistema a continuacion lo dirigiremos al login para que inicie sesion con el usuario que acaba de crear", "Proceso completado exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);             
                    }
                    else
                    {
                        MessageBox.Show("Las preguntas de seguridad y el codigo no pudieron ser ingresados en la base de datos", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MySqlCommand agregar = new MySqlCommand(string.Format("UPDATE empleados SET pregunta1='{0}' ,pregunta2='{1}',pregunta3='{2}',codigo='{3}',respuesta1='{4}',respuesta2='{5}',respuesta3='{6}' WHERE tipoUsuario = '1'", Constructor_Recuperaciones.pregunta1, Constructor_Recuperaciones.pregunta2, Constructor_Recuperaciones.pregunta3, add.codigo_correo, add.respuesta1, add.respuesta2, add.respuesta3), Conexion.getConnection());
                    retorno = Convert.ToInt16(agregar.ExecuteNonQuery());

                    if (retorno >= 1)
                    {
                        MessageBox.Show("Las preguntas de seguridad y el codigo no pudieron ser ingresados en la base de datos", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Hemos terminado de configurar el primer usuario del sistema a continuacion lo dirigiremos al login para que inicie sesion con el usuario que acaba de crear", "Proceso completado exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
                return retorno;
            }

            catch
            {
                MessageBox.Show("Ooops! ha ocurrido un error, consulte con su administrador", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return retorno;
            }
        } // INGRESAR LAS PREGUNTAS Y EL CODIGO AL PRIMER USUARIO 

        public static int AgregarEmpresa(Constructor_Empresa che)
        {
            int retorno = 0;
            try
            {
                MySqlCommand che2 = new MySqlCommand(string.Format("SELECT * FROM empresa WHERE empresa = '{0}' AND nit = '{1}'", che.Nombre_Empresa, che.nit), Conexion.getConnection());
                bool validar = Convert.ToBoolean(che2.ExecuteScalar());

                if (validar == true)
                {
                    MessageBox.Show("Error la empresa ya existe en la base de datos", "Duplicidad de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    retorno = 0;
                }
                else
                {
                    MySqlCommand kk = new MySqlCommand(String.Format("INSERT INTO empresa (empresa,nit,representante_legal,tipoEmpresa,direccion,logoempresa,correo_empresa,contraseña_correo) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", che.Nombre_Empresa, che.nit, che.representante, che.id_tipo_empresa, che.direccion, che.imagen,Constructor_Empresa.correoEmpresarial,Constructor_Empresa.clavecorreo), Conexion.getConnection());
                    retorno = Convert.ToInt16(kk.ExecuteNonQuery());

                     if (retorno >= 1)
                     {
                        MessageBox.Show("Empresa registrada exitosamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);             
                     }
                     else
                     {
                        MessageBox.Show("La empresa no pudo ser registrada", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                 }
                return retorno;
            }
            catch (Exception e)
            {
                MessageBox.Show("La empresa no pudo ser ingresada verifique su conexion a internet" + e.Message, "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }

        // METODOS PARA COMPLETAR COMBOBOX (PRIMERUSO)
        #region
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
                MessageBox.Show("Ha ocurrido un error al obtener los generos", "Error crítico de conexión");
                return data;
            }
            finally
            {
                Conexion.getConnection().Close();
            }
        }

        public static DataTable ObtenerTipoUsuario()
        {
            string query = "SELECT * FROM tipousuario WHERE id_tipousuario = 1";
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
                MessageBox.Show("Ha ocurrido un error al obtener los tipos de usuario", "Error crítico de conexión");
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
                MessageBox.Show("Ha ocurrido un error al obtener los tipos de usuario", "Error crítico de conexión");
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
                MessageBox.Show("Ha ocurrido un error al obtener los tipos de usuario", "Error crítico de conexión");
                return data;
            }
            finally
            {
                Conexion.getConnection().Close();
            }
        }

        public static DataTable ObtenerPreguntas()
        {
            string query = "SELECT * FROM preguntas";
            DataTable data = new DataTable();
            try
            {
                MySqlCommand cmdSelect = new MySqlCommand(query, Conexion.getConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdSelect);
                adapter.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ooops!, Ha ocurrido un error al obtener los tipos de usuario, consulte xon el administrado." + ex.Message, "");
                return data;
            }
            finally
            {
                Conexion.getConnection().Close();
            }

        } // Obtencion de preguntas para primer uso y para configuracion personal del usuario

        public static DataTable ObtenerTipo_Empresa()
        {
            string query = "SELECT * FROM tipo_empresa WHERE id_tipo_empresa = 1";
            DataTable data = new DataTable();
            try
            {
                MySqlCommand cmdSelect = new MySqlCommand(query, Conexion.getConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdSelect);
                adapter.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ooops!, Ha ocurrido un error al obtener los tipos de usuario, consulte xon el administrado." + ex.Message, "");
                return data;
            }
            finally
            {
                Conexion.getConnection().Close();
            }

        } // Obtener tipo de empresa para configuracion de primer uso empresa
        #endregion
    }
}

