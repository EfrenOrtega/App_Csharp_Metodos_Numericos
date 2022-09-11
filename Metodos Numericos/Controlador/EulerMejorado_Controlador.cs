using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Metodos_Numericos.Modelo;

namespace Metodos_Numericos.Controlador
{
    internal class EulerMejorado_Controlador
    {
        Euler_Modelo _euler_Modelo = new Euler_Modelo();
        private EulerMejorado_Modelo _Modelo;
        private EulerMejorado _vistaEulerMejorado;

        public EulerMejorado_Controlador(EulerMejorado_Modelo Modelo, EulerMejorado vistaEulerMejorado)
        {
            this._Modelo = Modelo;
            this._vistaEulerMejorado = vistaEulerMejorado;
            this._vistaEulerMejorado.btnCalcular.Click += new EventHandler(this.BtnCalcular_Click);

            this._vistaEulerMejorado.btnReiniciar.Click += new EventHandler(this.BtnReiniciar_Click);
            this._vistaEulerMejorado.BtnRegresar.Click += new EventHandler(this.BtnRegresar_Click);
            this._vistaEulerMejorado.BtnVerFormulas.Click += new EventHandler(this.BtnVerFormulas_Click);
        }

        // E V E N T O S ===============================================
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (_Modelo.ValidarCamposEulerMejorado(_vistaEulerMejorado))
            {
                double x0 = double.Parse(_vistaEulerMejorado.txtX0.Text),
                    y0 = double.Parse(_vistaEulerMejorado.txtY0.Text),
                    h = double.Parse(_vistaEulerMejorado.txtH.Text),
                    ni = double.Parse(_vistaEulerMejorado.txtNi.Text);

                //_euler_Modelo.funcion_yReal(x0);

                _vistaEulerMejorado.tabla.Rows.Clear();
                ImprimirEulerMejorado(x0, y0, h, ni);

            }
        }
        private void BtnReiniciar_Click(object sender, EventArgs e)
        {
            _vistaEulerMejorado.txtX0.Text = "";
            _vistaEulerMejorado.txtY0.Text = "";
            _vistaEulerMejorado.txtH.Text = "";
            _vistaEulerMejorado.txtNi.Text = "";
            _vistaEulerMejorado.tabla.Rows.Clear();
        }
        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this._vistaEulerMejorado.Close();
            this._vistaEulerMejorado.Dispose();
        }
        private void BtnVerFormulas_Click(object sender, EventArgs e)
        {
            Formulario Form = new Formulario();
            Form.BackgroundImage = Properties.Resources.FormulasEulerMejorado;
            Form.ShowDialog();
        }

        // M E T O D O S ===============================================
        public void ImprimirEulerMejorado(double x0, double y0, double h, double Ni)
        {
            int noI = 0;
            double yReal = y0, yEuler = y0, erEuler, yEulerM = y0, erEulerM, yF = y0, hF = h;
            do
            {
                if (noI == 0)
                {
                    yEuler = Math.Round(_euler_Modelo.funcion_Euler(x0, y0, 0), 6);
                    yReal = Math.Round(_euler_Modelo.funcion_yReal(x0), 6);
                    erEuler = Math.Abs(Math.Round((100 * (yEuler - yReal) / yReal), 6));
                    yEulerM = Math.Round(_Modelo.funcion_EulerMejorado(x0, y0, 0), 6);
                    erEulerM = Math.Abs(Math.Round((100 * (yEulerM - yReal) / yReal), 6));
                }
                else
                {
                    yEuler = Math.Round(_euler_Modelo.funcion_Euler(x0, yEuler, hF), 6);
                    yEulerM = Math.Round(_Modelo.funcion_EulerMejorado(x0, yEulerM, hF), 6);
                    x0 = x0 + h;
                    yReal = Math.Round(_euler_Modelo.funcion_yReal(x0), 6);
                    erEuler = Math.Abs(Math.Round((100 * (yEuler - yReal) / yReal), 6));
                    erEulerM = Math.Abs(Math.Round((100 * (yEulerM - yReal) / yReal), 6));
                }
                _vistaEulerMejorado.tabla.Rows.Add(noI, x0, yReal, yEuler, erEuler + " %", yEulerM, erEulerM + " %");

                noI++;
            } while (noI <= Ni);
        }

    }
}
