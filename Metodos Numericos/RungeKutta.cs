using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodos_Numericos
{
    public partial class RungeKutta : Form
    {
        public RungeKutta()
        {
            InitializeComponent();
        }

        private void BtnFormulas_Click(object sender, EventArgs e)
        {
            Formulario Form = new Formulario();
            Form.BackgroundImage = Properties.Resources.FormulasRunge_Kutta;
            Form.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                double x0 = double.Parse(txtX0.Text);//To convert the values of each text field
                double y0 = double.Parse(txtY0.Text);
                double h = double.Parse(txtH.Text);
                double Ni = double.Parse(txtNi.Text);

                tabla.Rows.Clear();//Method to clean all rows of table.
                Imprimir(x0, y0, h, Ni);
            }


        }

        private bool ValidarCampos()
        {
            //To verify if the text field aren't empty
            if (txtX0.Text == "")
            {
                txtX0.Focus();
                MessageBox.Show("Llena el campo X0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                if (txtY0.Text == "")
                {
                    txtY0.Focus();
                    MessageBox.Show("Llena el campo Y0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else
                {
                    if (txtH.Text == "")
                    {
                        txtH.Focus();
                        MessageBox.Show("Llena el campo H", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    else
                    {
                        if ((txtNi.Text == ""))
                        {
                            txtNi.Focus();
                            MessageBox.Show("Llena el campo Numero de Interaciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                        else if (int.Parse(txtNi.Text) > 900000)
                        {
                            Warning W = new Warning();
                            W.ShowDialog();
                            txtNi.Text = "";
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void Imprimir(double x0, double y0, double h, double Ni)
        {
            int noI = 0;
            double yReal = y0, yEuler = y0, erEuler=0, yEulerM = 0, erEulerM=0, yRunge = 4, erRunge=0, yF = y0, hF = h;
            do
            {
                if (noI == 0)
                {
                    yReal = Math.Round(funcion_yReal(x0), 6);
                    
                    yEuler = Math.Round(funcion_Euler(x0, y0, 0), 6);                    
                    erEuler = Math.Abs(Math.Round((100 * (yEuler - yReal) / yReal), 6));

                    yEulerM = Math.Round(funcion_EulerMejorado(x0, y0, 0), 6);
                    erEulerM = Math.Abs(Math.Round((100 * (yEulerM - yReal) / yReal), 6));

                    yRunge = Math.Round(funcion_Runge(x0, y0, 0), 6);
                    erRunge = Math.Abs(Math.Round((100 * (yRunge - yReal) / yReal), 6));
                }
                else
                {
                    yEuler = Math.Round(funcion_Euler(x0, yEuler, hF), 6);
                    yEulerM = Math.Round(funcion_EulerMejorado(x0, yEulerM, hF), 6);
                    yRunge = funcion_Runge(x0, yRunge, hF);

                    x0 = x0 + h;

                    yReal = Math.Round(funcion_yReal(x0), 6);
                    erEuler = Math.Abs(Math.Round((100 * (yEuler - yReal) / yReal), 6));
                    erEulerM = Math.Abs(Math.Round((100 * (yEulerM - yReal) / yReal), 6));
                    erRunge = Math.Abs(Math.Round((100 * (yRunge - yReal) / yReal), 6));
                }
                //MessageBox.Show("yEuler: "+ yEuler + "\nyReal: "+yReal+"\nerEuler: "+erEuler, "euler", MessageBoxButtons.OK);
                //tabla.Rows.Add(noI, x0, Math.Round(yReal, 6), Math.Round(yEuler, 6), Math.Round(erEuler, 6) + " %");
                tabla.Rows.Add(noI, x0, yReal, yEuler, erEuler + " %", yEulerM, erEulerM + " %", yRunge, erRunge+" %");

                noI++;
            } while (noI <= Ni);

        }

        double funcion_yReal(double x0)
        {

            double y = Math.Pow(((Math.Log(2 * (x0) + 1) / 4) + 2), 2);

            return y;
        }

        double funcion_Euler(double x, double y, double h)
        {
            double f = Math.Sqrt(y) / (2 * (x) + 1);

            double y1 = y + (h * f);

            return y1;
        }

        double funcion_EulerMejorado(double x, double y, double h)
        {

            double U1 = (y + h * (Math.Sqrt(y) / (2 * (x) + 1)));

            double y1 = (y + h * .5 * ((Math.Sqrt(y) / (2 * (x) + 1)) + (Math.Sqrt(U1) / (2 * (x + h) + 1))));

            return y1;
        }

        double funcion_Runge(double x, double y, double h)
        {

            double k1 = (Math.Sqrt(y) / (2 * (x) + 1));

            double k2 = (Math.Sqrt(y + (.5 * k1 * h)) / (2 * (x + (.5 * h)) + 1));

            double k3 = (Math.Sqrt(y + (.5 * k2 * h)) / (2 * (x + (.5 * h)) + 1));

            double k4 = (Math.Sqrt(y + (k3 * h)) / (2 * (x + h) + 1));

            double y1 = Math.Round((y + ((((double)1) / 6) * (k1 + (2 * k2) + (2 * k3) + k4) * h)), 6);

            return y1;
        }

        private void btnReiniciar_MouseClick(object sender, MouseEventArgs e)
        {
            txtX0.Text = "";
            txtY0.Text = "";
            txtH.Text = "";
            txtNi.Text = "";
            tabla.Rows.Clear();
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
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtY0_KeyPress(object sender, KeyPressEventArgs e)
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
            else if ((e.KeyChar == '.') && (!txtY0.Text.Contains(".")))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtH_KeyPress(object sender, KeyPressEventArgs e)
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
            else if ((e.KeyChar == '.') && (!txtH.Text.Contains(".")))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtNi_KeyPress(object sender, KeyPressEventArgs e)
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
            else if ((e.KeyChar == '.') && (!txtNi.Text.Contains(".")))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
