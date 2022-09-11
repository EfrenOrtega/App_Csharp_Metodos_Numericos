using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodos_Numericos.Modelo
{
    internal class RungeKutta_Modelo
    {
        public double x0 { get; set; }
        public double y0 { get; set; }
        public double h { get; set; }
        public double Ni { get; set; }

        //METODOS

        public double funcion_Runge(double x, double y, double h)
        {

            double k1 = (Math.Sqrt(y) / (2 * (x) + 1));

            double k2 = (Math.Sqrt(y + (.5 * k1 * h)) / (2 * (x + (.5 * h)) + 1));

            double k3 = (Math.Sqrt(y + (.5 * k2 * h)) / (2 * (x + (.5 * h)) + 1));

            double k4 = (Math.Sqrt(y + (k3 * h)) / (2 * (x + h) + 1));

            double y1 = Math.Round((y + ((((double)1) / 6) * (k1 + (2 * k2) + (2 * k3) + k4) * h)), 6);

            return y1;
        }

        public bool ValidarCamposRungeKutta(RungeKutta _vistaRungeKutta)
        {
            //To verify if the text field aren't empty
            if (_vistaRungeKutta.txtX0.Text == "")
            {
                _vistaRungeKutta.txtX0.Focus();
                MessageBox.Show("Llena el campo X0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                if (_vistaRungeKutta.txtY0.Text == "")
                {
                    _vistaRungeKutta.txtY0.Focus();
                    MessageBox.Show("Llena el campo Y0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else
                {
                    if (_vistaRungeKutta.txtH.Text == "")
                    {
                        _vistaRungeKutta.txtH.Focus();
                        MessageBox.Show("Llena el campo H", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    else
                    {
                        if ((_vistaRungeKutta.txtNi.Text == ""))
                        {
                            _vistaRungeKutta.txtNi.Focus();
                            MessageBox.Show("Llena el campo Numero de Interaciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                        else if (int.Parse(_vistaRungeKutta.txtNi.Text) > 900000)
                        {
                            Warning W = new Warning();
                            W.ShowDialog();
                            _vistaRungeKutta.txtNi.Text = "";
                            return false;
                        }
                    }
                }
            }
            return true;
        }

    }
}
