using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Vista;
using WindowsFormsApplication1.Vista.CRUD;
using WindowsFormsApplication1.Controlador;
using WindowsFormsApplication1.Controlador.Constructores;

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
            formulario = panel3.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;

                if (currentForm != null)
                {
                    currentForm.Close();
                    panel3.Controls.Remove(currentForm);
                }

                currentForm = formulario;
                panel3.Controls.Add(formulario);
                panel3.Tag = formulario;
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
            foreach (var control in panel3.Controls)
            {
                if (control is frmApartamentos)
                {

                }
                else if (control is frmApartamentos) // CASA
                {

                }
                else if (control is frmTerreno)
                {

                }
                
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirFormEnPanel<frmCasas>();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirFormEnPanel<frmApartamentos>();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirFormEnPanel<frmTerreno>();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<frmCasas>();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<frmTerreno>();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel<frmApartamentos>();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<frmCompraApar>();
        }

        private void toolStripButton4_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel<frmCompraCasa>();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<frmCompraTerreno>();
        }


        private void Tipo_propiedades_Load(object sender, EventArgs e)
        {
            if (Constructor_Login.nivel== 3)
            {
                che14.Visible = false;
                che13.Visible = false;
                che12.Visible = false;
                che10.Visible = false;                                        
            }
            else
            {
                //No hacer nada xD
            }
        }


        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<frmCompraApar>();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<frmCasas>();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<frmTerreno>();
        }

        private void bunifuImageButton6_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel<frmApartamentos>();
        }

        private void bunifuImageButton4_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel<frmCompraCasa>();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<frmCompraTerreno>();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbEmpresa_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pbEmpresa, "Seleccione una opcion en la parte superior del formulario");
        }
    }

}
