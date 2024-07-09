using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Controlador;
using WindowsFormsApplication1.Modelo;
using WindowsFormsApplication1.Modelo.Funciones_Primer_Uso;
using System.IO;
using System.Drawing.Imaging;
using WindowsFormsApplication1.Modelo.Funciones_CRUD;
using WindowsFormsApplication1.Controlador.Constructores;

namespace WindowsFormsApplication1.Vista
{
    public partial class Primer_uso : Form
    {
        public Primer_uso()
        {
            InitializeComponent();
            txtNit.ContextMenu = new ContextMenu();
            toolTip1.SetToolTip(btnExaminar , "Click o enter para ingresar el logo de su empresa");
            toolTip2.SetToolTip(btnGuardar , "Guardar datos y continuar");

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
      
        private void Primer_uso_Load(object sender, EventArgs e)
        {
            if (FuncionesPrimerUso.ObtenerTipo_Empresa() != null)
            {
                cmbTipoEmpresa.DataSource = FuncionesPrimerUso.ObtenerTipo_Empresa();
                cmbTipoEmpresa.DisplayMember = "tipo_empresa";
                cmbTipoEmpresa.ValueMember = "id_tipo_empresa";
            }
        }

        private void btnExaminar_Click_1(object sender, EventArgs e)
        {
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
                    txtImagen.Text= enconded;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al ingresar la imagen", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (txtDireccion.Text.Trim() == "" || txtEmpresa.Text.Trim() == "" || txtNit.Text.Trim() == "" || txtRepresentante.Text.Trim() == "" || pbLogo.Image == null)
            {
                MessageBox.Show("No se pueden guardar los cambios debido a que no todos los campos del formulario han sido completados", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                label22.Visible = true;
                label17.Visible = true;
            }
            else
            {
                if (MessageBox.Show("La direccion de correo electronico que a ingresado es" + " " + txtCorreoEmpresa.Text + " " + "ese correo se utilizara para el sistema","Seguro que desea continuar",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
                {
                    ValidarCorreo();
                }                  
            }                          
        }

        void ValidarCorreo()
        {
            if (txtCorreoEmpresa.Text.Contains("@gmail.com"))
            {
                if (MessageBox.Show("Esta seguro que desea ingresar la direccion de correo electronico" + " " + txtCorreoEmpresa.Text + " " + "Verifique si es su direccion de correo correcta si no es el caso presione el boton No y cambie su correo", "Verifique su correo electronico", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Constructor_Empresa che = new Constructor_Empresa();
                    che.id_tipo_empresa = Convert.ToInt16(cmbTipoEmpresa.SelectedValue);
                    che.Nombre_Empresa = txtEmpresa.Text;
                    che.direccion = txtDireccion.Text;
                    che.nit = txtNit.Text;
                    che.representante = txtRepresentante.Text;
                    che.imagen = txtImagen.Text;
                    Constructor_Empresa.correoEmpresarial = txtCorreoEmpresa.Text;
                    Constructor_Empresa.clavecorreo = txtClaveCorreo.Text;
                    int datos = FuncionesPrimerUso.AgregarEmpresa(che);
                    if (datos >= 1)
                    {
                        MessageBox.Show("Hemos finalizado con el registro de la empresa, a continuación se mostrará el formulario de primer usuario para que ingreses tus datos y crees tu usuario", "Proceso completado 1/2", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Primer_uso2 che2 = new Primer_uso2();
                        this.Hide();
                        che2.Show();
                    }
                    else
                    {
                        MessageBox.Show("La empresa no pudo ser ingresada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("El correo ingresado debe ser tipo @gmail.com", "Cambie la direccion de correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteNumerosEnteros(e);
        }

        private void txtnit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                MessageBox.Show("No puede copiar datos en este campo", "Copy Paste", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNit.Clear();
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

        private void txtNit_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ValidacionSoloLetrasyNumeros(e);
        }

        private void cmbTipoEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreoEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCorreoEmpresa.Text.Contains("@gmail.com"))
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

        private void txtCorreoEmpresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteLetras(e);
        }

        private void txtRepresentante_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteLetras(e);
        }
    }
}
