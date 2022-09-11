using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodos_Numericos.Modelo
{
    internal class NewtonRaphson_Modelo
    {
        public double x0 { get; set; }

        //METODOS

        public void getValues(double X0, NewtonRaphson _vistaNewtonRaphson)
        {
            List<double> fXn = new List<double>();
            List<double> Xn = new List<double>();
            List<double> fpX = new List<double>();
            List<double> XnX1 = new List<double>();

            Xn.Add(X0);
            XnX1.Add(0);
            //Console.WriteLine("No Existe");
            for (int i = 0; i >= 0; i++)
            {

                fXn.Add(Math.Round(((Math.Pow((Xn[i]), 3)) + (4 * (Math.Pow((Xn[i]), 2))) - 10), 6));
                fpX.Add(Math.Round(((3 * Math.Pow((Xn[i]), 2)) + (8 * Xn[i])), 6));
                if (i != 0)
                {
                    XnX1.Add(Math.Round((Math.Abs(Xn[i] - Xn[i - 1])), 6));
                }

                if (i != 0)
                {
                    if (Xn[i] == Xn[i - 1])
                    {
                        break;
                    }
                }

                Xn.Add(Math.Round((Xn[i] - (((double)fXn[i]) / (fpX[i]))), 6));

            }

            for (int i = 0; i < Xn.Count; i++)
            {
                if (i == 0)
                {
                    _vistaNewtonRaphson.tabla.Rows.Add(i, Xn[i], fXn[i], fpX[i], "No Existe");
                }
                else
                {
                    _vistaNewtonRaphson.tabla.Rows.Add(i, Xn[i], fXn[i], fpX[i], XnX1[i]);
                }
            }

        }

        public bool ValidarCamposNewtonRaphson(NewtonRaphson _vistaNewtonRaphson)
        {
            //To verify if the text field aren't empty
            if (_vistaNewtonRaphson.txtX0.Text == "")
            {
                _vistaNewtonRaphson.txtX0.Focus();
                MessageBox.Show("Llena el campo X0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (_vistaNewtonRaphson.txtX0.Text == "0")
            {
                _vistaNewtonRaphson.txtX0.Focus();
                MessageBox.Show("Ingrese Valores mayores a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

    }
}
