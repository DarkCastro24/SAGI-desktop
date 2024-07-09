using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WindowsFormsApplication1.Interfaces;
using WindowsFormsApplication1.Controlador;
using WindowsFormsApplication1.Modelo;

namespace WindowsFormsApplication1
{
    public partial class frmRecuperarContraseña : Form
    {
        public frmRecuperarContraseña()
        {
            InitializeComponent();
        }
        

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);
        private void grpAdmin_Enter(object sender, EventArgs e)
        {

        }

        private void txtUsuarioAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();
            log.Show();
            this.Hide();
        }

        private void toolSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void toolMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void ConcederAcceso()
        {
            if (ConstructorRecuperarConstraseña.nivel <= 2)

            {
                MessageBox.Show("Acceso concedido exitosamente", "Acceso correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grpUsuario.Enabled = true;
                txtContraseñaRecuperar.Enabled = false;
                BtnCambiarContraseña.Enabled = false;
                txtClaveAdmin.Visible = false;
                txtUsuarioAdmin.Visible = false;
                grpAdmin.Enabled = false;

            }

            else
            {
                MessageBox.Show("El usuario ingresado no es un Administrador", "Error al conceder permisos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void validarAcceso()
        {
            if (txtUsuarioAdmin.Text.Trim() == "" || txtClaveAdmin.Text.Trim() == "")
            {
                MessageBox.Show("Existen campos vacios", "Complete los campos solicitados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else

            {

                ConstructorRecuperarConstraseña rec = new ConstructorRecuperarConstraseña(txtUsuarioAdmin.Text, txtClaveAdmin.Text);
                ConstructorRecuperarConstraseña.usuario = txtUsuarioAdmin.Text;
                rec.clave = txtClaveAdmin.Text;
                bool datos = ValidarRecuperacion.ValidarUsuario(rec);

                if (datos == true)
                {
                    ConcederAcceso();
                    
                }
            }
        }

        private void BtnPemitir_Click(object sender, EventArgs e)
        {
            validarAcceso();
        }
       
 
        private void Validacion()
        {
            if (ConstructorNuevaContraseña.nivel <= 2)

            {
                MessageBox.Show("No puedes recuperar un usuario Administrador / Root", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Ingrese la nueva contraseña", "Usuario encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnValidar.Enabled = false;
                BtnCambiarContraseña.Enabled = true;
                txtContraseñaRecuperar.Enabled = true;
                txtUsuarioRecuperar.Enabled = false;
            }
        }

        void validarUsuario()
        {
            if (txtUsuarioRecuperar.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el usuario que desea recuperar", "Complete el campo solicitado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else

            {

                ConstructorNuevaContraseña validar = new ConstructorNuevaContraseña(txtUsuarioRecuperar.Text);
                ConstructorNuevaContraseña.usuario = txtUsuarioRecuperar.Text;
                bool datos = ValidarRecuperacion.Validar(validar);

                if (datos == true)
                {
                    Validacion();
                }

                else
                {
                    MessageBox.Show("No se puede conceder permisos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        void CambiarContraseña()
        {
            if (txtContraseñaRecuperar.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese la nueva contraseña", "Complete el campo solicitado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else

            {

                ConstructorContraseña contrasena = new ConstructorContraseña(txtContraseñaRecuperar.Text, txtUsuarioRecuperar.Text);
                ConstructorContraseña.usuario = txtUsuarioRecuperar.Text;
                contrasena.clave = txtContraseñaRecuperar.Text;
                bool datos = ValidarRecuperacion.contraseña(contrasena);

                if (datos == true)
                {
                    MessageBox.Show("Contraseña actualizada exitosamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmLogin kk = new frmLogin();
                    kk.Show();
                    this.Hide();
                  
                }

                else
                {
                    MessageBox.Show("No se puede conceder permisos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void BtnValidar_Click(object sender, EventArgs e)
        {
            validarUsuario();
        }

        private void BtnCambiarContraseña_Click(object sender, EventArgs e)
        {
            CambiarContraseña();
        }

        private void frmRecuperarContraseña_Load(object sender, EventArgs e)
        {

        }
    }
}
