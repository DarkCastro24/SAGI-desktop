using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Controlador.Constructores;

namespace WindowsFormsApplication1.Graficas
{
    public partial class frmGraficas : Form
    {
        public frmGraficas()
        {
            InitializeComponent();
        }

        private void MenuSidebar_Click(object sender, EventArgs e)
        {
            if (Sidebar.Width == 270)
            {
                Sidebar.Visible = false;
                Sidebar.Width = 68;
                SidebarWrapper.Width = 90;
                LineaSidebar.Width = 52;
                AnimacionSidebar.Show(Sidebar);
            }
            else
            {
                Sidebar.Visible = false;
                Sidebar.Width = 270;
                SidebarWrapper.Width = 300;
                LineaSidebar.Width = 252;
                AnimacionSidebarBack.Show(Sidebar);
            }
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            Temporizador.Stop();

            FuncionesGrafica.CasasAhuachapan();
            FuncionesGrafica.CasasCuscatlan();
            FuncionesGrafica.CasasChalatenango();
            FuncionesGrafica.CasasCabañas();
            FuncionesGrafica.CasasLaLibertad();
            FuncionesGrafica.CasasLaPaz();
            FuncionesGrafica.CasasLaUnion();
            FuncionesGrafica.CasasMorazan();
            FuncionesGrafica.CasasSanMiguel();
            FuncionesGrafica.CasasSanSalvador();
            FuncionesGrafica.CasasSanVicente();
            FuncionesGrafica.CasasSantaAna();
            FuncionesGrafica.CasasSonsonate();
            FuncionesGrafica.CasasUsulutan();

            FuncionesGrafica.ApartamentosAhuachapan();
            FuncionesGrafica.ApartamentosCabañas();
            FuncionesGrafica.ApartamentosChalatenango();
            FuncionesGrafica.ApartamentosCuscatlan();
            FuncionesGrafica.ApartamentosLaLibertad();
            FuncionesGrafica.ApartamentosLaPaz();
            FuncionesGrafica.ApartamentosLaUnion();
            FuncionesGrafica.ApartamentosMorazan();
            FuncionesGrafica.ApartamentosSanMiguel();
            FuncionesGrafica.ApartamentosSanSalvador();
            FuncionesGrafica.ApartamentosSantaAna();
            FuncionesGrafica.ApartamentosSanVicente();
            FuncionesGrafica.ApartamentosSonsonate();
            FuncionesGrafica.ApartamentosUsulutan();

            FuncionesGrafica.TerrenosAhuachapan();
            FuncionesGrafica.TerrenosCabañas();
            FuncionesGrafica.TerrenosChalatenango();
            FuncionesGrafica.TerrenosCuscatlan();
            FuncionesGrafica.TerrenosLaLibertad();
            FuncionesGrafica.TerrenosLaPaz();
            FuncionesGrafica.TerrenosLaUnion();
            FuncionesGrafica.TerrenosMorazan();
            FuncionesGrafica.TerrenosSanMiguel();
            FuncionesGrafica.TerrenosSanSalvador();
            FuncionesGrafica.TerrenosSantaAna();
            FuncionesGrafica.TerrenosSanVicente();
            FuncionesGrafica.TerrenosSonsonate();
            FuncionesGrafica.TerrenosUsulutan();

            FuncionesGrafica.ObtenerTodasLasVentasApartamentos();
            FuncionesGrafica.ObtenerTodasLasVentasCasas();
            FuncionesGrafica.ObtenerTodasLasVentasTerrenos();

            this.VentaTotal.Series["ChartLinea"].Points.AddXY("APARTAMENTOS", ConstructorGrafica.TodosApartamentos);
            this.VentaTotal.Series["ChartLinea"].Points.AddXY("CASAS", ConstructorGrafica.TodasCasas);
            this.VentaTotal.Series["ChartLinea"].Points.AddXY("TERRENOS", ConstructorGrafica.TodosTerrenos);


            //Datos de tabla zona oriental casas
            this.CasasZonaOriental.Series["ChartLinea"].Points.AddXY("AHUACHAPAN", ConstructorGrafica.casas_Ahuachapan);
            this.CasasZonaOriental.Series["ChartLinea"].Points.AddXY("SANTA ANA", ConstructorGrafica.casas_SantaAna);
            this.CasasZonaOriental.Series["ChartLinea"].Points.AddXY("SONSONATE", ConstructorGrafica.casas_Sonsonate);

            //Datos de tabla zona cental casas
            this.CasasZonaCentral.Series["ChartLinea"].Points.AddXY("CUSCATLAN", ConstructorGrafica.casas_Cuscatlan);
            this.CasasZonaCentral.Series["ChartLinea"].Points.AddXY("CHALATENANGO", ConstructorGrafica.casas_Chalatenango);
            this.CasasZonaCentral.Series["ChartLinea"].Points.AddXY("CABAÑAS", ConstructorGrafica.casas_Cabañas);
            this.CasasZonaCentral.Series["ChartLinea"].Points.AddXY("LA LIBERTAD", ConstructorGrafica.casas_LaLibertad);
            this.CasasZonaCentral.Series["ChartLinea"].Points.AddXY("LA PAZ", ConstructorGrafica.casas_LaPaz);
            this.CasasZonaCentral.Series["ChartLinea"].Points.AddXY("SAN SALVADOR", ConstructorGrafica.casas_SanSalvador);
            this.CasasZonaCentral.Series["ChartLinea"].Points.AddXY("SAN VICENTE", ConstructorGrafica.casas_SanVicente);

            //Datos de tabla zona occidental casas
            this.CasasZonaOccidental.Series["ChartLinea"].Points.AddXY("LA UNION", ConstructorGrafica.casas_LaUnion);
            this.CasasZonaOccidental.Series["ChartLinea"].Points.AddXY("MORAZAN", ConstructorGrafica.casas_Morazan);
            this.CasasZonaOccidental.Series["ChartLinea"].Points.AddXY("SAN MIGUEL", ConstructorGrafica.casas_SanMiguel);
            this.CasasZonaOccidental.Series["ChartLinea"].Points.AddXY("USULUTAN", ConstructorGrafica.casas_Usulutan);

            //Datos de tabla zona oriental apartamentos
            this.ApartamentosZonaOriental.Series["ChartLinea"].Points.AddXY("AHUACHAPAN", ConstructorGrafica.apar_Ahuachapan);
            this.ApartamentosZonaOriental.Series["ChartLinea"].Points.AddXY("SANTA ANA", ConstructorGrafica.apar_SantaAna);
            this.ApartamentosZonaOriental.Series["ChartLinea"].Points.AddXY("SONSONATE", ConstructorGrafica.apar_Sonsonate);

            //Datos de tabla zona cental apartamentos
            this.ApartamentosZonaCentral.Series["ChartLinea"].Points.AddXY("CUSCATLAN", ConstructorGrafica.apar_Cuscatlan);
            this.ApartamentosZonaCentral.Series["ChartLinea"].Points.AddXY("CHALATENANGO", ConstructorGrafica.apar_Chalatenango);
            this.ApartamentosZonaCentral.Series["ChartLinea"].Points.AddXY("CABAÑAS", ConstructorGrafica.apar_Cabañas);
            this.ApartamentosZonaCentral.Series["ChartLinea"].Points.AddXY("LA LIBERTAD", ConstructorGrafica.apar_LaLibertad);
            this.ApartamentosZonaCentral.Series["ChartLinea"].Points.AddXY("LA PAZ", ConstructorGrafica.apar_LaPaz);
            this.ApartamentosZonaCentral.Series["ChartLinea"].Points.AddXY("SAN SALVADOR", ConstructorGrafica.apar_SanSalvador);
            this.ApartamentosZonaCentral.Series["ChartLinea"].Points.AddXY("SAN VICENTE", ConstructorGrafica.apar_SanVicente);

            //Datos de tabla zona occidental apartamentos
            this.ApartamentosZonaOccidental.Series["ChartLinea"].Points.AddXY("LA UNION", ConstructorGrafica.apar_LaUnion);
            this.ApartamentosZonaOccidental.Series["ChartLinea"].Points.AddXY("MORAZAN", ConstructorGrafica.apar_Morazan);
            this.ApartamentosZonaOccidental.Series["ChartLinea"].Points.AddXY("SAN MIGUEL", ConstructorGrafica.apar_SanMiguel);
            this.ApartamentosZonaOccidental.Series["ChartLinea"].Points.AddXY("USULUTAN", ConstructorGrafica.apar_Usulutan);

            //Datos de tabla zona oriental terrenos
            this.TerrenosZonaOriental.Series["ChartLinea"].Points.AddXY("AHUACHAPAN", ConstructorGrafica.terrenos_Ahuachapan);
            this.TerrenosZonaOriental.Series["ChartLinea"].Points.AddXY("SANTA ANA", ConstructorGrafica.terrenos_SantaAna);
            this.TerrenosZonaOriental.Series["ChartLinea"].Points.AddXY("SONSONATE", ConstructorGrafica.terrenos_Sonsonate);

            //Datos de tabla zona cental terrenos
            this.TerrenosZonaCentral.Series["ChartLinea"].Points.AddXY("CUSCATLAN", ConstructorGrafica.terrenos_Cuscatlan);
            this.TerrenosZonaCentral.Series["ChartLinea"].Points.AddXY("CHALATENANGO", ConstructorGrafica.terrenos_Chalatenango);
            this.TerrenosZonaCentral.Series["ChartLinea"].Points.AddXY("CABAÑAS", ConstructorGrafica.terrenos_Cabañas);
            this.TerrenosZonaCentral.Series["ChartLinea"].Points.AddXY("LA LIBERTAD", ConstructorGrafica.terrenos_LaLibertad);
            this.TerrenosZonaCentral.Series["ChartLinea"].Points.AddXY("LA PAZ", ConstructorGrafica.terrenos_LaPaz);
            this.TerrenosZonaCentral.Series["ChartLinea"].Points.AddXY("SAN SALVADOR", ConstructorGrafica.terrenos_SanSalvador);
            this.TerrenosZonaCentral.Series["ChartLinea"].Points.AddXY("SAN VICENTE", ConstructorGrafica.terrenos_SanVicente);

            //Datos de tabla zona occidental terrenos
            this.TerrenosZonaOccidental.Series["ChartLinea"].Points.AddXY("LA UNION", ConstructorGrafica.terrenos_LaUnion);
            this.TerrenosZonaOccidental.Series["ChartLinea"].Points.AddXY("MORAZAN", ConstructorGrafica.terrenos_Morazan);
            this.TerrenosZonaOccidental.Series["ChartLinea"].Points.AddXY("SAN MIGUEL", ConstructorGrafica.terrenos_SanMiguel);
            this.TerrenosZonaOccidental.Series["ChartLinea"].Points.AddXY("USULUTAN", ConstructorGrafica.terrenos_Usulutan);

        }

