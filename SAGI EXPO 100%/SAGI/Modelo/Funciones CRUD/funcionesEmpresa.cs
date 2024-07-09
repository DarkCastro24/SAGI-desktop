using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using WindowsFormsApplication1.Controlador;
using WindowsFormsApplication1.Controlador.Constructores;

namespace WindowsFormsApplication1.Modelo.Funciones_CRUD
{
    class funcionesEmpresa
    {
        public static DataTable ObtenerTipo_Empresa()
        {
            string query = "SELECT * FROM tipo_empresa WHERE id_tipo_Empresa = 2";
            DataTable data = new DataTable();
            try
            {
                MySqlCommand cmdSelect = new MySqlCommand(query, Conexion.getConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdSelect);
                adapter.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ooops!, Ha ocurrido un error al obtener los tipos de usuario, consulte xon el administrado." + ex.Message, "");
                return data;
            }
            finally
            {
                Conexion.getConnection().Close();
            }

        }
        public static int AgregarEmpresa(Constructor_Empresa che)
        {
            int retorno = 0;

            try
            {
                MySqlCommand che2 = new MySqlCommand(string.Format("SELECT * FROM empresa WHERE empresa ='{0}' OR nit ='{1}'", che.Nombre_Empresa, che.nit), Conexion.getConnection());
                bool validar = Convert.ToBoolean(che2.ExecuteScalar());

                if (validar == true)
                {
                    MessageBox.Show("Error la empresa ya existe en la base de datos", "Duplicidad de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {                   
                    MySqlCommand kk = new MySqlCommand(String.Format("INSERT INTO empresa (empresa,nit,representante_legal,tipoEmpresa,direccion,logoempresa,correo_empresa) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", che.Nombre_Empresa, che.nit, che.representante, che.id_tipo_empresa, che.direccion, che.imagen,Constructor_Empresa.correoEmpresarial), Conexion.getConnection());
                    retorno = Convert.ToInt16(kk.ExecuteNonQuery());

                    if (retorno >= 1)
                    {
                        MessageBox.Show("Empresa registrada exitosamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("La empresa no pudo ser registrada", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                return retorno;

            }
            catch (Exception e)
            {
                MessageBox.Show("La empresa no pudo ser ingresada verifique su conexion a internet" + e.Message, "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static DataTable Mostrar()
        {
            DataTable ds = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT id_empresa AS ID, empresa AS Empresa, nit AS NIT , representante_legal AS Representante, tipo_empresa AS Tipo_Empresa, direccion AS Direccion , logoempresa AS logoempresa ,correo_empresa AS Correo FROM empresa INNER JOIN  tipo_empresa ON tipo_empresa.id_tipo_empresa = empresa.tipoEmpresa", Conexion.getConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds);
                return ds;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ds = new DataTable();
            }
        }

        public static int ActualizarEmpresa(Constructor_Empresa actualizar)
        {
            int retorno = 0;
            try
            {
                    MySqlCommand cmdadd = new MySqlCommand(string.Format("UPDATE `empresa` SET `empresa`='{0}',`nit`='{1}',`representante_legal`='{2}',`tipoEmpresa`='{3}',`direccion`='{4}' ,`logoempresa`='{5}', correo_empresa = '{6}' WHERE id_empresa ='{7}'", actualizar.Nombre_Empresa , actualizar.nit, actualizar.representante, actualizar.id_tipo_empresa, actualizar.direccion, actualizar.imagen, Constructor_Empresa.correoEmpresarial, Constructor_Empresa.ID_empresa), Conexion.getConnection());
                    retorno = Convert.ToInt32(cmdadd.ExecuteScalar());

                    if (retorno <= 1)
                    {
                        MessageBox.Show("La empresa fue actualizada correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("LA CHEPIE");
                    }
                
                
                return retorno;
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }

        public static int Eliminar()
        {
            int retorno = 0;

            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("DELETE FROM empresa WHERE id_empresa = '{0}'", Constructor_Empresa.ID_empresa), Conexion.getConnection());
                retorno = Convert.ToInt32(cmdadd.ExecuteScalar());                            
                MessageBox.Show("La empresa fue eliminada correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);              
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
    }
}
