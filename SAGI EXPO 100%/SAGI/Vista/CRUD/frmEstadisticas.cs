using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Graficas;
using WindowsFormsApplication1.Reportes;

namespace WindowsFormsApplication1.Vista.CRUD
{
    public partial class frmEstadisticas : Form
    {
        public frmEstadisticas()
        {
            InitializeComponent();
        }
      
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmGraficas che = new frmGraficas();
            che.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            TodosLosReportes che = new TodosLosReportes();
            che.Show();
        }
    }
}
