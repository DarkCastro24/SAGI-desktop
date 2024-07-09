using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Interfaces
{
    public partial class frmVenta : Form
    {
        public frmVenta()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Propiedades_venta prop = new Propiedades_venta();
            prop.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Plantilla_de_factura plan = new Plantilla_de_factura();
            plan.Show();
        }
    }
}
