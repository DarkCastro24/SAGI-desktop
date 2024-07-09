using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Modelo.Funciones_CRUD
{
    class Validaciones
    {
        public static void SolamenteLetras(KeyPressEventArgs e)
        {
            
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

        }

        public static void SolamenteNumerosEnteros(KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

        }

        public static void NoEspacios(KeyPressEventArgs e)
        {
            if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

        }

        // Solo agarra letras y espacios 

        // Validacion para ingresar solemente numeros decimales con 1 punto
        //if (textbox.Text.Contains('.'))
        //{
        //    if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
        //    {
        //          if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '.')
        //            {
        //                e.Handled = false;
        //            }
        //            else
        //            {
        //                e.Handled = true;
        //            }                            
        //     }
        //     else
        //     {
        //        e.Handled = true;
        //     }
        //  }

        // Solo permite numeros enteros sin ningun .

        // Validacion para el copy paste borra el valor ingresado en el textbox (COLOCAR EN EL EVENTO KEY_DOWN)
        //if (e.Control && e.KeyCode == Keys.V)
        //    {
        //        MessageBox.Show("No puede copiar datos en este campo","Copy Paste",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        //        textBox4.Clear();
        //    }
    }
}
