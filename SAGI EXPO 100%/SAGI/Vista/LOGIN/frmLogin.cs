using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WindowsFormsApplication1.Controlador;
using WindowsFormsApplication1.Modelo;
using System.Threading;
using WindowsFormsApplication1.Vista;
using System.Security.Cryptography;
using WindowsFormsApplication1.Modelo.Funciones_Primer_Uso;
using WindowsFormsApplication1.Vista.LOGIN;
using WindowsFormsApplication1.Controlador.Constructores;
using WindowsFormsApplication1.Vista.CRUD;
using WindowsFormsApplication1.Modelo.Funciones_CRUD;

namespace WindowsFormsApplication1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            Thread f = new Thread(new ThreadStart(StartForm));
            f.Start();
            Thread.Sleep(3000);
            f.Abort();
            txtContraseña.ContextMenu = new ContextMenu();
            txtUsuario.ContextMenu = new ContextMenu();
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

        public void StartForm()
        {
            Application.Run(new Splashscreen());

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        void VerificarUsuario()
        {
            
            if (txtUsuario.Text.Trim() == "" || txtContraseña.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos", "Formularios vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Constructor_Login log = new Constructor_Login();
                Constructor_Login.usuario = txtUsuario.Text;
                Constructor_Login.contraseña = txtEncriptado.Text;
                bool datos = ValidarRecuperacion.Ingreso();
                ValidarRecuperacion.ConseguirImagenEmpresa();

                if (datos == true)
                {
                    if (Constructor_Login.contraseña == "efAdsX436aQfSUcxfwNEbBolhN0=")
                    {
                        MessageBox.Show("A continuacion procedera a cambiar su contraseña", "Es su primera vez utilizando su usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        FrmCambiarContraseña che = new FrmCambiarContraseña();
                        che.Show();
                    }
                    else
                    {
                        MessageBox.Show("Acceso concedido", "Bienvenido " + Constructor_Login.usuario, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        frmRoot che = new frmRoot();
                        che.Show();
                    }
                }
            }         
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";

            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";

            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_Load(object sender, EventArgs e) 
        {
            toolTip1.SetToolTip(picHide, "Ocultar Contraseña");
            toolTip2.SetToolTip(picShow, "Mostrar Contraseña");

            if (FuncionesPrimerUso.VerificarEmpresa() == true) //Verificar si existe una empresa en la base de datos
            {
                if (FuncionesPrimerUso.VerificarUsuario() == true) //Verificar si existe un usuario en la base de datos 
                {
                    PrimerUso.Visible = false;                           
                }
                  
                else
	            {
                    PrimerUso.LabelText = "Primer Usuario";
                    txtContraseña.Visible = false;
                    txtUsuario.Visible = false;
                    pictureBox1.Visible = false;
                    btnIniciaSesion.Visible = false;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    pictureBox5.Visible = false;
                    picShow.Visible = false;
                    linkLabel1.Visible = false;
                    picHide.Visible = false;
                }
            }
            else
            {
                txtContraseña.Visible = false;
                txtUsuario.Visible = false;
                pictureBox1.Visible = false;
                btnIniciaSesion.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                pictureBox5.Visible = false;
                picShow.Visible = false;
                linkLabel1.Visible = false;
                picHide.Visible = false;
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnIniciaSesion_Click(object sender, EventArgs e)
        {                  
               VerificarUsuario();               
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            byte[] passtohash = System.Text.Encoding.UTF8.GetBytes(txtContraseña.Text.ToString());
            txtEncriptado.Text = Hash(passtohash);
        }

        private void picShow_Click(object sender, EventArgs e)
        {
            if (txtContraseña.UseSystemPasswordChar == true)
            {
                txtContraseña.UseSystemPasswordChar = false;
                picShow.Visible = false;
                picHide.Visible = true;
            }
        }

        private void picHide_Click(object sender, EventArgs e)
        {
            if (txtContraseña.UseSystemPasswordChar == false)
            {
                txtContraseña.UseSystemPasswordChar = true;
                picShow.Visible = true;
                picHide.Visible = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Eleccion_recuperar che = new Eleccion_recuperar();
            this.Hide();
            che.Show();
            
        }

        private void pictureBox2_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
           
        }
        public string Hash(byte[] val)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(val);
                return Convert.ToBase64String(hash);

            }
        }
           
        private void PrimerUso_Click(object sender, EventArgs e)
        {
            if (PrimerUso.LabelText == "Primer Usuario")
            {
                Primer_uso2 che = new Primer_uso2();
                this.Hide();
                che.Show();
            }
            else if (PrimerUso.LabelText == "Configurar Preguntas")
            {
                PrimerUsoSeguridad che = new PrimerUsoSeguridad();
                this.Hide();
                che.Show();
            }
            else if (PrimerUso.LabelText == "Configuracion Empresa")
            {
                Primer_uso che = new Primer_uso();
                this.Hide();
                che.Show();
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionSoloLetrasyNumeros(e);
            Validaciones.NoEspacios(e);
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                VerificarUsuario();
            }
            else
            {

            }
            ValidacionSoloLetrasyNumeros(e);
            Validaciones.NoEspacios(e);
        }

        private void btnIniciaSesion_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        

        private void txtEncriptado_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
