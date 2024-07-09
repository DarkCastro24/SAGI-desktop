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
using WindowsFormsApplication1.Modelo.Funciones_Primer_Uso;
using WindowsFormsApplication1.Modelo.Funciones_CRUD;
using WindowsFormsApplication1.Reportes;

namespace WindowsFormsApplication1
{
    public partial class frmExpCliente : Form
    {
        public static int espanol = 0;
        public static int ingles = 1;
        public frmExpCliente()
        {
            InitializeComponent();
            dgvUsuarios.DataSource = funciones_cliente.Mostrar();
            txtApellido.ContextMenu = new ContextMenu();
            txtDUI.ContextMenu = new ContextMenu();
            txtNombre.ContextMenu = new ContextMenu();
            txtTelefono.ContextMenu = new ContextMenu();
            dtpNacimiento.ContextMenu = new ContextMenu();
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
            toolTip1.SetToolTip(button1, "Buscar cliente por numero telefonico");
            toolTip2.SetToolTip(button2, "Buscar cliente por medio de dui");
            toolTip3.SetToolTip(button3, "Limpiar todos los campos y habilitar boton de guardar");
            try
            {
                this.dgvUsuarios.Columns[0].Visible = false;
            }
            catch (Exception)
            {

               
            }
           
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
                
                if (txtCorreo.Text.Contains("@gmail.com"))
                {
                    if (txtNombre.Text.Trim() == "" || txtApellido.Text.Trim() == "" || txtCorreo.Text.Trim() == "" || txtDireccion.Text.Trim() == "" || txtDUI.Text.Trim() == "" || cmbEstado.Text.Trim() == "" || cmbEstadoCivil.Text.Trim() == "" || cmbGenero.Text.Trim() == "" || cmbtipocliente.Text.Trim() == "" ||
                    txtTelefono.Text.Trim() == "")
                    {
                        if (espanol== 0)
                        {
                            MessageBox.Show("Complete todos los campos que se le solicitan", "Existen campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("complete all the requested data", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
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
                        LimpiarTodo();
                    }
                }
                else
                {
                    if (espanol == 0)
                    {
                        MessageBox.Show("El formato del correo electronico debe ser **@gmail.com", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("The email has to been **@gmail.com", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    cmbGenero.DisplayMember = "genero";
                    cmbGenero.ValueMember = "id_genero";
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

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardarBien_Click(object sender, EventArgs e)
        {
            AgregarClientes();
        }

        public void ActualizarCliente()
        {

            try
            {
                if (txtNombre.Text.Trim() == "" || txtApellido.Text.Trim() == "" || txtCorreo.Text.Trim() == "" || txtDireccion.Text.Trim() == "" || txtDUI.Text.Trim() == "" || cmbEstado.Text.Trim() == "" || cmbEstadoCivil.Text.Trim() == "" || cmbGenero.Text.Trim() == "" || cmbtipocliente.Text.Trim() == "" ||
                txtTelefono.Text.Trim() == "")
                {
                    if (espanol == 0)
                    {
                        MessageBox.Show("No se han seleccionado registros", "Existen campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Not selected register", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                else
                {
                    if (espanol == 0)
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
                            LimpiarTodo();
                        }
                        else
                        {
                            if (MessageBox.Show("Are you sure you want to update the information?", "Warning Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
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
                                LimpiarTodo();
                            }
                        }
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

        public void Eliminar()
        {
            try
            {
                if (txtNombre.Text.Trim() == "" || txtApellido.Text.Trim() == "" || txtCorreo.Text.Trim() == "" || txtDireccion.Text.Trim() == "" || txtDUI.Text.Trim() == "" || cmbEstado.Text.Trim() == "" || cmbEstadoCivil.Text.Trim() == "" || cmbGenero.Text.Trim() == "" || cmbtipocliente.Text.Trim() == "" ||
                txtTelefono.Text.Trim() == "")
                {
                    if (espanol == 0)
                    {
                        MessageBox.Show("No se ha seleccionado registro", "Mensaje de advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Not selected register", "Warning Message ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                else
                {
                    if (espanol == 0)
                    {
                        if(MessageBox.Show("Seguro de eliminar registro", "Mensaje de advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                            ConstructorExpedienteCliente eliminar = new ConstructorExpedienteCliente();
                            eliminar.Id = Convert.ToInt32(txtId.Text);
                            funciones_cliente.Eliminar(eliminar);
                            dgvUsuarios.DataSource = funciones_cliente.Mostrar();
                            LimpiarTodo();
                        }
                    }
                    else
                    {
                        if(MessageBox.Show("Are you sure you want to delete the register?", "Warning Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                            ConstructorExpedienteCliente eliminar = new ConstructorExpedienteCliente();
                            eliminar.Id = Convert.ToInt32(txtId.Text);
                            funciones_cliente.Eliminar(eliminar);
                            dgvUsuarios.DataSource = funciones_cliente.Mostrar();
                            LimpiarTodo();
                        }
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
            dgvUsuarios.DataSource = funciones_cliente.Mostrar();
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
            }
        }

        private void btnSuprimir_Click(object sender, EventArgs e)
        {
            Eliminar();
            btnGuardarBien.Enabled = true;
            btnSuprimir.Enabled = false;
            btnEditar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarCliente();
            btnGuardarBien.Enabled = true;
            btnSuprimir.Enabled = false;
            btnEditar.Enabled = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteLetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteLetras(e);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (txtDUI.Text != "")
            {
                ConstructorExpedienteCliente che = new ConstructorExpedienteCliente();
                che.dui = txtDUI.Text;
                dgvUsuarios.DataSource = funciones_cliente.BuscarCliente(che);
            }
            else if (txtDUI.Text == "")
            {
                dgvUsuarios.DataSource = funciones_cliente.Mostrar();
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            dgvUsuarios.DataSource = funciones_cliente.Mostrar();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTelefono.Text != "")
            {
                ConstructorExpedienteCliente che = new ConstructorExpedienteCliente();
                che.telefono = txtTelefono.Text;
                dgvUsuarios.DataSource = funciones_cliente.BuscarTelefono(che);
            }
            else if (txtTelefono.Text == "")
            {
                dgvUsuarios.DataSource = funciones_cliente.Mostrar();
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
        private void txtDUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteLetras(e);

            Validaciones.NoEspacios(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteLetras(e);
            Validaciones.NoEspacios(e);
        }

        private void dtpNacimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteLetras(e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
            btnGuardarBien.Enabled = true;
            btnEditar.Enabled = true;
            btnSuprimir.Enabled = true;
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if (txtCorreo.Text.Contains("@gmail.com"))
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
            dgvUsuarios.DataSource = funciones_cliente.Mostrar();            
        }

        private void txtDUI_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = funciones_cliente.Mostrar();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Expediente_Clientes kk = new Expediente_Clientes();
            kk.Show();
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.NoEspacios(e);
        }
    }
}
