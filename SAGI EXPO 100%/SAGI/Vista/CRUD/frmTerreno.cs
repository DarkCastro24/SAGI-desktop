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
using WindowsFormsApplication1.Modelo.Funciones_CRUD;
using WindowsFormsApplication1.Controlador;
using WindowsFormsApplication1.Vista.CRUD;
using WindowsFormsApplication1.Controlador.Constructor_CRUD;
using WindowsFormsApplication1.Reportes;

namespace WindowsFormsApplication1.Interfaces
{
    public partial class frmTerreno : Form
    {
        public static int espanol = 0;
        public static int ingles = 1;
        funciones_terreno func = new funciones_terreno();
        public frmTerreno()
        {
            InitializeComponent();
            Controles();
            Mostrar();
            txtPrecio.ContextMenu = new ContextMenu();
            txtExtension.ContextMenu = new ContextMenu();
        }

        void Mostrar()
        {
            dgvUsuarios.DataSource = funciones_terreno.Mostrar();
        }
        public void LimpiarTodo()
        {
            txtDireccion.Clear();
            txtExtension.Clear();
            txtID.Clear();
            txtPrecio.Clear();
        }

        public void AgregarTerreno()
        {
            try
            {
                if (txtDireccion.Text.Trim() == "" || txtExtension.Text.Trim() == "" || txtPrecio.Text.Trim() == "" || cmbMunicipio.Text.Trim() == "" || txtIDCliente.Text.Trim() == "")
                {
                    if (espanol == 0)
                    {
                        MessageBox.Show("Exiten campos vacíos", "Mensaje de advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("EMPTY FIELDS", "Warning Message ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
                    agregar.municipio = Convert.ToInt16(cmbMunicipio.SelectedValue);
                    agregar.Descripcion_terreno = txtDescripcionTerreno.Text;
                    agregar.id_cliente = Convert.ToInt16(txtIDCliente.Text);
                    ConstructorGaleria.direccion = txtDireccion.Text;
                    int datos = funciones_terreno.Agregar(agregar);
                    ConstructorGaleria.direccion = txtDireccion.Text;
                    bool val = funcionesBusquedaFiltrada.ConseguirIDTerreno();
                    ConstructorGaleria.Actualizar_Agregar = "Nada xD";
                    Mostrar();

                    if (val == true)
                    {
                        LimpiarTodo();
                        if (espanol == 0)
                        {
                            MessageBox.Show("A continuacion procedera a ingresar las imagenes del terreno que desea poner en venta", "Solo falta un paso para completar el ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmimagen che3 = new frmimagen();
                            che3.Show();
                        }
                        
                        else
                        {
                            MessageBox.Show("Next, proceed to enter the images of the land that you want to put on sale ", " Only one step is missing to complete the data entry ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmimagen che3 = new frmimagen();
                            che3.Show();
                        }
                       
                        
                    }
                    else
                    {
                        if (espanol == 0)
                        {
                            MessageBox.Show("El terreno no pudo ser ingresado");
                        }
                        else
                        {
                            MessageBox.Show("The land couldn't be registered");
                        }
                      
                    }
                }
            }
            catch (Exception)

            {
                if (espanol == 0)
                {
                    MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("An unexpected error has occurred", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }
        
        public void actualizarTerreno()
        {
            try
            {
                if (txtIDCliente.Text.Trim() == "")
                {
                    if (espanol == 0)
                    {
                        MessageBox.Show("No se ha seleccionado a un cliente", "Existen campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Unselected client", "EMPTY FIELDS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                else if (txtDireccion.Text.Trim() == "" || txtExtension.Text.Trim() == "" || txtPrecio.Text.Trim() == "" || cmbMunicipio.Text.Trim() == "")
                {
                    if (espanol == 0)
                    {
                        MessageBox.Show("No ha seleccionado ningún registro", "Mensaje de advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Unselected register", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                else
                {
                    if
                       (MessageBox.Show("¿Seguro que desea actualizar registro?", "Mensaje de advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
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
                        actualizar.municipio = Convert.ToInt16(cmbMunicipio.SelectedValue);
                        actualizar.Descripcion_terreno = txtDescripcionTerreno.Text;
                        actualizar.id_cliente = Convert.ToInt32(txtIDCliente.Text);
                        ConstructorGaleria.id_terreno = Convert.ToInt16(txtID.Text);
                        ConstructorGaleria.direccion = txtDireccion.Text;
                        Mostrar();
                        btnAgregar.Enabled = true;
                        btnSuprimir.Enabled = false;
                        btnEditar.Enabled = false;

                        int dato = funciones_terreno.Actualizar(actualizar);

                        if (dato <= 1)
                        {
                            bool val = funcionesBusquedaFiltrada.ConseguirIDTerreno();
                            ConstructorGaleria.Actualizar_Agregar = "Validar";

                            if (val == true)
                            {
                                LimpiarTodo();                             
                                dgvUsuarios.DataSource = funciones_terreno.Mostrar();
                                if (MessageBox.Show("Desea actualizar las imagenes del terreno seleccionado", "Desea Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Information)==DialogResult.Yes)
                                {
                                    frmimagen che3 = new frmimagen();
                                    che3.Show();
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
                                    MessageBox.Show("The aparment couldn't be registered");
                                }
                                
                            }
                        }
                        else
                        {
                            if (espanol == 0)
                            {
                                MessageBox.Show("Ha ocurrido un error");
                            }
                            else
                            {
                                MessageBox.Show("Error");
                            }
                            
                        }
                       
                    }
                }
            }
            catch (Exception)
            {
                if (espanol == 0)
                {
                    MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (txtDireccion.Text.Trim() == "" || txtExtension.Text.Trim() == "" || txtPrecio.Text.Trim() == "" || cmbMunicipio.Text.Trim() == "")
                {
                    if (espanol == 0)
                    {
                        MessageBox.Show("No se ha seleccionado ningún registro", "Mensaje de advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No register select", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                else
                {
                    if (MessageBox.Show("¿Seguro desea eliminar el registro?", "Mensaje de advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        ConstructorTerrenos eliminar = new ConstructorTerrenos();
                        eliminar.IdTerreno = Convert.ToInt32(txtID.Text);
                        funciones_terreno.Eliminar(eliminar);
                        Mostrar();
                        LimpiarTodo();
                    }
                }
            }
            catch (Exception)
            {
                if (espanol == 0)
                {
                    MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("An unexpected error has occurred", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void btnGuardarBien_Click(object sender, EventArgs e)
        {
            AgregarTerreno();
        }
              
        private void frmTerreno_Load(object sender, EventArgs e)
        {
            try
            {
                toolTip1.SetToolTip(button1, "Borrar todos los campos y habilitar la opcion de agregar");
                this.dgvUsuarios.Columns[0].Visible = false;
            }
            catch (Exception)
            {

                throw;
            }
            
            Departamento();
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
                if (funciones_terreno.Estado() != null)
                {
                    cmbEstado.DataSource = funciones_terreno.Estado();
                    cmbEstado.DisplayMember = "estadopropiedad";
                    cmbEstado.ValueMember = "id_estado";
                }
            }
            catch (Exception)
            {
                if (espanol == 0)
                {
                    MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("An unexpected error has occurred", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            LimpiarTodo();
            btnAgregar.Enabled = true;
            btnEditar.Enabled = true;
            btnSuprimir.Enabled = true;
            dgvUsuarios.DataSource = funciones_terreno.Mostrar();
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
                txtDescripcionTerreno.Text = Convert.ToString(fila.Cells[4].Value);
                cmbEstado.Text = Convert.ToString(fila.Cells[5].Value);
                txtPrecio.Text = Convert.ToString(fila.Cells[6].Value);
                txtExtension.Text = Convert.ToString(fila.Cells[7].Value);
                txtDireccion.Text = Convert.ToString(fila.Cells[8].Value);
                cmbMunicipio.Text = Convert.ToString(fila.Cells[9].Value);
                btnAgregar.Enabled = false;
                btnEditar.Enabled = true;
                btnSuprimir.Enabled = true;
            }
            catch (Exception)
            {
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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
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


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void cmbDepartamento_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ClasificarDepartamento();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionSoloLetrasyNumeros(e);
            Validaciones.SolamenteNumerosEnteros(e);
            Validaciones.NoEspacios(e);
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

        private void txtExtension_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionSoloLetrasyNumeros(e);
            Validaciones.SolamenteNumerosEnteros(e);
            Validaciones.NoEspacios(e);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtDireccion.Clear();
            txtDescripcionTerreno.Clear();
            txtPrecio.Clear();
            txtExtension.Clear();
            btnAgregar.Enabled = true;
            btnEditar.Enabled = true;
            btnSuprimir.Enabled = true;
        }

        private void cmbTipoRelieve_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtExtension_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtPrecio_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteNumerosEnteros(e);
        }

        private void txtExtension_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteNumerosEnteros(e);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ReporteIngresoTerrenos che = new ReporteIngresoTerrenos();
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

        private void txtDescripcionTerreno_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}

            