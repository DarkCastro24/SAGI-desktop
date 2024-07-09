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
using WindowsFormsApplication1.Controlador.Constructor_CRUD;
using WindowsFormsApplication1.Modelo;
using WindowsFormsApplication1.Modelo.Funciones_CRUD;
using WindowsFormsApplication1.Reportes;

namespace WindowsFormsApplication1.Vista.CRUD
{
    public partial class frmCompraCasa : Form
    {
        public static int espanol = 0;
        public static int ingles = 1;
        public frmCompraCasa()
        {
            InitializeComponent();
            txtprecio.ContextMenu = new ContextMenu();
            txttamaño.ContextMenu = new ContextMenu();
            txtPiso.ContextMenu = new ContextMenu();
            txttamaño.ContextMenu = new ContextMenu();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() == "")
            {
                if (espanol == 0)
                {
                    MessageBox.Show("Las fotografias no pueden ser mostradas debido a que no a seleccionado ningun registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Photographs cannot be displayed because no record has been selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            else
            {
                ConstructorGaleria.ID = Convert.ToInt16(txtId.Text);
                bool retorno = funcionesBusquedaFiltrada.ConseguirImagenesCasa();
                if (retorno == true)
                {
                    if (ConstructorGaleria.imagen1 == "" || ConstructorGaleria.imagen2 == "" || ConstructorGaleria.imagen3 == "" || ConstructorGaleria.imagen4 == "")
                    {
                        if (espanol == 0)
                        {
                            MessageBox.Show("El registro que ha seleccionado no contiene ninguna imagen");
                        }
                        else
                        {
                            MessageBox.Show("The record you selected does not contain any images");
                        }
                        
                    }
                    else
                    {
                        if (espanol == 0)
                        {
                            if (MessageBox.Show("Se han encontrado las imagenes del apartamento seleccionado a continuacion se mostraran las imagenes del terreno seleccionado", "¿Esta seguro que desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                frmGaleria che2 = new frmGaleria();
                                che2.Show();
                            }
                            else
                            {
                                if (MessageBox.Show("The images of the selected apartment have been found below, the images of the selected land will be shown", "Are you sure you want to continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                                {
                                    frmGaleria che2 = new frmGaleria();
                                    che2.Show();
                                }
                            }
                        }
                        
                    }

                }
            }
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() == "")
            {
                if (espanol == 0)
                {
                    MessageBox.Show("Seleccione un registro para poder continuar", "No ha seleccionado ninguna propiedad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Select a record to continue ", " You have not selected any property", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                ConstructorGaleria.ID = Convert.ToInt16(txtId.Text);
                ReporteDetalleCasa che = new ReporteDetalleCasa();
                che.Show();
            }
            
        }
     
        public void MostrarTodasLasCasas()
        {
            dgvCasas.DataSource = funciones_casa.Mostrar();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void frmCompraCasa_Load(object sender, EventArgs e)
        {
            MostrarTodasLasCasas();
            /*this.dgvCasas.Columns[0].Visible = false;*/ // 15 14 13 12
            this.dgvCasas.Columns[0].Visible = false;
            this.dgvCasas.Columns[12].Visible = false;
            this.dgvCasas.Columns[13].Visible = false;
            this.dgvCasas.Columns[14].Visible = false;
            this.dgvCasas.Columns[15].Visible = false;
        }

        private void dgvCasas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow fila = dgvCasas.Rows[e.RowIndex];
                txtId.Text = Convert.ToString(fila.Cells[0].Value);
            }
            catch (Exception)
            {

            }
           
        }

        private void txtprecio_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        
        

        private void txtCuartos_ValueChanged(object sender, EventArgs e)
        {
            if (txtCuartos.Text != "")
            {
                Constructor_casa che = new Constructor_casa();
                che.numero_cuartos = Convert.ToInt32(txtCuartos.Text);
                dgvCasas.DataSource = funciones_casa.BusquedaCuartos(che);
            }
            else if (txtCuartos.Value != 0)
            {
                dgvCasas.DataSource = funciones_casa.Mostrar();
            }
        }

        private void txtPiso_ValueChanged(object sender, EventArgs e)
        {
            if (txtPiso.Text != "")
            {
                Constructor_casa che = new Constructor_casa();
                che.numero_pisos = Convert.ToInt32(txtPiso.Text);
                dgvCasas.DataSource = funciones_casa.BusquedaPisos(che);
            }
            else if (txtPiso.Value != 0)
            {
                dgvCasas.DataSource = funciones_casa.Mostrar();
            }
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionSoloLetrasyNumeros(e);
            Validaciones.SolamenteNumerosEnteros(e);
        }

        private void txttamaño_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionSoloLetrasyNumeros(e);
            Validaciones.SolamenteNumerosEnteros(e);
        }

        private void txtCuartos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteNumerosEnteros(e);
            ValidacionSoloLetrasyNumeros(e);
        }

        private void txtPiso_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionSoloLetrasyNumeros(e);
            Validaciones.SolamenteNumerosEnteros(e);
        }

        private void txtprecio_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteNumerosEnteros(e);
        }

        private void txttamaño_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteNumerosEnteros(e);
        }

        private void txtprecio_TextChanged_1(object sender, EventArgs e)
        {

            if (txtprecio.Text != "")
            {
                Constructor_casa che = new Constructor_casa();
                che.precio = Convert.ToInt32(txtprecio.Text);
                dgvCasas.DataSource = funciones_casa.BusquedaPrecio(che);
            }
            else
            {
                dgvCasas.DataSource = funciones_casa.Mostrar();
            }
        }

        private void txttamaño_TextChanged_1(object sender, EventArgs e)
        {
            if (txttamaño.Text != "")
            {
                Constructor_casa che = new Constructor_casa();
                che.area_casa = Convert.ToInt32(txttamaño.Text);
                dgvCasas.DataSource = funciones_casa.BusquedaArea(che);
            }
            else
            {
                dgvCasas.DataSource = funciones_casa.Mostrar();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txttamaño.Clear();
            txtprecio.Clear();
            txtCuartos.Value = 0;
            txtPiso.Value = 0;
            MostrarTodasLasCasas();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgvCasas.DataSource = funciones_casa.Mostrar();
        }
    }
}
