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

namespace WindowsFormsApplication1.Vista
{
    public partial class Primer_uso2 : Form
    {
        public Primer_uso2()
        {

            InitializeComponent();
            Thread f = new Thread(new ThreadStart(StartForm));
            f.Start();
            Thread.Sleep(3000);
            f.Abort();
        }

        public void StartForm()
        {
            Application.Run(new Splashscreen());

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
            try
            {
                ConstructorNuevoUsuario agregar = new ConstructorNuevoUsuario();
                agregar.nombre = txtNombre.Text;
                agregar.apellido = txtApellido.Text;
                agregar.correo = txtCorreo.Text;
                agregar.direccion = txtDireccion.Text;
                agregar.nacimiento = dtpEmpleado.Text;
                agregar.usuario = txtUsuario.Text;
                agregar.contraseña = txtEncriptado.Text;
                agregar.profesion = txtProfesion.Text;
                agregar.estado = Convert.ToInt32(cmbEstado.SelectedValue);
                agregar.tipo_usuario = Convert.ToInt32(cmbTipoUsuario.SelectedValue);
                agregar.genero = Convert.ToInt32(cmbGenero.SelectedValue);
                int datos = PrimerUso.NuevoUsuario(agregar);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error al obtener los tipos de usuario", "Error critico de conexion");
                throw;
            }
        }
   
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim()=="" || txtApellido.Text.Trim()==""|| txtContraseña.Text.Trim()==""|| txtCorreo.Text.Trim()==""|| txtDireccion.Text.Trim()==""||txtProfesion.Text.Trim()==""||txtUsuario.Text.Trim()=="")
            {
                MessageBox.Show("Complete todos los campos solicitados","Campos vacios",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {              
                    AgregarUsuario();             
                    Primer_uso kk = new Primer_uso();
                    kk.Visible = true;
                    this.Hide();                                                  
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Primer_uso2_Load(object sender, EventArgs e)
        {
            CompletarComboBox();
        }

        public void CompletarComboBox()
        {
            if (PrimerUso.ObtenerEstado() != null)
            {
                cmbEstado.DataSource = PrimerUso.ObtenerEstado();
                cmbEstado.DisplayMember = "estado_usuario";
                cmbEstado.ValueMember = "id_estado";
            }

            if (PrimerUso.ObtenerGenero() != null)
            {
                cmbGenero.DataSource = PrimerUso.ObtenerGenero();
                cmbGenero.DisplayMember = "genero_empl";
                cmbGenero.ValueMember = "id_generoEmpl";
            }

            if (PrimerUso.ObtenerTipoUsuario() != null)
            {
                cmbTipoUsuario.DataSource = PrimerUso.ObtenerTipoUsuario();
                cmbTipoUsuario.DisplayMember = "tipo_usuario";
                cmbTipoUsuario.ValueMember = "id_tipoUsuario";
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
                {
                    e.Handled = true;
                }

                else

                {
                    e.Handled = false;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error Critico.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
                {
                    e.Handled = true;
                }

                else

                {
                    e.Handled = false;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error Critico.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtProfesion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
                {
                    e.Handled = true;
                }

                else

                {
                    e.Handled = false;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error Critico.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }          
}
   


