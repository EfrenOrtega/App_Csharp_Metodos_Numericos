using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metodos_Numericos.Modelo;

namespace Metodos_Numericos.Controlador
{
    internal class GaussSeidel_Controlador
    {
        private GaussSeidel_Modelo _Modelo;
        private GaussSeidel _vistaGaussSeidel;

        public GaussSeidel_Controlador(GaussSeidel_Modelo Modelo, GaussSeidel vistaGaussSeidel)
        {
            this._Modelo = Modelo;
            this._vistaGaussSeidel = vistaGaussSeidel;

            this._vistaGaussSeidel.btnCalcular.Click += new EventHandler(this.BtnCalcular_Click);
            this._vistaGaussSeidel.btnReiniciar.Click += new EventHandler(this.btnReiniciar_Click);
            this._vistaGaussSeidel.BtnRegresar.Click += new EventHandler(this.BtnRegresar_Click);
        }

        // E V E N T O S ===============================================

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int x1 = 0, x2 = 0, x3 = 0, y1 = 0, y2 = 0, y3 = 0, z1 = 0, z2 = 0, z3 = 0, num1 = 0, num2 = 0, num3 = 0;

            if (_Modelo.ValidarCampos(_vistaGaussSeidel))
            {
                x1 = int.Parse(_vistaGaussSeidel.txtX1.Text);//To convert the values of each text field
                x2 = int.Parse(_vistaGaussSeidel.txtX2.Text);
                x3 = int.Parse(_vistaGaussSeidel.txtX3.Text);

                y1 = int.Parse(_vistaGaussSeidel.txtY1.Text);
                y2 = int.Parse(_vistaGaussSeidel.txtY2.Text);
                y3 = int.Parse(_vistaGaussSeidel.txtY3.Text);

                z1 = int.Parse(_vistaGaussSeidel.txtZ1.Text);
                z2 = int.Parse(_vistaGaussSeidel.txtZ2.Text);
                z3 = int.Parse(_vistaGaussSeidel.txtZ3.Text);

                num1 = int.Parse(_vistaGaussSeidel.txtNum1.Text);
                num2 = int.Parse(_vistaGaussSeidel.txtNum2.Text);
                num3 = int.Parse(_vistaGaussSeidel.txtNum3.Text);

                imprimirMatriz1(x1, x2, x3, y1, y2, y3, z1, z2, z3, num1, num2, num3);

                imprimirMatriz2(x1, x2, x3, y1, y2, y3, z1, z2, z3, num1, num2, num3);

                _vistaGaussSeidel.tabla.Rows.Clear();//Method to clean all rows of table.

                imprimirTabla();

            }
        }
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            _vistaGaussSeidel.txtX1.Text = "";//To convert the values of each text field
            _vistaGaussSeidel.txtX2.Text = "";
            _vistaGaussSeidel.txtX3.Text = "";

            _vistaGaussSeidel.txtY1.Text = "";
            _vistaGaussSeidel.txtY2.Text = "";
            _vistaGaussSeidel.txtY3.Text = "";

            _vistaGaussSeidel.txtZ1.Text = "";
            _vistaGaussSeidel.txtZ2.Text = "";
            _vistaGaussSeidel.txtZ3.Text = "";

            _vistaGaussSeidel.txtNum1.Text = "";
            _vistaGaussSeidel.txtNum2.Text = "";
            _vistaGaussSeidel.txtNum3.Text = "";

            _vistaGaussSeidel.M1Ecu1.Text = "";
            _vistaGaussSeidel.M1Ecu2.Text = "";
            _vistaGaussSeidel.M1Ecu3.Text = "";

            _vistaGaussSeidel.M2Ecu1.Text = "";
            _vistaGaussSeidel.M2Ecu2.Text = "";
            _vistaGaussSeidel.M2Ecu3.Text = "";

            _vistaGaussSeidel.XNum.Text = "";
            _vistaGaussSeidel.XDen.Text = "";

            _vistaGaussSeidel.YNum.Text = "";
            _vistaGaussSeidel.YDen.Text = "";

            _vistaGaussSeidel.ZNum.Text = "";
            _vistaGaussSeidel.ZDen.Text = "";

