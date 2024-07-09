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

namespace WindowsFormsApplication1.Vista
{
    public partial class FrmCita : Form
    {
        public FrmCita()
        {
            InitializeComponent();
            Controles();
        }

        private void FrmCita_Load(object sender, EventArgs e)
        {
            
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Controles()
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
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("" + es, "Error", MessageBoxButtons.OK);
            }
        }
    }
}
