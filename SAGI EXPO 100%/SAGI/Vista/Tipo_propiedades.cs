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
    public partial class Tipo_propiedades : Form
    {
        public Tipo_propiedades()
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
                if (control is frmApartamentos)
                {

                }
                else if (control is frmCasas)
                {

                }
                else if (control is frmTerreno)
                {

                }
                
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<frmCasas>();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<frmTerreno>();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<frmApartamentos>();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
