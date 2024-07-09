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
using MySql.Data.MySqlClient;
using WindowsFormsApplication1.Modelo;
using System.Security.Cryptography;

namespace WindowsFormsApplication1.Interfaces
{
    public partial class frmExpEmpleados : Form
    {
        public frmExpEmpleados()
        {
            InitializeComponent();
        }

        private void btnGuardarBien_Click(object sender, EventArgs e)
        {
            AgregarUsuario();
        }

        public void CompletarComboBox()
        {
            try
            {
                if (funciones_empleado.ObtenerEstado() != null)
                {
                    cmbEstado.DataSource = funciones_empleado.ObtenerEstado();
                    cmbEstado.DisplayMember = "estado_usuario";
                    cmbEstado.ValueMember = "id_estado";
                }

                if (funciones_empleado.ObtenerGenero() != null)
                {
                    cmbGenero.DataSource = funciones_empleado.ObtenerGenero();
                    cmbGenero.DisplayMember = "genero_empl";
                    cmbGenero.ValueMember = "id_generoEmpl";
                }

                if (funciones_empleado.ObtenerTipoUsuario() != null)
                {
                    cmbtipousuario.DataSource = funciones_empleado.ObtenerTipoUsuario();
                    cmbtipousuario.DisplayMember = "tipo_usuario";
                    cmbtipousuario.ValueMember = "id_tipoUsuario";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmExpEmpleados_Load(object sender, EventArgs e)
        {
            CompletarComboBox();
            dgvUsuarios.DataSource = funciones_empleado.Mostrar();
        }

        public void AgregarUsuario()
        {
            try
            {
                if (txtNombre.Text.Trim() == "" || txtApellido.Text.Trim() == "" || txtCorreo.Text.Trim() == "" || txtDireccion.Text.Trim() == "" || txtCorreo.Text.Trim() == "" || txtDireccion.Text.Trim() == "" || txtUsuario.Text.Trim() == "" || txtProfesion.Text.Trim() == "" || txtContraseña.Text.Trim() == "")
                {
                    MessageBox.Show("Existen campos vacios", "Mensaje de advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
                else
                {
                    ConstructorNuevoUsuario agregar = new ConstructorNuevoUsuario();
                    agregar.nombre = txtNombre.Text;
                    agregar.apellido = txtApellido.Text;
                    agregar.correo = txtCorreo.Text;
                    agregar.direccion = txtDireccion.Text;
                    agregar.nacimiento = dtpNacimiento.Text;
                    agregar.usuario = txtUsuario.Text;
                    agregar.contraseña = txtEncriptado.Text;
                    agregar.profesion = txtProfesion.Text;
                    agregar.estado = Convert.ToInt32(cmbEstado.SelectedValue);
                    agregar.tipo_usuario = Convert.ToInt32(cmbtipousuario.SelectedValue);
                    agregar.genero = Convert.ToInt32(cmbGenero.SelectedValue);
                    int datos = funciones_empleado.Ingresar(agregar);
                    dgvUsuarios.DataSource = funciones_empleado.Mostrar();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void ActualizarUsuario()
        {
            try
            {
                if (txtNombre.Text.Trim() == "" || txtApellido.Text.Trim() == "" || txtCorreo.Text.Trim() == "" || txtDireccion.Text.Trim() == "" || txtCorreo.Text.Trim() == "" || txtDireccion.Text.Trim() == "" || txtUsuario.Text.Trim() == "" || txtProfesion.Text.Trim() == "")
                {
                    MessageBox.Show("Existen campos vacios", "Mensaje de advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("¿Seguro de actualizar registro?", "Mensaje de advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        ConstructorNuevoUsuario actu = new ConstructorNuevoUsuario();
                        actu.id_empleado = Convert.ToInt32(txtID.Text);
                        actu.nombre = txtNombre.Text;
                        actu.apellido = txtApellido.Text;
                        actu.correo = txtCorreo.Text;
                        actu.direccion = txtDireccion.Text;
                        actu.nacimiento = dtpNacimiento.Text;
                        actu.usuario = txtUsuario.Text;
                        actu.contraseña = txtEncriptado.Text;
                        actu.profesion = txtProfesion.Text;
                        actu.estado = Convert.ToInt32(cmbEstado.SelectedValue);
                        actu.tipo_usuario = Convert.ToInt32(cmbtipousuario.SelectedValue);
                        actu.genero = Convert.ToInt32(cmbGenero.SelectedValue);
                        int datos = funciones_empleado.Actualizar(actu);
                        dgvUsuarios.DataSource = funciones_empleado.Mostrar();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            byte[] passtohash = System.Text.Encoding.UTF8.GetBytes(txtContraseña.Text.ToString());
            txtEncriptado.Text = Hash(passtohash);
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.dgvUsuarios.Columns[0].Visible = false;
                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];
                txtID.Text = Convert.ToString(fila.Cells[0].Value);
                cmbGenero.Text = Convert.ToString(fila.Cells[1].Value);
                cmbEstado.Text = Convert.ToString(fila.Cells[2].Value);
                cmbtipousuario.Text = Convert.ToString(fila.Cells[3].Value);
                txtNombre.Text = Convert.ToString(fila.Cells[4].Value);
                txtApellido.Text = Convert.ToString(fila.Cells[5].Value);
                dtpNacimiento.Text = Convert.ToString(fila.Cells[6].Value);
                txtCorreo.Text = Convert.ToString(fila.Cells[7].Value);
                txtDireccion.Text = Convert.ToString(fila.Cells[8].Value);
                txtProfesion.Text = Convert.ToString(fila.Cells[9].Value);
                txtUsuario.Text = Convert.ToString(fila.Cells[10].Value);
                txtEncriptado.Text = Convert.ToString(fila.Cells[11].Value);
                btnGuardarBien.Enabled = false;
                btnEditar.Enabled = true;
                btnSuprimir.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Limpiar();
            btnGuardarBien.Enabled = true;
            btnEditar.Enabled = true;
            btnSuprimir.Enabled = true;
        }

        public void Limpiar()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            txtProfesion.Clear();
            txtUsuario.Clear();
            txtContraseña.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarUsuario();
            Limpiar();
            btnGuardarBien.Enabled = true;
            btnSuprimir.Enabled = false;
            btnEditar.Enabled = false;
        }

        public void Eliminar()
        {
            try
            {
                if (txtNombre.Text.Trim() == "" || txtApellido.Text.Trim() == "" || txtCorreo.Text.Trim() == "" || txtDireccion.Text.Trim() == "" || txtCorreo.Text.Trim() == "" || txtDireccion.Text.Trim() == "" || txtUsuario.Text.Trim() == "" || txtProfesion.Text.Trim() == "" || txtEncriptado.Text.Trim() == "")
                {
                    MessageBox.Show("No se ha seleccionado registro", "Mensaje de advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("Seguro de eliminar registro", "Mensaje de advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        ConstructorNuevoUsuario eliminar = new ConstructorNuevoUsuario();
                        eliminar.id_empleado = Convert.ToInt32(txtID.Text);
                        funciones_empleado.Eliminar(eliminar);
                        dgvUsuarios.DataSource = funciones_empleado.Mostrar();
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
            Limpiar();
            btnGuardarBien.Enabled = true;
            btnSuprimir.Enabled = false;
            btnEditar.Enabled = false;

        }
    }
}
