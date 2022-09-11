using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Metodos_Numericos.Modelo;
using Metodos_Numericos.Controlador;

namespace Metodos_Numericos
{
    public partial class NewtonRaphson : Form
    {
        public NewtonRaphson()
        {
            InitializeComponent();
            NewtonRaphson_Modelo modelo = new NewtonRaphson_Modelo();
            NewtonRaphson_Controlador controlador = new NewtonRaphson_Controlador(modelo, this);
        }

        private void txtX0_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion para solo números
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            /*verifica que pueda ingresar punto y también que solo pueda
           ingresar un punto*/
            else if ((e.KeyChar == '.') && (!txtX0.Text.Contains(".")))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else{
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
