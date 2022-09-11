using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodos_Numericos.Modelo
{
    internal class Euler_Modelo
    {
        public double x0 { get; set; }
        public double y0 { get; set; }
        public double h { get; set; }
        public double Ni { get; set; }

        //METODOS

        public double funcion_yReal(double x0)
        {

            double y = Math.Pow(((Math.Log(2 * (x0) + 1) / 4) + 2), 2);

            return y;
        }

        public double funcion_Euler(double x, double y, double h)
        {
            double f = Math.Sqrt(y) / (2 * (x) + 1);

            double y1 = y + (h * f);

            return y1;
        }

        public bool ValidarCamposEuler(Euler _vistaEuler)
        {
            //To verify if the text field aren't empty
            if (_vistaEuler.txtX0.Text == "")
            {
                _vistaEuler.txtX0.Focus();
                MessageBox.Show("Llena el campo X0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                if (_vistaEuler.txtY0.Text == "")
                {
                    _vistaEuler.txtY0.Focus();
                    MessageBox.Show("Llena el campo Y0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else
                {
                    if (_vistaEuler.txtH.Text == "")
                    {
                        _vistaEuler.txtH.Focus();
                        MessageBox.Show("Llena el campo H", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    else
                    {
                        if ((_vistaEuler.txtNi.Text == ""))
                        {
                            _vistaEuler.txtNi.Focus();
                            MessageBox.Show("Llena el campo Numero de Interaciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                        else if (int.Parse(_vistaEuler.txtNi.Text) > 900000)
                        {
                            Warning W = new Warning();
                            W.ShowDialog();
                            _vistaEuler.txtNi.Text = "";
                            return false;
                        }
                    }
                }
            }
            return true;
        }

    }
}