            _vistaGaussSeidel.ResX.Text = "X =";
            _vistaGaussSeidel.ResY.Text = "Y =";
            _vistaGaussSeidel.ResZ.Text = "Z =";

            _vistaGaussSeidel.tabla.Rows.Clear();
        }
        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this._vistaGaussSeidel.Close();
            this._vistaGaussSeidel.Dispose();
        }

        // M E T O D O S ===============================================

        public void imprimirMatriz1(int x1, int x2, int x3, int y1, int y2, int y3, int z1, int z2, int z3, int num1, int num2, int num3)
        {
            _vistaGaussSeidel.M1Ecu1.Text = x1 + "x " + _Modelo.signo(y1) + " " + Math.Abs(y1) + "y " + _Modelo.signo(z1) + " " + Math.Abs(z1) + "z = " + num1;
            _vistaGaussSeidel.M1Ecu2.Text = x2 + "x " + _Modelo.signo(y2) + " " + Math.Abs(y2) + "y " + _Modelo.signo(z2) + " " + Math.Abs(z2) + "z = " + num2;
            _vistaGaussSeidel.M1Ecu3.Text = x3 + "x " + _Modelo.signo(y3) + " " + Math.Abs(y3) + "y " + _Modelo.signo(z3) + " " + Math.Abs(z3) + "z = " + num3;
        }

        public void imprimirMatriz2(int x1, int x2, int x3, int y1, int y2, int y3, int z1, int z2, int z3, int num1, int num2, int num3)
        {
            if (_Modelo.NumMayor(x1, x2, x3) == x1)
            {
                _vistaGaussSeidel.M2Ecu1.Text = x1 + "x " + _Modelo.signo(y1) + " " + Math.Abs(y1) + "y " + _Modelo.signo(z1) + " " + Math.Abs(z1) + "z = " + num1;

                imprimirEcDesX(x1, y1, z1, num1);

                if (_Modelo.NumMayor2(y2, y3) == y2)
                {
                    _vistaGaussSeidel.M2Ecu2.Text = x2 + "x " + _Modelo.signo(y2) + " " + Math.Abs(y2) + "y " + _Modelo.signo(z2) + " " + Math.Abs(z2) + "z = " + num2;
                    _vistaGaussSeidel.M2Ecu3.Text = x3 + "x " + _Modelo.signo(y3) + " " + Math.Abs(y3) + "y " + _Modelo.signo(z3) + " " + Math.Abs(z3) + "z = " + num3;

                    imprimirEcDesY(x2, y2, z2, num2);

                    imprimirEcDesZ(x3, y3, z3, num3);

                }
                else
                {
                    _vistaGaussSeidel.M2Ecu2.Text = x3 + "x " + _Modelo.signo(y3) + " " + Math.Abs(y3) + "y " + _Modelo.signo(z3) + " " + Math.Abs(z3) + "z = " + num3;
                    _vistaGaussSeidel.M2Ecu3.Text = x2 + "x " + _Modelo.signo(y2) + " " + Math.Abs(y2) + "y " + _Modelo.signo(z2) + " " + Math.Abs(z2) + "z = " + num2;

                    imprimirEcDesY(x3, y3, z3, num3);

                    imprimirEcDesZ(x2, y2, z2, num2);

                }
            }
            else if (_Modelo.NumMayor(x1, x2, x3) == x2)
            {
                _vistaGaussSeidel.M2Ecu1.Text = x2 + "x " + _Modelo.signo(y2) + " " + Math.Abs(y2) + "y " + _Modelo.signo(z2) + " " + Math.Abs(z2) + "z = " + num2;

                imprimirEcDesX(x2, y2, z2, num2);

                if (_Modelo.NumMayor2(y1, y3) == y1)
                {
                    _vistaGaussSeidel.M2Ecu2.Text = x1 + "x " + _Modelo.signo(y1) + " " + Math.Abs(y1) + "y " + _Modelo.signo(z1) + " " + Math.Abs(z1) + "z = " + num1;
                    _vistaGaussSeidel.M2Ecu3.Text = x3 + "x " + _Modelo.signo(y3) + " " + Math.Abs(y3) + "y " + _Modelo.signo(z3) + " " + Math.Abs(z3) + "z = " + num3;

                    imprimirEcDesY(x1, y1, z1, num1);

                    imprimirEcDesZ(x3, y3, z3, num3);

                }
                else
                {
                    _vistaGaussSeidel.M2Ecu3.Text = x1 + "x " + _Modelo.signo(y1) + " " + Math.Abs(y1) + "y " + _Modelo.signo(z1) + " " + Math.Abs(z1) + "z = " + num1;
                    _vistaGaussSeidel.M2Ecu2.Text = x3 + "x " + _Modelo.signo(y3) + " " + Math.Abs(y3) + "y " + _Modelo.signo(z3) + " " + Math.Abs(z3) + "z = " + num3;

                    imprimirEcDesY(x3, y3, z3, num3);

                    imprimirEcDesZ(x1, y1, z1, num1);

                }
            }
            else if (_Modelo.NumMayor(x1, x2, x3) == x3)
            {
                _vistaGaussSeidel.M2Ecu1.Text = x3 + "x " + _Modelo.signo(y3) + " " + Math.Abs(y3) + "y " + _Modelo.signo(z3) + " " + Math.Abs(z3) + "z = " + num3;

                imprimirEcDesX(x3, y3, z3, num3);

                if (_Modelo.NumMayor2(y1, y2) == y1)
                {
                    _vistaGaussSeidel.M2Ecu2.Text = x1 + "x " + _Modelo.signo(y1) + " " + Math.Abs(y1) + "y " + _Modelo.signo(z1) + " " + Math.Abs(z1) + "z = " + num1;
                    _vistaGaussSeidel.M2Ecu3.Text = x2 + "x " + _Modelo.signo(y2) + " " + Math.Abs(y2) + "y " + _Modelo.signo(z2) + " " + Math.Abs(z2) + "z = " + num2;

                    imprimirEcDesY(x1, y1, z1, num1);

                    imprimirEcDesZ(x2, y2, z2, num2);

                }
                else
                {
                    _vistaGaussSeidel.M2Ecu3.Text = x1 + "x " + _Modelo.signo(y1) + " " + Math.Abs(y1) + "y " + _Modelo.signo(z1) + " " + Math.Abs(z1) + "z = " + num1;
                    _vistaGaussSeidel.M2Ecu2.Text = x2 + "x " + _Modelo.signo(y2) + " " + Math.Abs(y2) + "y " + _Modelo.signo(z2) + " " + Math.Abs(z2) + "z = " + num2;

                    imprimirEcDesY(x2, y2, z2, num2);

                    imprimirEcDesZ(x1, y1, z1, num1);

                }
            }
        }

        public void imprimirEcDesX(int x, int y, int z, int num)
        {
            int num1, num2;

            if (_Modelo.signo(y) == "+")
            {
                num1 = y * -1;
            }
            else
            {
                num1 = y * -1;
            }

            if (_Modelo.signo(z) == "+")
            {
                num2 = z * -1;
            }
            else
            {
                num2 = z * -1;
            }


            _vistaGaussSeidel.XNum.Text = num + " " + _Modelo.signo(num1) + " " + Math.Abs(num1) + "y " + _Modelo.signo(num2) + " " + Math.Abs(num2) + "z ";
            _vistaGaussSeidel.XDen.Text = x.ToString();

            _Modelo.set_EcuacionDespejadaX(x, num, num1, num2);
        }

        public void imprimirEcDesY(int x, int y, int z, int num)
        {
            int num1, num2;

            if (_Modelo.signo(x) == "+")
            {
                num1 = x * -1;
            }
            else
            {
                num1 = x * -1;
            }

            if (_Modelo.signo(z) == "+")
            {
                num2 = z * -1;
            }
            else
            {
                num2 = z * -1;
            }


            _vistaGaussSeidel.YNum.Text = num + " " + _Modelo.signo(num1) + " " + Math.Abs(num1) + "x " + _Modelo.signo(num2) + " " + Math.Abs(num2) + "z ";
            _vistaGaussSeidel.YDen.Text = y.ToString();

            _Modelo.set_EcuacionDespejadaY(y, num, num1, num2);
        }

        public void imprimirEcDesZ(int x, int y, int z, int num)
        {
            int num1, num2;

            if (_Modelo.signo(x) == "+")
            {
                num1 = x * -1;
            }
            else
            {
                num1 = x * -1;
            }

            if (_Modelo.signo(y) == "+")
            {
                num2 = y * -1;
            }
            else
            {
                num2 = y * -1;
            }


            _vistaGaussSeidel.ZNum.Text = num + " " + _Modelo.signo(num1) + " " + Math.Abs(num1) + "x " + _Modelo.signo(num2) + " " + Math.Abs(num2) + "y ";
            _vistaGaussSeidel.ZDen.Text = z.ToString();

            _Modelo.set_EcuacionDespejadaZ(z, num, num1, num2);
        }

        public void imprimirTabla()
        {
            bool salida = false;
            int noI = 0;
            double Xn = 0, Yn = 0, Zn = 0, ErrX = 2, ErrY = 2, ErrZ = 2, Xn1 = 0, Yn1 = 0, Zn1 = 0;

            do
            {
                if (noI == 101)
                {
                    _vistaGaussSeidel.ResX.Text = "X =  " + Xn;
                    _vistaGaussSeidel.ResY.Text = "Y =  " + Yn;
                    _vistaGaussSeidel.ResZ.Text = "Z =  " + Zn;
                    MessageBox.Show("Ha llegado al maximo de iteraciones", "Crashea?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                }

                if (noI == 0)
                {
                    _vistaGaussSeidel.tabla.Rows.Add(noI, 0, 0, 0, "-", "-", "-");
                }
                else if (noI == 1)
                {
                    Xn = _Modelo.desarrolloEcuacioneX(_Modelo.get_EcuacionDespejadaX(), 0, 0, 0);
                    Yn = _Modelo.desarrolloEcuacioneY(_Modelo.get_EcuacionDespejadaY(), Xn, 0, 0);
                    Zn = _Modelo.desarrolloEcuacioneZ(_Modelo.get_EcuacionDespejadaZ(), Xn, Yn, 0);

                    ErrX = Math.Abs(Math.Round((((Xn - 0) / Xn) * 100), 6));
                    ErrY = Math.Abs(Math.Round((((Yn - 0) / Yn) * 100), 6));
                    ErrZ = Math.Abs(Math.Round((((Zn - 0) / Zn) * 100), 6));

                    _vistaGaussSeidel.tabla.Rows.Add(noI, Xn, Yn, Zn, ErrX + " %", ErrY + " %", ErrZ + " %");

                }
                else
                {
                    Xn = _Modelo.desarrolloEcuacioneX(_Modelo.get_EcuacionDespejadaX(), Xn, Yn, Zn);
                    Yn = _Modelo.desarrolloEcuacioneY(_Modelo.get_EcuacionDespejadaY(), Xn, Yn, Zn);
                    Zn = _Modelo.desarrolloEcuacioneZ(_Modelo.get_EcuacionDespejadaZ(), Xn, Yn, Zn);

                    ErrX = Math.Abs(Math.Round((((Xn - Xn1) / Xn) * 100), 6));
                    ErrY = Math.Abs(Math.Round((((Yn - Yn1) / Yn) * 100), 6));
                    ErrZ = Math.Abs(Math.Round((((Zn - Zn1) / Zn) * 100), 6));

                    _vistaGaussSeidel.tabla.Rows.Add(noI, Xn, Yn, Zn, ErrX + " %", ErrY + " %", ErrZ + " %");


                }
                Xn1 = Xn;
                Yn1 = Yn;
                Zn1 = Zn;

                if (ErrX < 1 && ErrY < 1 && ErrZ < 1)
                {
                    _vistaGaussSeidel.ResX.Text = "X =  " + Xn;
                    _vistaGaussSeidel.ResY.Text = "Y =  " + Yn;
                    _vistaGaussSeidel.ResZ.Text = "Z =  " + Zn;
                    salida = true;
                }

                noI++;
            } while (salida == false);
        }

    }
}
