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
using WindowsFormsApplication1.Vista.CRUD;
using System.Globalization;
using System.Threading;
using WindowsFormsApplication1.Controlador.Constructores;
using WindowsFormsApplication1.Controlador.Constructor_CRUD;
using WindowsFormsApplication1.Modelo.Funciones_CRUD;

namespace WindowsFormsApplication1.Vista
{
    //Crud Citas
    public partial class FrmCita : Form
    {
        public static int espanol = 0;
        public static int ingles =1;
        public FrmCita()
        {
            InitializeComponent();
            Controles();
            Thread t = new Thread(new ThreadStart(MiSubrutina));
            t.IsBackground = false;
            t.Start();
            txtCliente.ContextMenu = new ContextMenu();
            txtDireccion.ContextMenu = new ContextMenu();
            txtAsunto.ContextMenu = new ContextMenu();
        }
        private void FrmCita_Load(object sender, EventArgs e)
        {
            Controles();
            dtpNacimiento.Value = DateTime.Today;
            dtpNacimiento.MinDate = DateTime.Today;
            int datos;
            do
            {
                datos = Funciones_Citas.carga();
                if (datos >=1)
                {
                    datos = 0;
                }
            } while (datos >= 1);
            
            Ver();
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
        }
        //Funciones
        #region
        public void Controles()
        {
            try
            {
                empleado();
                if (Funciones_Citas.comboEstado() != null && Funciones_Citas.priori() != null && Funciones_Citas.grid() != null)
                {
                    cmbEstado.DataSource = Funciones_Citas.comboEstado();
                    cmbEstado.DisplayMember = "estado_cita";
                    cmbEstado.ValueMember = "id_estadoCita";
                    cmbPriori.DataSource = Funciones_Citas.priori();
                    cmbPriori.DisplayMember = "prioridad";
                    cmbPriori.ValueMember = "id_prioridad";
                    Ver();
                   

                }
            }
            catch (Exception es)
            {
                MessageBox.Show("" + es, "Error", MessageBoxButtons.OK);
            }
        }
        public void empleado()
        {
            string empl = Constructor_Login.usuario;
            Constructor_Citas empleeado = new Constructor_Citas();
            empleeado.nom = empl;
            Funciones_Citas.empleado(empleeado);
        }
        public void Ver()
        {
            dgvCitas.DataSource = Funciones_Citas.grid();
            this.dgvCitas.Columns[0].Visible = false;
            this.dgvCitas.Columns[5].Visible = false;
        }
        
