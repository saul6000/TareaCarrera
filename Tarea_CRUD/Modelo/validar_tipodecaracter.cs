using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Tarea_CRUD.Modelo
{
  public  class validar_tipodecaracter
    {
        public static void letra(KeyPressEventArgs v)
        {
            if (Char.IsLetter(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;

            }

        }
        public static void Numeros(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;

            }
        }
        public static bool ValidarCampoDecimal(TextBox CajaDeTexto)
        {
            try
            {
                decimal d = Convert.ToDecimal(CajaDeTexto.Text);
                return true;
            }
            catch (Exception)
            {
                CajaDeTexto.Text = "0";
                CajaDeTexto.Select(0, CajaDeTexto.Text.Length);
                return false;
            }
        }
    }
}
