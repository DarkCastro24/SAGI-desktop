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
using MySql.Data.MySqlClient;
using WindowsFormsApplication1.Modelo.Funciones_CRUD;
using WindowsFormsApplication1.Vista.CRUD;
using WindowsFormsApplication1.Controlador.Constructor_CRUD;

namespace WindowsFormsApplication1.Interfaces
{
    public partial class frmApartamentos : Form
    {
        public static int espanol = 0;
        public static int ingles = 1;
        public frmApartamentos()
        {
            InitializeComponent();
            Mostrar();
            txtBloqueEdificio.ContextMenu = new ContextMenu();
            txtCuartos.ContextMenu = new ContextMenu();
            txtDescripcion.ContextMenu = new ContextMenu();
            txtCuartos.ContextMenu = new ContextMenu();
            txtPrecio.ContextMenu = new ContextMenu();
            txtPiso.ContextMenu = new ContextMenu();
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


        void Mostrar()
        {
            dgvUsuarios.DataSource = funciones_apartamento.Mostrar();
        }

        void ClasificarDepartamento()
        {
            if (cmbDepartamento.Text == "Ahuachapan")
            {
                Ahuachapan();
            }
            else if (cmbDepartamento.Text == "Cabañas")
            {
                Cabañas();
            }
            else if (cmbDepartamento.Text == "Chalatenango")
            {
                Chalatenango();
            }
            else if (cmbDepartamento.Text == "Cuscatlan")
            {
                Cuscatlan();
            }
            else if (cmbDepartamento.Text == "La Libertad")
            {
                LaLibertad();
            }
            else if (cmbDepartamento.Text == "La Paz")
            {
                LaPaz();
            }
            else if (cmbDepartamento.Text == "La Union")
            {
                LaUnion();
            }
            else if (cmbDepartamento.Text == "Morazan")
            {
                Morazan();
            }
            else if (cmbDepartamento.Text == "San Miguel")
            {
                SanMiguel();
            }
            else if (cmbDepartamento.Text == "San Salvador")
            {
                SanSalvador();
            }
            else if (cmbDepartamento.Text == "San Vicente")
            {
                SanVicente();
            }

            else if (cmbDepartamento.Text == "Santa Ana")
            {
                SantaAna();
            }

            else if (cmbDepartamento.Text == "Sonsonate")
            {
                Sonsonate();
            }

            else if (cmbDepartamento.Text == "Usulutan")
            {
                Usulutan();
            }
        }

        void Departamento()
        {
            cmbDepartamento.DataSource = Municipio.ObtenerDepartamentos();
            cmbDepartamento.DisplayMember = "departamento";
            cmbDepartamento.ValueMember = "id_departamento";
        }

        void Ahuachapan()
        {
            cmbMunicipio.DataSource = Municipio.Ahuachapan();
            cmbMunicipio.DisplayMember = "municipio";
            cmbMunicipio.ValueMember = "id_municipio";
        }

        void Cabañas()
        {
            cmbMunicipio.DataSource = Municipio.Cabañas();
            cmbMunicipio.DisplayMember = "municipio";
            cmbMunicipio.ValueMember = "id_municipio";
        }

        void Chalatenango()
        {
            cmbMunicipio.DataSource = Municipio.Chalatenango();
            cmbMunicipio.DisplayMember = "municipio";
            cmbMunicipio.ValueMember = "id_municipio";
        }

        void Cuscatlan()
        {
            cmbMunicipio.DataSource = Municipio.Cuscatlan();
            cmbMunicipio.DisplayMember = "municipio";
            cmbMunicipio.ValueMember = "id_municipio";
        }

        void LaLibertad()
        {
            cmbMunicipio.DataSource = Municipio.LaLibertad();
            cmbMunicipio.DisplayMember = "municipio";
            cmbMunicipio.ValueMember = "id_municipio";
        }

        void LaPaz()
        {
            cmbMunicipio.DataSource = Municipio.LaPaz();
            cmbMunicipio.DisplayMember = "municipio";
            cmbMunicipio.ValueMember = "id_municipio";
        }

        void LaUnion()
        {
            cmbMunicipio.DataSource = Municipio.LaUnion();
            cmbMunicipio.DisplayMember = "municipio";
            cmbMunicipio.ValueMember = "id_municipio";
        }

        void Morazan()
        {
            cmbMunicipio.DataSource = Municipio.Morazan();
            cmbMunicipio.DisplayMember = "municipio";
            cmbMunicipio.ValueMember = "id_municipio";
        }

        void SanMiguel()
        {
            cmbMunicipio.DataSource = Municipio.SanMiguel();
            cmbMunicipio.DisplayMember = "municipio";
            cmbMunicipio.ValueMember = "id_municipio";
        }

        void SanSalvador()
        {
            cmbMunicipio.DataSource = Municipio.SanSalvador();
            cmbMunicipio.DisplayMember = "municipio";
            cmbMunicipio.ValueMember = "id_municipio";
        }

        void SanVicente()
        {
            cmbMunicipio.DataSource = Municipio.SanVicente();
            cmbMunicipio.DisplayMember = "municipio";
            cmbMunicipio.ValueMember = "id_municipio";
        }

        void SantaAna()
        {
            cmbMunicipio.DataSource = Municipio.SantaAna();
            cmbMunicipio.DisplayMember = "municipio";
            cmbMunicipio.ValueMember = "id_municipio";

        }

        void Sonsonate()
        {
            cmbMunicipio.DataSource = Municipio.Sonsonate();
            cmbMunicipio.DisplayMember = "municipio";
            cmbMunicipio.ValueMember = "id_municipio";
        }

        void Usulutan()
        {
            cmbMunicipio.DataSource = Municipio.Usulutan();
            cmbMunicipio.DisplayMember = "municipio";
            cmbMunicipio.ValueMember = "id_municipio";
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
            ActualizarApar();
            btnGuardarBien.Enabled = true;
            btnSuprimir.Enabled = false;
            btnEditar.Enabled = false;
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.dgvUsuarios.Columns[0].Visible = false;
                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];
                txtID.Text = Convert.ToString(fila.Cells[0].Value);
                cmbEstado.Text = Convert.ToString(fila.Cells[1].Value);
                cmbDepartamento.Text = Convert.ToString(fila.Cells[2].Value);
                cmbMunicipio.Text = Convert.ToString(fila.Cells[6].Value);
                txtPrecio.Text = Convert.ToString(fila.Cells[3].Value);
                txtDescripcion.Text = Convert.ToString(fila.Cells[4].Value);
                txtDIreccion.Text = Convert.ToString(fila.Cells[5].Value);
                txtPiso.Text = Convert.ToString(fila.Cells[7].Value);
                txtCuartos.Text = Convert.ToString(fila.Cells[8].Value);
                txtBaños.Text = Convert.ToString(fila.Cells[9].Value);
                txtArea.Text = Convert.ToString(fila.Cells[10].Value);
                NumEdificio.Text = Convert.ToString(fila.Cells[11].Value);
                txtBloqueEdificio.Text = Convert.ToString(fila.Cells[12].Value);
                txtEdificio.Text = Convert.ToString(fila.Cells[13].Value);
                btnGuardarBien.Enabled = false;
                btnEditar.Enabled = true;
                btnSuprimir.Enabled = true;
            }
            catch (Exception)
            {
            }
        }
        void ComboBox()
        {

            try
            {
                if (funciones_apartamento.ObtenerEstadoApar() != null)
                {
                    cmbEstado.DataSource = funciones_apartamento.ObtenerEstadoApar();
                    cmbEstado.DisplayMember = "estadopropiedad";
                    cmbEstado.ValueMember = "id_estado";
                }

                if (funciones_apartamento.ObtenerEstadoApar() != null)
                {
                    cmbEstado.DataSource = funciones_apartamento.ObtenerEstadoApar();
                    cmbEstado.DisplayMember = "estadopropiedad";
                    cmbEstado.ValueMember = "id_estado";
                }

                if (funciones_apartamento.ObtenerTipoApartamento() != null)
                {
                    cmbTipoApartamento.DataSource = funciones_apartamento.ObtenerTipoApartamento();
                    cmbTipoApartamento.DisplayMember = "tipo_apartamento";
                    cmbTipoApartamento.ValueMember = "id_tipoApartamento";
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
                    MessageBox.Show("An error has occurred", "Critical connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void frmApartamentos_Load(object sender, EventArgs e)
        {
            ComboBox();
            this.dgvUsuarios.Columns[0].Visible = false;
            Departamento();
        }

        private void btnGuardarBien_Click(object sender, EventArgs e)
        {
            AgregarApar();
        }

        public void AgregarApar()
        {
            try
            {
                if (txtPrecio.Text.Trim() == "" || txtDescripcion.Text.Trim() == "" || txtDIreccion.Text.Trim() == "" || cmbMunicipio.Text.Trim() == "" || txtPiso.Text.Trim() == "" || txtCuartos.Text.Trim() == "" || txtBaños.Text.Trim() == "" || txtArea.Text.Trim() == "" || txtEdificio.Text.Trim() == "" || txtIDCliente.Text.Trim() == "")
                {
                    if (espanol == 0)
                    {
                        MessageBox.Show("Complete todos los campos que se le solicitan", "Existen campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Complete all the fields that are requested", "There are empty fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                else
                {
                    Constructor_apartamento che = new Constructor_apartamento();
                    che.estado = Convert.ToInt32(cmbEstado.SelectedValue);
                    che.departamento = Convert.ToInt32(cmbDepartamento.SelectedValue);
                    che.precio = Convert.ToInt32(txtPrecio.Text);
                    che.direccion = txtDIreccion.Text;
                    che.descripcion = txtDescripcion.Text;
                    ConstructorGaleria.direccion = txtDIreccion.Text;
                    che.municipio = Convert.ToInt16(cmbMunicipio.SelectedValue);
                    che.piso = Convert.ToInt32(txtPiso.Text);
                    che.baños = Convert.ToInt32(txtBaños.Text);
                    che.cuartos = Convert.ToInt32(txtCuartos.Text);
                    che.area = Convert.ToDecimal(txtArea.Text);
                    che.edificio = Convert.ToString(txtEdificio.Text);
                    che.Numero_Edificio = Convert.ToInt32(NumEdificio.Text);
                    che.tipo_Apartamento = Convert.ToInt16(cmbTipoApartamento.SelectedValue);
                    che.Bloque_Edificio = txtBloqueEdificio.Text;
                    che.Numero_Edificio = Convert.ToInt16(NumEdificio.Text);
                    che.id_cliente = Convert.ToInt16(txtIDCliente.Text);
                    int datos = funciones_apartamento.Agregar(che);
                    bool val = funcionesBusquedaFiltrada.ConseguirIDApartamento();
                    if (val == true)
                    {
                        ConstructorGaleria.Actualizar_Agregar = "Nada xD";
                        LimpiarTodo();
                        Mostrar();
                        if (espanol == 0)
                        {
                            MessageBox.Show("A continuacion procedera a ingresar las imagenes de la vivienda que desea poner en venta", "Solo falta un paso para completar el ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmimagen che2 = new frmimagen();
                            che2.Show();
                        }
                        else
                        {
                            MessageBox.Show("Then proceed to enter the images of the home you want to put on sale", "Only one step is missing to complete the data entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmimagen che2 = new frmimagen();
                            che2.Show();
                        }
                       
                    }
                    else
                    {
                        if (espanol == 0)
                        {
                            MessageBox.Show("El apartamento no pudo ser ingresado");
                        }
                        else
                        {
                            MessageBox.Show("The apartment could not be entered");
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
                    MessageBox.Show("An error has occurred", "Critical connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

}

        public void LimpiarTodo()
        {
            txtPrecio.Clear();
            txtDIreccion.Clear();
            txtArea.Clear();
            txtEdificio.Clear();
            txtDescripcion.Clear();
            txtEdificio.Clear();
            txtBloqueEdificio.Clear();
            txtIDCliente.Clear();
            txtCliente.Clear();
        }

        public void ActualizarApar()
        {

            try
            {
                if (espanol == 0)
                {
                    if (txtIDCliente.Text.Trim() == "")
                    {
                        MessageBox.Show("No se ha seleccionado a un cliente", "Existen campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (txtID.Text.Trim() == "")
                    {
                        MessageBox.Show("No se han seleccionado registros", "Existen campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Seguro de actualizar datos", "Mensaje de advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            Constructor_apartamento agregar = new Constructor_apartamento();
                            ConstructorGaleria.id_apartamento = Convert.ToInt32(txtID.Text);
                            agregar.estado = Convert.ToInt32(cmbEstado.SelectedValue);
                            agregar.departamento = Convert.ToInt32(cmbDepartamento.SelectedValue);
                            agregar.precio = Convert.ToInt32(txtPrecio.Text);
                            agregar.descripcion = txtDescripcion.Text;
                            agregar.direccion = txtDIreccion.Text;
                            agregar.municipio = Convert.ToInt16(cmbMunicipio.SelectedValue);
                            ConstructorGaleria.direccion = txtDIreccion.Text;
                            agregar.piso = Convert.ToInt32(txtPiso.Text);
                            agregar.cuartos = Convert.ToInt32(txtCuartos.Text);
                            agregar.baños = Convert.ToInt32(txtBaños.Text);
                            agregar.area = Convert.ToDecimal(txtArea.Text);
                            agregar.edificio = Convert.ToString(txtEdificio.Text);
                            agregar.tipo_Apartamento = Convert.ToInt32(cmbTipoApartamento.SelectedValue);
                            agregar.Bloque_Edificio = txtBloqueEdificio.Text;
                            agregar.Numero_Edificio = Convert.ToInt32(NumEdificio.Text);
                            agregar.id_cliente = Convert.ToInt32(txtIDCliente.Text);
                            funciones_apartamento.Actualizar(agregar);
                            Mostrar();
                            LimpiarTodo();
                            if (MessageBox.Show("Desea actualizar las imagenes de su propiedad", "Desea Continuar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                ConstructorGaleria.Actualizar_Agregar = "Validar";
                                bool val = funcionesBusquedaFiltrada.ConseguirIDApartamento();
                                if (val == true)
                                {
                                    LimpiarTodo();
                                    frmimagen che2 = new frmimagen();
                                    che2.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Acaba de ocurrir un error inesperado", "Error al actualizar imagenes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }

                            }
                        }
                    }
                }
                else
                {
                    if (txtIDCliente.Text.Trim() == "")
                    {
                        MessageBox.Show("A customer has not been selected", "There are empty fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (txtID.Text.Trim() == "")
                    {
                        MessageBox.Show("No records selected", "There are empty fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Are you sure you want to update the information?", "Warning Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            Constructor_apartamento agregar = new Constructor_apartamento();
                            ConstructorGaleria.id_apartamento = Convert.ToInt32(txtID.Text);
                            agregar.estado = Convert.ToInt32(cmbEstado.SelectedValue);
                            agregar.departamento = Convert.ToInt32(cmbDepartamento.SelectedValue);
                            agregar.precio = Convert.ToInt32(txtPrecio.Text);
                            agregar.descripcion = txtDescripcion.Text;
                            agregar.direccion = txtDIreccion.Text;
                            agregar.municipio = Convert.ToInt16(cmbMunicipio.SelectedValue);
                            ConstructorGaleria.direccion = txtDIreccion.Text;
                            agregar.piso = Convert.ToInt32(txtPiso.Text);
                            agregar.cuartos = Convert.ToInt32(txtCuartos.Text);
                            agregar.baños = Convert.ToInt32(txtBaños.Text);
                            agregar.area = Convert.ToDecimal(txtArea.Text);
                            agregar.edificio = Convert.ToString(txtEdificio.Text);
                            agregar.tipo_Apartamento = Convert.ToInt32(cmbTipoApartamento.SelectedValue);
                            agregar.Bloque_Edificio = txtBloqueEdificio.Text;
                            agregar.Numero_Edificio = Convert.ToInt32(NumEdificio.Text);
                            agregar.id_cliente = Convert.ToInt32(txtIDCliente.Text);
                            funciones_apartamento.Actualizar(agregar);
                            Mostrar();
                            LimpiarTodo();
                            if (MessageBox.Show("Do you want to update the information?", "Do you want to continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                ConstructorGaleria.Actualizar_Agregar = "Validar";
                                bool val = funcionesBusquedaFiltrada.ConseguirIDApartamento();
                                if (val == true)
                                {
                                    LimpiarTodo();
                                    frmimagen che2 = new frmimagen();
                                    che2.Show();
                                }
                                else
                                {
                                    MessageBox.Show("An unexpected error has just occurred ", " Error updating images ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }

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
                    MessageBox.Show("An error has occurred", "Critical connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
	}

        public void Eliminar()
        {
            try
            {
                if (txtID.Text.Trim() == "" /*|| txtPrecio.Text.Trim() == "" || txtDescripcion.Text.Trim() == "" || txtDIreccion.Text.Trim() == "" || cmbMunicipio.Text.Trim() == "" || txtPiso.Text.Trim() == "" || txtCuartos.Text.Trim() == "" || txtBaños.Text.Trim() == "" || txtArea.Text.Trim() == "" || txtEdificio.Text.Trim() == ""*/)
                {
                    if (espanol == 0)
                    {
                        MessageBox.Show("No se ha seleccionado registro", "Mensaje de advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No record selected", "Warning message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to delete the register?", "Warning Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        ConstructorGaleria.id_apartamento = Convert.ToInt32(txtID.Text);
                        funciones_apartamento.Eliminar();
                        Mostrar();
                        LimpiarTodo();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Unexpected error", "Error connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            LimpiarTodo();
            btnGuardarBien.Enabled = true;
            btnEditar.Enabled = true;
            btnSuprimir.Enabled = true;
        }

        private void cmbDepartamento_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ClasificarDepartamento();
        }

        private void bunifuSeparator3_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteLetras(e);
        }

        private void txtDIreccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteLetras(e);
        }

        private void txtEdificio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteLetras(e);
        }

        private void txtBloqueEdificio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteLetras(e);
            Validaciones.NoEspacios(e);
        }

        private void txtArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteNumerosEnteros(e);
            Validaciones.NoEspacios(e);
        }

        private void txtBaños_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteNumerosEnteros(e);
            Validaciones.NoEspacios(e);
        }

        private void txtPiso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteNumerosEnteros(e);
            Validaciones.NoEspacios(e);
        }

        private void txtCuartos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteNumerosEnteros(e);
            Validaciones.NoEspacios(e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteNumerosEnteros(e);
            Validaciones.NoEspacios(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDescripcion.Clear();
            txtDIreccion.Clear();
            txtEdificio.Clear();
            txtBloqueEdificio.Clear();
            txtArea.Clear();
            txtPrecio.Clear();
            btnGuardarBien.Enabled = true;
            btnEditar.Enabled = true;
            btnSuprimir.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                buscar_cliente kk = new buscar_cliente();
                kk.ShowDialog();
                if (kk != null)
                {
                    txtIDCliente.Text = Convert.ToString(constructor_factura.id_cliente);
                    txtCliente.Text = constructor_factura.cliente;

                }
            }
            catch (Exception)
            {

            }
        }

        private void txtArea_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteNumerosEnteros(e);
        }

        private void txtPrecio_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteNumerosEnteros(e);
        }

        private void dgvUsuarios_Click(object sender, EventArgs e)
        {

        }
    }
}
