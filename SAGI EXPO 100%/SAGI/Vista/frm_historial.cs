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
    public partial class frm_historial : Form
    {
        public frm_historial()
        {
            InitializeComponent();
        }

        private void frm_historial_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Funciones_Citas.grid();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
