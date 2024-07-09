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
    class facturacion_terreno
    {
        public static bool ConseguirImagenesApar()
        {
            bool retorno = false;

            MySqlCommand cmdselect = new MySqlCommand(string.Format("SELECT id_factura FROM detalleterreno WHERE id_factura = (SELECT MAX(id_factura) FROM detalleterreno)", ConstructorGaleria.ID), Conexion.getConnection());
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
                MySqlCommand cmd = new MySqlCommand(String.Format("INSERT INTO `detalleterreno`(`id_factura`, `terreno`, `iva`, `subtotal`, `comision`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", che.Id2, che.Id_apar, che.iva, che.subtotal, che.comision), Conexion.getConnection());
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
                MySqlCommand cmd = new MySqlCommand(String.Format("DELETE FROM facturaterreno WHERE id_facturaTerr = '{0}'", che.id_factura), Conexion.getConnection());
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

        public static DataTable mostrar()
        {
            DataTable ds = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT id_facturaterr AS ID, nombre_client AS Cliente, nombre_empl AS Empleado, estado_factura AS Estado, total AS Total, fecha_de_factura AS Fecha FROM `facturaterreno`  INNER JOIN cliente ON cliente.id_cliente = facturaterreno.cliente INNER JOIN empleados ON empleados.id_empleado = facturaterreno.empleado INNER JOIN estadofactura ON estadofactura.id_estado = facturaterreno.estado WHERE id_facturaTerr = (SELECT MAX(id_facturaTerr) FROM facturaterreno)", Conexion.getConnection());
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

        public static int ActualizaCliente(Constructor_apartamento che)
        {
            int retorno = 0;
            try
            {
                int estado = 2;
                MySqlCommand cmd = new MySqlCommand(String.Format("UPDATE `terreno` SET `id_cliente`= '{0}', estado = '{1}' WHERE id_terreno = '{2}'", che.id_cliente, estado ,Constructor_apartamento.id_apar), Conexion.getConnection());
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

        public static int IngresaeFactura(constructor_factura che)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(string.Format("SELECT * FROM facturaterreno WHERE detalle = ?detalle"), Conexion.getConnection());
                cmdselect.Parameters.Add(new MySqlParameter("detalle", che.detalle));
                MySqlDataReader dr = cmdselect.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("El registro ya existe", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return retorno = 0;
                }
                else
                {
                    MySqlCommand cmd = new MySqlCommand(String.Format("INSERT INTO `facturaterreno`(`id_facturaTerr`, `cliente`, `empleado`, `estado`, `total`, `fecha_de_factura`, `detalle`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", che.id_factura, constructor_factura.id_cliente, ConstructorCambiarContraseña.ID_Usuario, che.estado, constructor_factura.total, che.fecha, che.detalle), Conexion.getConnection());
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

        //Historial

        public static DataTable Historial()
        {
            DataTable ds = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT id_facturaterr AS ID, nombre_client AS Cliente, nombre_empl AS Empleado, estado_factura AS Estado, total AS Total, fecha_de_factura AS Fecha FROM `facturaterreno`  INNER JOIN cliente ON cliente.id_cliente = facturaterreno.cliente INNER JOIN empleados ON empleados.id_empleado = facturaterreno.empleado INNER JOIN estadofactura ON estadofactura.id_estado = facturaterreno.estado", Conexion.getConnection());
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
                MySqlCommand cmd = new MySqlCommand(String.Format("SELECT id_facturaterr AS ID, nombre_client AS Cliente, nombre_empl AS Empleado, estado_factura AS Estado, total AS Total, fecha_de_factura AS Fecha FROM `facturaterreno`  INNER JOIN cliente ON cliente.id_cliente = facturaterreno.cliente INNER JOIN empleados ON empleados.id_empleado = facturaterreno.empleado INNER JOIN estadofactura ON estadofactura.id_estado = facturaterreno.estado WHERE fecha_de_factura LIKE CONCAT ('%',?fecha,'%')"), Conexion.getConnection());
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
