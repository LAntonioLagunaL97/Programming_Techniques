﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Practica_5
{
    class Limpiar
    {
        public void BorrarCampos(Control control)
        {
            foreach (var txt in control.Controls)
            {
                if(txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
            }
                

        }
    }
}