        public Image TextoaImagenLogo(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0,
            imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            pbLogo.Image = Image.FromStream(ms);
            return image;

        }

        private void frmGraficas_Load(object sender, EventArgs e)
        {
            OcultarGraficas();
            FuncionesGrafica.ConseguirImagenEmpresa();
            txtLogo.Text = Constructor_Usuarios.imagenEmpresa;

            try
            {
                TextoaImagenLogo(txtLogo.Text);
            }
            catch (Exception)
            {
               
            }
        }

        void OcultarGraficas()
        {
            CasasZonaOccidental.Visible = false;
            CasasZonaOriental.Visible = false;
            CasasZonaCentral.Visible = false;
            ApartamentosZonaCentral.Visible = false;
            ApartamentosZonaOccidental.Visible = false;
            ApartamentosZonaOriental.Visible = false;
            TerrenosZonaCentral.Visible = false;
            TerrenosZonaOccidental.Visible = false;
            TerrenosZonaOriental.Visible = false;
            VentaTotal.Visible = false;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            OcultarGraficas();
            CasasZonaOriental.Visible = true;        
        }

        

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            OcultarGraficas();
            CasasZonaCentral.Visible = true;
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            
        }

        private void Sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ZonaOccidentalCasas_Click(object sender, EventArgs e)
        {
            OcultarGraficas();
            CasasZonaOccidental.Visible = true;
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            OcultarGraficas();
            ApartamentosZonaOriental.Visible = true;
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            OcultarGraficas();
            ApartamentosZonaCentral.Visible = true;
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            OcultarGraficas();
            ApartamentosZonaOccidental.Visible = true;
        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {
            OcultarGraficas();
            TerrenosZonaOriental.Visible = true;
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            OcultarGraficas();
            TerrenosZonaCentral.Visible = true;
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            OcultarGraficas();
            TerrenosZonaOccidental.Visible = true;
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

           

            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            btnMaximizar.Visible = false;
            btnNormal.Visible = true;
        }

        private void btnNormal_Click_1(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1174, 693);
            btnNormal.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            OcultarGraficas();
            VentaTotal.Visible = true;
        }
    }
}
