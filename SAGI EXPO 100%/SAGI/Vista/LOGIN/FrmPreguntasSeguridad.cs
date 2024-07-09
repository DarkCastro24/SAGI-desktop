using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WindowsFormsApplication1.Controlador;
using WindowsFormsApplication1.Modelo;
using System.Security.Cryptography;
using WindowsFormsApplication1.Controlador.Constructores;
using WindowsFormsApplication1.Modelo.Funciones_CRUD;
using WindowsFormsApplication1.Vista.PRIMER_USO;

namespace WindowsFormsApplication1.Vista
{
    public partial class FrmPreguntasSeguridad : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);
        public FrmPreguntasSeguridad()
        {
            InitializeComponent();
            txtUsuario.ContextMenu = new ContextMenu();
            CodigoSeguridad.ContextMenu = new ContextMenu();
            txtContraseña.ContextMenu = new ContextMenu();
        }

        public void ValidarUsuario()
        {
            Constructor_Recuperaciones.Usuario = txtUsuario.Text;
            bool datos = ValidarRecuperacion.ValidarUsuarioPregunta( );

                if (datos == true)
                {
                    ObtenerPreguntas();
                    MessageBox.Show("Responda las preguntas o ingrese el codigo de seguridad para recuperar su contraseña", "Usuario encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grpPregunta1.Enabled = true;
                    grpPregunta2.Enabled = true;
                    grpPregunta3.Enabled = true;
                    grpUsuario.Enabled = false;                 
                   
                }                    
        }

        void ObtenerPreguntas()
        {          
            if (ValidarRecuperacion.ObtenerPregunta1() != null)
            {
                cmbPregunta1.DataSource = ValidarRecuperacion.ObtenerPregunta1();
                cmbPregunta1.DisplayMember = "preguntas";
                cmbPregunta1.ValueMember = "id_pregunta";
            }

            if (ValidarRecuperacion.ObtenerPregunta2() != null)
            {
                cmbPregunta2.DataSource = ValidarRecuperacion.ObtenerPregunta2();
                cmbPregunta2.DisplayMember = "preguntas";
                cmbPregunta2.ValueMember = "id_pregunta";
            }

            if (ValidarRecuperacion.ObtenerPregunta3() != null)
            {
                cmbPregunta3.DataSource = ValidarRecuperacion.ObtenerPregunta3();
                cmbPregunta3.DisplayMember = "preguntas";
                cmbPregunta3.ValueMember = "id_pregunta";
            }
        }
        public void ValidarCodigo()
        {
            Constructor_Recuperaciones cod = new Constructor_Recuperaciones();
            cod.cod = CodigoSeguridad.Text;
            Constructor_Recuperaciones.Usuario = txtUsuario.Text;
            bool datos = ValidarRecuperacion.ValidarCodigo(cod);

            if (datos == true)
            {
                MessageBox.Show("El codigo de seguridad ingresado es correcto", "Escriba su nueva contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grpPregunta1.Enabled = false;
                grpPregunta2.Enabled = false;
                grpPregunta3.Enabled = false;
                grpUsuario.Enabled = false;
                grpContraseña.Enabled = true;
            }
            else
            {
                MessageBox.Show("El codigo de seguridad ingresado no es valido", "Error al conceder permisos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ValidarPreguntas()
        {
            if (Pregunta1.Text.Trim() == "" || Pregunta2.Text.Trim() == "" || Pregunta3.Text.Trim() == "")
            {
                MessageBox.Show("Responda las preguntas que se le solicitan", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Constructor_Recuperaciones che = new Constructor_Recuperaciones();
                che.respuesta1 = txtEncriptado2.Text;
                che.respuesta2 = txtEncriptado3.Text;
                che.respuesta3 = txtEncriptado4.Text;
                Constructor_Recuperaciones.Usuario = txtUsuario.Text;
                bool datos = ValidarRecuperacion.ValidarPreguntas(che);

                if (datos == true)
                {
                    MessageBox.Show("Las respuestas que ha ingresado son correctas", "Escriba su nueva contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grpPregunta1.Enabled = false;
                    grpPregunta2.Enabled = false;
                    grpPregunta3.Enabled = false;
                    grpUsuario.Enabled = false;
                    grpContraseña.Enabled = true;
                }

                else
                {
                    MessageBox.Show("Preguntas respondidas incorrectamente", "Error al conceder permisos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        public void CambiarContraseña()
        {
            Constructor_Recuperaciones.Contraseña= txtEncriptado.Text;
            Constructor_Recuperaciones.Usuario = txtUsuario.Text;
            int datos = ValidarRecuperacion.ContraseñaPreguntas();

            if (datos >= 1)
            {
                MessageBox.Show("La contraseña de su usuario ha sido actualizada correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmLogin che2= new frmLogin();
                che2.Show();               
            }
            else
            {
                MessageBox.Show("La contraseña no pudo ser actualizada", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el usuario que desea recuperar", "Campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ValidarUsuario();
            }
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Trim()=="" || txtConfirmarContraseña.Text.Trim()=="")
            {
                MessageBox.Show("Ingrese las preguntas de seguridad", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (txtContraseña.Text == txtConfirmarContraseña.Text)
                {
                    if (txtEncriptado.Text == "efAdsX436aQfSUcxfwNEbBolhN0=")
                    {
                        MessageBox.Show("No puede ingresar la contraseña defult (primeruso) como contraseña personal", "Cambie su contraseña");
                    }
                    else
                    {
                        CambiarContraseña();
                    }                    
                }
                else
                {
                    MessageBox.Show("Debe confirmar su contraseña para poder continuar");
                }
            }
            
        }

        private void btnCodigo_Click(object sender, EventArgs e)
        {

            if (CodigoSeguridad.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el codigo para recuperar su contraseña", "Campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ValidarCodigo();
            }
        }

        private void btnPreguntas_Click(object sender, EventArgs e)
        {
            ValidarPreguntas();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            byte[] passtohash = System.Text.Encoding.UTF8.GetBytes(txtContraseña.Text.ToString());
            txtEncriptado.Text = Hash(passtohash);
        }

        public string Hash(byte[] val)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(val);
                return Convert.ToBase64String(hash);

            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmLogin kk = new frmLogin();
            this.Hide();
            kk.Show();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionSoloLetrasyNumeros(e);
            Validaciones.NoEspacios(e);
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea regresar al login","Desea continuar",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
                this.Hide();
                frmLogin che = new frmLogin();
                che.Show();
            }          
        }

        private void Pregunta1_TextChanged(object sender, EventArgs e)
        {
            string che = Pregunta1.Text;
            string encriptado = Seguridad.Encriptar(che);
            txtEncriptado2.Text = encriptado;
        }

        private void Pregunta2_TextChanged(object sender, EventArgs e)
        {
            string che = Pregunta2.Text;
            string encriptado = Seguridad.Encriptar(che);
            txtEncriptado3.Text = encriptado;
        }

        private void Pregunta3_TextChanged(object sender, EventArgs e)
        {
            string che = Pregunta3.Text;
            string encriptado = Seguridad.Encriptar(che);
            txtEncriptado4.Text = encriptado;
        }

        private void txtEncriptado2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEncriptado3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEncriptado4_TextChanged(object sender, EventArgs e)
        {

        }

        private void CodigoSeguridad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.NoEspacios(e);
            ValidacionSoloLetrasyNumeros(e);
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

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionSoloLetrasyNumeros(e);
            Validaciones.NoEspacios(e);
        }

        private void FrmPreguntasSeguridad_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnValidar , "Verificar la existencia de su usuario");
            toolTip2.SetToolTip(btnPreguntas , "Verificar si las respuestas de las preguntas son validas");
            toolTip3.SetToolTip(btnCodigo , "Verificar si el codigo es valido");
            toolTip4.SetToolTip(btnCambiarContraseña , "Cambiar contraseña de su usuario");
        }

        private void txtConfirmarContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.NoEspacios(e);
        }

        private void Pregunta1_KeyPress(object sender, KeyPressEventArgs e)
        {

            Validaciones.NoEspacios(e);
        }

        private void Pregunta2_KeyPress(object sender, KeyPressEventArgs e)
        {

            Validaciones.NoEspacios(e);
        }

        private void Pregunta3_KeyPress(object sender, KeyPressEventArgs e)
        {

            Validaciones.NoEspacios(e);
        }
    }
}
