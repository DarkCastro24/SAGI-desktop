using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Vista.CRUD;
using WindowsFormsApplication1.Vista;
using WindowsFormsApplication1.Interfaces;

namespace WindowsFormsApplication1.Vista
{
    public partial class FrmTipo_Venta : Form
    {
        public FrmTipo_Venta()
        {
            InitializeComponent();
        }

        Form currentForm;

        private void AbrirFormEnPanel<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            //Buscar la coleccion del formulario
            formulario = panelContenedor.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;

                if (currentForm != null)
                {
                    currentForm.Close();
                    panelContenedor.Controls.Remove(currentForm);
                }

                currentForm = formulario;
                panelContenedor.Controls.Add(formulario);
                panelContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            else
            {
                formulario.BringToFront();
            }

        }

        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            foreach (var control in panelContenedor.Controls)
            {
                if (control is frm_ventaCasa)
                {

                }
                else if (control is frm_ventaTerr) // CASA
                {

                }

            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<frm_ventaApar>();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<frm_ventaCasa>();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<frm_ventaTerr>();
        }

        private void FrmTipo_Venta_Load(object sender, EventArgs e)
        {
            
        }
    }
}
