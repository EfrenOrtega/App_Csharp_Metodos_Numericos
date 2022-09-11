using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Metodos_Numericos.Modelo;

namespace Metodos_Numericos.Controlador
{
    internal class RungeKutta_Controlador
    {
        Euler_Modelo _euler_Modelo = new Euler_Modelo();
        EulerMejorado_Modelo _eulerMejorado_Modelo = new EulerMejorado_Modelo();
        private RungeKutta_Modelo _Modelo;
        private RungeKutta _vistaRungeKutta;

        public RungeKutta_Controlador(RungeKutta_Modelo Modelo, RungeKutta vistaRungeKutta)
        {
            this._Modelo = Modelo;
            this._vistaRungeKutta = vistaRungeKutta;

            this._vistaRungeKutta.btnCalcular.Click += new EventHandler(this.BtnCalcular_Click);
            this._vistaRungeKutta.BtnReiniciar.Click += new EventHandler(this.BtnReiniciar_Click);
            this._vistaRungeKutta.BtnRegresar.Click += new EventHandler(this.BtnRegresar_Click);
            this._vistaRungeKutta.BtnVerFormulas.Click += new EventHandler(this.BtnVerFormulas_Click);
        }

        // E V E N T O S ===============================================
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (_Modelo.ValidarCamposRungeKutta(_vistaRungeKutta))
            {
                double x0 = double.Parse(_vistaRungeKutta.txtX0.Text),
                    y0 = double.Parse(_vistaRungeKutta.txtY0.Text),
                    h = double.Parse(_vistaRungeKutta.txtH.Text),
                    ni = double.Parse(_vistaRungeKutta.txtNi.Text);

                _vistaRungeKutta.tabla.Rows.Clear();
                ImprimirRungeKutta(x0, y0, h, ni);

            }
        }
        private void BtnReiniciar_Click(object sender, EventArgs e)
        {
            _vistaRungeKutta.txtX0.Text = "";
            _vistaRungeKutta.txtY0.Text = "";
            _vistaRungeKutta.txtH.Text = "";
            _vistaRungeKutta.txtNi.Text = "";
            _vistaRungeKutta.tabla.Rows.Clear();
        }
        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this._vistaRungeKutta.Close();
            this._vistaRungeKutta.Dispose();
        }
        private void BtnVerFormulas_Click(object sender, EventArgs e)
        {
            Formulario Form = new Formulario();
            Form.BackgroundImage = Properties.Resources.FormulasRunge_Kutta;
            Form.ShowDialog();
        }

        // M E T O D O S ===============================================
        public void ImprimirRungeKutta(double x0, double y0, double h, double Ni)
        {
            int noI = 0;
            double yReal = y0, yEuler = y0, erEuler = 0, yEulerM = 0, erEulerM = 0, yRunge = 4, erRunge = 0, yF = y0, hF = h;
            do
            {
                if (noI == 0)
                {
                    yReal = Math.Round(_euler_Modelo.funcion_yReal(x0), 6);

                    yEuler = Math.Round(_euler_Modelo.funcion_Euler(x0, y0, 0), 6);
                    erEuler = Math.Abs(Math.Round((100 * (yEuler - yReal) / yReal), 6));

                    yEulerM = Math.Round(_eulerMejorado_Modelo.funcion_EulerMejorado(x0, y0, 0), 6);
                    erEulerM = Math.Abs(Math.Round((100 * (yEulerM - yReal) / yReal), 6));

                    yRunge = Math.Round(_Modelo.funcion_Runge(x0, y0, 0), 6);
                    erRunge = Math.Abs(Math.Round((100 * (yRunge - yReal) / yReal), 6));
                }
                else
                {
                    yEuler = Math.Round(_euler_Modelo.funcion_Euler(x0, yEuler, hF), 6);
                    yEulerM = Math.Round(_eulerMejorado_Modelo.funcion_EulerMejorado(x0, yEulerM, hF), 6);
                    yRunge = _Modelo.funcion_Runge(x0, yRunge, hF);

                    x0 = x0 + h;

                    yReal = Math.Round(_euler_Modelo.funcion_yReal(x0), 6);
                    erEuler = Math.Abs(Math.Round((100 * (yEuler - yReal) / yReal), 6));
                    erEulerM = Math.Abs(Math.Round((100 * (yEulerM - yReal) / yReal), 6));
                    erRunge = Math.Abs(Math.Round((100 * (yRunge - yReal) / yReal), 6));
                }
                _vistaRungeKutta.tabla.Rows.Add(noI, x0, yReal, yEuler, erEuler + " %", yEulerM, erEulerM + " %", yRunge, erRunge + " %");

                noI++;
            } while (noI <= Ni);
        }

    }
}
