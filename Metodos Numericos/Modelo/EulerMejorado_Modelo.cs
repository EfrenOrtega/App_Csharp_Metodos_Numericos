using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodos_Numericos.Modelo
{
    internal class EulerMejorado_Modelo
    {
        public double x0 { get; set; }
        public double y0 { get; set; }
        public double h { get; set; }
        public double Ni { get; set; }

        //METODOS

        public double funcion_EulerMejorado(double x, double y, double h)
        {
            double U1 = (y + h * (Math.Sqrt(y) / (2 * (x) + 1)));

            double y1 = (y + h * .5 * ((Math.Sqrt(y) / (2 * (x) + 1)) + (Math.Sqrt(U1) / (2 * (x + h) + 1))));

            return y1;
        }

        public bool ValidarCamposEulerMejorado(EulerMejorado _vistaEulerMejorado)
        {
            //To verify if the text field aren't empty
            if (_vistaEulerMejorado.txtX0.Text == "")
            {
                _vistaEulerMejorado.txtX0.Focus();
                MessageBox.Show("Llena el campo X0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                if (_vistaEulerMejorado.txtY0.Text == "")
                {
                    _vistaEulerMejorado.txtY0.Focus();
                    MessageBox.Show("Llena el campo Y0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else
                {
                    if (_vistaEulerMejorado.txtH.Text == "")
                    {
                        _vistaEulerMejorado.txtH.Focus();
                        MessageBox.Show("Llena el campo H", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    else
                    {
                        if ((_vistaEulerMejorado.txtNi.Text == ""))
                        {
                            _vistaEulerMejorado.txtNi.Focus();
                            MessageBox.Show("Llena el campo Numero de Interaciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                        else if (int.Parse(_vistaEulerMejorado.txtNi.Text) > 900000)
                        {
                            Warning W = new Warning();
                            W.ShowDialog();
                            _vistaEulerMejorado.txtNi.Text = "";
                            return false;
                        }
                    }
                }
            }
            return true;
        }

    }
}
