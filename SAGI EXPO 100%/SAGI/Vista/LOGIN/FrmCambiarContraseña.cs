using System;
using System.Windows.Forms;
using WindowsFormsApplication1.Modelo;
using System.Security.Cryptography;
using WindowsFormsApplication1.Controlador;
using WindowsFormsApplication1.Controlador.Constructores;
using WindowsFormsApplication1.Modelo.Funciones_CRUD;
using WindowsFormsApplication1.Controlador.Constructores_CRUD;

namespace WindowsFormsApplication1.Vista.LOGIN
{
    
    public partial class FrmCambiarContraseña : Form
    {
        public static int espanol = 0;
        public static int ingles = 1;
        public FrmCambiarContraseña()
        {
            InitializeComponent();
            contraseña.ContextMenu = new ContextMenu();
            contraseña2.ContextMenu = new ContextMenu();
            toolTip1.SetToolTip(picHide, "Ocultar Contraseña");
            toolTip2.SetToolTip(picShow, "Mostrar Contraseña");
            toolTip3.SetToolTip(pictureBox2 , "Guardar contraseña y continuar");
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

        public void CambiarContraseña()
          
        {
            if (contraseña2.Text.Trim()=="" || contraseña.Text.Trim()=="")
            {
                if (espanol == 0 )
                {
                    MessageBox.Show("CAMPOS VACIOS");
                }
                else
                {
                    MessageBox.Show("EMPTY FIELDS");
                }
               
            }
            else
            {
                ConstructorCambiarContraseña.Contraseña = txtEncriptado.Text;
                int datos = ValidarRecuperacion.FrmCambiarContraseña();
                if (contraseña.Text == contraseña2.Text)
                {
                    if (ConstructorCambiarContraseña.Contraseña == "efAdsX436aQfSUcxfwNEbBolhN0=")
                    {
                        if (espanol == 0)
                        {
                            MessageBox.Show("No puede ingresar la clave default como contraseña para el uso de su usuario");
                        }
                        else
                        {
                            MessageBox.Show("You can't enter the default key as password for using your user");
                        }
                       
                    }
                    else
                    {                       
                        if (datos >= 1)
                        {
                            if (espanol == 0)
                            {
                                MessageBox.Show("La contraseña de su usuario ha sido actualizada correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MessageBox.Show("Si desea configurar el resto de datos de su usuario podra realizarlo cuando inicie sesion, debera dirigirse al apartado de configuracion personal", "En caso de querer realizar otros cambios en su usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ConstructorConfiguracion.Validacion = "yes";
                                this.Hide();
                                frmLogin k = new frmLogin();
                                k.Show();
                            }
                            else
                            {
                                MessageBox.Show("The password has been updated correctly", "Complete process", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MessageBox.Show("If you want to configure the rest of your own information you can do it when you log in, you should go to the personal configuration section", "In case you want to make other changes in your user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ConstructorConfiguracion.Validacion = "yes";
                                this.Hide();
                                frmLogin k = new frmLogin();
                                k.Show();
                            }
                           
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error su contraseña no pudo ser actualizada", "Error al completar el proceso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese la misma contraseña en los dos campos", "Escriba correctamente su contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public string Hash(byte[] val)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(val);
                return Convert.ToBase64String(hash);

            }
        } // Metodo de encriptacion     

        private void FrmCambiarContraseña_Load(object sender, EventArgs e)
        {
            lblusaurio.Text = "Bienvenido" + " " + Constructor_Login.usuario;
            
        }
        
        private void label4_Click_1(object sender, EventArgs e)
        {
            CambiarContraseña();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CambiarContraseña();
        }

        private void contraseña_TextChanged_1(object sender, EventArgs e)
        {
            byte[] passtohash = System.Text.Encoding.UTF8.GetBytes(contraseña.Text.ToString());
            txtEncriptado.Text = Hash(passtohash);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionSoloLetrasyNumeros(e);
            Validaciones.NoEspacios(e);
        }

        private void contraseña2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionSoloLetrasyNumeros(e);
            Validaciones.NoEspacios(e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picHide_Click(object sender, EventArgs e)
        {
            contraseña.UseSystemPasswordChar = true;
            contraseña2.UseSystemPasswordChar = true;
            picShow.Visible = true;
            picHide.Visible = false;
        }

        private void picShow_Click(object sender, EventArgs e)
        {
            contraseña.UseSystemPasswordChar = false;
            contraseña2.UseSystemPasswordChar = false;
            picShow.Visible = false;
            picHide.Visible = true;
        }
    }
}
