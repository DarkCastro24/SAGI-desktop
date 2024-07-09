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

namespace WindowsFormsApplication1
{
    public partial class frmExpCliente : Form
    {
        public frmExpCliente()
        {
            InitializeComponent();
            dgvUsuarios.DataSource = funciones_cliente.Mostrar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuSeparator3_Load(object sender, EventArgs e)
        {

        }

        private void frmExpCliente_Load(object sender, EventArgs e)
        {
            ComboBox();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        public void AgregarClientes()
        {
            try
            {
                if (txtNombre.Text.Trim() == "" || txtApellido.Text.Trim() == "" || txtCorreo.Text.Trim() == "" || txtDireccion.Text.Trim() == "" || txtDUI.Text.Trim() == "" || cmbEstado.Text.Trim() == "" || cmbEstadoCivil.Text.Trim() == "" || cmbGenero.Text.Trim() == "" || cmbtipocliente.Text.Trim() == "" ||
                txtTelefono.Text.Trim() == "")
                {
                    MessageBox.Show("Complete todos los campos que se le solicitan", "Existen campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ConstructorExpedienteCliente agregar = new ConstructorExpedienteCliente();
                    agregar.apellidos = txtApellido.Text;
                    agregar.correo = txtCorreo.Text;
                    agregar.direccion = txtDireccion.Text;
                    agregar.dui = txtDUI.Text;
                    agregar.estado = Convert.ToString(cmbEstado.SelectedValue);
                    agregar.EstadoCivil = Convert.ToString(cmbEstadoCivil.SelectedValue);
                    agregar.genero = Convert.ToString(cmbGenero.SelectedValue);
                    agregar.Nacimiento = dtpNacimiento.Text;
                    agregar.nombres = txtNombre.Text;
                    agregar.tipoCliente = Convert.ToString(cmbtipocliente.SelectedValue);
                    agregar.telefono = txtTelefono.Text;
                    int datos = funciones_cliente.Agregar(agregar);
                    dgvUsuarios.DataSource = funciones_cliente.Mostrar();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void ComboBox()
        {

            try
            {
                if (funciones_cliente.ObtenerEstado() != null)
                {
                    cmbEstado.DataSource = funciones_cliente.ObtenerEstado();
                    cmbEstado.DisplayMember = "estado_cliente";
                    cmbEstado.ValueMember = "id_estado";
                }

                if (funciones_cliente.ObtenerEstadoCivil() != null)
                {
                    cmbEstadoCivil.DataSource = funciones_cliente.ObtenerEstadoCivil();
                    cmbEstadoCivil.DisplayMember = "estado_civil";
                    cmbEstadoCivil.ValueMember = "id_estadoCivil";
                }

                if (funciones_cliente.ObtenerGenero() != null)
                {
                    cmbGenero.DataSource = funciones_cliente.ObtenerGenero();
                    cmbGenero.DisplayMember = "genero_cliente";
                    cmbGenero.ValueMember = "id_generoClien";
                }

                if (funciones_cliente.ObtenerTipoCliente() != null)
                {
                    cmbtipocliente.DataSource = funciones_cliente.ObtenerTipoCliente();
                    cmbtipocliente.DisplayMember = "tipo_cliente";
                    cmbtipocliente.ValueMember = "id_tipoCliente";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardarBien_Click(object sender, EventArgs e)
        {
            AgregarClientes();
            LimpiarTodo();
        }

        public void ActualizarCliente()
        {

            try
            {
                if (txtNombre.Text.Trim() == "" || txtApellido.Text.Trim() == "" || txtCorreo.Text.Trim() == "" || txtDireccion.Text.Trim() == "" || txtDUI.Text.Trim() == "" || cmbEstado.Text.Trim() == "" || cmbEstadoCivil.Text.Trim() == "" || cmbGenero.Text.Trim() == "" || cmbtipocliente.Text.Trim() == "" ||
                txtTelefono.Text.Trim() == "")
                {
                    MessageBox.Show("No se han seleccionado registros", "Existen campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Seguro de actualizar datos", "Mensaje de advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        ConstructorExpedienteCliente actualizar = new ConstructorExpedienteCliente();
                        actualizar.Id = Convert.ToInt16(txtId.Text);
                        actualizar.apellidos = txtApellido.Text;
                        actualizar.correo = txtCorreo.Text;
                        actualizar.direccion = txtDireccion.Text;
                        actualizar.dui = txtDUI.Text;
                        actualizar.estado = Convert.ToString(cmbEstado.SelectedValue);
                        actualizar.EstadoCivil = Convert.ToString(cmbEstadoCivil.SelectedValue);
                        actualizar.genero = Convert.ToString(cmbGenero.SelectedValue);
                        actualizar.Nacimiento = dtpNacimiento.Text;
                        actualizar.nombres = txtNombre.Text;
                        actualizar.tipoCliente = Convert.ToString(cmbtipocliente.SelectedValue);
                        actualizar.telefono = txtTelefono.Text;
                        int datos = funciones_cliente.Actualizar(actualizar);
                        dgvUsuarios.DataSource = funciones_cliente.Mostrar();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Eliminar()
        {
            try
            {
                if (txtNombre.Text.Trim() == "" || txtApellido.Text.Trim() == "" || txtCorreo.Text.Trim() == "" || txtDireccion.Text.Trim() == "" || txtDUI.Text.Trim() == "" || cmbEstado.Text.Trim() == "" || cmbEstadoCivil.Text.Trim() == "" || cmbGenero.Text.Trim() == "" || cmbtipocliente.Text.Trim() == "" ||
                txtTelefono.Text.Trim() == "")
                {
                    MessageBox.Show("No se ha seleccionado registro", "Mensaje de advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("Seguro de eliminar registro", "Mensaje de advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        ConstructorExpedienteCliente eliminar = new ConstructorExpedienteCliente();
                        eliminar.Id = Convert.ToInt32(txtId.Text);
                        funciones_cliente.Eliminar(eliminar);
                        dgvUsuarios.DataSource = funciones_cliente.Mostrar();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LimpiarTodo()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtId.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtDUI.Clear();
            txtDireccion.Clear();
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            LimpiarTodo();
            btnGuardarBien.Enabled = true;
            btnEditar.Enabled = true;
            btnSuprimir.Enabled = true;
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];
                txtId.Text = Convert.ToString(fila.Cells[0].Value);
                cmbtipocliente.Text = Convert.ToString(fila.Cells[1].Value);
                cmbGenero.Text = Convert.ToString(fila.Cells[2].Value);
                cmbEstadoCivil.Text = Convert.ToString(fila.Cells[3].Value);
                cmbEstado.Text = Convert.ToString(fila.Cells[4].Value);
                txtNombre.Text = Convert.ToString(fila.Cells[5].Value);
                txtApellido.Text = Convert.ToString(fila.Cells[6].Value);
                txtDUI.Text = Convert.ToString(fila.Cells[7].Value);
                this.dtpNacimiento.Text = Convert.ToString(fila.Cells[8].Value);
                txtCorreo.Text = Convert.ToString(fila.Cells[9].Value);
                txtDireccion.Text = Convert.ToString(fila.Cells[10].Value);
                txtTelefono.Text = Convert.ToString(fila.Cells[11].Value);
                btnGuardarBien.Enabled = false;
                btnEditar.Enabled = true;
                btnSuprimir.Enabled = true;
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarCliente();
            LimpiarTodo();
            btnGuardarBien.Enabled = true;
            btnSuprimir.Enabled = false;
            btnEditar.Enabled = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
