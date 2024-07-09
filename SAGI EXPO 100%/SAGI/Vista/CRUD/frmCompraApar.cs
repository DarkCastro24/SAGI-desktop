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
    public partial class frmCompraApar : Form
    {
        public static int espanol = 0;
        public static int ingles = 1;
        public frmCompraApar()
        {
            InitializeComponent();
            txtprecio.ContextMenu = new ContextMenu();
            txtArea.ContextMenu = new ContextMenu();
            txtCuartos.ContextMenu = new ContextMenu();
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

        void MostrarTodasLosApartamentos()
        {
            dgvApartamentos.DataSource = funciones_apartamento.Mostrar();
        }

        private void frmCompraApar_Load(object sender, EventArgs e)
        {
            MostrarTodasLosApartamentos();
            this.dgvApartamentos.Columns[0].Visible = false;
            //this.dgvApartamentos.Columns[0].Visible = false;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim()=="")
            {
                if (espanol == 0)
                {
                    MessageBox.Show("Las fotografias no pueden ser mostradas debido a que no a seleccionado ningun registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Photographs cannot be displayed because no record has been selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                              
            }
            else
            {              
                ConstructorGaleria.ID = Convert.ToInt16(txtID.Text);
                bool retorno = funcionesBusquedaFiltrada.ConseguirImagenesApar();
                if (retorno == true)
                {
                    if (ConstructorGaleria.imagen1 == " " || ConstructorGaleria.imagen2 == " " || ConstructorGaleria.imagen3 == " " || ConstructorGaleria.imagen4 ==  " ")
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
                        if (espanol ==0)
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

        private void dgvApartamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow fila = dgvApartamentos.Rows[e.RowIndex];
                txtID.Text = Convert.ToString(fila.Cells[0].Value);
            }
            catch (Exception)
            {

            }
                    
        }
        
        

        private void txtArea_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCuartos_ValueChanged(object sender, EventArgs e)
        {
            if (txtCuartos.Text != "")
            {
                Constructor_apartamento che = new Constructor_apartamento();
                che.cuartos = Convert.ToInt32(txtCuartos.Text);
                dgvApartamentos.DataSource = funciones_apartamento.BusquedaDepar(che);
            }
            else if(txtCuartos.Text == "0")
            {
                dgvApartamentos.DataSource = funcionesBusquedaFiltrada.MostrarApartamentos();
            }
        }
        

        private void txtArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionSoloLetrasyNumeros(e);
            Validaciones.SolamenteNumerosEnteros(e);
        }

        private void txtCuartos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteNumerosEnteros(e);
            ValidacionSoloLetrasyNumeros(e);
        }

        private void txtArea_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteNumerosEnteros(e);
        }

        private void txtprecio_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteNumerosEnteros(e);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() == "")
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
                ConstructorGaleria.ID = Convert.ToInt16(txtID.Text);
                ReporteDetalleApartamento che = new ReporteDetalleApartamento();
                che.Show();
            }
            
        }

        private void txtArea_TextChanged_1(object sender, EventArgs e)
        {

            if (txtArea.Text != "")
            {
                Constructor_apartamento che = new Constructor_apartamento();
                che.area = Convert.ToInt32(txtArea.Text);
                dgvApartamentos.DataSource = funciones_apartamento.BusquedaArea(che);
            }
            else
            {
                dgvApartamentos.DataSource = funcionesBusquedaFiltrada.MostrarApartamentos();
            }
        }

        private void txtprecio_TextChanged(object sender, EventArgs e)
        {

            if (txtprecio.Text != "")
            {
                Constructor_apartamento che = new Constructor_apartamento();
                che.precio = Convert.ToInt32(txtprecio.Text);
                dgvApartamentos.DataSource = funciones_apartamento.BusquedaFiltrada(che);
            }
            else
            {
                dgvApartamentos.DataSource = funcionesBusquedaFiltrada.MostrarApartamentos();
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtArea.Clear();
            txtprecio.Clear();
            txtCuartos.Value = 0;
            MostrarTodasLosApartamentos();
            
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgvApartamentos.DataSource = funcionesBusquedaFiltrada.MostrarApartamentos();
        }

        private void bunifuSeparator2_Load(object sender, EventArgs e)
        {

        }
    }

}
