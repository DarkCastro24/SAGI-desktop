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
using WindowsFormsApplication1.Controlador.Constructor_CRUD;
using WindowsFormsApplication1.Modelo.Funciones_CRUD;
using WindowsFormsApplication1.Reportes;

namespace WindowsFormsApplication1.Interfaces
{
    public partial class frmExpEmpleados : Form
    {
        public static int espanol = 0;
        public static int ingles = 1;
        public frmExpEmpleados()
        {
            InitializeComponent();
            txtApellido.ContextMenu = new ContextMenu();
            txtNombre.ContextMenu = new ContextMenu();
            dtpNacimiento.ContextMenu = new ContextMenu();
            txtProfesion.ContextMenu = new ContextMenu();
            txtUsuario.ContextMenu = new ContextMenu();
        }

        private void btnGuardarBien_Click(object sender, EventArgs e)
        {
            if (espanol ==0 )
            {
                if (txtCorreo.Text.Contains("@gmail.com"))
                {
                    if (MessageBox.Show("La direccion de correo electronico que a ingresado es" + " " + txtCorreo.Text + " " + "ese correo se utilizara para el sistema", "Seguro que desea continuar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        AgregarUsuario();
                        btnGuardarBien.Enabled = true;
                        btnEditar.Enabled = false;
                        btnSuprimir.Enabled = false;
                    }
                }
            }
            else
            {
                if (txtCorreo.Text.Contains("@gmail.com"))
                {
                    if (MessageBox.Show("The email register is" + " " + txtCorreo.Text + " " + "this email is going to be used for the system", "Are you sure you want to continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        AgregarUsuario();
                        btnGuardarBien.Enabled = true;
                        btnEditar.Enabled = false;
                        btnSuprimir.Enabled = false;
                    }
                }
            }

        }

        void ComboBoxAdmin()
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
                    cmbGenero.DisplayMember = "genero";
                    cmbGenero.ValueMember = "id_genero";
                }

                if (funciones_empleado.ObtenerTipoUsuario2() != null)
                {
                    cmbtipousuario.DataSource = funciones_empleado.ObtenerTipoUsuario2();
                    cmbtipousuario.DisplayMember = "tipo_usuario";
                    cmbtipousuario.ValueMember = "id_tipoUsuario";
                }

                if (funciones_empleado.ObtenerEmpresa() != null)
                {
                    cmbEmpresa.DataSource = funciones_empleado.ObtenerEmpresa();
                    cmbEmpresa.DisplayMember = "empresa";
                    cmbEmpresa.ValueMember = "id_empresa";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al cargar los combo box", "Reinicie el sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }
           
        private void frmExpEmpleados_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnContra, "Actualizar contraseña del usuario a *primeruso*");
            ComboBoxAdmin();
            dgvUsuarios.DataSource = funciones_empleado.Mostrar();   
            this.dgvUsuarios.Columns[0].Visible = false;        
        }

