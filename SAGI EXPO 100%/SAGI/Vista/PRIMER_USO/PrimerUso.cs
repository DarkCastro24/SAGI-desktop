using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using WindowsFormsApplication1.Modelo;
using WindowsFormsApplication1.Controlador;
using System.Security.Cryptography;
using WindowsFormsApplication1.Modelo.Funciones_Primer_Uso;
using System.IO;
using System.Drawing.Imaging;
using WindowsFormsApplication1.Modelo.Funciones_CRUD;
using WindowsFormsApplication1.Controlador.Constructores;

namespace WindowsFormsApplication1.Vista
{
    public partial class Primer_uso2 : Form
    {
        public Primer_uso2()
        {
            InitializeComponent();
            txtNombre.ContextMenu = new ContextMenu();
            txtProfesion.ContextMenu = new ContextMenu();
            txtApellido.ContextMenu = new ContextMenu();
            
        } 

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void AgregarUsuario()
        {
            if (txtimagen.Text == "hola")
            {
                MessageBox.Show("No se ha seleccionado ninguna imagen", "Mensaje de Primer Uso");
            }
            else
            {
                Constructor_Usuarios agregar = new Constructor_Usuarios();
                agregar.Nombre_Usuario = txtNombre.Text;
                agregar.Apellido_Usuario = txtApellido.Text;
                agregar.Correo = txtCorreo.Text;
                agregar.Direccion_Usuario = txtDireccion.Text;
                agregar.nacimiento = dtpEmpleado.Text;
                Constructor_Usuarios.Usuario = txtUsuario.Text;
                agregar.contraseña = txtEncriptado.Text;
                agregar.profesion = txtProfesion.Text;
                agregar.Empresa = Convert.ToInt32(cmbEmpresa.SelectedValue);
                agregar.estado = Convert.ToInt32(cmbEstado.SelectedValue);
                agregar.tipo_usuario = Convert.ToInt32(cmbTipoUsuario.SelectedValue);
                agregar.genero = Convert.ToInt32(cmbGenero.SelectedValue);
                agregar.imagenUsuario = txtimagen.Text;
                int datos = FuncionesPrimerUso.NuevoUsuario(agregar);
                if (datos >= 1)
                {
                    MessageBox.Show("Hemos finalizado la configuracion inicial del sistema a continuacion se mostrara un formulario para configurar las preguntas y código de seguridad, le serviran en caso de olvidar su contraseña", "Mensaje del Sistema || Primer Uso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PrimerUsoSeguridad che = new PrimerUsoSeguridad();
                    this.Hide();
                    che.Visible = true;
                }
                else
                {
                    MessageBox.Show("El usuario no pudo ser ingresado");
                }
            }                 
        }

        private void Primer_uso2_Load(object sender, EventArgs e)
        {
            CompletarComboBox();
            lblcoinciden.Visible = false;
            lblnocoinciden.Visible = false;
            toolTip1.SetToolTip(btnExaminar, "Click o Enter para agregar su imagen de perfil");
            toolTip2.SetToolTip(button1, "Guardar datos y continuar");
        }

        public void CompletarComboBox()
        {
            if (FuncionesPrimerUso.ObtenerEstado() != null)
            {
                cmbEstado.DataSource = FuncionesPrimerUso.ObtenerEstado();
                cmbEstado.DisplayMember = "estado_usuario";
                cmbEstado.ValueMember = "id_estado";
            }

            if (FuncionesPrimerUso.ObtenerGenero() != null)
            {
                cmbGenero.DataSource = FuncionesPrimerUso.ObtenerGenero();
                cmbGenero.DisplayMember = "genero";
                cmbGenero.ValueMember = "id_genero";
            }

            if (FuncionesPrimerUso.ObtenerTipoUsuario() != null)
            {
                cmbTipoUsuario.DataSource = FuncionesPrimerUso.ObtenerTipoUsuario();
                cmbTipoUsuario.DisplayMember = "tipo_usuario";
                cmbTipoUsuario.ValueMember = "id_tipoUsuario";
            }

            if (FuncionesPrimerUso.ObtenerEmpresa() != null)
            {
                cmbEmpresa.DataSource = FuncionesPrimerUso.ObtenerEmpresa();
                cmbEmpresa.DisplayMember = "empresa";
                cmbEmpresa.ValueMember = "id_empresa";
            }
        }

        public void ValidacionSoloLetrasyNumeros(KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtProfesion_KeyPress(object sender, KeyPressEventArgs e) // Validacion de bloqueo de letras numeros puntos etc

        {
            ValidacionSoloLetrasyNumeros(e);
            Validaciones.SolamenteLetras(e);
        }

        public string Hash(byte[] val)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(val);
                return Convert.ToBase64String(hash);

            }
        }

