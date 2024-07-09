using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Controlador;
using WindowsFormsApplication1.Controlador.Constructores;
using WindowsFormsApplication1.Modelo.Funciones_CRUD;
using WindowsFormsApplication1.Modelo.Funciones_Primer_Uso;

namespace WindowsFormsApplication1.Vista.CRUD
{
    public partial class frmEmpresa : Form
    {
        //CRUD BY CASTROLL


        public static int espanol = 0;
        public static int ingles = 1;
        public frmEmpresa()
        {
            InitializeComponent();
            txtNit.ContextMenu = new ContextMenu();                    
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

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            try
            {
                txtlogo.Clear();
                AbrirImagen.Filter = "Archivo de Imagen (.jpg) |*.jpg | Archivo de Imagen (.png) |*.png| Archivo de Imagen (.jpeg) |*.jpge| Todos los Archivos|*.*";
                DialogResult resultado = AbrirImagen.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    pbLogo.Image = Image.FromFile(AbrirImagen.FileName);
                    MemoryStream ms = new MemoryStream();
                    pbLogo.Image.Save(ms, ImageFormat.Jpeg);
                    byte[] aByte = ms.ToArray();
                    string enconded = Convert.ToBase64String(aByte);
                    txtlogo.Text= enconded;
                }
            }
            catch (Exception)
            {
                if (espanol == 0)
                {
                    MessageBox.Show("Error al ingresar la imagen", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error to upload the image", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDireccion.Text.Trim() == "" || txtEmpresa.Text.Trim() == "" || txtNit.Text.Trim() == "" || txtRepresentante.Text.Trim() == "")
            {
                if (espanol == 0)
                {
                    MessageBox.Show("No se pueden guardar los cambios debido a que no todos los campos del formulario han sido completados", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Changes cannot be saved because not all form fields have been completed.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                
            }
            else if(txtlogo.Text.Trim() == "")
            {
                if (espanol == 0)
                {
                    MessageBox.Show("No image selected", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                ValidarCorreoAgregar();
            }
        }

        void mostrar()
        {
            dgvEmpresa.DataSource = funcionesEmpresa.Mostrar();
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        void TipoEmpresa()
        {
            cmbTipoEmpresa.DataSource = funcionesEmpresa.ObtenerTipo_Empresa();
            cmbTipoEmpresa.DisplayMember = "tipo_empresa";
            cmbTipoEmpresa.ValueMember = "id_tipo_empresa";
        }

        public Image TextoaImagen(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0,
            imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            pbLogo.Image = Image.FromStream(ms);
            return image;

        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            TipoEmpresa();
            mostrar();            
            this.dgvEmpresa.Columns[0].Visible = false;
            this.dgvEmpresa.Columns[6].Visible = false;
            toolTip1.SetToolTip(btnExaminar, "Presione click o enter para seleccionar la imagen de su empresa");
            toolTip2.SetToolTip(btnMostrar, "Borrar todos los campos y habilitar la opcion de agregar");
        }

        private void dgvEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.dgvEmpresa.Columns[0].Visible = false;
                DataGridViewRow fila = dgvEmpresa.Rows[e.RowIndex];
                txtId.Text = Convert.ToString(fila.Cells[0].Value);
                txtEmpresa.Text = Convert.ToString(fila.Cells[1].Value);
                txtNit.Text = Convert.ToString(fila.Cells[2].Value);
                txtRepresentante.Text = Convert.ToString(fila.Cells[3].Value);
                cmbTipoEmpresa.Text = Convert.ToString(fila.Cells[4].Value);
                txtDireccion.Text = Convert.ToString(fila.Cells[5].Value);
                txtlogo.Text = Convert.ToString(fila.Cells[6].Value);
                txtCorreo.Text = Convert.ToString(fila.Cells[7].Value);
                btnGuardar.Enabled = false;
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
                if (txtlogo.Text == "")
                {

                }
                else
                {
                    TextoaImagen(txtlogo.Text);
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtDireccion.Text.Trim() == "" || txtEmpresa.Text.Trim() == "" || txtNit.Text.Trim() == "" || txtRepresentante.Text.Trim() == "")
            {
                if (espanol == 0)
                {
                    MessageBox.Show("No se pueden guardar los cambios debido a que no todos los campos del formulario han sido completados", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Changes cannot be saved because not all form fields have been completed.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                
            }
            else
            {
                ValidarCorreoActualizar();
            }
        }

        public void Limpiar()
        {
            txtId.Clear();
            txtDireccion.Clear();
            txtEmpresa.Clear();
            txtlogo.Clear();
            txtNit.Clear();
            txtRepresentante.Clear();
            txtCorreo.Clear();
            btnGuardar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDireccion.Text.Trim() == "" || txtEmpresa.Text.Trim() == "" || txtNit.Text.Trim() == "" || txtRepresentante.Text.Trim() == "")
                {
                    if (espanol == 0)
                    {
                        MessageBox.Show("Seleccione registro", "Existen campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Select any register", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                else
                {
                    if (MessageBox.Show("Seguro de eliminar datos", "Mensaje de advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Constructor_Empresa.ID_empresa = Convert.ToInt32(txtId.Text);
                        int datos = funcionesEmpresa.Eliminar();
                        mostrar();
                        Limpiar();
                        btnGuardar.Enabled = true;
                        btnActualizar.Enabled = false;
                        btnEliminar.Enabled = false;
                    }
                }
            }
            catch (Exception)
            {
                if (espanol == 0)
                {
                    MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("An unexpected error has occurred", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

               
            }
        }

        private void txtNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionSoloLetrasyNumeros(e);
            Validaciones.SolamenteNumerosEnteros(e);
        }

        private void txtEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteLetras(e);
        }

        private void txtRepresentante_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteLetras(e);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteLetras(e);
        }

        private void txtNit_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            Validaciones.NoEspacios(e);
        }

        void ValidarCorreoAgregar()
        {
            if (txtCorreo.Text.Contains("@gmail.com"))
            {
                if (espanol == 0)
                {
                    if (MessageBox.Show("Esta seguro que desea ingresar la direccion de correo electronico" + " " + txtCorreo.Text, "Verifique su correo electronico", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Constructor_Empresa che = new Constructor_Empresa();
                        che.id_tipo_empresa = Convert.ToInt16(cmbTipoEmpresa.SelectedValue);
                        che.Nombre_Empresa = txtEmpresa.Text;
                        che.direccion = txtDireccion.Text;
                        che.nit = txtNit.Text;
                        che.representante = txtRepresentante.Text;
                        Constructor_Empresa.correoEmpresarial = txtCorreo.Text;
                        MemoryStream ms = new MemoryStream();
                        pbLogo.Image.Save(ms, ImageFormat.Jpeg);
                        byte[] aByte = ms.ToArray();
                        string enconded = Convert.ToBase64String(aByte);
                        txtlogo.Text = enconded;
                        che.imagen = txtlogo.Text;
                        int datos = funcionesEmpresa.AgregarEmpresa(che);
                        Limpiar();
                        btnGuardar.Enabled = true;
                        btnActualizar.Enabled = false;
                        btnEliminar.Enabled = false;
                        mostrar();
                    }
                    else
                    {
                        if (MessageBox.Show("Are you sure you wanto to user this email?" + " " + txtCorreo.Text, "Verify your email", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            Constructor_Empresa che = new Constructor_Empresa();
                            che.id_tipo_empresa = Convert.ToInt16(cmbTipoEmpresa.SelectedValue);
                            che.Nombre_Empresa = txtEmpresa.Text;
                            che.direccion = txtDireccion.Text;
                            che.nit = txtNit.Text;
                            che.representante = txtRepresentante.Text;
                            Constructor_Empresa.correoEmpresarial = txtCorreo.Text;
                            MemoryStream ms = new MemoryStream();
                            pbLogo.Image.Save(ms, ImageFormat.Jpeg);
                            byte[] aByte = ms.ToArray();
                            string enconded = Convert.ToBase64String(aByte);
                            txtlogo.Text = enconded;
                            che.imagen = txtlogo.Text;
                            int datos = funcionesEmpresa.AgregarEmpresa(che);
                            Limpiar();
                            btnGuardar.Enabled = true;
                            btnActualizar.Enabled = false;
                            btnEliminar.Enabled = false;
                            mostrar();
                        }
                    }
                }
               
            }
            else
            {
                if (espanol == 0)
                {
                    MessageBox.Show("El correo ingresado debe ser tipo @gmail.com", "Cambie la direccion de correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The email entered must be type @ gmail.com", "Change the email address", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }

        void ValidarCorreoActualizar()
        {
            if (txtCorreo.Text.Contains("@gmail.com"))
            {
                if (espanol == 0)
                {
                    if (MessageBox.Show("Esta seguro que desea ingresar la direccion de correo electronico" + " " + txtCorreo.Text, "Verifique su correo electronico", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Constructor_Empresa che = new Constructor_Empresa();
                        che.id_tipo_empresa = Convert.ToInt16(cmbTipoEmpresa.SelectedValue);
                        che.Nombre_Empresa = txtEmpresa.Text;
                        che.direccion = txtDireccion.Text;
                        che.nit = txtNit.Text;
                        che.representante = txtRepresentante.Text;
                        che.imagen = txtlogo.Text;
                        Constructor_Empresa.correoEmpresarial = txtCorreo.Text;
                        Constructor_Empresa.ID_empresa = Convert.ToInt16(txtId.Text);
                        funcionesEmpresa.ActualizarEmpresa(che);
                        Limpiar();
                        btnGuardar.Enabled = true;
                        btnActualizar.Enabled = false;
                        btnEliminar.Enabled = false;
                        mostrar();
                    }
                    else
                    {
                        if (MessageBox.Show("Are yousure you want to use this email?" + " " + txtCorreo.Text, "Check your email", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            Constructor_Empresa che = new Constructor_Empresa();
                            che.id_tipo_empresa = Convert.ToInt16(cmbTipoEmpresa.SelectedValue);
                            che.Nombre_Empresa = txtEmpresa.Text;
                            che.direccion = txtDireccion.Text;
                            che.nit = txtNit.Text;
                            che.representante = txtRepresentante.Text;
                            che.imagen = txtlogo.Text;
                            Constructor_Empresa.correoEmpresarial = txtCorreo.Text;
                            Constructor_Empresa.ID_empresa = Convert.ToInt16(txtId.Text);
                            funcionesEmpresa.ActualizarEmpresa(che);
                            Limpiar();
                            btnGuardar.Enabled = true;
                            btnActualizar.Enabled = false;
                            btnEliminar.Enabled = false;
                            mostrar();
                        }
                    }
                }
                
            }
            else
            {
                if (espanol == 0)
                {
                    MessageBox.Show("El correo ingresado debe ser tipo @gmail.com", "Cambie la direccion de correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The email entered must be type @ gmail.com", "Change the email address", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
               
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
    }
}
