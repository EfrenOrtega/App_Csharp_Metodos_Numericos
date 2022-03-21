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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.Visible = true;
            this.Visible = false;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(255, 64, 64);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(22, 26, 29);
        }
        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(44, 50, 55);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(22, 26, 29);
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnMethod1_Click(object sender, EventArgs e)
        {
            //To add a line styles to the btn when we push on it.
            PanelSelector.Visible = true;
            PanelSelector.Height = BtnMethod1.Height;
            PanelSelector.Top = BtnMethod1.Top;
            PanelSelector.Left = BtnMethod1.Left;
            BtnMethod1.BackColor = Color.FromArgb(32, 40, 46); ;
        }

        private void BtnMethod2_Click(object sender, EventArgs e)
        {
            //To add a line styles to the btn when we push on it.
            PanelSelector.Visible = true;
            PanelSelector.Height = BtnMethod2.Height;
            PanelSelector.Top = BtnMethod2.Top;
            BtnMethod2.BackColor = Color.FromArgb(32, 40, 46);
        }

        private void BtnMethod3_Click(object sender, EventArgs e)
        {
            //To add a line styles to the btn when we push on it.
            PanelSelector.Visible = true;
            PanelSelector.Height = BtnMethod3.Height;
            PanelSelector.Top = BtnMethod3.Top;
            BtnMethod3.BackColor = Color.FromArgb(32, 40, 46);
        }

        private void BtnMethod4_Click(object sender, EventArgs e)
        {
            //To add a line styles to the btn when we push on it.
            PanelSelector.Visible = true;
            PanelSelector.Height = BtnMethod4.Height;
            PanelSelector.Top = BtnMethod4.Top;
            BtnMethod4.BackColor = Color.FromArgb(32, 40, 46);
        }


        private void BtnMethod1_Leave(object sender, EventArgs e)
        {
            BtnMethod1.BackColor = Color.FromArgb(38, 50, 57);
        }

        private void BtnMethod2_Leave(object sender, EventArgs e)
        {
            BtnMethod2.BackColor = Color.FromArgb(38, 50, 57);
        }

        private void BtnMethod3_Leave(object sender, EventArgs e)
        {
            BtnMethod3.BackColor = Color.FromArgb(38, 50, 57);
        }

        private void BtnMethod4_Leave(object sender, EventArgs e)
        {
            BtnMethod4.BackColor = Color.FromArgb(38, 50, 57);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtX0_TextChanged(object sender, EventArgs e)
        {

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

        private void btnCalcular_MouseClick(object sender, MouseEventArgs e)
        {
            if (ValidarCampos())
            {
                double x0 = double.Parse(txtX0.Text);
                double y0 = double.Parse(txtY0.Text);
                double h = double.Parse(txtH.Text);
                double Ni = double.Parse(txtNi.Text);

                tabla.Rows.Clear();

                Imprimir(x0, y0, h, Ni);

            }


        }

        private bool ValidarCampos()
        {
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
                        if (txtNi.Text == "")
                        {
                            txtNi.Focus();
                            MessageBox.Show("Llena el campo Numero de Interaciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void btnReiniciar_MouseClick(object sender, MouseEventArgs e)
        {
            txtX0.Text = "";
            txtY0.Text = "";
            txtH.Text = "";
            txtNi.Text = "";
            tabla.Rows.Clear();
        }

        private void Imprimir(double x0, double y0, double h, double Ni)
        {
            int noI = 0;
            double yReal = y0, yEuler = y0, erEuler, yF = y0, hF = h;
            do
            {
                if (noI == 0)
                {
                    yEuler = Math.Round(funcion_Euler(x0, y0, 0), 6);
                    yReal = Math.Round(funcion_yReal(x0), 6);
                    erEuler = Math.Round((100 * (yEuler - yReal) / yReal), 6);
                }
                else
                {
                    yEuler = Math.Round(funcion_Euler(x0, yEuler, hF), 6);
                    x0 = x0 + h;
                    yReal = Math.Round(funcion_yReal(x0), 6);
                    erEuler = Math.Round((100 * (yEuler - yReal) / yReal), 6);
                }
                //MessageBox.Show("yEuler: "+ yEuler + "\nyReal: "+yReal+"\nerEuler: "+erEuler, "euler", MessageBoxButtons.OK);
                //tabla.Rows.Add(noI, x0, Math.Round(yReal, 6), Math.Round(yEuler, 6), Math.Round(erEuler, 6) + " %"); 
                tabla.Rows.Add(noI, x0, yReal, yEuler, erEuler + " %");

                noI++;
            } while (noI <= Ni);
        }
        double funcion_yReal(double x0)
        {

            double y = Math.Pow(((Math.Log(2 * (x0) + 1) / 4) + 2), 2);

            return y;
        }

        double funcion_Euler(double x, double y, double h)
        {            //función y´= Raiz(y)/2x+1{	

            double f = Math.Sqrt(y) / (2 * (x) + 1);

            double y1 = y + (h * f);

            return y1;
        }

        private void tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }
    }
    }