        private void TxtCliente_TextChanged(object sender, EventArgs e)
        {
        }
        private void MiSubrutina()
        {
            int datos = 0;
            do
            {
                datos = Funciones_Citas.alarma();
                if (datos >= 1)
                {
                    notifyIcon1.Visible = true;
                    datos = 0;
                }
            } while (datos >= 1);
            
        }
        #endregion
        //Crud Botones
        #region
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAsunto.Text.Trim() == "" || txtDireccion.Text.Trim() == "" || txtIDCliente.Text.Trim() == "" || numHora.Text.Trim() == "" || numMin.Text.Trim() == "" || cmbP.Text.Trim() == "")
                {
                    MessageBox.Show("Existen campos vacíos", "Complete los campos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (txtAsunto.Text.Trim() != "" && txtDireccion.Text.Trim() != "" && txtIDCliente.Text.Trim() != "")
                {

                    Constructor_Citas kk = new Constructor_Citas();
                    kk.cli = Convert.ToInt16(txtIDCliente.Text);
                    kk.asunto = txtAsunto.Text;
                    kk.lugar = txtDireccion.Text;
                    kk.fecha = Convert.ToString(dtpNacimiento.Text);
                    kk.priori = Convert.ToInt16(cmbPriori.SelectedValue);
                    kk.det = Convert.ToInt16(cmbEstado.SelectedValue);
                    kk.hora = Convert.ToInt16(numHora.SelectedItem);
                    kk.min = Convert.ToInt16(numMin.SelectedItem);
                    kk.per = Convert.ToString(cmbP.SelectedItem);

                    DateTime fec = DateTime.Today;
                    string fecha = fec.ToString("yyy-MM-dd");
                    DateTime now = DateTime.Now;
                    int hora = Convert.ToInt16(now.ToString("hh", new CultureInfo("en-US")));
                    int min = Convert.ToInt16(now.ToString("mm", new CultureInfo("en-US")));
                    int hora2 = Convert.ToInt16(now.AddMinutes(+120).ToString("hh", new CultureInfo("en-US")));
                    int min2 = Convert.ToInt16(now.AddMinutes(+120).ToString("mm", new CultureInfo("en-US")));
                    string per = now.ToString("tt", new CultureInfo("en-US"));

                    if (kk.fecha == fecha && kk.hora >= hora && kk.min >= min && kk.per != per)
                    {
                        if (kk.hora >= hora2 && kk.min >= min2 && kk.per != per)
                        {
                            bool datos = Funciones_Citas.verificarFecha(kk);
                            if (datos == false)
                            {
                                Funciones_Citas.Insertar(kk);
                                Ver();
                            }
                            else
                            {
                                if (espanol == 0)
                                {
                                    MessageBox.Show("Ya existe un cita reservada ese mismo día y esa misma fecha.", "Verifica los datos");
                                }
                                else
                                {
                                    MessageBox.Show("There is already an appointment booked that same day and that same date.", "Verify the data");
                                }
                                
                            }
                        }
                        else
                        {

                            if (MessageBox.Show("¿Deseas continuar? Revisa que tengas espacio para realizar esta cita, lo recomendable sería que calcules muy bien tu tiempo, de lo contrario las cosas no podrían salir muy bien.", "Verifica los datos.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                bool datos = Funciones_Citas.verificarFecha(kk);
                                if (datos == false)
                                {
                                    Funciones_Citas.Insertar(kk);
                                    Ver();
                                }
                                else
                                {
                                    if (espanol == 0)
                                    {
                                        MessageBox.Show("Ya existe un cita reservada ese mismo día y esa misma fecha.", "Verifica los datos");
                                    }
                                    else
                                    {
                                        MessageBox.Show("There is already an appointment booked that same day and that same date.", "Verify the data");
                                    }
                                    
                                }
                            }

                        }

                    }
                    else if (kk.fecha != fecha)
                    {
                        bool datos = Funciones_Citas.verificarFecha(kk);
                        if (datos == false)
                        {
                            Funciones_Citas.Insertar(kk);
                            Ver();
                        }
                        else
                        {
                            if (espanol == 0)
                            {
                                MessageBox.Show("Ya existe un cita reservada ese mismo día y esa misma fecha.", "Verifica los datos");
                            }
                            else
                            {
                                MessageBox.Show("There is already an appointment booked that same day and that same date.", "Verify the data");
                            }
                           
                        }
                    }
                    else
                    {
                        if (espanol == 0)
                        {
                            MessageBox.Show("Ingresa una hora distinta a la actual.", "Verifica los datos");
                        }
                        else
                        {
                            MessageBox.Show("Enter different from the current time." ,"Check data");
                        }
                        
                    }



                }
                else
                {
                    if (espanol == 0)
                    {
                        MessageBox.Show("Llena todos los campos por favor!", "Espacios vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Fill in all fields please!", "Empty spaces", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                   
                }
            }
            catch (Exception)
            {
            }
        }
        private void dgvCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int posicion;
                posicion = this.dgvCitas.CurrentRow.Index;

                txtID.Text = dgvCitas[0, posicion].Value.ToString();
                cmbEstado.Text = dgvCitas[1, posicion].Value.ToString();
                cmbPriori.Text = dgvCitas[2, posicion].Value.ToString();
                txtAsunto.Text = dgvCitas[3, posicion].Value.ToString();
                txtDireccion.Text = dgvCitas[6, posicion].Value.ToString();
                dtpNacimiento.Text = dgvCitas[7, posicion].Value.ToString();
                numHora.Text = dgvCitas[8, posicion].Value.ToString();
                numMin.Text = dgvCitas[9, posicion].Value.ToString();
                cmbP.Text = dgvCitas[10, posicion].Value.ToString();

                btnAdd.Enabled = false;
                btnCancelar.Enabled = true;
                btnEditar.Enabled = true;
            }
            catch (Exception)
            {
            }

        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtIDCliente.Text.Trim() == "")
            {
                if (espanol == 0)
                {
                    MessageBox.Show("Seleccione a un cliente", "Complete los campos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Select a customer", "Complete the fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            if (txtAsunto.Text.Trim() == "" || txtDireccion.Text.Trim() == "")
            {
                if (espanol == 0)
                {
                    MessageBox.Show("Existen campos vacíos", "Complete los campos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("There are empty fields", "Complete the fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else if (txtAsunto.Text.Trim() != "" && txtDireccion.Text.Trim() != "" && txtIDCliente.Text.Trim() != "")
            {
                Constructor_Citas upd = new Constructor_Citas();
                upd.cli = Convert.ToInt16(txtIDCliente.Text);
                upd.asunto = txtAsunto.Text;
                upd.lugar = txtDireccion.Text;
                upd.fecha = Convert.ToString(dtpNacimiento.Text);
                upd.priori = Convert.ToInt16(cmbPriori.SelectedValue);
                upd.det = Convert.ToInt16(cmbEstado.SelectedValue);
                upd.hora = Convert.ToInt16(numHora.SelectedItem);
                upd.min = Convert.ToInt16(numMin.SelectedItem);
                upd.id = Convert.ToInt16(txtID.Text);
                upd.per = Convert.ToString(cmbP.SelectedItem);

                Funciones_Citas.actualizar(upd);
                Ver();

            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Constructor_Citas upd = new Constructor_Citas();
            upd.id = Convert.ToInt16(txtID.Text);
            Funciones_Citas.Cancelar(upd);
            Ver();
            btnAdd.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
        }
        private void btnH_Click(object sender, EventArgs e)
        {
            FrmHistorialCitas historial = new FrmHistorialCitas();
            historial.Show();
        }
        private void txtCliente_TextChanged_1(object sender, EventArgs e)
        {
            string buscador = txtCliente.Text;
            txtCliente.AutoCompleteCustomSource.Add(Funciones_Citas.buscar(buscador));
        }


        #endregion

        private void txtDireccion_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtAsunto_KeyDown(object sender, KeyEventArgs e)
        {

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
        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionSoloLetrasyNumeros(e);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtDireccion.Clear();
            txtAsunto.Clear();
            txtCliente.Clear();
            txtIDCliente.Clear();
            btnAdd.Enabled = true;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = true;
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtAsunto_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
        
    

