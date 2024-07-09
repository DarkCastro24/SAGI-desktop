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

namespace WindowsFormsApplication1.Vista
{
    public partial class frm_citas : Form
    {
        public frm_citas()
        {
            InitializeComponent();
        }

        public void Combos()
        {
            if (btnEditar.Enabled == false)
            {
                try
                {
                    if (Funciones_Citas.comboEstado() != null && Funciones_Citas.priori() != null && Funciones_Citas.cliente() != null && Funciones_Citas.grid() != null)
                    {
                        cmbEstado.DataSource = Funciones_Citas.comboEstado();
                        cmbEstado.DisplayMember = "estado_cita";
                        cmbEstado.ValueMember = "id_estadoCita";
                        cmbPriori.DataSource = Funciones_Citas.priori();
                        cmbPriori.DisplayMember = "prioridad";
                        cmbPriori.ValueMember = "id_prioridad";
                        cmbCliente.DataSource = Funciones_Citas.cliente();
                        cmbCliente.DisplayMember = "nombre_client";
                        cmbCliente.ValueMember = "id_cliente";
                        dgvCitas.DataSource = Funciones_Citas.grid();
                        cmbEmpleado.DataSource = Funciones_Citas.empleado();
                        cmbEmpleado.DisplayMember = "nombre_empl";
                        cmbEmpleado.ValueMember = "id_empleado";
                    }
                }
                catch (Exception es)
                {
                    MessageBox.Show("" + es, "Error", MessageBoxButtons.OK);
                }
            }
            else if (btnEditar.Enabled == true)
            {
                try
                {
                    if (Funciones_Citas.comboEstado() != null && Funciones_Citas.priori() != null && Funciones_Citas.cliente() != null && Funciones_Citas.grid() != null)
                    {
                        cmbEstado.DataSource = Funciones_Citas.comboEstado2();
                        cmbEstado.DisplayMember = "estado_cita";
                        cmbEstado.ValueMember = "id_estadoCita";
                        cmbPriori.DataSource = Funciones_Citas.priori();
                        cmbPriori.DisplayMember = "prioridad";
                        cmbPriori.ValueMember = "id_prioridad";
                        cmbCliente.DataSource = Funciones_Citas.cliente();
                        cmbCliente.DisplayMember = "nombre_client";
                        cmbCliente.ValueMember = "id_cliente";
                        dgvCitas.DataSource = Funciones_Citas.grid();
                        cmbEmpleado.DataSource = Funciones_Citas.empleado();
                        cmbEmpleado.DisplayMember = "nombre_empl";
                        cmbEmpleado.ValueMember = "id_empleado";
                    }
                }
                catch (Exception es)
                {
                    MessageBox.Show("" + es, "Error", MessageBoxButtons.OK);
                }
            }

        }

        private void frm_citas_Load(object sender, EventArgs e)
        {
            Combos();
            //Verificar();
            dgvCitas.DataSource = Funciones_Citas.grid();
        }

        //public void Verificar()
        //{
        //    string act = lblFecha.Text;
        //    Funciones_Citas.cambiar(act);
        //}

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
            Limpiar();
            btnAgregar.Enabled = true;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        public void Agregar()
        {
            try
            {
                if (txtAsunto.Text.Trim() == "" || txtLugar.Text.Trim() == "")
                {
                    MessageBox.Show("Complete todos los campos que se le solicitan", "Existen campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Constructor_Citas insert = new Constructor_Citas();
                    insert.det = Convert.ToInt16(cmbEstado.SelectedValue);
                    insert.priori = Convert.ToInt16(cmbPriori.SelectedValue);
                    insert.emp = Convert.ToInt16(cmbEmpleado.SelectedValue);
                    insert.cli = Convert.ToInt16(cmbCliente.SelectedValue);
                    insert.asunto = txtAsunto.Text;
                    insert.lugar = txtLugar.Text;
                    Funciones_Citas.Insertar(insert);
                    dgvCitas.DataSource = Funciones_Citas.grid();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Limpiar()
        {
            txtAsunto.Clear();
            txtID.Clear();
            txtLugar.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_historial hist = new frm_historial();
            hist.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Constructor_Citas upd = new Constructor_Citas();
            upd.id = Convert.ToInt32(txtID.Text);
            Funciones_Citas.Cancelar(upd);
            dgvCitas.DataSource = Funciones_Citas.grid();
            btnAgregar.Enabled = true;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            Limpiar();
            btnAgregar.Enabled = true;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
        }

        private void dgvCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            DataGridViewRow fila = dgvCitas.Rows[e.RowIndex];
            txtID.Text = Convert.ToString(fila.Cells[0].Value);
            cmbEstado.Text = Convert.ToString(fila.Cells[1].Value);
            cmbEmpleado.Text = Convert.ToString(fila.Cells[2].Value);
            cmbCliente.Text = Convert.ToString(fila.Cells[3].Value);
            cmbPriori.Text = Convert.ToString(fila.Cells[4].Value);
            txtAsunto.Text = Convert.ToString(fila.Cells[5].Value);            
            txtLugar.Text = Convert.ToString(fila.Cells[6].Value);
            btnAgregar.Enabled = false;
            btnEditar.Enabled = true;
            Combos();
        }

        public void Actualizar()
        {
            try
            {
                if (txtAsunto.Text.Trim() == "" || txtLugar.Text.Trim() == "")
                {
                    MessageBox.Show("Complete todos los campos que se le solicitan", "Existen campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("Seguro de actualizar datos", "Mensaje de advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Constructor_Citas upd = new Constructor_Citas();
                        upd.id = Convert.ToInt16(txtID.Text);
                        upd.lugar = txtLugar.Text;
                        upd.asunto = txtAsunto.Text;
                        upd.det = Convert.ToInt16(cmbEstado.SelectedValue);
                        upd.cli = Convert.ToInt16(cmbCliente.SelectedValue);
                        upd.emp = Convert.ToInt16(cmbEmpleado.SelectedValue);
                        upd.priori = Convert.ToInt16(cmbPriori.SelectedValue);
                        Funciones_Citas.actualizar(upd);
                        dgvCitas.DataSource = Funciones_Citas.grid();
                        btnAgregar.Enabled = true;
                        btnEditar.Enabled = false;
                        btnCancelar.Enabled = false;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Actualizar();
            Limpiar();
            btnAgregar.Enabled = true;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
        }
    }
}
