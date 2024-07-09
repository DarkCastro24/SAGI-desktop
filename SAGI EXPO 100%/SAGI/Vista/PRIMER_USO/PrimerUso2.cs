using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WindowsFormsApplication1.Controlador;
using WindowsFormsApplication1.Modelo.Funciones_Primer_Uso;
using WindowsFormsApplication1.Modelo;
using System.Security.Cryptography;
using WindowsFormsApplication1.Controlador.Constructores;
using WindowsFormsApplication1.Vista.PRIMER_USO;
using WindowsFormsApplication1.Modelo.Funciones_CRUD;

namespace WindowsFormsApplication1.Vista
{
    public partial class PrimerUsoSeguridad : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);

        public PrimerUsoSeguridad()
        {
            InitializeComponent();
            Codigo.ContextMenu = new ContextMenu();
        }

        void CompletarCombobox()
        {            
                cmbpregunta1.DataSource = ValidarRecuperacion.ObtenerTodasLasPreguntas();
                cmbpregunta1.DisplayMember = "preguntas";
                cmbpregunta1.ValueMember = "id_pregunta";

                cmbpregunta2.DataSource = ValidarRecuperacion.ObtenerTodasLasPreguntas();
                cmbpregunta2.DisplayMember = "preguntas";
                cmbpregunta2.ValueMember = "id_pregunta";

                cmbpregunta3.DataSource = ValidarRecuperacion.ObtenerTodasLasPreguntas();
                cmbpregunta3.DisplayMember = "preguntas";
                cmbpregunta3.ValueMember = "id_pregunta";                                             
        }

        void ValidarPreguntas()
        {
            if (cmbpregunta1.Text == cmbpregunta2.Text || cmbpregunta1.Text == cmbpregunta3.Text || cmbpregunta2.Text == cmbpregunta3.Text)
            {
                MessageBox.Show("Debe seleccionar preguntas diferentes para poder continuar", "Preguntas Repetidas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Pregunta1.Text.Trim() == "" || Pregunta2.Text.Trim() == "" || Pregunta3.Text.Trim() == "")
                {
                    MessageBox.Show("Complete todos los campos que se le solicitan", "Existen Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    if (Codigo.Text.Trim() == "")
                    {
                        MessageBox.Show("No puede dejar el codigo de seguridad vacio", "Existen Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else if (Codigo.Text != label9.Text)
                    {
                        MessageBox.Show("No coinciden el codigo generado", "Existen Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        IngresarDatos();
                    }
                }

            }
        }

        void IngresarDatos()
        {           
              if (MessageBox.Show("¿Ya anoto o guardo su cúdigo de seguridad?", "¿Esta seguro que desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
              {
                   string usuario = Constructor_Recuperaciones.Usuario;
                   Constructor_Recuperaciones add = new Constructor_Recuperaciones();
                   add.codigo_correo = Convert.ToInt32(Codigo.Text);
                   Constructor_Recuperaciones.pregunta1 = Convert.ToInt16(cmbpregunta1.SelectedValue);
                   Constructor_Recuperaciones.pregunta2 = Convert.ToInt16(cmbpregunta2.SelectedValue);
                   Constructor_Recuperaciones.pregunta3 = Convert.ToInt16(cmbpregunta3.SelectedValue);
                   add.respuesta1 = txtEncriptacion3.Text;
                   add.respuesta2 = txtEncriptacion2.Text;
                   add.respuesta3 = txtEncriptacion1.Text;
                   int datos = FuncionesPrimerUso.IngresarDatos(add);

                   if (datos >= 1)
                   {
                       this.Hide();
                       frmLogin che = new frmLogin();
                       che.Show();
                   }
                   else
                   {
                      MessageBox.Show("ERROR AL INGRESAR DATOS");
                   }           
              }
              else
              {
                 MessageBox.Show("Ingrese el código de seguridad correctamente", "Código incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
         }
                                
        private void PrimerUsoSeguridad_Load(object sender, EventArgs e) // Generar el codigo de seguridad
        {
            Random codigo = new Random();
            int generar = codigo.Next(10000000, 99999999);
            label9.Text = generar.ToString();
            toolTip1.SetToolTip(label9, "Codigo de seguridad");
            toolTip2.SetToolTip(Codigo, "Escriba el codigo de seguridad");
            CompletarCombobox();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir de la aplicacion", "¿Seguro que desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
            

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        } //Movimiento de panel

        private void button1_Click_1(object sender, EventArgs e)
        {
            ValidarPreguntas();
        }

        private void Pregunta3_TextChanged_1(object sender, EventArgs e)
        {
            string che = Pregunta3.Text;
            string encriptado = Seguridad.Encriptar(che);
            txtEncriptacion1.Text = encriptado;
        }

        private void Pregunta2_TextChanged_1(object sender, EventArgs e)
        {
            string che = Pregunta2.Text;
            string encriptado = Seguridad.Encriptar(che);
            txtEncriptacion2.Text = encriptado;
        }

        private void Pregunta1_TextChanged_1(object sender, EventArgs e)
        {
            string che = Pregunta1.Text;
            string encriptado = Seguridad.Encriptar(che);
            txtEncriptacion3.Text = encriptado;
        }

        private void grpUsuario_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteNumerosEnteros(e);
        }

        private void Pregunta1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteLetras(e);
        }

        private void Pregunta2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteLetras(e);
        }

        private void Pregunta3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteLetras(e);
        }
    }
}
