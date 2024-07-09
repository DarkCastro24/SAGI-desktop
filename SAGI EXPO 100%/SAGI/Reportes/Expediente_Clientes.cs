using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Reportes
{
    public partial class Expediente_Clientes : Form
    {
        public Expediente_Clientes()
        {
            InitializeComponent();
        }

        private void Expediente_Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetClientes.DataTable' Puede moverla o quitarla según sea necesario.
            this.DataTableTableAdapter.Fill(this.DataSetClientes.DataTable);

            this.reportViewer1.RefreshReport();
        }
    }
}
