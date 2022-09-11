using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodos_Numericos.Modelo
{
    internal class GaussSeidel_Modelo
    {
        private int[] ecuacionX = new int[4];
        private int[] ecuacionY = new int[4];
        private int[] ecuacionZ = new int[4];

        // Set de ecuaciones
        public void set_EcuacionDespejadaX(int x, int num, int num1, int num2)
        {
            ecuacionX[0] = x;
            ecuacionX[1] = num1;
            ecuacionX[2] = num2;
            ecuacionX[3] = num;
        }

        public void set_EcuacionDespejadaY(int y, int num, int num1, int num2)
        {
            ecuacionY[0] = y;
            ecuacionY[1] = num1;
            ecuacionY[2] = num2;
            ecuacionY[3] = num;
        }

        public void set_EcuacionDespejadaZ(int z, int num, int num1, int num2)
        {
            ecuacionZ[0] = z;
            ecuacionZ[1] = num1;
            ecuacionZ[2] = num2;
            ecuacionZ[3] = num;
        }

        //Get de ecuaciones

        public int []  get_EcuacionDespejadaX()
        {
            return this.ecuacionX;
        }

        public int[] get_EcuacionDespejadaY()
        {
            return this.ecuacionY;
        }

        public int[] get_EcuacionDespejadaZ()
        {
            return this.ecuacionZ;
        }

        //Metodods

        public int NumMayor(int num1, int num2, int num3)
        {
            if (num1 > num2 && num1 > num3)
            {
                return num1;
            }
            else if (num2 > num3 && num2 > num3)
            {
                return num2;
            }
            else if (num3 > num1 && num3 > num2)
            {
                return num3;
            }

            if (num1 == num2 && num1 == num3)
            {
                return num1;
            }

            return num1;
        }

        public int NumMayor2(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else if (num2 > num1)
            {
                return num2;
            }
            if (num1 == num2)
            {
                return num1;
            }
            return num1;
        }

        public string signo(int num)
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

        public bool ValidarCampos(GaussSeidel vistaGaussSeidel)
        {
            //To verify if the text field aren't empty
            if (vistaGaussSeidel.txtX1.Text == "" || vistaGaussSeidel.txtX2.Text == "" || vistaGaussSeidel.txtX3.Text == "")
            {
                MessageBox.Show("Falta llenar algun campo de una X", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                if (vistaGaussSeidel.txtY1.Text == "" || vistaGaussSeidel.txtY2.Text == "" || vistaGaussSeidel.txtY3.Text == "")
                {
                    MessageBox.Show("Falta llenar algun campo de una Y", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else
                {
                    if (vistaGaussSeidel.txtZ1.Text == "" || vistaGaussSeidel.txtZ2.Text == "" || vistaGaussSeidel.txtZ3.Text == "")
                    {
                        MessageBox.Show("Falta llenar algun campo de una Z", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    else
                    {
                        if (vistaGaussSeidel.txtNum1.Text == "" || vistaGaussSeidel.txtNum2.Text == "" || vistaGaussSeidel.txtNum3.Text == "")
                        {
                            MessageBox.Show("Falta llenar algun campo de un Numero del final", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                    }
                }
            }
            return true;
        }


        public double desarrolloEcuacioneX(int[] ecuacionX, double X1, double Y1, double Z1)
        {
            double num1, num2;

            num1 = ecuacionX[1] * Y1;
            num2 = ecuacionX[2] * Z1;

            double xn = Math.Round((ecuacionX[3] + num1 + num2) / ecuacionX[0], 6);


            return xn;

        }

        public double desarrolloEcuacioneY(int[] ecuacionY, double X1, double Y1, double Z1)
        {
            double num1, num2;

            num1 = ecuacionY[0] * X1;
            num2 = ecuacionY[2] * Z1;

            double yn = Math.Round((ecuacionY[3] + num1 + num2) / ecuacionY[1], 6);

            return yn;

        }

        public double desarrolloEcuacioneZ(int[] ecuacionZ, double X1, double Y1, double Z1)
        {
            double num1, num2;

            num1 = ecuacionZ[0] * X1;
            num2 = ecuacionZ[1] * Y1;

            double zn = Math.Round((ecuacionZ[3] + num1 + num2) / ecuacionZ[2], 6);

            return zn;

        }

    }
}
