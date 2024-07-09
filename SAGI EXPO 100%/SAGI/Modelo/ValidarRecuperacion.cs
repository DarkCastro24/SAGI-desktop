using System;
using WindowsFormsApplication1.Controlador;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;
using WindowsFormsApplication1.Controlador.Constructores;
using WindowsFormsApplication1.Controlador.Constructores_CRUD;

namespace WindowsFormsApplication1.Modelo
{
    class ValidarRecuperacion
    {
        // FRM LOGIN
        public static bool Ingreso()
        {
            bool retorno = false;

            string query = "SELECT * FROM empleados WHERE binary usuario = ?user";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion.getConnection());

                cmdselect.Parameters.Add(new MySqlParameter("user", Constructor_Login.usuario));
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());

                if (retorno == true)
                {
                    int estado = 1;
                    string query2 = "SELECT * FROM empleados WHERE binary usuario = ?user AND  binary clave = ?pass AND estado = ?estado";
                    MySqlCommand cmdselect2 = new MySqlCommand(query2, Conexion.getConnection());
                    cmdselect2.Parameters.Add(new MySqlParameter("user", Constructor_Login.usuario));
                    cmdselect2.Parameters.Add(new MySqlParameter("pass", Constructor_Login.contraseña));
                    cmdselect2.Parameters.Add(new MySqlParameter("estado", estado));
                    retorno = Convert.ToBoolean(cmdselect2.ExecuteScalar());

                    if (retorno == true)
                    {
                        int intentos = 0;
                        MySqlCommand cmdreset = new MySqlCommand(string.Format("UPDATE empleados set intentos = ?intentos WHERE binary usuario = ?user"), Conexion.getConnection());
                        cmdreset.Parameters.Add(new MySqlParameter("intentos", intentos));
                        cmdreset.Parameters.Add(new MySqlParameter("user", Constructor_Login.usuario));
                        int reset = Convert.ToInt16(cmdreset.ExecuteNonQuery());
                        MySqlDataReader _reader = cmdselect2.ExecuteReader();
                        while (_reader.Read())
                        {
                            Constructor_Login.Nombre_Usuario = _reader.GetString(4) + " " + _reader.GetString(5);
                            Constructor_Login.nivel = _reader.GetInt16(3);
                            ConstructorCambiarContraseña.ID_Usuario = _reader.GetInt16(0);
                            ConstructorConfiguracion.ID_empleado = _reader.GetInt16(0);
                            Constructor_Usuarios.id_empresa = _reader.GetInt16(21);
                            try
                            {
                                Constructor_Login.Imagen_Usuario = _reader.GetString(22);
                                ConstructorConfiguracion.imagenUsuario = _reader.GetString(22);
                            }
                            catch (Exception)
                            {

                            }
                        }
                    }
                    else
                    {
                        MySqlDataReader reader = cmdselect.ExecuteReader();
                        while (reader.Read())
                        {
                            int intentos = 0;
                            intentos = reader.GetInt16(12) + 1;
                            if (intentos > 5)
                            {
                                int bloqueo = 3;
                                MySqlCommand cmdlock = new MySqlCommand(string.Format("UPDATE empleados set estado = ?estado WHERE binary usuario = ?user"), Conexion.getConnection());
                                cmdlock.Parameters.Add(new MySqlParameter("estado", bloqueo));
                                cmdlock.Parameters.Add(new MySqlParameter("user", Constructor_Login.usuario));
                                int verificacion = Convert.ToInt32(cmdlock.ExecuteNonQuery());
                                if (verificacion >= 1)
                                {
                                    MessageBox.Show("El usuario está bloqueado", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            else
                            {
                                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE empleados set intentos = '{0}' WHERE usuario = '{1}'", intentos, Constructor_Login.usuario), Conexion.getConnection());
                                int verificacion = Convert.ToInt32(cmdupdate.ExecuteNonQuery());
                                if (verificacion >= 1)
                                {
                                    MessageBox.Show("La contraseña ingresada es incorrecta", "Verifique su información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El usuario o la contraseña no existen en la base de datos", "Verifique su información", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Oops!", "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }


        } // Metodo para validar todas las funciones del LOGIN
        public static bool ConseguirImagenEmpresa() // Conseguir la imagen de la empresa
        {
            bool retorno = false;
            try
            {
                MySqlCommand query = new MySqlCommand(string.Format("SELECT * FROM empresa WHERE id_empresa = '{0}'", Constructor_Login.Empresa), Conexion.getConnection());
                MySqlDataReader _reader = query.ExecuteReader();

                    while (_reader.Read())
                    {
                        Constructor_Login.Imagen_Empresa = _reader.GetString(6);
                        ConstructorCambiarContraseña.ID_Usuario = _reader.GetInt16(0);
                        retorno = true;
                    }
                      
                return retorno;
            }
            catch
            {
                return retorno;
            }
        }

        // FRM CAMBIAR CONTRASEÑA

        public static int FrmCambiarContraseña() //ACTUALIZAR CONTRASEÑA DE USUARIO Y ACTUALIZAR LOS INTENTOS A 0
        {

            int retorno = 0;
            int estado = 1;
            int intentos = 0;

            try
            {
                MySqlCommand clave = new MySqlCommand(string.Format("UPDATE empleados SET clave = '{0}', estado = '{1}',  intentos = '{2}' WHERE id_empleado = '{3}'", ConstructorCambiarContraseña.Contraseña, estado, intentos,  ConstructorCambiarContraseña.ID_Usuario), Conexion.getConnection());
                retorno = Convert.ToInt16(clave.ExecuteNonQuery());
                return retorno;
            }

            catch

            {
                MessageBox.Show("Ooops! ha ocurrido un error, consulte con su administrador", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return retorno;
            }

        }

        public static int OmitirPreguntas() //ACTUALIZAR CONTRASEÑA DE USUARIO Y ACTUALIZAR LOS INTENTOS A 0
        {

            int retorno = 0;
            int codigo = 0;

            try
            {
                MySqlCommand clave = new MySqlCommand(string.Format("UPDATE empleados SET codigo = '{0}' WHERE usuario = '{1}'",codigo, Constructor_Recuperaciones.Usuario), Conexion.getConnection());
                retorno = Convert.ToInt16(clave.ExecuteNonQuery());
                return retorno;
            }

            catch

            {
                MessageBox.Show("Ooops! ha ocurrido un error, consulte con su administrador", "Error crítico de conexiósn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return retorno;
            }

        }


        // Recuperacion por intervencion de administrador
        public static bool ValidarAdmin(Constructor_Recuperaciones recu)
        {
            bool retorno = false;
            int nivel = 0;
         
            try
            {
                MySqlCommand query = new MySqlCommand(string.Format("SELECT * FROM empleados WHERE binary usuario = ?user"), Conexion.getConnection());
                query.Parameters.Add(new MySqlParameter("user", Constructor_Recuperaciones.Usuario));
                retorno = Convert.ToBoolean(query.ExecuteScalar());

                if (retorno == true)
                {
                    int estado = 1;
                    MySqlCommand query2 = new MySqlCommand(string.Format("SELECT * FROM empleados WHERE binary usuario = ?user AND clave = ?clave AND estado= ?estado"), Conexion.getConnection());
                    query2.Parameters.Add(new MySqlParameter("user", Constructor_Recuperaciones.Usuario));
                    query2.Parameters.Add(new MySqlParameter("clave", recu.ContraseñaAdmin));
                    query2.Parameters.Add(new MySqlParameter("estado", estado));
                    retorno = Convert.ToBoolean(query2.ExecuteScalar());

                    if (retorno == true)
                    {
                        MySqlDataReader _reader = query2.ExecuteReader();

                        while (_reader.Read())
                        {
                            Constructor_Login.nivel = _reader.GetInt16(3);
                            nivel = Constructor_Login.nivel;
                        }

                        if (nivel == 1 || nivel == 2)
                        {
                           
                        }
                        else
                        {
                            MessageBox.Show("El usuario ingresado es un corredor debe ser administrador para poder recuperar un usuario", "Error al conceder permisos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            retorno = false;
                        }

                    }
                    else
                    {
                        MessageBox.Show("La contraseña ingresada no coincide con el usuario admin que escribio", "Contraseña incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("El usuario ingresado como administrador no esta registrado en la base de datos",
                    "Datos erroneos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                return retorno;
            }
            catch
            {
                MessageBox.Show("Ooops! ha ocurrido un error, consulte con su administrador", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return retorno;
            }
        }
        public static bool ValidarCorredor() 
        {
            bool retorno = false;

            try
            {
                MySqlCommand query2 = new MySqlCommand(string.Format("SELECT * FROM empleados WHERE binary usuario = ?user"), Conexion.getConnection());
                query2.Parameters.Add(new MySqlParameter("user", Constructor_Recuperaciones.Usuario));
                retorno = Convert.ToBoolean(query2.ExecuteScalar());
                MySqlDataReader _reader = query2.ExecuteReader();

                if (retorno == true)
                {
                   while (_reader.Read())
                   {
                      Constructor_Login.nivel = _reader.GetInt16(3);
                      ConstructorCambiarContraseña.ID_Usuario = _reader.GetInt16(0);
                   }
                }
                else
                {
                    MessageBox.Show("El usuario que desea recuperar no esta registrado en la base de datos","Datos erroneos",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
                return retorno;
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error", "Error al conceder permisos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return retorno;
            }
        }          
        public static bool CambiarContraseñaPorAdmin() // Metodo para resetear la contraseña a la default y los intentos y estados a 0
        {
            bool retorno = false;
            
            try
            {
                MySqlCommand cmdupd = new MySqlCommand(string.Format("UPDATE empleados SET clave = ?clave , estado = '1',  intentos = '0' WHERE usuario = ?user"), Conexion.getConnection());
                cmdupd.Parameters.Add(new MySqlParameter("clave", Constructor_Recuperaciones.Contraseña));
                cmdupd.Parameters.Add(new MySqlParameter("user", Constructor_Recuperaciones.Usuario));
                retorno = Convert.ToBoolean(cmdupd.ExecuteScalar());
                return retorno;
            }
            catch
            {

                MessageBox.Show("Error Crítico de conexión", "Error al cambiar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return retorno;
            }

        }

        // Recuperar por Preguntas
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

        public static bool ValidarUsuarioPregunta() // VALIDAR USUARIO Y OBTENER PREGUNTAS
        {
            bool retorno = false;

            try
            {
                MySqlCommand select = new MySqlCommand(string.Format("SELECT * FROM empleados WHERE binary usuario =?user"),Conexion.getConnection());
                select.Parameters.Add(new MySqlParameter("user", Constructor_Recuperaciones.Usuario));
                retorno = Convert.ToBoolean(select.ExecuteScalar());

                if (retorno == true)
                {
                    MySqlDataReader _reader = select.ExecuteReader();
                    try
                    {
                        while (_reader.Read())
                        {
                            Constructor_Recuperaciones.pregunta1 = _reader.GetInt16(13);
                            Constructor_Recuperaciones.pregunta2 = _reader.GetInt16(14);
                            Constructor_Recuperaciones.pregunta3 = _reader.GetInt16(15);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("El usuario que ha ingresado no posee preguntas de seguridad", "Error al validar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        retorno = false;
                    }
                    
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;             
            }

            catch

            {
                MessageBox.Show("Ooops! ha ocurrido un error, consulte con su administrador", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                retorno = false;
                return retorno;
            }
        } // Verificar si el usuario existe en la base de datos

        public static bool ValidarPreguntas(Constructor_Recuperaciones val)
        {
            bool retorno = false;

            try
            {
                MySqlCommand validar = new MySqlCommand(string.Format("SELECT * FROM empleados WHERE binary usuario = ?user AND respuesta1 = ?respuesta AND respuesta2 = ?respuesta2 AND respuesta3 = ?respuesta3"), Conexion.getConnection());
                validar.Parameters.Add(new MySqlParameter("?respuesta", val.respuesta1));
                validar.Parameters.Add(new MySqlParameter("?respuesta2", val.respuesta2));
                validar.Parameters.Add(new MySqlParameter("?respuesta3", val.respuesta3));
                validar.Parameters.Add(new MySqlParameter("?user", Constructor_Recuperaciones.Usuario));
                retorno = Convert.ToBoolean(validar.ExecuteScalar());
                return retorno;

            }

            catch

            {
                MessageBox.Show("Ooops! ha ocurrido un error, consulte con su administrador", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return retorno;
            }
        } // Validar si las preguntas que el usuario ingreso son correctas    

        public static bool ValidarCodigo(Constructor_Recuperaciones val)
        {
            bool retorno = false;

            try
            {
                MySqlCommand validar = new MySqlCommand(string.Format("SELECT * FROM empleados WHERE usuario =?user AND codigo = ?cod"), Conexion.getConnection());
                validar.Parameters.Add(new MySqlParameter("?user", Constructor_Recuperaciones.Usuario));
                validar.Parameters.Add(new MySqlParameter("?cod", val.cod));
                retorno = Convert.ToBoolean(validar.ExecuteScalar());
                return retorno;
            }
            catch
            {
                MessageBox.Show("Ooops! ha ocurrido un error, consulte con su administrador", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return retorno;
            }
        } // Validar si el codigo pertenece a ese usuario y si es correcto

        public static int ContraseñaPreguntas() //ACTUALIZAR CONTRASEÑA DE USUARIO Y ACTUALIZAR LOS INTENTOS A 0 
        {

            int retorno = 0;
            try
            {
                MySqlCommand clave = new MySqlCommand(string.Format("UPDATE empleados SET clave = ?clave, estado = '1',  intentos = '2' WHERE usuario = ?user"), Conexion.getConnection());
                clave.Parameters.Add(new MySqlParameter("?clave", Constructor_Recuperaciones.Contraseña));
                clave.Parameters.Add(new MySqlParameter("?user", Constructor_Recuperaciones.Usuario));
                retorno = Convert.ToInt16(clave.ExecuteNonQuery());
                return retorno;
            }

            catch

            {
                MessageBox.Show("Ooops! ha ocurrido un error, consulte con su administrador", "Error crítico de conexiósn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return retorno;
            }

        }
        public static DataTable ObtenerPregunta1()
        {
            MySqlCommand che2 = new MySqlCommand(string.Format("SELECT * FROM preguntas WHERE id_pregunta ='{0}'", Constructor_Recuperaciones.pregunta1), Conexion.getConnection());
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
            MySqlCommand che2 = new MySqlCommand(string.Format("SELECT * FROM preguntas WHERE id_pregunta ='{0}'", Constructor_Recuperaciones.pregunta2), Conexion.getConnection());
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
            MySqlCommand che2 = new MySqlCommand(string.Format("SELECT * FROM preguntas WHERE id_pregunta ='{0}'", Constructor_Recuperaciones.pregunta3), Conexion.getConnection());
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

        // Recuperacion por correo electronico

        public static bool ConseguirCorreoEmpresa() // CONSEGUIR EL CORREO DE LA EMPRESA A LA CUAL PERTENECE EL USUARIO
        {
            bool retorno = false;

            try
            {
                MySqlCommand select = new MySqlCommand(string.Format("SELECT * FROM empleados WHERE binary usuario =?user"), Conexion.getConnection());
                select.Parameters.Add(new MySqlParameter("user", Constructor_Recuperaciones.Usuario));
                MySqlDataReader _reader = select.ExecuteReader();
                while (_reader.Read())
                {
                    Constructor_Recuperaciones.Empresa = _reader.GetInt16(21);
                    ConstructorCambiarContraseña.ID_Usuario = _reader.GetInt16(0);
                }

                MySqlCommand select2 = new MySqlCommand(string.Format("SELECT * FROM empresa WHERE id_empresa =?empresa"), Conexion.getConnection());
                select2.Parameters.Add(new MySqlParameter("empresa", Constructor_Recuperaciones.Empresa));

                MySqlDataReader _reader2 = select2.ExecuteReader();
                while (_reader2.Read())
                {
                    Constructor_Recuperaciones.CorreoEmpresa = _reader2.GetString(7);
                    Constructor_Recuperaciones.ContraseñaCorreoEmpresa = _reader2.GetString(8);
                }
                return retorno;
            }                                                       
            catch
            {
                return retorno;
            }
        }

        public static string recover(string usuario)
        {

            Random rdn = new Random();
            int codigo = rdn.Next(1000, 9000);
            codigo.ToString();

            string query = "SELECT * FROM empleados WHERE binary usuario=?user";
            MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnection());
            cmdselect.Parameters.AddWithValue("user", usuario);
            cmdselect.CommandType = CommandType.Text;


            MySqlDataReader reader = cmdselect.ExecuteReader();


            if (reader.Read() == true)
            {
                int ID = Convert.ToInt16(reader.GetInt16(0));
                Constructor_Login.ID_Usuario = ID;
                string nombreusuario = reader.GetString(4) + " " + reader.GetString(5);
                Constructor_Login.usuario = nombreusuario;
                string correo = reader.GetString(7);
                MessageBox.Show("A continuacion enviaremos el codigo de recuperacion a su correo "+ " " + correo, "Ingrese a su correo electrico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var Modelo = new Modelo.Conexion_correo();
                bool datos = false;

                MySqlCommand cod = new MySqlCommand(string.Format("UPDATE empleados SET codigo_correo='{0}' WHERE usuario='{1}'", codigo, usuario), Conexion.getConnection());
                datos = Convert.ToBoolean(cod.ExecuteNonQuery());
                if (datos == true)
                {           
                        Modelo.sendmail
                        (
                        subject: "Aprobación de código de correo",
                        body: "Hola," + nombreusuario + "\nhas solicitado recuperar tu contraseña\n" +
                        "tu codigo de seguridad es:\n" + codigo + "\nPor favor, escriba este codigo en el cuadro de verificacion ",
                        recipientmail: new List<string> { correo }
                        );
                        if (Constructor_Recuperaciones.verificarcorreo == "se envio el mensaje")
                        {
                            MessageBox.Show("El codigo de recuperacion fue enviado correctamente a su correo electronico", "Revise su correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("El codigo no pudo ser enviado al correo que usted ingreso en su usuario debido a que es una direccion de correo inexistente", "Error al enviar codigo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                       
                        return "Hola, se ha enviado un mensaje a tu correo electronico";              
                }
                return "Hola, se ha enviado un mensaje a tu correo electronico";
            }
            else
            {
               
                return "No tienes una cuenta con estas credenciales";
            }
        }
      
        public static bool validarcod(Constructor_Recuperaciones cod)
        {
            bool retorno = false;
            string query = "SELECT * FROM empleados WHERE binary codigo_correo=?cod";
            try
            {
                MySqlCommand cmdeselct = new MySqlCommand(query, Conexion.getConnection());
                cmdeselct.Parameters.Add(new MySqlParameter("cod", cod.cod));
                retorno = Convert.ToBoolean(cmdeselct.ExecuteScalar());

                if (retorno == true)
                {
                    MessageBox.Show("El código de seguridad es correcto, a continuación se procederá a cambiar sus credenciales", "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El codigo no concuerda el código generado", "Error al conceder acceso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                return retorno;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en la base de datos" + e, "error critico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return retorno;

            }
        }
    }
}
