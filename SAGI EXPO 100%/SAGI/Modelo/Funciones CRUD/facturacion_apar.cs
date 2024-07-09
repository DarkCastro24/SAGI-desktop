using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Controlador;
using WindowsFormsApplication1.Controlador.Constructor_CRUD;
using WindowsFormsApplication1.Controlador.Constructores;

namespace WindowsFormsApplication1.Modelo.Funciones_CRUD
{
    public class facturacion_apar
    {
        public static bool ConseguirImagenesApar()
        {
            bool retorno = false;

            MySqlCommand cmdselect = new MySqlCommand(string.Format("SELECT id_factura FROM detalleapar WHERE id_factura = (SELECT MAX(id_factura) FROM detalleapar)", ConstructorGaleria.ID), Conexion.getConnection());
            retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
            if (retorno == true)
            {
                MySqlDataReader _reader = cmdselect.ExecuteReader();
                try
                {
                    while (_reader.Read())
                    {
                        constructor_factura.Id = _reader.GetInt32(0);
                    }

                }
                catch (Exception)
                {

                    MessageBox.Show("Hubo un error al cargar las imagenes del registro seleccionado");
                    retorno = false;
                }
            }

            else
            {
                MessageBox.Show("Hubo un error al completar el proceso");
            }
            return retorno;
        }

