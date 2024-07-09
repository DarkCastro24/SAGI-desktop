using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Controlador;
using WindowsFormsApplication1.Controlador.Constructores;

namespace WindowsFormsApplication1.Graficas
{
    class FuncionesGrafica
    {
        public static bool ConseguirImagenEmpresa()
        {
            bool retorno = false;
            
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(string.Format("SELECT * FROM empresa WHERE id_empresa = '{0}'", Constructor_Usuarios.id_empresa), Conexion.getConnection());
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());

                if (retorno == true)
                {
                    MySqlDataReader _reader = cmdselect.ExecuteReader();
                    while (_reader.Read())
                    {
                        try
                        {
                            Constructor_Usuarios.imagenEmpresa = _reader.GetString(6);

                        }
                        catch (Exception)
                        {
                   
                        }
                    }
                }
                return retorno;
            }
            catch (Exception)
            {

                MessageBox.Show("Oops!", "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }       
        }

        //METODOS PARA OBTENER DATOS CASAS
        public static int CasasAhuachapan()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM casa WHERE id_departamento = 1 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.casas_Ahuachapan = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int CasasCuscatlan()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM casa WHERE id_departamento = 2 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.casas_Cuscatlan = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int CasasChalatenango()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM casa WHERE id_departamento = 3 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.casas_Chalatenango = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int CasasCabañas()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM casa WHERE id_departamento = 4 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.casas_Cabañas = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int CasasLaLibertad()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM casa WHERE id_departamento = 5 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.casas_LaLibertad = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int CasasLaPaz()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM casa WHERE id_departamento = 6 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.casas_LaPaz = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int CasasLaUnion()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM casa WHERE id_departamento = 7 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.casas_LaUnion = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int CasasMorazan()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM casa WHERE id_departamento = 8 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.casas_Morazan = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int CasasSanMiguel()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM casa WHERE id_departamento = 9 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.casas_SanMiguel = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int CasasSanSalvador()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM casa WHERE id_departamento = 10 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.casas_SanSalvador = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int CasasSanVicente()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM casa WHERE id_departamento = 11 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.casas_SanVicente = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int CasasSantaAna()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM casa WHERE id_departamento = 12 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.casas_SantaAna = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int CasasSonsonate()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM casa WHERE id_departamento = 13 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.casas_Sonsonate = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int CasasUsulutan()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM casa WHERE id_departamento = 14 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.casas_Usulutan = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        //METODOS PARA OBTENER DATOS APARTAMENTOS
        public static int ApartamentosAhuachapan()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM apartamento WHERE id_departamento = 1 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.apar_Ahuachapan = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int ApartamentosCuscatlan()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM apartamento WHERE id_departamento = 2 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.apar_Cuscatlan= row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int ApartamentosChalatenango()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM apartamento WHERE id_departamento = 3 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.apar_Chalatenango = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int ApartamentosCabañas()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM apartamento WHERE id_departamento = 4 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.apar_Cabañas = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int ApartamentosLaLibertad()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM apartamento WHERE id_departamento = 5 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.apar_LaLibertad = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int ApartamentosLaPaz()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM apartamento WHERE id_departamento = 6 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.apar_LaPaz = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int ApartamentosLaUnion()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM apartamento WHERE id_departamento = 7 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.apar_LaUnion = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int ApartamentosMorazan()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM apartamento WHERE id_departamento = 8 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.apar_Morazan = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int ApartamentosSanMiguel()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM apartamento WHERE id_departamento = 9 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.apar_SanMiguel = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int ApartamentosSanSalvador()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM apartamento WHERE id_departamento = 10 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.apar_SanSalvador = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int ApartamentosSanVicente()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM apartamento WHERE id_departamento = 11 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.apar_SanVicente = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int ApartamentosSantaAna()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM apartamento WHERE id_departamento = 12 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.apar_SantaAna = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int ApartamentosSonsonate()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM apartamento WHERE id_departamento = 13 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.apar_Sonsonate = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int ApartamentosUsulutan()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM apartamento WHERE id_departamento = 14 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.apar_Usulutan = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        //METODOS PARA OBTENER DATOS TERRENOS
        public static int TerrenosAhuachapan()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM terreno WHERE id_departamento = 1 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.terrenos_Ahuachapan = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int TerrenosCuscatlan()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM terreno WHERE id_departamento = 2 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.terrenos_Cuscatlan = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int TerrenosChalatenango()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM terreno WHERE id_departamento = 3 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.terrenos_Chalatenango = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int TerrenosCabañas()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM terreno WHERE id_departamento = 4 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.terrenos_Cabañas = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int TerrenosLaLibertad()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM terreno WHERE id_departamento = 5 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.terrenos_LaLibertad = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int TerrenosLaPaz()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM terreno WHERE id_departamento = 6 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.terrenos_LaPaz = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int TerrenosLaUnion()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM terreno WHERE id_departamento = 7 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.terrenos_LaUnion = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int TerrenosMorazan()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM terreno WHERE id_departamento = 8 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.terrenos_Morazan = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int TerrenosSanMiguel()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM terreno WHERE id_departamento = 9 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.terrenos_SanMiguel = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int TerrenosSanSalvador()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM terreno WHERE id_departamento = 10 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.terrenos_SanSalvador = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int TerrenosSanVicente()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM terreno WHERE id_departamento = 11 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.terrenos_SanVicente = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int TerrenosSantaAna()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM terreno WHERE id_departamento = 12 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.terrenos_SantaAna = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int TerrenosSonsonate()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM terreno WHERE id_departamento = 13 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.terrenos_Sonsonate = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int TerrenosUsulutan()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM terreno WHERE id_departamento = 14 AND estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.terrenos_Usulutan = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int ObtenerTodasLasVentasApartamentos()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM apartamento where estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.TodosApartamentos = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int ObtenerTodasLasVentasCasas()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM casa where estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.TodasCasas = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }

        public static int ObtenerTodasLasVentasTerrenos()
        {
            int retorno = 0;
            try
            {
                MySqlCommand che = new MySqlCommand(string.Format("SELECT COUNT(*) FROM terreno where estado = 2"), Conexion.getConnection());
                int row;
                row = Convert.ToInt32(che.ExecuteScalar());
                ConstructorGrafica.TodosTerrenos = row;
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico de conexion");
                return retorno;
            }
        }
    }
}
