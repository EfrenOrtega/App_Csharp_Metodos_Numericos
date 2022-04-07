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
    
    public partial class GaussSeidel : Form
    {
        int[] ecuacionX = new int[4];
        int[] ecuacionY = new int[4];
        int[] ecuacionZ = new int[4];

        int x1, x2, x3, y1, y2, y3, z1, z2, z3, num1, num2, num3;

        public GaussSeidel()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            x1 = 0; x2 = 0; x3 = 0; y1 = 0; y2 = 0; y3 = 0; z1 = 0; z2 = 0; z3 = 0; num1 = 0; num2 = 0; num3 = 0;
            if (ValidarCampos())
            {
                x1 = int.Parse(txtX1.Text);//To convert the values of each text field
                x2 = int.Parse(txtX2.Text);
                x3 = int.Parse(txtX3.Text);

                y1 = int.Parse(txtY1.Text);
                y2 = int.Parse(txtY2.Text);
                y3 = int.Parse(txtY3.Text);


                z1 = int.Parse(txtZ1.Text);
                z2 = int.Parse(txtZ2.Text);
                z3 = int.Parse(txtZ3.Text);

                num1 = int.Parse(txtNum1.Text);
                num2 = int.Parse(txtNum2.Text);
                num3 = int.Parse(txtNum3.Text);

                imprimirMatriz1(x1, x2, x3, y1, y2, y3, z1, z2, z3, num1, num2, num3);

                imprimirMatriz2(x1, x2, x3, y1, y2, y3, z1, z2, z3, num1, num2, num3);

                tabla.Rows.Clear();//Method to clean all rows of table.

                imprimirTabla();

            }
        }

        private void imprimirMatriz1(int x1, int x2, int x3, int y1, int y2, int y3, int z1, int z2, int z3, int num1, int num2, int num3)
        {
            M1Ecu1.Text = x1 + "x " + signo(y1) + " " + Math.Abs(y1) + "y " + signo(z1) + " " + Math.Abs(z1) + "z = " + num1;
            M1Ecu2.Text = x2 + "x " + signo(y2) + " " + Math.Abs(y2) + "y " + signo(z2) + " " + Math.Abs(z2) + "z = " + num2;
            M1Ecu3.Text = x3 + "x " + signo(y3) + " " + Math.Abs(y3) + "y " + signo(z3) + " " + Math.Abs(z3) + "z = " + num3;
        }

        private void imprimirMatriz2(int x1, int x2, int x3, int y1, int y2, int y3, int z1, int z2, int z3, int num1, int num2, int num3)
        {
            if (NumMayor(x1, x2, x3) == x1)
            {
                M2Ecu1.Text = x1 + "x " + signo(y1) + " " + Math.Abs(y1) + "y " + signo(z1) + " " + Math.Abs(z1) + "z = " + num1;

                imprimirEcDesX(x1, y1, z1, num1);

                if (NumMayor2(y2, y3) == y2)
                {
                    M2Ecu2.Text = x2 + "x " + signo(y2) + " " + Math.Abs(y2) + "y " + signo(z2) + " " + Math.Abs(z2) + "z = " + num2;
                    M2Ecu3.Text = x3 + "x " + signo(y3) + " " + Math.Abs(y3) + "y " + signo(z3) + " " + Math.Abs(z3) + "z = " + num3;

                    imprimirEcDesY(x2, y2, z2, num2);

                    imprimirEcDesZ(x3, y3, z3, num3);

                }
                else
                {
                    M2Ecu2.Text = x3 + "x " + signo(y3) + " " + Math.Abs(y3) + "y " + signo(z3) + " " + Math.Abs(z3) + "z = " + num3;
                    M2Ecu3.Text = x2 + "x " + signo(y2) + " " + Math.Abs(y2) + "y " + signo(z2) + " " + Math.Abs(z2) + "z = " + num2;

                    imprimirEcDesY(x3, y3, z3, num3);

                    imprimirEcDesZ(x2, y2, z2, num2);

                }
            }
            else if (NumMayor(x1, x2, x3) == x2)
            {
                M2Ecu1.Text = x2 + "x " + signo(y2) + " " + Math.Abs(y2) + "y " + signo(z2) + " " + Math.Abs(z2) + "z = " + num2;

                imprimirEcDesX(x2, y2, z2, num2);

                if (NumMayor2(y1, y3) == y1)
                {
                    M2Ecu2.Text = x1 + "x " + signo(y1) + " " + Math.Abs(y1) + "y " + signo(z1) + " " + Math.Abs(z1) + "z = " + num1;
                    M2Ecu3.Text = x3 + "x " + signo(y3) + " " + Math.Abs(y3) + "y " + signo(z3) + " " + Math.Abs(z3) + "z = " + num3;

                    imprimirEcDesY(x1, y1, z1, num1);

                    imprimirEcDesZ(x3, y3, z3, num3);

                }
                else
                {
                    M2Ecu3.Text = x1 + "x " + signo(y1) + " " + Math.Abs(y1) + "y " + signo(z1) + " " + Math.Abs(z1) + "z = " + num1;
                    M2Ecu2.Text = x3 + "x " + signo(y3) + " " + Math.Abs(y3) + "y " + signo(z3) + " " + Math.Abs(z3) + "z = " + num3;

                    imprimirEcDesY(x3, y3, z3, num3);

                    imprimirEcDesZ(x1, y1, z1, num1);

                }
            }
            else if (NumMayor(x1, x2, x3) == x3)
            {
                M2Ecu1.Text = x3 + "x " + signo(y3) + " " + Math.Abs(y3) + "y " + signo(z3) + " " + Math.Abs(z3) + "z = " + num3;

                imprimirEcDesX(x3, y3, z3, num3);

                if (NumMayor2(y1, y2) == y1)
                {
                    M2Ecu2.Text = x1 + "x " + signo(y1) + " " + Math.Abs(y1) + "y " + signo(z1) + " " + Math.Abs(z1) + "z = " + num1;
                    M2Ecu3.Text = x2 + "x " + signo(y2) + " " + Math.Abs(y2) + "y " + signo(z2) + " " + Math.Abs(z2) + "z = " + num2;

                    imprimirEcDesY(x1, y1, z1, num1);

                    imprimirEcDesZ(x2, y2, z2, num2);

                }
                else
                {
                    M2Ecu3.Text = x1 + "x " + signo(y1) + " " + Math.Abs(y1) + "y " + signo(z1) + " " + Math.Abs(z1) + "z = " + num1;
                    M2Ecu2.Text = x2 + "x " + signo(y2) + " " + Math.Abs(y2) + "y " + signo(z2) + " " + Math.Abs(z2) + "z = " + num2;

                    imprimirEcDesY(x2, y2, z2, num2);

                    imprimirEcDesZ(x1, y1, z1, num1);

                }
            }
            /*
            M2Ecu1.Text = x1 + "x " + signo(y1) + " " + Math.Abs(y1) + "y " + signo(z1) + " " + Math.Abs(z1) + "z = " + num1;
            M2Ecu2.Text = x2 + "x " + signo(y2) + " " + Math.Abs(y2) + "y " + signo(z2) + " " + Math.Abs(z2) + "z = " + num2;
            M2Ecu3.Text = x3 + "x " + signo(y3) + " " + Math.Abs(y3) + "y " + signo(z3) + " " + Math.Abs(z3) + "z = " + num3;
        */
        }

        private int NumMayor(int num1, int num2, int num3)
        {
            if(num1 > num2 && num1 > num3)
            {
                return num1;
            }else if(num2 > num3 && num2 > num3)
            {
                return num2;
            }else if(num3 > num1 && num3 > num2)
            {
                return num3;
            }

            if(num1 == num2 && num1==num3)
            {
                return num1;
            }

            return num1;
        }

        private int NumMayor2(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else if(num2 > num1)
            {
                return num2;
            }
            if(num1 == num2)
            {
                return num1;
            }
            return num1;
        }

        private string signo(int num)
        {
            if (num < 0)
            {
                return "-";
            }
            else
            {
                return "+";            
            }
        }

        private bool ValidarCampos()
        {
            //To verify if the text field aren't empty
            if (txtX1.Text == "" || txtX2.Text == "" || txtX3.Text == "")
            {
                MessageBox.Show("Falta llenar algun campo de una X", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                if (txtY1.Text == "" || txtY2.Text == "" || txtY3.Text == "")
                {
                    MessageBox.Show("Falta llenar algun campo de una Y", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else
                {
                    if (txtZ1.Text == "" || txtZ2.Text == "" || txtZ3.Text == "")
                    {
                        MessageBox.Show("Falta llenar algun campo de una Z", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    else
                    {
                        if (txtNum1.Text == "" || txtNum2.Text == "" || txtNum3.Text == "")
                        {
                            MessageBox.Show("Falta llenar algun campo de un Numero del final", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void imprimirEcDesX(int x, int y, int z, int num)
        {
            int num1, num2;

            if (signo(y)== "+")
            {
                num1 = y * -1;
            }
            else
            {
                num1 = y * -1;
            }

            if (signo(z)== "+")
            {
                num2 = z * -1;
            }
            else
            {
                num2 = z * -1; 
            }
            

            XNum.Text = num + " " + signo(num1) + " " + Math.Abs(num1) + "y " + signo(num2) + " " + Math.Abs(num2) + "z ";
            XDen.Text = x.ToString();

            
            ecuacionX[0] = x;
            ecuacionX[1] = num1;
            ecuacionX[2] = num2;
            ecuacionX[3] = num;

            //ecuacionX[] = {num, num1, num2, x };
            //desarrolloEcuacioneX(x, num1, num2, num);
        }

        private void imprimirEcDesY(int x, int y, int z, int num)
        {
            int num1, num2;

            if (signo(x) == "+")
            {
                num1 = x * -1;
            }
            else
            {
                num1 = x * -1;
            }

            if (signo(z) == "+")
            {
                num2 = z * -1; 
            }
            else
            {
                num2 = z * -1; 
            }


            YNum.Text = num + " " + signo(num1) + " " + Math.Abs(num1) + "x " + signo(num2) + " " + Math.Abs(num2) + "z ";
            YDen.Text = y.ToString();

            ecuacionY[0] = y;
            ecuacionY[1] = num1;
            ecuacionY[2] = num2;
            ecuacionY[3] = num;

            //desarrolloEcuacioneY(y, num1, num2, num);
        }

        private void imprimirEcDesZ(int x, int y, int z, int num)
        {
            int num1, num2;

            if (signo(x) == "+")
            {
                num1 = x * -1;
            }
            else
            {
                num1 = x * -1;
            }

            if (signo(y) == "+")
            {
                num2 = y * -1;
            }
            else
            {
                num2 = y * -1;
            }


            ZNum.Text = num + " " + signo(num1) + " " + Math.Abs(num1) + "x " + signo(num2) + " " + Math.Abs(num2) + "y ";
            ZDen.Text = z.ToString();

            ecuacionZ[0] = z;
            ecuacionZ[1] = num1;
            ecuacionZ[2] = num2;
            ecuacionZ[3] = num;

            //desarrolloEcuacioneZ(z, num1, num2, num);
        }

        private double desarrolloEcuacioneX(int x, int y, int z, int num, double X1, double Y1, double Z1)
        {
            double num1, num2;

            num1 = y * Y1;
            num2 = z * Z1;
            
            double xn = Math.Round( (num + num1 + num2) / x, 6);


            return xn;

        }

        private double desarrolloEcuacioneY(int y, int x, int z, int num, double X1, double Y1, double Z1)
        {
            double num1, num2;

            num1 = x * X1;
            num2 = z * Z1;

            double yn = Math.Round( (num + num1 + num2 ) / y, 6);

            return yn;

        }

        private double desarrolloEcuacioneZ(int z, int x, int y, int num, double X1, double Y1, double Z1)
        {
            double num1, num2;

            num1 = x * X1;
            num2 = y * Y1;

            double zn = Math.Round( (num + num1 + num2) / z, 6);

            return zn;

        }

        public void imprimirTabla()
        {
            bool salida = false;
            int noI = 0;
            double Xn = 0, Yn = 0, Zn = 0, ErrX = 2, ErrY = 2, ErrZ=2, X0=0, Y0 = 0, Z0 = 0, Xn1=0, Yn1=0, Zn1=0;

            do
            {
                if(noI == 101)
                {
                    ResX.Text = "X =  " + Xn;
                    ResY.Text = "Y =  " + Yn;
                    ResZ.Text = "Z =  " + Zn;
                    MessageBox.Show("Ha llegado al maximo de iteraciones", "Crashea?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                }

                if (noI == 0)
                {
                    tabla.Rows.Add(noI, 0, 0, 0, "-", "-", "-");
                }
                else if (noI == 1)
                {
                    Xn = desarrolloEcuacioneX(ecuacionX[0], ecuacionX[1], ecuacionX[2], ecuacionX[3], 0, 0, 0);
                    Yn = desarrolloEcuacioneY(ecuacionY[0], ecuacionY[1], ecuacionY[2], ecuacionY[3], Xn, 0, 0);
                    Zn = desarrolloEcuacioneZ(ecuacionZ[0], ecuacionZ[1], ecuacionZ[2], ecuacionZ[3], Xn, Yn, 0);

                    ErrX = Math.Abs(Math.Round( ( ((Xn - 0) / Xn) * 100), 6));
                    ErrY = Math.Abs(Math.Round( ( ((Yn - 0) / Yn) * 100), 6));
                    ErrZ = Math.Abs(Math.Round( ( ((Zn - 0) / Zn) * 100), 6));

                    tabla.Rows.Add(noI, Xn, Yn, Zn, ErrX + " %", ErrY + " %", ErrZ + " %");
                    
                }
                else
                {
                    Xn = desarrolloEcuacioneX(ecuacionX[0], ecuacionX[1], ecuacionX[2], ecuacionX[3], Xn, Yn, Zn);
                    Yn = desarrolloEcuacioneY(ecuacionY[0], ecuacionY[1], ecuacionY[2], ecuacionY[3], Xn, Yn, Zn);
                    Zn = desarrolloEcuacioneZ(ecuacionZ[0], ecuacionZ[1], ecuacionZ[2], ecuacionZ[3], Xn, Yn, Zn);

                    ErrX = Math.Abs(Math.Round((((Xn - Xn1) / Xn) * 100), 6));
                    ErrY = Math.Abs(Math.Round((((Yn - Yn1) / Yn) * 100), 6));
                    ErrZ = Math.Abs(Math.Round((((Zn - Zn1) / Zn) * 100), 6));

                    tabla.Rows.Add(noI, Xn, Yn, Zn, ErrX + " %", ErrY + " %", ErrZ + " %");

                
                }
                Xn1 = Xn;
                Yn1 = Yn;
                Zn1 = Zn;

                if (ErrX < 1 && ErrY < 1 && ErrZ < 1)
                {
                    ResX.Text = "X =  " + Xn;               
                    ResY.Text = "Y =  " + Yn;
                    ResZ.Text = "Z =  " + Zn;
                    salida = true;
                }

                noI++;
            } while (salida == false );
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtX1.Text = "";//To convert the values of each text field
            txtX2.Text = "";
            txtX3.Text = "";

            txtY1.Text = "";
            txtY2.Text = "";
            txtY3.Text = "";

            txtZ1.Text = "";
            txtZ2.Text = "";
            txtZ3.Text = "";

            txtNum1.Text = "";
            txtNum2.Text = "";
            txtNum3.Text = "";

            M1Ecu1.Text = "";
            M1Ecu2.Text = "";
            M1Ecu3.Text = "";

            M2Ecu1.Text = "";
            M2Ecu2.Text = "";
            M2Ecu3.Text = "";

            XNum.Text = "";
            XDen.Text = "";

            YNum.Text = "";
            YDen.Text = "";

            ZNum.Text = "";
            ZDen.Text = "";

            ResX.Text = "X =";
            ResY.Text = "Y =";
            ResZ.Text = "Z =";

            tabla.Rows.Clear();
        }

        private void txtX1_KeyPress(object sender, KeyPressEventArgs e)
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
            /*verifica que pueda signo negativo y también que solo pueda
           ingresar un signo negativo*/
            else if ((e.KeyChar == '-') && (!txtX1.Text.Contains("-")))
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

        private void txtX2_KeyPress(object sender, KeyPressEventArgs e)
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
            /*verifica que pueda signo negativo y también que solo pueda
           ingresar un signo negativo*/
            else if ((e.KeyChar == '-') && (!txtX2.Text.Contains("-")))
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

        private void txtX3_KeyPress(object sender, KeyPressEventArgs e)
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
            /*verifica que pueda signo negativo y también que solo pueda
           ingresar un signo negativo*/
            else if ((e.KeyChar == '-') && (!txtX3.Text.Contains("-")))
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

        private void txtY1_KeyPress(object sender, KeyPressEventArgs e)
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
            /*verifica que pueda signo negativo y también que solo pueda
           ingresar un signo negativo*/
            else if ((e.KeyChar == '-') && (!txtY1.Text.Contains("-")))
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

        private void txtY2_KeyPress(object sender, KeyPressEventArgs e)
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
            /*verifica que pueda signo negativo y también que solo pueda
           ingresar un signo negativo*/
            else if ((e.KeyChar == '-') && (!txtY2.Text.Contains("-")))
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

        private void txtY3_KeyPress(object sender, KeyPressEventArgs e)
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
            /*verifica que pueda signo negativo y también que solo pueda
           ingresar un signo negativo*/
            else if ((e.KeyChar == '-') && (!txtY3.Text.Contains("-")))
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

        private void txtZ1_KeyPress(object sender, KeyPressEventArgs e)
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
            /*verifica que pueda signo negativo y también que solo pueda
           ingresar un signo negativo*/
            else if ((e.KeyChar == '-') && (!txtZ1.Text.Contains("-")))
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

        private void txtZ2_KeyPress(object sender, KeyPressEventArgs e)
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
            /*verifica que pueda signo negativo y también que solo pueda
           ingresar un signo negativo*/
            else if ((e.KeyChar == '-') && (!txtZ2.Text.Contains("-")))
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

        private void txtZ3_KeyPress(object sender, KeyPressEventArgs e)
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
            /*verifica que pueda signo negativo y también que solo pueda
           ingresar un signo negativo*/
            else if ((e.KeyChar == '-') && (!txtZ3.Text.Contains("-")))
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

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
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
            /*verifica que pueda signo negativo y también que solo pueda
           ingresar un signo negativo*/
            else if ((e.KeyChar == '-') && (!txtNum1.Text.Contains("-")))
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

        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
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
            /*verifica que pueda signo negativo y también que solo pueda
           ingresar un signo negativo*/
            else if ((e.KeyChar == '-') && (!txtNum2.Text.Contains("-")))
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

        private void txtNum3_KeyPress(object sender, KeyPressEventArgs e)
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
            /*verifica que pueda signo negativo y también que solo pueda
           ingresar un signo negativo*/
            else if ((e.KeyChar == '-') && (!txtNum3.Text.Contains("-")))
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
