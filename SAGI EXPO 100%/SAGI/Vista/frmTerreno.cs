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
    public partial class frmTerreno : Form
    {
        funciones_terreno func = new funciones_terreno();
        public frmTerreno()
        {
            InitializeComponent();
            dgvUsuarios.DataSource = func.Mostrar();
            Controles();
        }

        public void LimpiarTodo()
        {
            txtDireccion.Clear();
            txtExtension.Clear();
            txtID.Clear();
            txtMunicipio.Clear();
            txtPrecio.Clear();
        }

        public void AgregarTerreno()
        {
            try
            {
                if (txtDireccion.Text.Trim() == "" || txtExtension.Text.Trim() == "" || txtPrecio.Text.Trim() == "" || txtMunicipio.Text.Trim() == "")
                {
                    MessageBox.Show("Exiten campos vacíos", "Mensaje de advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ConstructorTerrenos agregar = new ConstructorTerrenos();
                    agregar.direccion = txtDireccion.Text;
                    agregar.departamento = Convert.ToInt32(cmbDepartamento.SelectedValue);
                    agregar.Extension = Convert.ToInt32(txtExtension.Text);
                    agregar.Precio = Convert.ToInt32(txtPrecio.Text);
                    agregar.TipoRelieve = Convert.ToInt32(cmbTipoRelieve.SelectedValue);
                    agregar.TipoTerreno = Convert.ToInt32(cmbTipoTerreno.SelectedValue);
                    agregar.Estado = Convert.ToInt32(cmbEstado.SelectedValue);
                    agregar.municipio = txtMunicipio.Text;
                    int datos = funciones_terreno.Agregar(agregar);
                    dgvUsuarios.DataSource = func.Mostrar();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Buscar()
        {
            ConstructorTerrenos buscar = new ConstructorTerrenos();
            buscar.departamento = Convert.ToInt32(cmbDepartamento.SelectedValue);
            buscar.TipoRelieve = Convert.ToInt32(cmbTipoRelieve.SelectedValue);
            buscar.TipoTerreno = Convert.ToInt32(cmbTipoTerreno.SelectedValue);
            buscar.Estado = Convert.ToInt32(cmbEstado.SelectedValue);
            dgvUsuarios.DataSource = funciones_terreno.Buscar(buscar);
        }

        public void actualizarTerreno()
        {
            try
            {
                if (txtDireccion.Text.Trim() == "" || txtExtension.Text.Trim() == "" || txtPrecio.Text.Trim() == "" || txtMunicipio.Text.Trim() == "")
                {
                    MessageBox.Show("No ha seleccionado registro", "Mensaje de advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("Seguro de actualizar registro", "Mensaje de advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        ConstructorTerrenos actualizar = new ConstructorTerrenos();
                        actualizar.IdTerreno = Convert.ToInt32(txtID.Text);
                        actualizar.direccion = txtDireccion.Text;
                        actualizar.departamento = Convert.ToInt32(cmbDepartamento.SelectedValue);
                        actualizar.Extension = Convert.ToInt32(txtExtension.Text);
                        actualizar.Precio = Convert.ToInt32(txtPrecio.Text);
                        actualizar.TipoRelieve = Convert.ToInt32(cmbTipoRelieve.SelectedValue);
                        actualizar.TipoTerreno = Convert.ToInt32(cmbTipoTerreno.SelectedValue);
                        actualizar.Estado = Convert.ToInt32(cmbEstado.SelectedValue);
                        actualizar.municipio = txtMunicipio.Text;
                        funciones_terreno.Actualizar(actualizar);
                        dgvUsuarios.DataSource = func.Mostrar();
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
                if (txtDireccion.Text.Trim() == "" || txtExtension.Text.Trim() == "" || txtPrecio.Text.Trim() == "" || txtMunicipio.Text.Trim() == "")
                {
                    MessageBox.Show("No se ha seleccionado registro", "Mensaje de advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("Seguro de eliminar registro", "Mensaje de advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        ConstructorTerrenos eliminar = new ConstructorTerrenos();
                        eliminar.IdTerreno = Convert.ToInt32(txtID.Text);
                        funciones_terreno.Eliminar(eliminar);
                        dgvUsuarios.DataSource = func.Mostrar();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarBien_Click(object sender, EventArgs e)
        {
            AgregarTerreno();
            LimpiarTodo();
        }

        
        private void frmTerreno_Load(object sender, EventArgs e)
        {
            
        }

        public void Controles()
        {
            try
            {
                if (funciones_terreno.ObtenerTipoTerreno() != null)
                {
                    cmbTipoTerreno.DataSource = funciones_terreno.ObtenerTipoTerreno();
                    cmbTipoTerreno.DisplayMember = "tipo_terreno";
                    cmbTipoTerreno.ValueMember = "id_tipoTerreno";
                }

                if (funciones_terreno.ObtenerTipoRelieve() != null)
                {
                    cmbTipoRelieve.DataSource = funciones_terreno.ObtenerTipoRelieve();
                    cmbTipoRelieve.DisplayMember = "tipo_relieve";
                    cmbTipoRelieve.ValueMember = "id_tipoRelieve";
                }

                if (funciones_terreno.ObtenerDepartamento() != null)
                {
                    cmbDepartamento.DataSource = funciones_terreno.ObtenerDepartamento();
                    cmbDepartamento.DisplayMember = "departamento_terr";
                    cmbDepartamento.ValueMember = "id_departamentoTerr";
                }
                if (funciones_terreno.Estado() != null)
                {
                    cmbEstado.DataSource = funciones_terreno.Estado();
                    cmbEstado.DisplayMember = "estado_terr";
                    cmbEstado.ValueMember = "id_estadoTerr";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            LimpiarTodo();
            btnAgregar.Enabled = true;
            dgvUsuarios.DataSource = func.Mostrar();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];
                txtID.Text = Convert.ToString(fila.Cells[0].Value);
                cmbTipoRelieve.Text = Convert.ToString(fila.Cells[1].Value);
                cmbTipoTerreno.Text = Convert.ToString(fila.Cells[2].Value);
                cmbDepartamento.Text = Convert.ToString(fila.Cells[3].Value);
                cmbEstado.Text = Convert.ToString(fila.Cells[4].Value);
                txtPrecio.Text = Convert.ToString(fila.Cells[5].Value);
                txtExtension.Text = Convert.ToString(fila.Cells[6].Value);
                txtDireccion.Text = Convert.ToString(fila.Cells[7].Value);
                txtMunicipio.Text = Convert.ToString(fila.Cells[8].Value);
                btnAgregar.Enabled = false;
                btnEditar.Enabled = true;
                btnSuprimir.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSuprimir_Click(object sender, EventArgs e)
        {
            Eliminar();
            btnAgregar.Enabled = true;
            btnSuprimir.Enabled = false;
            btnEditar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            actualizarTerreno();
            btnAgregar.Enabled = true;
            btnSuprimir.Enabled = false;
            btnEditar.Enabled = false;
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtExtension_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txtExtension.Text.Contains('.'))
                {
                    if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
                    {
                        try
                        {
                            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '.')
                            {
                                e.Handled = false;
                            }
                            else
                            {
                                e.Handled = true;
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error Critico.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
                else if (e.KeyChar == '.' && txtExtension.Text.Trim() == "")
                {
                    e.Handled = true;
                }
                else
                {
                    try
                    {
                        if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '.')
                        {
                            e.Handled = false;
                        }
                        else
                        {
                            e.Handled = true;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error Critico.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error Critico.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txtPrecio.Text.Contains('.'))
                {
                    if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
                    {
                        try
                        {
                            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '.')
                            {
                                e.Handled = false;
                            }
                            else
                            {
                                e.Handled = true;
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error Critico.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
                else if (e.KeyChar == '.' && txtPrecio.Text.Trim() == "")
                {
                    e.Handled = true;
                }
                else
                {
                    try
                    {
                        if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '.')
                        {
                            e.Handled = false;
                        }
                        else
                        {
                            e.Handled = true;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error Critico.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error Critico.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

            