using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Controlador.Constructores;
using WindowsFormsApplication1.Modelo;
using WindowsFormsApplication1.Modelo.Funciones_CRUD;
using WindowsFormsApplication1.Vista.LOGIN;

namespace WindowsFormsApplication1.Interfaces
{
    public partial class Recuperación_correo : Form
    {
        public Recuperación_correo()
        {
            InitializeComponent();
            txtUsuario.ContextMenu = new ContextMenu();
            txtCorreo.ContextMenu = new ContextMenu();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin log = new frmLogin();
            log.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciaSesion_Click(object sender, EventArgs e)
        {
            if (txtCorreo.Text.Trim() == "")
            {
                MessageBox.Show("campos vacios", "Llene los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Constructor_Recuperaciones cons = new Constructor_Recuperaciones();
                cons.cod = txtCorreo.Text;
                bool datos = ValidarRecuperacion.validarcod(cons);
                if (datos == true)
                {
                    txtCorreo.Clear();
                    Form f = new FrmCambiarContraseña();
                    f.Show();
                    this.Hide();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text.Trim() == "")
                {
                    MessageBox.Show("Complete el campo de usuario", "Llene los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        Constructor_Recuperaciones.Usuario = txtUsuario.Text;
                        ValidarRecuperacion.ConseguirCorreoEmpresa();

                        Recovery user = new Recovery();
                        var result = user.recovery(txtUsuario.Text);
                        if (Constructor_Recuperaciones.verificarcorreo == "se envio el mensaje")
                        {
                            txtCorreo.Enabled = true;
                            btnIniciaSesion.Enabled = true;
                            txtUsuario.Enabled = false;
                            button1.Enabled = false;
                        }                      
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Error al embiar el correo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al embiar el correo electronico");
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionSoloLetrasyNumeros(e);
            Validaciones.NoEspacios(e);
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

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionSoloLetrasyNumeros(e);
            Validaciones.NoEspacios(e);
        }

        private void Recuperación_correo_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button1, "Enviar codigo de verificacion al correo del usuario");
            toolTip2.SetToolTip(btnIniciaSesion , "Confirmar si el codigo ingresado es correcto");
        }
    }
}
