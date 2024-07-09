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
using WindowsFormsApplication1.Controlador.Constructores;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1.Vista.CRUD
{
    public partial class FrmHistorialCitas : Form
    {
        public FrmHistorialCitas()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);
        private void FrmHistorialCitas_Load(object sender, EventArgs e)
        {
            mostrar();
        }
        
            public void mostrar()
        {
            dataGridView1.DataSource = Funciones_Citas.grid2();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            if (Constructor_Login.nivel == 1)
            {
                btnHistorial.Enabled = true;
                btn1.Enabled = true;

            }

            else if (Constructor_Login.nivel == 2)
            {
                btn1.Enabled = true;
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = this.dataGridView1.CurrentRow.Index;
            txtID.Text = dataGridView1[0, posicion].Value.ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de eliminar este elemento del historial?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt16(txtID.Text);
                Funciones_Citas.borrar(id);
                mostrar();
            }
            
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de eliminar TODO el historial?","Confirmacion",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes )
            {
                Funciones_Citas.Historial();
                mostrar();
            }
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
