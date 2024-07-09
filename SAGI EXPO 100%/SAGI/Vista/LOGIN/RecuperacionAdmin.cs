using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WindowsFormsApplication1.Controlador;
using WindowsFormsApplication1.Modelo;
using System.Security.Cryptography;
using WindowsFormsApplication1.Controlador.Constructores;
using WindowsFormsApplication1.Modelo.Funciones_CRUD;

namespace WindowsFormsApplication1
{
    public partial class frmRecuperarContraseña : Form
    {
        public frmRecuperarContraseña()
        {
            InitializeComponent();
            txtUsuarioAdmin.ContextMenu = new ContextMenu();
            txtClaveAdmin.ContextMenu = new ContextMenu();
            txtUsuarioRecuperar.ContextMenu = new ContextMenu();
        }
       

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);
        private void grpAdmin_Enter(object sender, EventArgs e)
        {

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


        private void txtUsuarioAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin log = new frmLogin();
            log.Show();          
        }

        private void toolSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void grpUsuario_Enter(object sender, EventArgs e)
        {
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
     
        private void BtnPemitir_Click(object sender, EventArgs e)
        {
            ValidarAdmin();
        }
              
        void ValidarAdmin() // Metodo para validar si el usuario que va a dar permisos es Root / Admin
        {
            if (txtUsuarioAdmin.Text.Trim() == "" || txtClaveAdmin.Text.Trim() == "" ||txtUsuarioRecuperar.Text.Trim() == "")
            {
                MessageBox.Show("Existen campos vacios", "Complete los campos solicitados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else

            {
                if (txtUsuarioAdmin.Text == txtUsuarioRecuperar.Text)
                {
                    MessageBox.Show("Ingrese un usuario diferente, No puede recuperar su propio usuario", "Ingrese otro usuario",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                else
                {
                    Constructor_Recuperaciones rec = new Constructor_Recuperaciones();
                    Constructor_Recuperaciones.Usuario = txtUsuarioAdmin.Text;
                    rec.ContraseñaAdmin = txtEncriptado.Text;
                    bool datos = ValidarRecuperacion.ValidarAdmin(rec);

                    if (datos == true)
                    {


                        Constructor_Recuperaciones.Usuario = txtUsuarioRecuperar.Text;
                        bool datos2 = ValidarRecuperacion.ValidarCorredor();

                        if (datos2 == true)
                        {
                            if (Constructor_Login.nivel == 1)

                            {
                                MessageBox.Show("No puedes recuperar un usuario Root", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            else
                            {
                                MessageBox.Show("A continuacion ingrese la nueva contraseña para el usuario que desea recuperar", "Escriba la nueva contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                BtnCambiarContraseña.Enabled = true;
                                txtUsuarioRecuperar.Enabled = false;
                                grpUsuario.Enabled = true;
                                BtnCambiarContraseña.Enabled = true;
                                txtClaveAdmin.Visible = false;
                                txtUsuarioAdmin.Visible = false;
                                grpAdmin.Enabled = false;
                            }
                        }
                     }
                  }
               } 
            }

        void CambiarContraseña() //Restablecer contraseña a la contraseña default para el usuario que se desea recuperar
        {
            if (NuevaContraseña.Text.Trim()=="" || ConfirmarContraseña.Text.Trim()=="")
            {
                MessageBox.Show("Ingrese la nueva contraseña del usuario a recuperar para poder continuar", "Ingrese la nueva contraseña",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                if (NuevaContraseña.Text == "primeruso")
                {
                    MessageBox.Show("No puede utilizar la contraseña default como contraseña personal","Cambie su contraseña",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    if (NuevaContraseña.Text == ConfirmarContraseña.Text)
                    {
                        Constructor_Recuperaciones.Usuario = txtUsuarioRecuperar.Text;
                        Constructor_Recuperaciones.Contraseña = txtContraseñaEncriptada.Text;
                        bool datos = ValidarRecuperacion.CambiarContraseñaPorAdmin();

                        if (datos == false)
                        {
                            MessageBox.Show("La contraseña del usuario fue actualizada correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            frmLogin che = new frmLogin();
                            che.Show();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar la contraseña");
                        }                     
                    }
                    else
                    {
                        MessageBox.Show("Escriba correctamente su contraseña", "Las contraseñas no coinciden", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
        }

        public string Hash(byte[] val) // Metodo para la encriptacion de contraseña
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(val);
                return Convert.ToBase64String(hash);

            }
        }

        private void txtEncriptado_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnCambiarContraseña_Click(object sender, EventArgs e)
        {
            CambiarContraseña();
        }

        private void txtClaveAdmin_TextChanged(object sender, EventArgs e)
        {
            byte[] passtohash = System.Text.Encoding.UTF8.GetBytes(txtClaveAdmin.Text.ToString());
            txtEncriptado.Text = Hash(passtohash);
        }

        private void txtUsuarioAdmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionSoloLetrasyNumeros(e);
            Validaciones.NoEspacios(e);
        }

        private void txtClaveAdmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionSoloLetrasyNumeros(e);
            Validaciones.NoEspacios(e);
        }

        private void txtUsuarioRecuperar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionSoloLetrasyNumeros(e);
            Validaciones.NoEspacios(e);
        }

        private void picHide_Click(object sender, EventArgs e)
        {
                txtClaveAdmin.UseSystemPasswordChar = true;
                picShow.Visible = true;
                picHide.Visible = false;
        }

        private void picShow_Click(object sender, EventArgs e)
        {
                txtClaveAdmin.UseSystemPasswordChar = false;
                picShow.Visible = false;
                picHide.Visible = true;         
        }

        private void frmRecuperarContraseña_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(BtnPemitir , "Verificar si el usuario es un admin o root");
            toolTip3.SetToolTip(BtnCambiarContraseña , "Cambiar contraseña del usuario");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ConfirmarContraseña.UseSystemPasswordChar = true;
            NuevaContraseña.UseSystemPasswordChar = true;
            pbShow2.Visible = true;
            pbHide2.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ConfirmarContraseña.UseSystemPasswordChar = false;
            NuevaContraseña.UseSystemPasswordChar = false;
            pbShow2.Visible = false;
            pbHide2.Visible = true;
        }

        private void NuevaContraseña_TextChanged(object sender, EventArgs e)
        {
            byte[] passtohash = System.Text.Encoding.UTF8.GetBytes(NuevaContraseña.Text.ToString());
            txtContraseñaEncriptada.Text = Hash(passtohash);
        }
    }
}

