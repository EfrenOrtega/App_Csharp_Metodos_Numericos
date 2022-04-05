using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Metodos_Numericos
{
    public partial class NewtonRaphson : Form
    {
        public NewtonRaphson()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                double x0 = double.Parse(txtX0.Text);

                tabla.Rows.Clear();//Method to clean all rows of table.
                getValues(x0);
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

            if (txtX0.Text == "0") {
                txtX0.Focus();
                MessageBox.Show("Ingrese Valores mayores a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            
            return true;
        }


        private void getValues(double X0) {
            List<double> fXn = new List<double>();
            List<double> Xn = new List<double>();
            List<double> fpX = new List<double>();
            List<double> XnX1 = new List<double>();


            Xn.Add(X0);
            XnX1.Add(0);
            Console.WriteLine("No Existe");
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
                    tabla.Rows.Add(i, Xn[i], fXn[i], fpX[i], "No Existe");
                }
                else
                {
                    tabla.Rows.Add(i, Xn[i], fXn[i], fpX[i], XnX1[i]);
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
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

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtX0.Text = "";
            tabla.Rows.Clear();
        }

        private void BtnFormulas_Click(object sender, EventArgs e)
        {
            Formulario Form = new Formulario();
            Form.BackgroundImage = Properties.Resources.FormulasNewton;
            Form.ShowDialog();
        }
    }
}
