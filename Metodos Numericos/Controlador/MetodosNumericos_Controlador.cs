using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Metodos_Numericos.Modelo;
//using Metodos_Numericos.Euler;

namespace Metodos_Numericos.Controlador
{
    internal class MetodosNumericos_Controlador
    {
        private Euler _vistaEuler;

        public MetodosNumericos_Controlador(Form vista)
        {
            this._vistaEuler = (Euler)vista;
            this._vistaEuler.btnCalcular.Click += new EventHandler(this.BtnCalcular_Click);
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            
        }

    }
}