        public void AgregarUsuario()
        {
            try
            {
                if (txtNombre.Text.Trim() == "" || txtApellido.Text.Trim() == "" || txtCorreo.Text.Trim() == "" || txtDireccion.Text.Trim() == "" || txtCorreo.Text.Trim() == "" || txtDireccion.Text.Trim() == "" || txtUsuario.Text.Trim() == "" || txtProfesion.Text.Trim() == "" /*|| txtContraseña.Text.Trim() == "" */)
                {
                    if (espanol ==0)
                    {
                        MessageBox.Show("Existen campos vacios", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("EMPTY FIELDS", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                else
                {
                    ConstructorExpedienteEmpleados agregar = new ConstructorExpedienteEmpleados();
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
                     agregar.empresa = Convert.ToInt16(cmbEmpresa.SelectedValue);
                    int datos = funciones_empleado.Ingresar(agregar);
                    dgvUsuarios.DataSource = funciones_empleado.Mostrar();
                    Limpiar();

                    if (espanol == 0)
                    {
                        MessageBox.Show("El usuario debera utilizar la contraseña *primeruso* la proxima vez que ingrese al sistema", "Usuario Ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("The user have to use the password *firstuse* the next time you log in at the system", "Usuario Ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void ActualizarUsuario()
        {
            try
            {
                if (txtID.Text.Trim()== "" || txtNombre.Text.Trim() == "" || txtApellido.Text.Trim() == "" || txtCorreo.Text.Trim() == "" || txtDireccion.Text.Trim() == "" || txtCorreo.Text.Trim() == "" || txtDireccion.Text.Trim() == "" || txtUsuario.Text.Trim() == "" || txtProfesion.Text.Trim() == "")
                {
                    if (espanol == 0)
                    {
                        MessageBox.Show("Existen campos vacios", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("EMPTY FIELDS", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                   
                }
                else
                {
                    if (espanol == 0)
                    {
                        if (MessageBox.Show("¿Seguro de actualizar registro?", "Mensaje de advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            ConstructorExpedienteEmpleados actu = new ConstructorExpedienteEmpleados();
                            actu.id_empleado = Convert.ToInt32(txtID.Text);
                            actu.genero = Convert.ToInt32(cmbGenero.SelectedValue);
                            actu.estado = Convert.ToInt32(cmbEstado.SelectedValue);
                            actu.tipo_usuario = Convert.ToInt32(cmbtipousuario.SelectedValue);
                            actu.nombre = Convert.ToString(txtNombre.Text);
                            actu.apellido = Convert.ToString(txtApellido.Text);
                            actu.nacimiento = Convert.ToString(dtpNacimiento.Text);
                            actu.correo = Convert.ToString(txtCorreo.Text);
                            actu.direccion = Convert.ToString(txtDireccion.Text);
                            actu.profesion = Convert.ToString(txtProfesion.Text);
                            actu.usuario = Convert.ToString(txtUsuario.Text);
                            actu.empresa = Convert.ToInt16(cmbEmpresa.SelectedValue);
                            int datos = funciones_empleado.Actualizar(actu);
                            dgvUsuarios.DataSource = funciones_empleado.Mostrar();
                            Limpiar();
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Are you sure you want to update the register?", "Warning message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            ConstructorExpedienteEmpleados actu = new ConstructorExpedienteEmpleados();
                            actu.id_empleado = Convert.ToInt32(txtID.Text);
                            actu.genero = Convert.ToInt32(cmbGenero.SelectedValue);
                            actu.estado = Convert.ToInt32(cmbEstado.SelectedValue);
                            actu.tipo_usuario = Convert.ToInt32(cmbtipousuario.SelectedValue);
                            actu.nombre = Convert.ToString(txtNombre.Text);
                            actu.apellido = Convert.ToString(txtApellido.Text);
                            actu.nacimiento = Convert.ToString(dtpNacimiento.Text);
                            actu.correo = Convert.ToString(txtCorreo.Text);
                            actu.direccion = Convert.ToString(txtDireccion.Text);
                            actu.profesion = Convert.ToString(txtProfesion.Text);
                            actu.usuario = Convert.ToString(txtUsuario.Text);
                            actu.empresa = Convert.ToInt16(cmbEmpresa.SelectedValue);
                            int datos = funciones_empleado.Actualizar(actu);
                            dgvUsuarios.DataSource = funciones_empleado.Mostrar();
                            Limpiar();
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

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];
                txtID.Text = Convert.ToString(fila.Cells[0].Value);
                cmbGenero.Text = Convert.ToString(fila.Cells[1].Value);
                cmbtipousuario.Text = Convert.ToString(fila.Cells[2].Value);
                txtNombre.Text = Convert.ToString(fila.Cells[3].Value);
                txtApellido.Text = Convert.ToString(fila.Cells[4].Value);
                dtpNacimiento.Text = Convert.ToString(fila.Cells[5].Value);
                txtCorreo.Text = Convert.ToString(fila.Cells[6].Value);
                txtDireccion.Text = Convert.ToString(fila.Cells[7].Value);
                txtProfesion.Text = Convert.ToString(fila.Cells[8].Value);
                txtUsuario.Text = Convert.ToString(fila.Cells[9].Value);
                cmbEmpresa.Text = Convert.ToString(fila.Cells[10].Value);
                btnGuardarBien.Enabled = false;
                btnEditar.Enabled = true;
                btnSuprimir.Enabled = true;
            }
            catch (Exception)
            {
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
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarUsuario();
            btnGuardarBien.Enabled = true;
            btnSuprimir.Enabled = false;
            btnEditar.Enabled = false;
        }

        public void Eliminar()
        {
            try
            {
                if (txtNombre.Text.Trim() == "" || txtApellido.Text.Trim() == "" || txtCorreo.Text.Trim() == "" || txtDireccion.Text.Trim() == "" || txtCorreo.Text.Trim() == "" || txtDireccion.Text.Trim() == "" || txtUsuario.Text.Trim() == "" || txtProfesion.Text.Trim() == "")
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
                        if (MessageBox.Show("Seguro de eliminar registro", "Mensaje de advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            ConstructorExpedienteEmpleados eliminar = new ConstructorExpedienteEmpleados();
                            eliminar.id_empleado = Convert.ToInt32(txtID.Text);
                            funciones_empleado.Eliminar(eliminar);
                            dgvUsuarios.DataSource = funciones_empleado.Mostrar();
                            Limpiar();
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("are you sure you want to delete the register?", "Warning Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            ConstructorExpedienteEmpleados eliminar = new ConstructorExpedienteEmpleados();
                            eliminar.id_empleado = Convert.ToInt32(txtID.Text);
                            funciones_empleado.Eliminar(eliminar);
                            dgvUsuarios.DataSource = funciones_empleado.Mostrar();
                            Limpiar();
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

        private void btnSuprimir_Click(object sender, EventArgs e)
        {
            Eliminar();
            btnGuardarBien.Enabled = true;
            btnSuprimir.Enabled = false;
            btnEditar.Enabled = false;

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
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteLetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteLetras(e);
        }

        private void txtProfesion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteLetras(e);
        }

        private void btnContra_Click(object sender, EventArgs e)
        {
            if (espanol == 0)
            {
                if(MessageBox.Show("¿Está seguro de restaurar la contraseña del usuario seleccionado?", "Mensaje de advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                    if (txtID.Text.Trim() == "")
                    {
                        MessageBox.Show("Seleccione un usuario", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        ConstructorExpedienteEmpleados che = new ConstructorExpedienteEmpleados();
                        che.id_empleado = Convert.ToInt32(txtID.Text);
                        che.contraseña = "efAdsX436aQfSUcxfwNEbBolhN0=";
                        funciones_empleado.ClaveDefault(che);
                    }
                }
                else
                {  
                    if(MessageBox.Show("Are you sure you want to restore the password for this user?", "Warning Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                        if (txtID.Text.Trim() == "")
                        {
                            MessageBox.Show("Choose an user", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            ConstructorExpedienteEmpleados che = new ConstructorExpedienteEmpleados();
                            che.id_empleado = Convert.ToInt32(txtID.Text);
                            che.contraseña = "efAdsX436aQfSUcxfwNEbBolhN0=";
                            funciones_empleado.ClaveDefault(che);
                        }
                    }
                }
            }
            
            else
            {

            }          
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtCorreo.Text != "")
            {
                ConstructorExpedienteEmpleados che = new ConstructorExpedienteEmpleados();
                che.correo = txtCorreo.Text;
                dgvUsuarios.DataSource = funciones_empleado.Buscar_Correo(che);
            }
            else
            {
                dgvUsuarios.DataSource = funciones_empleado.Mostrar();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                ConstructorExpedienteEmpleados che = new ConstructorExpedienteEmpleados();
                che.usuario = txtUsuario.Text;
                dgvUsuarios.DataSource = funciones_empleado.Buscar_usuario(che);
            }
            else
            {
                dgvUsuarios.DataSource = funciones_empleado.Mostrar();
            }
        }

        private void dtpNacimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionSoloLetrasyNumeros(e);
            Validaciones.NoEspacios(e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtCorreo.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtProfesion.Clear();
            txtUsuario.Clear();
            txtID.Clear();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
            dgvUsuarios.DataSource = funciones_empleado.Mostrar();
            btnSuprimir.Enabled = true;
            btnEditar.Enabled = true;
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = funciones_empleado.Mostrar();
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
       
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
