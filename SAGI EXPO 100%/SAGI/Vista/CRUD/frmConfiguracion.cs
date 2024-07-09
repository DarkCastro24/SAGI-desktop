using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Modelo.Funciones_CRUD;
using WindowsFormsApplication1.Controlador;
using System.IO;
using System.Drawing.Imaging;
using System.Security.Cryptography;
using WindowsFormsApplication1.Controlador.Constructores;
using WindowsFormsApplication1.Vista.PRIMER_USO;
using WindowsFormsApplication1.Controlador.Constructores_CRUD;

namespace WindowsFormsApplication1.Vista.CRUD
{
    public partial class frmConfiguracion : Form
    {
        public static int espanol = 0;
        public static int ingles = 1;
        public frmConfiguracion()
        {
            InitializeComponent();
        }

        private void frmConfiguracion_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pbTodasLasPreguntas, "Presione click si desea cambiar las preguntas de su usuario");
            toolTip2.SetToolTip(picHide, "Ocultar la contraseña");
            toolTip3.SetToolTip(picShow, "Mostrar la contraseña");
            txtId.Text = Convert.ToString(Constructor_Login.ID_Usuario);
            panelDatos.Enabled = false;          
            panel1.Enabled = true;
            if (espanol == 0)
            {
                MessageBox.Show("Ingrese su contraseña para confirmar que es el dueño de la cuenta", "Ingrese su contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Enter your password to confirm that you are the owner of the account", "Enter your password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
       
        public Image TextoaImagen(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0,
            imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            pbLogo.Image = Image.FromStream(ms);
            return image;

        }

        void PreguntasSeleccionadas()
        {
            if (FuncionesConfiguracion.ObtenerPregunta1() != null)
            {
                cmbPregunta1.DataSource = FuncionesConfiguracion.ObtenerPregunta1();
                cmbPregunta1.DisplayMember = "preguntas";
                cmbPregunta1.ValueMember = "id_pregunta";
            }

            if (FuncionesConfiguracion.ObtenerPregunta2() != null)
            {
                cmbPregunta2.DataSource = FuncionesConfiguracion.ObtenerPregunta2();
                cmbPregunta2.DisplayMember = "preguntas";
                cmbPregunta2.ValueMember = "id_pregunta";
            }

            if (FuncionesConfiguracion.ObtenerPregunta3() != null)
            {
                cmbPregunta3.DataSource = FuncionesConfiguracion.ObtenerPregunta3();
                cmbPregunta3.DisplayMember = "preguntas";
                cmbPregunta3.ValueMember = "id_pregunta";
            }
        }

        void ComboBoxTodasLasPreguntas()
        {
            if (FuncionesConfiguracion.ObtenerTodasLasPreguntas() != null)
            {
                cmbPregunta1.DataSource = FuncionesConfiguracion.ObtenerTodasLasPreguntas();
                cmbPregunta1.DisplayMember = "preguntas";
                cmbPregunta1.ValueMember = "id_pregunta";
            }

            if (FuncionesConfiguracion.ObtenerTodasLasPreguntas() != null)
            {
                cmbPregunta2.DataSource = FuncionesConfiguracion.ObtenerTodasLasPreguntas();
                cmbPregunta2.DisplayMember = "preguntas";
                cmbPregunta2.ValueMember = "id_pregunta";
            }

            if (FuncionesConfiguracion.ObtenerTodasLasPreguntas() != null)
            {
                cmbPregunta3.DataSource = FuncionesConfiguracion.ObtenerTodasLasPreguntas();
                cmbPregunta3.DisplayMember = "preguntas";
                cmbPregunta3.ValueMember = "id_pregunta";
            }
        }

        public string Hash(byte[] val)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(val);
                return Convert.ToBase64String(hash);

            }
        }
               
        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (txtId.Text.Trim() == "")
                {
                    if (espanol == 0)
                    {
                        MessageBox.Show("No se ha seleccionado ningun registro", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("No register selected", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    
                }
                //PENDIENTE ESTO VA CON OTRO CONSTRUCTOR
                Constructor_Usuarios che = new Constructor_Usuarios();
                che.Correo = txtCorreo.Text;
                che.profesion = txtProfesion.Text;
                che.Direccion_Usuario = txtDireccion.Text;
                che.Correo = txtCorreo.Text;
                che.imagenUsuario = txtlogo.Text;
                Constructor_Login.ID_Usuario = Convert.ToInt16(txtId.Text);
                Constructor_Usuarios.Usuario = txtUsuario.Text;
                int datos = FuncionesConfiguracion.ActualizarDatosUsuario(che);
            }
            catch (Exception)
            {
                if (espanol == 0)
                {
                    MessageBox.Show("Ha ocurrido un error", "Consulte con el administrador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("An unexpected error", "Check with the administrator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (txtValidarClave.Text.Trim() == "")
            {
                if (espanol == 0)
                {
                    MessageBox.Show("Complete el campo solicitado", "Ingrese la contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Complete the requested field", "Enter your password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }
            else
            {
                if (Constructor_Login.contraseña == txtEncriptadoClaveValidar.Text)
                {

                    txtId.Text = Convert.ToString(ConstructorConfiguracion.ID_empleado);
                    if (espanol == 0)
                    {
                        MessageBox.Show("La contraseña es correcta, A continuacion puede configurar sus datos usuario" + " " + Constructor_Login.usuario + " , " + "debe dar click en el formulario que se encuentra en la parte inferior", "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("The password is correct, now you can change your information" + " " + Constructor_Login.usuario + " , " + "you must click on the form at the bottom ", " Access Granted ", , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    panelContenedor.Enabled = true;
                    panelDatos.Enabled = true;
                    txtValidarClave.Visible = false;
                    button1.Visible = false;
                    label2.Location = new Point(393, 13);
                    pictureBox6.Location = new Point(331, 3);
                    CargarTodo();
                    try
                    {
                        TextoaImagen(Constructor_Login.Imagen_Usuario);
                    }
                    catch (Exception)
                    {
                     
                    }

                    if (Respuesta1.Text.Trim()=="" || Respuesta2.Text.Trim()=="" || Respuesta3.Text.Trim()=="")
                    {
                        ComboBoxTodasLasPreguntas();
                    }
                }
                else
                {
                    if (espanol == 0)
                    {
                        MessageBox.Show("La contraseña es incorrecta", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("The password is incorrect", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
            }
        }

        private void btnCambiarContraseña_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text.Trim() == "")
                {
                    if (espanol == 0)
                    {
                        MessageBox.Show("No se ha seleccionado ningun registro", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("No register selected", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    
                }
                if (txtContraseña.Text.Trim() == "" || txtConfirmarContraseña.Text.Trim() == "")
                {
                    if (espanol == 0)
                    {
                        MessageBox.Show("Complete los campos de contraseña para continuar", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Complete all the fields from password for continue", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    
                }
                else
                {
                    if (txtConfirmarContraseña.Text == txtContraseña.Text)
                    {
                        if (txtEncriptadoComparar.Text == txtEncriptado.Text)
                        {
                            if (espanol == 0)
                            {
                                MessageBox.Show("Acabas de ingresar la misma contraseña que tenias antes", "Ingresa una contraseña diferente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("You just entered with the same password you have before", "Enter with a diferent password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            
                        }
                        else
                        {
                            if (txtEncriptado.Text == "efAdsX436aQfSUcxfwNEbBolhN0=")
                            {
                                if (espanol == 0)
                                {
                                    MessageBox.Show("No puede ingresar la contraseña default como su contraseña personal", "Cambie su contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("You can't use the defaulot password like your propely password", "Change your password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                
                            }
                            else
                            {
                                Constructor_Login che = new Constructor_Login();
                                che.clave = txtEncriptado.Text;
                                Constructor_Login.ID_Usuario = Convert.ToInt16(txtId.Text);
                                int datos = FuncionesConfiguracion.ActualizarContraseña(che);

                                if (datos >= 1)
                                {
                                    CargarTodo();
                                }
                                else
                                {
                                    MessageBox.Show("Error");
                                }
                            }
                        }
                    }
                    else
                    {
                        if (espanol == 0)
                        {
                            MessageBox.Show("Escriba su contraseña correctamente", "Las contraseñas no coinciden", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("Enter your correctly password", "Passwords do not match", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnPreguntas_Click_1(object sender, EventArgs e)
        {
            try
            {
                ConstructorConfiguracion.pregunta1 = Convert.ToInt16(cmbPregunta1.SelectedValue);
                ConstructorConfiguracion.pregunta2 = Convert.ToInt16(cmbPregunta2.SelectedValue);
                ConstructorConfiguracion.pregunta3 = Convert.ToInt16(cmbPregunta3.SelectedValue);
                ConstructorConfiguracion.respuesta1 = txtRespuesta1.Text;
                ConstructorConfiguracion.respuesta2 = txtRespuesta2.Text;
                ConstructorConfiguracion.respuesta3 = txtRespuesta3.Text;
                int datos = FuncionesConfiguracion.ActualizarPreguntasUsuario();

                if (datos >= 1)
                {
                    if (espanol == 0)
                    {
                        MessageBox.Show("Las preguntas y respuestas de seguridad de su usuario fueron actualizadas correctamente", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Your user's security questions and answers were updated correctly ", "Data updated4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                else
                {
                    MessageBox.Show("ERROR");
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void txtValidarClave_TextChanged_2(object sender, EventArgs e)
        {
            byte[] passtohash = System.Text.Encoding.UTF8.GetBytes(txtValidarClave.Text.ToString());
            txtEncriptadoClaveValidar.Text = Hash(passtohash);
        }

        private void picHide_Click_2(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
            txtConfirmarContraseña.UseSystemPasswordChar = true;
            picShow.Visible = true;
            picHide.Visible = false;
        }

        private void picShow_Click_1(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = false;
            txtConfirmarContraseña.UseSystemPasswordChar = false;
            picShow.Visible = false;
            picHide.Visible = true;
        }
              
        private void btnExaminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                txtlogo.Clear();
                AbrirImagen.Filter = "Archivo de Imagen (.jpg) |*.jpg | Archivo de Imagen (.png) |*.png| Archivo de Imagen (.jpeg) |*.jpge| Todos los Archivos|*.*";
                DialogResult resultado = AbrirImagen.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    pbLogo.Image = Image.FromFile(AbrirImagen.FileName);
                    MemoryStream ms = new MemoryStream();
                    pbLogo.Image.Save(ms, ImageFormat.Jpeg);
                    byte[] aByte = ms.ToArray();
                    string enconded = Convert.ToBase64String(aByte);
                    txtlogo.Text = enconded;
                }
            }
            catch (Exception)
            {
                if (espanol == 0)
                {
                    MessageBox.Show("Error al ingresar la imagen", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error entering the image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void txtCorreo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (txtCorreo.Text.Contains("@gmail.com"))
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = false;
            }
        }

        private void Respuesta1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteLetras(e);
            Validaciones.NoEspacios(e);
        }

        private void Respuesta2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteLetras(e);
            Validaciones.NoEspacios(e);
        }

        private void Respuesta3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteLetras(e);
            Validaciones.NoEspacios(e);
        }

        private void Respuesta3_TextChanged_1(object sender, EventArgs e)
        {

            string che = Respuesta3.Text;
            string encriptado = Seguridad.Encriptar(che);
            txtRespuesta3.Text = encriptado;
        }

        private void Respuesta2_TextChanged_1(object sender, EventArgs e)
        {
            string che = Respuesta2.Text;
            string encriptado = Seguridad.Encriptar(che);
            txtRespuesta2.Text = encriptado;
        }

        private void Respuesta1_TextChanged_1(object sender, EventArgs e)
        {
            string che = Respuesta1.Text;
            string encriptado = Seguridad.Encriptar(che);
            txtRespuesta1.Text = encriptado;
        }

        private void pbTodasLasPreguntas_Click(object sender, EventArgs e)
        {
            ComboBoxTodasLasPreguntas();
        }

        private void label7_Click(object sender, EventArgs e)
        {
         
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            byte[] passtohash = System.Text.Encoding.UTF8.GetBytes(txtContraseña.Text.ToString());
            txtEncriptado.Text = Hash(passtohash);
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbPregunta1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbPregunta2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbPregunta3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {

        }

        void desencriptar_respuestas()
        {
            string desencriptado1 = Seguridad.DesEncriptar(ConstructorConfiguracion.respuesta1);
            string desencriptado2 = Seguridad.DesEncriptar(ConstructorConfiguracion.respuesta2);
            string desencriptado3 = Seguridad.DesEncriptar(ConstructorConfiguracion.respuesta3);

            Respuesta1.Text = desencriptado1;
            Respuesta2.Text = desencriptado2;
            Respuesta3.Text = desencriptado3;
        }

        void CargarTodo()
        {
            FuncionesConfiguracion.MostrarDatos();
            txtUsuario.Text = ConstructorConfiguracion.Usuario;
            txtCorreo.Text = ConstructorConfiguracion.Correo;
            txtDireccion.Text = ConstructorConfiguracion.Direccion;
            txtProfesion.Text = ConstructorConfiguracion.Profesion;
            txtlogo.Text = ConstructorConfiguracion.imagenUsuario;
            txtEncriptadoComparar.Text = ConstructorConfiguracion.Contraseña;

            try
            {

                try
                {
                    desencriptar_respuestas();
                }
                catch (Exception)
                {

                }
                PreguntasSeleccionadas();

                try
                {
                    TextoaImagen(txtlogo.Text);
                }
                catch (Exception)
                {

                }
            }
            catch (Exception)
            {
                ComboBoxTodasLasPreguntas();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (espanol == 0)
            {
                if (MessageBox.Show("¿Está seguro de terminar la configuración?", "Guardar cambios del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to finish?", "Save all the updates", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        this.Close();
                    }
                    else
                    {
                    }
            

            }
        }
    }
}
