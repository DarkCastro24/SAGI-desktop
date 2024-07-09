using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Controlador.Constructor_CRUD;
using WindowsFormsApplication1.Modelo;

namespace WindowsFormsApplication1.Reportes
{
    public partial class ReporteDetalleApartamento : Form
    {
        public ReporteDetalleApartamento()
        {
            InitializeComponent();
        }

        private void ReporteDetalleApartamento_Load(object sender, EventArgs e)
        {
            
            this.DataTableTableAdapter.DetalleDepartemento(this.DataSetDetalleApartamento.DataTable, ConstructorGaleria.ID);
            this.reportViewer1.RefreshReport();
            // TODO: esta línea de código carga datos en la tabla 'DataSetDetalleApartamento.DataTable' Puede moverla o quitarla según sea necesario.

        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
           
        }
    }
}
