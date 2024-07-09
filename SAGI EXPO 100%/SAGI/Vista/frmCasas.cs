using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Modelo;
using WindowsFormsApplication1.Controlador;

namespace WindowsFormsApplication1.Interfaces
{
    public partial class frmCasas : Form
    {
        public frmCasas()
        {
            InitializeComponent();
            dgvCasa.DataSource = funciones_casa.Mostrar();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        void ComboBox()
        {

            try
            {
                if (funciones_casa.ObtenerEstadoCasa() != null)
                {
                    cmbEstado.DataSource = funciones_casa.ObtenerEstadoCasa();
                    cmbEstado.DisplayMember = "estado_casa";
                    cmbEstado.ValueMember = "id_estadoCasa";
                }

                if (funciones_casa.ObtenerDepartamento() != null)
                {
                    cmbDepartamento.DataSource = funciones_casa.ObtenerDepartamento();
                    cmbDepartamento.DisplayMember = "departamento_casa";
                    cmbDepartamento.ValueMember = "id_departamentoCasa";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCasas_Load(object sender, EventArgs e)
        {
            ComboBox();
        }

        private void txtMunicipio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCuartos_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dgvCasa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow fila = dgvCasa.Rows[e.RowIndex];
                txtID.Text = Convert.ToString(fila.Cells[0].Value);
                cmbEstado.Text = Convert.ToString(fila.Cells[1].Value);
                cmbDepartamento.Text = Convert.ToString(fila.Cells[2].Value);
                txtPrecio.Text = Convert.ToString(fila.Cells[3].Value);
                txtDIreccion.Text = Convert.ToString(fila.Cells[4].Value);
                txtGeneral.Text = Convert.ToString(fila.Cells[5].Value);
                txtMunicipio.Text = Convert.ToString(fila.Cells[6].Value);
                txtPisos.Text = Convert.ToString(fila.Cells[7].Value);
                txtCuartos.Text = Convert.ToString(fila.Cells[8].Value);
                txtBaños.Text = Convert.ToString(fila.Cells[9].Value);
                txtConstruccion.Text = Convert.ToString(fila.Cells[10].Value);
                txtArea.Text = Convert.ToString(fila.Cells[11].Value);
                btnGuardarBien.Enabled = false;
                btnEditar.Enabled = true;
                btnSuprimir.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LimpiarTodo()
        {
            txtID.Clear();
            txtPrecio.Clear();
            txtDIreccion.Clear();
            txtGeneral.Clear();
            txtMunicipio.Clear();
            txtPisos.Clear();
            txtCuartos.Clear();
            txtBaños.Clear();
            txtConstruccion.Clear();
            txtArea.Clear();
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            LimpiarTodo();
            btnGuardarBien.Enabled = true;
            btnEditar.Enabled = true;
            btnSuprimir.Enabled = true;
        }

        public void AgregarCasa()
        {
            try
            {
                if (txtPrecio.Text.Trim() == "" || txtDIreccion.Text.Trim() == "" || txtGeneral.Text.Trim() == "" || txtMunicipio.Text.Trim() == "" || txtPisos.Text.Trim() == "" || txtCuartos.Text.Trim() == "" || txtBaños.Text.Trim() == "" || txtConstruccion.Text.Trim() == "" || txtArea.Text.Trim() == "")
                {
                    MessageBox.Show("Complete todos los campos que se le solicitan", "Existen campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Constructor_casa agregar = new Constructor_casa();
                    agregar.estado = Convert.ToInt32(cmbEstado.SelectedValue);
                    agregar.departamento = Convert.ToInt32(cmbDepartamento.SelectedValue);
                    agregar.precio = Convert.ToInt32(txtPrecio.Text);
                    agregar.direccion = txtDIreccion.Text;
                    agregar.descripcion = txtGeneral.Text;
                    agregar.municipio = txtMunicipio.Text;
                    agregar.numero_pisos = Convert.ToInt32(txtPisos.Text);
                    agregar.numero_baños = Convert.ToInt32(txtBaños.Text);
                    agregar.numero_cuartos = Convert.ToInt32(txtCuartos.Text);
                    agregar.area_casa = Convert.ToDecimal(txtConstruccion.Text);
                    agregar.area_terreno = Convert.ToDecimal(txtArea.Text);                    
                    int datos = funciones_casa.Agregar(agregar);
                    dgvCasa.DataSource = funciones_casa.Mostrar();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnGuardarBien_Click(object sender, EventArgs e)
        {
            AgregarCasa();
            LimpiarTodo();
        }

        public void ActualizarCasa()
        {

            try
            {
                if (txtPrecio.Text.Trim() == "" || txtDIreccion.Text.Trim() == "" || txtGeneral.Text.Trim() == "" || txtMunicipio.Text.Trim() == "" || txtPisos.Text.Trim() == "" || txtCuartos.Text.Trim() == "" || txtBaños.Text.Trim() == "" || txtConstruccion.Text.Trim() == "" || txtArea.Text.Trim() == "")
                {
                    MessageBox.Show("No se han seleccionado registros", "Existen campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Seguro de actualizar datos", "Mensaje de advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Constructor_casa actualizar = new Constructor_casa();
                        actualizar.id_casa = Convert.ToInt16(txtID.Text);
                        actualizar.estado = Convert.ToInt32(cmbEstado.SelectedValue);
                        actualizar.departamento = Convert.ToInt32(cmbDepartamento.SelectedValue);
                        actualizar.precio = Convert.ToInt32(txtPrecio.Text);
                        actualizar.direccion = txtDIreccion.Text;
                        actualizar.descripcion = txtGeneral.Text;
                        actualizar.municipio = txtMunicipio.Text;
                        actualizar.numero_pisos = Convert.ToInt32(txtPisos.Text);
                        actualizar.numero_baños = Convert.ToInt32(txtBaños.Text);
                        actualizar.numero_cuartos = Convert.ToInt32(txtCuartos.Text);
                        actualizar.area_casa = Convert.ToDecimal(txtConstruccion.Text);
                        actualizar.area_terreno = Convert.ToDecimal(txtArea.Text);
                        int datos = funciones_casa.Actualizar(actualizar);
                        dgvCasa.DataSource = funciones_casa.Mostrar();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarCasa();
            LimpiarTodo();
            btnGuardarBien.Enabled = true;
            btnSuprimir.Enabled = false;
            btnEditar.Enabled = false;
        }

        public void Eliminar()
        {
            try
            {
                if (txtPrecio.Text.Trim() == "" || txtDIreccion.Text.Trim() == "" || txtGeneral.Text.Trim() == "" || txtMunicipio.Text.Trim() == "" || txtPisos.Text.Trim() == "" || txtCuartos.Text.Trim() == "" || txtBaños.Text.Trim() == "" || txtConstruccion.Text.Trim() == "" || txtArea.Text.Trim() == "")
                {
                    MessageBox.Show("No se ha seleccionado registro", "Mensaje de advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("Seguro de eliminar registro", "Mensaje de advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        Constructor_casa eliminar = new Constructor_casa();
                        eliminar.id_casa = Convert.ToInt16(txtID.Text);
                        funciones_casa.Eliminar(eliminar);
                        dgvCasa.DataSource = funciones_casa.Mostrar();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuprimir_Click(object sender, EventArgs e)
        {
            Eliminar();
            LimpiarTodo();
            btnGuardarBien.Enabled = true;
            btnSuprimir.Enabled = false;
            btnEditar.Enabled = false;
        }
    }
}
