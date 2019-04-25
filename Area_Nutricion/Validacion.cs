﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area_Nutricion
{
    class Validacion
    {
        public void soloNumeros(KeyPressEventArgs e)
        {
            if(Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }

            else if(Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}