        private void btnExaminar_Click_1(object sender, EventArgs e)
        {
            txtimagen.Text = "holo";
            try
            {
                OpenCargarImagen.Filter = "Archivo de Imagen (.jpg) |*.jpg | Archivo de Imagen (.png) |*.png| Archivo de Imagen (.jpeg) |*.jpge| Todos los Archivos|*.*";
                DialogResult resultado = OpenCargarImagen.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    pbLogo.Image = Image.FromFile(OpenCargarImagen.FileName);
                    MemoryStream ms = new MemoryStream();
                    pbLogo.Image.Save(ms, ImageFormat.Jpeg);
                    byte[] aByte = ms.ToArray();
                    string enconded = Convert.ToBase64String(aByte);
                    txtimagen.Text = enconded;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al ingresar la imagen", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text.Trim() == "" || txtNombre.Text.Trim() == "" || txtApellido.Text.Trim() == "" || txtContraseña.Text.Trim() == "" || txtCorreo.Text.Trim() == "" || txtDireccion.Text.Trim() == "" || txtProfesion.Text.Trim() == "" || txtUsuario.Text.Trim() == "")
                {
                    MessageBox.Show("Complete todos los campos solicitados", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    label21.Visible = true;
                    label17.Visible = true;
                }
                else if (txtUsuario.Text.Trim() != "" && txtNombre.Text.Trim() != "" && txtApellido.Text.Trim() != "" && txtContraseña.Text.Trim() != "" && txtCorreo.Text.Trim() != "" && txtDireccion.Text.Trim() != "" && txtProfesion.Text.Trim() != "" && txtUsuario.Text.Trim() != "")
                {
                    if (txtContraseña.Text == txtConfirmarContraseña.Text)
                    {
                        if (txtEncriptado.Text == "efAdsX436aQfSUcxfwNEbBolhN0=")
                        {
                            MessageBox.Show("No puede ingresar la contraseña por defecto", "Cambie su contraseña");
                        }
                        else
                        {
                            ValidarCorreo();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden", "Ingrese contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void txtContraseña_TextChanged_1(object sender, EventArgs e)
        {
            if (txtContraseña.Text == txtConfirmarContraseña.Text && txtContraseña.Text != "" && txtConfirmarContraseña.Text != "")
            {
                lblcoinciden.Show();
                lblnocoinciden.Hide();
            }
            else if (txtContraseña.Text != txtConfirmarContraseña.Text)
            {
                lblnocoinciden.Show();
                lblcoinciden.Hide();
            }
            else if (txtConfirmarContraseña.Text.Trim() == "")
            {
                lblcoinciden.Visible = false;
                lblnocoinciden.Visible = false;
            }
            byte[] passtohash = System.Text.Encoding.UTF8.GetBytes(txtContraseña.Text.ToString());
            txtEncriptado.Text = Hash(passtohash);
        }

        void ValidarCorreo()
        {
            if (txtCorreo.Text.Contains("@gmail.com"))
            {
                if (MessageBox.Show("Esta seguro que desea ingresar la direccion de correo electronico" + " " + txtCorreo.Text +" " + "Si es una direccion inexistente perdera la oportunidad de recuperar su usuario mediante codigo de correo electronico", "Verifique su correo electronico",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
                {
                    AgregarUsuario();
                }           
            }
            else
            {
                MessageBox.Show("El correo ingresado debe ser tipo @gmail.com", "Cambie la direccion de correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtConfirmarContraseña_TextChanged_1(object sender, EventArgs e)
        {
            if (txtContraseña.Text == txtConfirmarContraseña.Text && txtContraseña.Text != "" && txtConfirmarContraseña.Text != "")
            {
                lblcoinciden.Show();
                lblnocoinciden.Hide();
            }
            else if (txtContraseña.Text != txtConfirmarContraseña.Text)
            {
                lblnocoinciden.Show();
                lblcoinciden.Hide();
            }
            else if (txtConfirmarContraseña.Text.Trim() == "")
            {
                lblcoinciden.Visible = false;
                lblnocoinciden.Visible = false;
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteLetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteLetras(e);
        }

        private void txtProfesion_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteLetras(e);
        }
    }          
}
   


