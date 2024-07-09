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
using WindowsFormsApplication1.Modelo.Funciones_CRUD;
using WindowsFormsApplication1.Vista.CRUD;
using WindowsFormsApplication1.Controlador.Constructor_CRUD;
using WindowsFormsApplication1.Reportes;

namespace WindowsFormsApplication1.Vista
{
    public partial class frmCasas : Form
    {
        public frmCasas()
        {
            InitializeComponent();
            Mostrar();
        }

        private void frmCasas_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(CbxGarage, "Seleccione si la casa que desea ingresar posee garage");
            toolTip2.SetToolTip(CbxPatio, "Seleccione si la casa que desea ingresar posee patio");
            this.dgvUsuarios.Columns[0].Visible = false;
            Mostrar();
            ComboBox();
            Departamento();
        }

        void Mostrar() 
        {
            dgvUsuarios.DataSource = funciones_casa.Mostrar();
        }
        void ComboBox()
        {

            try
            {
                if (funciones_casa.ObtenerEstadoCasa() != null)
                {
                    cmbEstado.DataSource = funciones_casa.ObtenerEstadoCasa();
                    cmbEstado.DisplayMember = "estadopropiedad";
                    cmbEstado.ValueMember = "id_estado";
                }

                if (funciones_casa.ObtenerTipoCasa() != null)
                {
                    cmbTipoCasa.DataSource = funciones_casa.ObtenerTipoCasa();
                    cmbTipoCasa.DisplayMember = "tipo_casa";
                    cmbTipoCasa.ValueMember = "id_tipoCasa";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Combobox departamentos y municipios
        #region
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
        #endregion

        void HabilitarGarage()
        {
            if (txtDescripcionGarage.Enabled == false)
            {
                txtDescripcionGarage.Enabled = true;
                NumGarage.Enabled = true;
            }
            else
            {
                txtDescripcionGarage.Enabled = false;
                NumGarage.Enabled = false;
            }
        }

        void HabilitarPatio()
        {
            if (txtDescripcionPatio.Enabled == false)
            {
                txtDescripcionPatio.Enabled = true;
                NumPatio.Enabled = true;
            }
            else
            {
                txtDescripcionPatio.Enabled = false;
                NumPatio.Enabled = false;
            }
        }

        public void Agregar()
        {
            try
            {
                if (/*txtID.Text.Trim() == "" || */txtPrecio.Text.Trim() == "" || txtDescripcion.Text.Trim() == "" || txtDireccion.Text.Trim() == "" || cmbMunicipio.Text.Trim() == "" || txtPiso.Text.Trim() == "" || txtPiso.Text.Trim() == "" || txtBaños.Text.Trim() == "" || txtArea.Text.Trim() == "" || txtPiso.Text.Trim() == "" || txtIDCliente.Text.Trim()== "" || txtConstruccion.Text.Trim() == "")
                {
                    MessageBox.Show("Complete todos los campos que se le solicitan", "Existen campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Constructor_casa agregar = new Constructor_casa();
                    agregar.estado = Convert.ToInt32(cmbEstado.SelectedValue);
                    agregar.departamento = Convert.ToInt32(cmbDepartamento.SelectedValue);
                    agregar.precio = Convert.ToInt32(txtPrecio.Text);
                    agregar.direccion = txtDireccion.Text;
                    agregar.descripcion = txtDescripcion.Text;
                    agregar.municipio = Convert.ToInt16(cmbMunicipio.SelectedValue);
                    agregar.numero_pisos = Convert.ToInt32(txtPiso.Text);
                    agregar.numero_baños = Convert.ToInt32(txtBaños.Text);
                    agregar.numero_cuartos = Convert.ToInt32(txtCuartos.Text);
                    agregar.area_casa = Convert.ToDecimal(txtArea.Text);
                    agregar.area_terreno = Convert.ToDecimal(txtConstruccion.Text);
                    agregar.tipo_casa = Convert.ToInt16(cmbTipoCasa.SelectedValue);
                    agregar.Descripcion_garage = txtDescripcionGarage.Text;
                    agregar.Descripcion_patio = txtDescripcionPatio.Text;
                    agregar.numero_garage = Convert.ToInt16(NumGarage.Text);
                    agregar.numero_patio = Convert.ToInt16(NumPatio.Text);
                    agregar.Descripcion_garage = txtDescripcionGarage.Text;
                    agregar.Descripcion_patio = txtDescripcionPatio.Text;
                    agregar.id_cliente = Convert.ToInt16(txtIDCliente.Text);
                    int datos = funciones_casa.Agregar(agregar);
                    
                    if (datos == 1)
                    {
                        ConstructorGaleria.direccion = txtDireccion.Text;
                        bool val = funcionesBusquedaFiltrada.ConseguirIDCasa();
                        ConstructorGaleria.Actualizar_Agregar = "Nada xD";
                        Mostrar();
                        Limpiar();
                        if (val == true)
                        {
                            Limpiar();
                            MessageBox.Show("A continuacion procedera a ingresar las imagenes de la vivienda que desea poner en venta", "Solo falta un paso para completar el ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmimagen che2 = new frmimagen();
                            che2.Show();
                        }                      
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Actualizar()
        {
            try
            {
                if (txtIDCliente.Text.Trim() == "")
                {
                    MessageBox.Show("No se ha seleccionado a un cliente", "Existen campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtID.Text.Trim() == "" || txtPrecio.Text.Trim() == "" || txtDescripcion.Text.Trim() == "" || txtDireccion.Text.Trim() == "" || cmbMunicipio.Text.Trim() == "" || txtPiso.Text.Trim() == "" || txtPiso.Text.Trim() == "" || txtBaños.Text.Trim() == "" || txtArea.Text.Trim() == "" || txtPiso.Text.Trim() == "")
                {
                    MessageBox.Show("Seleccione registro", "Existen campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("Seguro de actualizar datos", "Mensaje de advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Constructor_casa agregar = new Constructor_casa();
                        agregar.id_casa = Convert.ToInt32(txtID.Text);
                        agregar.estado = Convert.ToInt32(cmbEstado.SelectedValue);
                        agregar.departamento = Convert.ToInt32(cmbDepartamento.SelectedValue);
                        agregar.precio = Convert.ToInt32(txtPrecio.Text);
                        agregar.direccion = txtDireccion.Text;
                        agregar.descripcion = txtDescripcion.Text;
                        agregar.municipio = Convert.ToInt16(cmbMunicipio.SelectedValue);
                        agregar.numero_pisos = Convert.ToInt32(txtPiso.Text);
                        agregar.numero_baños = Convert.ToInt32(txtBaños.Text);
                        agregar.numero_cuartos = Convert.ToInt32(txtPiso.Text);
                        agregar.area_casa = Convert.ToDecimal(txtArea.Text);
                        agregar.Descripcion_garage = txtDescripcionGarage.Text;
                        agregar.Descripcion_patio = txtDescripcionPatio.Text;
                        agregar.numero_garage = Convert.ToInt32(NumGarage.Text);
                        agregar.numero_patio = Convert.ToInt32(NumPatio.TextAlign);
                        agregar.id_cliente = Convert.ToInt32(txtIDCliente.Text);
                        agregar.area_terreno = Convert.ToDecimal(txtConstruccion.Text);
                        int datos = funciones_casa.Actualizar(agregar);
                        ConstructorGaleria.direccion = txtDireccion.Text;
                        bool val = funcionesBusquedaFiltrada.ConseguirIDCasa();
                        ConstructorGaleria.Actualizar_Agregar = "Validar";
                        Mostrar();
                        Limpiar();
                        if (val == true)
                        {
                            if (MessageBox.Show("Desea actualizar las imagenes de su propiedad", "Desea Continuar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                if (val == true)
                                {
                                    frmimagen che2 = new frmimagen();
                                    che2.Show();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("El apartamento no pudo ser ingresado");
                        }
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
                if (txtID.Text.Trim() == "" || txtPrecio.Text.Trim() == "" || txtDescripcion.Text.Trim() == "" || txtDireccion.Text.Trim() == "" || cmbMunicipio.Text.Trim() == "" || txtPiso.Text.Trim() == "" || txtPiso.Text.Trim() == "" || txtBaños.Text.Trim() == "" || txtArea.Text.Trim() == "" || txtPiso.Text.Trim() == "")
                {
                    MessageBox.Show("Seleccione registro", "Existen campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("Seguro de eliminar datos", "Mensaje de advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Constructor_casa agregar = new Constructor_casa();
                        agregar.id_casa = Convert.ToInt32(txtID.Text);
                        int datos = funciones_casa.Eliminar(agregar);
                        Mostrar();
                        Limpiar();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardarBien_Click(object sender, EventArgs e)
        {
            Agregar();
            btnGuardarBien.Enabled = true;
            btnEditar.Enabled = false;
            btnSuprimir.Enabled = false;
        }

        public void Limpiar()
        {
            txtID.Clear();
            txtPrecio.Clear();
            txtDireccion.Clear();
            txtDescripcion.Clear();
            txtArea.Clear();
            txtConstruccion.Clear();
            txtDescripcionGarage.Clear();
            txtDescripcionPatio.Clear();
            txtIDCliente.Clear();
            txtCliente.Clear();
        }

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClasificarDepartamento();
        }

        private void CbxPatio_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarPatio();
        }

        private void CbxGarage_CheckedChanged_1(object sender, EventArgs e)
        {
            HabilitarGarage();
        }

        private void dgvUsuarios_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];
                txtID.Text = Convert.ToString(fila.Cells[0].Value);
                cmbEstado.Text = Convert.ToString(fila.Cells[1].Value);
                cmbDepartamento.Text = Convert.ToString(fila.Cells[2].Value);
                txtPrecio.Text = Convert.ToString(fila.Cells[3].Value);
                txtDireccion.Text = Convert.ToString(fila.Cells[4].Value);
                txtDescripcion.Text = Convert.ToString(fila.Cells[5].Value);
                cmbMunicipio.Text = Convert.ToString(fila.Cells[6].Value);
                txtPiso.Text = Convert.ToString(fila.Cells[7].Value);
                txtCuartos.Text = Convert.ToString(fila.Cells[8].Value);
                txtBaños.Text = Convert.ToString(fila.Cells[9].Value);
                txtArea.Text = Convert.ToString(fila.Cells[10].Value);
                txtConstruccion.Text = Convert.ToString(fila.Cells[11].Value);
                NumPatio.Text = Convert.ToString(fila.Cells[13].Value);
                NumGarage.Text = Convert.ToString(fila.Cells[12].Value);
                txtDescripcionPatio.Text = Convert.ToString(fila.Cells[15].Value);
                txtDescripcionGarage.Text = Convert.ToString(fila.Cells[14].Value);
                cmbTipoCasa.Text = Convert.ToString(fila.Cells[16].Value);
            }
            catch (Exception)
            {
            }

            btnGuardarBien.Enabled = false;
            btnEditar.Enabled = true;
            btnSuprimir.Enabled = true;
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            Actualizar();
            btnGuardarBien.Enabled = true;
            btnEditar.Enabled = false;
            btnSuprimir.Enabled = false;
        }

        private void btnSuprimir_Click_1(object sender, EventArgs e)
        {
            Eliminar();
            btnGuardarBien.Enabled = true;
            btnEditar.Enabled = false;
            btnSuprimir.Enabled = false;
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

        private void txtArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionSoloLetrasyNumeros(e);
            Validaciones.SolamenteNumerosEnteros(e);
            Validaciones.NoEspacios(e);
        }

        private void txtConstruccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionSoloLetrasyNumeros(e);
            Validaciones.SolamenteNumerosEnteros(e);
            Validaciones.NoEspacios(e);
        }

        private void NumGarage_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionSoloLetrasyNumeros(e);
            Validaciones.SolamenteNumerosEnteros(e);
            Validaciones.NoEspacios(e);
        }

        private void txtBaños_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionSoloLetrasyNumeros(e);
            Validaciones.SolamenteNumerosEnteros(e);
            Validaciones.NoEspacios(e);
        }

        private void NumPatio_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionSoloLetrasyNumeros(e);
            Validaciones.SolamenteNumerosEnteros(e);
            Validaciones.NoEspacios(e);
        }

        private void txtCuartos_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionSoloLetrasyNumeros(e);
            Validaciones.SolamenteNumerosEnteros(e);
            Validaciones.NoEspacios(e);
        }

        private void txtPiso_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionSoloLetrasyNumeros(e);
            Validaciones.SolamenteNumerosEnteros(e);
            Validaciones.NoEspacios(e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionSoloLetrasyNumeros(e);
            Validaciones.SolamenteNumerosEnteros(e);
            Validaciones.NoEspacios(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDireccion.Clear();
            txtDescripcion.Clear();
            txtDescripcionGarage.Clear();
            txtDescripcionPatio.Clear();
            txtArea.Clear();
            txtConstruccion.Clear();
            txtPrecio.Clear();
            btnGuardarBien.Enabled = true;
            btnEditar.Enabled = true;
            btnSuprimir.Enabled = true;
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteLetras(e);
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteLetras(e);
        }

        private void txtDescripcionGarage_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void txtDescripcionPatio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteLetras(e);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ReporteIngresoCasas che = new ReporteIngresoCasas();
            che.Show();
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

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator4_Load(object sender, EventArgs e)
        {

        }

        private void txtIDCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDescripcionGarage_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcionGarage_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtArea_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteNumerosEnteros(e);
        }

        private void txtConstruccion_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteNumerosEnteros(e);
        }

        private void txtPrecio_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteNumerosEnteros(e);

        }

        private void bunifuSeparator2_Load(object sender, EventArgs e)
        {

        }
    }
}