        public static int IngresarDet(constructor_factura che)
        {
            int retorno = 0;

            try
            {
                MySqlCommand cmd = new MySqlCommand(String.Format("INSERT INTO `detalleapar`(`id_factura`, `apartamento`, `iva`, `subtotal`, `comision`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", che.Id2, che.Id_apar, che.iva, che.subtotal, che.comision), Conexion.getConnection());
                retorno = Convert.ToInt16(cmd.ExecuteNonQuery());
                if (retorno == 1)
                {
                    MessageBox.Show("Detalle Ingresado correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return retorno;
                }
                else
                {
                    return retorno;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al completar el proceso");
                return retorno;
            }
        }
        

        public static int EliminarFactura(constructor_factura che)
        {
            int retorno = 0;


            try
            {
                MySqlCommand cmd = new MySqlCommand(String.Format("DELETE FROM facturaapar WHERE id_facturaApar = '{0}'", che.id_factura), Conexion.getConnection());
                retorno = Convert.ToInt16(cmd.ExecuteNonQuery());
                if (retorno == 1)
                {
                    MessageBox.Show("Factura Eliminado correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return retorno;
                }
                else
                {
                    return retorno;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al completar el proceso");
                return retorno;
            }
        }

        public static int ActualizaCliente(Constructor_apartamento che)
        {
            int retorno = 0;
            try
            {
                int estado = 2;
                MySqlCommand cmd = new MySqlCommand(String.Format("UPDATE `apartamento` SET `id_cliente`= '{0}', estado = '{1}' WHERE id_apartamento = '{2}'", che.id_cliente, estado, Constructor_apartamento.id_apar), Conexion.getConnection());
                retorno = Convert.ToInt16(cmd.ExecuteNonQuery());
                if (retorno == 1)
                {
                    MessageBox.Show("Cliente nombrado actualizado correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return retorno;
                }
                else
                {
                    return retorno;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al completar el proceso");
                return retorno;
            }
        }

        public static DataTable mostrar()
        {
            DataTable ds = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT id_facturaapar AS ID, nombre_client AS Cliente, nombre_empl AS Empleado, estado_factura AS Estado, total AS Total, fecha_de_factura AS Fecha FROM `facturaapar`  INNER JOIN cliente ON cliente.id_cliente = facturaapar.cliente INNER JOIN empleados ON empleados.id_empleado = facturaapar.empleado INNER JOIN estadofactura ON estadofactura.id_estado = facturaapar.estado WHERE id_facturaApar = (SELECT MAX(id_facturaApar) FROM facturaapar)", Conexion.getConnection());
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



        public static DataTable ObtenerEstadoFactura()
        {
            string query = "SELECT * FROM estadofactura";
            DataTable data = new DataTable();
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion.getConnection());
                MySqlDataAdapter Adapter = new MySqlDataAdapter(cmdselect);
                Adapter.Fill(data);
                return data;

            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
            finally
            {
                Conexion.getConnection().Close();
            }
        }



        public static int IngresaeFactura(constructor_factura che)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(string.Format("SELECT * FROM facturaapar WHERE detalle = ?detalle"), Conexion.getConnection());
                cmdselect.Parameters.Add(new MySqlParameter("detalle", che.detalle));
                MySqlDataReader dr = cmdselect.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("El registro ya existe", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return retorno = 0;
                }
                else
                {
                    MySqlCommand cmd = new MySqlCommand(String.Format("INSERT INTO `facturaapar`(`id_facturaapar`, `cliente`, `empleado`, `estado`, `detalle`, `total`, `fecha_de_factura`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", che.id_factura, constructor_factura.id_cliente , ConstructorCambiarContraseña.ID_Usuario, che.estado, che.detalle, constructor_factura.total, che.fecha), Conexion.getConnection());
                    retorno = Convert.ToInt16(cmd.ExecuteNonQuery());
                    if (retorno == 1)
                    {
                        MessageBox.Show("Factura Ingresado correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return retorno;
                    }
                    else
                    {
                        return retorno;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Hubo un error al completar el proceso" + e);
                return retorno;
            }
        }

        public static DataTable Mostrar()
        {
            DataTable ds;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT id_cliente AS ID, tipo_Cliente AS Tipo_Cliente, genero AS Genero, estado_cliente AS Estado, estado_Civil AS Estado_Civil, nombre_client AS Nombre, apellido_cliente AS Apellidos, dui AS DUI, nacimiento_cliente AS Nacimiento, correo_cliente AS Correo, direccion_cliente AS Direccion, telefono AS Telefono FROM cliente INNER JOIN tipoCliente ON tipoCliente.id_tipoCliente = cliente.tipoCliente INNER JOIN estadoCivil ON estadoCivil.id_estadoCivil = cliente.estadoCivil INNER JOIN tbgenero ON tbgenero.id_genero = cliente.id_genero INNER JOIN estadoclien ON estadoClien.id_estado = cliente.id_estado ", Conexion.getConnection());
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                ds = new DataTable();
                ad.Fill(ds);
                return ds;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ds = new DataTable();
            }
        }


        //Historial de factura
        public static DataTable Historial()
        {
            DataTable ds = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT id_facturaapar AS ID, CONCAT(nombre_client, ' ', apellido_cliente) AS Cliente, CONCAT(nombre_empl, ' ', apellido_empl) AS Empleado, estado_factura AS Estado, total AS Total, fecha_de_factura AS Fecha FROM `facturaapar`  INNER JOIN cliente ON cliente.id_cliente = facturaapar.cliente INNER JOIN empleados ON empleados.id_empleado = facturaapar.empleado INNER JOIN estadofactura ON estadofactura.id_estado = facturaapar.estado", Conexion.getConnection());
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

        public static DataTable BusquedaFiltrada(constructor_factura che)
        {
            DataTable ds = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand(String.Format("SELECT id_facturaapar AS ID, CONCAT(nombre_client, ' ', apellido_cliente) AS Cliente, CONCAT(nombre_empl, ' ', apellido_empl) AS Empleado, estado_factura AS Estado, total AS Total, fecha_de_factura AS Fecha FROM `facturaapar`  INNER JOIN cliente ON cliente.id_cliente = facturaapar.cliente INNER JOIN empleados ON empleados.id_empleado = facturaapar.empleado INNER JOIN estadofactura ON estadofactura.id_estado = facturaapar.estado WHERE fecha_de_factura LIKE CONCAT ('%',?fecha,'%')"), Conexion.getConnection());
                cmd.Parameters.Add(new MySqlParameter("fecha", che.fecha));
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                ad.Fill(ds);
                return ds;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error crítico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ds;
            }
        }
    }   
}
