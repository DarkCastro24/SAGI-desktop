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
    public partial class frmCompraTerreno : Form
    {
        public static int espanol = 0;
        public static int ingles = 1;
        public frmCompraTerreno()
        {
            InitializeComponent();
            txttamaño.ContextMenu = new ContextMenu();
            txtprecio.ContextMenu = new ContextMenu();
        }

        private void frmCompraTerreno_Load(object sender, EventArgs e)
        {
            Mostrar();
            this.dgvTerrenos.Columns[0].Visible = false;
            //this.dgvTerrenos.Columns[0].Visible = false;
        }

        

        void Mostrar()
        {
            dgvTerrenos.DataSource = funciones_terreno.Mostrar();
        }

        void BusquedaSimple()
        {
            if (txtprecio.Text.Trim()==""|| txttamaño.Text.Trim()=="")
            {
                if (espanol == 0)
                {
                    MessageBox.Show("Complete los filtros para continuar");
                }
                else
                {
                    MessageBox.Show("Complete the filters to continue");
                }
                
            }
            else
            {
                ConstructorBusquedaFiltrada che = new ConstructorBusquedaFiltrada();
                che.area_terreno = Convert.ToInt32(txttamaño.Text);
                che.precio = Convert.ToInt32(txtprecio.Text);
                dgvTerrenos.DataSource = funcionesBusquedaFiltrada.BusquedaFiltradaCompletaTerreno(che);
            }
        }
        void BusquedaFiltrada()
        {
            if (espanol == 0)
            {
                if (txtprecio.Text.Trim() == "")
                {
                    MessageBox.Show("Se mostraran terrenos que oscilen como maximo el tamaño que escribio", "Se mostraran terrenos sin filtro de precio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txttamaño.Text.Trim() == "")
                {
                    MessageBox.Show("Se mostraran terrenos que oscilen como maximo el precio que escribio", "Se mostraran terrenos sin filtro de tamaño", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtprecio.Text.Trim() == "" || txttamaño.Text.Trim() == "")
                {
                    MessageBox.Show("Se mostraran terrenos que pertenescan unicamente al departamento y municipio que selecciono", "Se mostraran terrenos sin filtro de tamaño ni precio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("A continuacion se mostraran los terrenos que se encontraron en los registros de nuestra base de datos", "Se mostraran los terrenos disponibles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (txtprecio.Text.Trim() == "")
                {
                    MessageBox.Show("Lands will be shown that oscillate at most the size you wrote ","Land will be shown without price filter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txttamaño.Text.Trim() == "")
                {
                    MessageBox.Show("Land will be displayed that oscillate at most the price you wrote", "Land will be shown without price", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtprecio.Text.Trim() == "" || txttamaño.Text.Trim() == "")
                {
                    MessageBox.Show("Land will be shown that belongs only to the department and municipality that I select", "Se mostraran terrenos sin filtro de tamaño ni precio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The lands that were found in the records of our database will be shown below.", "Se mostraran los terrenos disponibles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            BusquedaSimple();
        }

        private void dgvTerrenos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow fila = dgvTerrenos.Rows[e.RowIndex];
                txtId.Text = Convert.ToString(fila.Cells[0].Value);
            }
            catch (Exception)
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (espanol == 0)
            {

            }
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
                bool retorno = funcionesBusquedaFiltrada.ConseguirImagenesTerreno();
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
                        if ( espanol == 0)
                        {
                            if (MessageBox.Show("Se han encontrado las imagenes del apartamento seleccionado a continuacion se mostraran las imagenes del terreno seleccionado", "¿Esta seguro que desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                frmGaleria che2 = new frmGaleria();
                                che2.Show();
                            }
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
                    MessageBox.Show("Select a register", "No register selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                ConstructorGaleria.ID = Convert.ToInt16(txtId.Text);
                ReporteDetalleTerreno che = new ReporteDetalleTerreno();
                che.Show();
            }
            
        }
       
        private void txtprecio_TextChanged_2(object sender, EventArgs e)
        {
            if (txtprecio.Text != "")
            {
                ConstructorTerrenos che = new ConstructorTerrenos();
                che.Precio = Convert.ToInt32(txtprecio.Text);
                dgvTerrenos.DataSource = funciones_terreno.BusquedaPrecio(che);
            }
            else
            {
                dgvTerrenos.DataSource = funciones_terreno.Mostrar();
            }
        }

        private void txttamaño_TextChanged_1(object sender, EventArgs e)
        {

            if (txttamaño.Text != "")
            {
                ConstructorTerrenos che = new ConstructorTerrenos();
                che.Extension = Convert.ToInt32(txttamaño.Text);
                dgvTerrenos.DataSource = funciones_terreno.BusquedaArea(che);
            }
            else
            {
                dgvTerrenos.DataSource = funciones_terreno.Mostrar();
            }
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteNumerosEnteros(e);
        }

        private void txttamaño_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteNumerosEnteros(e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txttamaño.Clear();
            txtprecio.Clear();      
            Mostrar();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgvTerrenos.DataSource = funciones_terreno.Mostrar();
        }
    }
}
