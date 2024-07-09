using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WindowsFormsApplication1.Interfaces;
using WindowsFormsApplication1.Controlador;
using WindowsFormsApplication1.Modelo;
using System.Threading;
using WindowsFormsApplication1.Vista;

namespace WindowsFormsApplication1.Vista
{
    public partial class FrmIntermediario : Form
    {
        public FrmIntermediario()
        {
            InitializeComponent();
            this.Hide();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
        }

        private void FrmIntermediario_Load(object sender, EventArgs e)
        {
            bool datos = ValidarPrimerUso.PrimerUso();
            if (datos == true)
            {

                this.Hide();
            }
            if (datos == false)
            {

                this.Hide();
            }
        }
    }
}
