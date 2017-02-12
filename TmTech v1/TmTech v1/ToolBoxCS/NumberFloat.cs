using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmTech_v1.ToolBoxCS
{
   public class NumberFloat:NumberInterGer
    {
       protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
       {
           if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
           {
               e.Handled = true;
           }

           // only allow one decimal point
           if ((e.KeyChar == '.') && (this.Text.IndexOf('.') > -1))
           {
               e.Handled = true;
           }
       }
       
    }
}
