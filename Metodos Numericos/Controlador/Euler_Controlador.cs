using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Metodos_Numericos.Modelo;

namespace Metodos_Numericos.Controlador
{
    internal class Euler_Controlador
    {
        private Euler_Modelo _Modelo;
        private Euler _vistaEuler;

        public Euler_Controlador(Euler_Modelo Modelo, Euler vistaEuler)
        {
            this._Modelo = Modelo;
            this._vistaEuler = vistaEuler;
            this._vistaEuler.btnCalcular.Click += new EventHandler(this.BtnCalcular_Click);

            this._vistaEuler.btnReiniciar.Click += new EventHandler(this.BtnReiniciar_Click);
            this._vistaEuler.BtnRegresar.Click += new EventHandler(this.BtnRegresar_Click);
            this._vistaEuler.BtnVerFormulas.Click += new EventHandler(this.BtnVerFormulas_Click);
        }

        // E V E N T O S ===============================================
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (_Modelo.ValidarCamposEuler(_vistaEuler))
            {
                double x0 = double.Parse(_vistaEuler.txtX0.Text),
                    y0 = double.Parse(_vistaEuler.txtY0.Text),
                    h = double.Parse(_vistaEuler.txtH.Text),
                    ni = double.Parse(_vistaEuler.txtNi.Text);

                _Modelo.funcion_yReal(x0);

                _vistaEuler.tabla.Rows.Clear();
                ImprimirEuler(x0, y0, h, ni);

            }
        }
        private void BtnReiniciar_Click(object sender, EventArgs e)
        {
            _vistaEuler.txtX0.Text = "";
            _vistaEuler.txtY0.Text = "";
            _vistaEuler.txtH.Text = "";
            _vistaEuler.txtNi.Text = "";
            _vistaEuler.tabla.Rows.Clear();
        }
        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this._vistaEuler.Close();
            this._vistaEuler.Dispose();
        }
        private void BtnVerFormulas_Click(object sender, EventArgs e)
        {
            Formulario Form = new Formulario();
            Form.BackgroundImage = Properties.Resources.Formulas1;
            Form.ShowDialog();
        }

        // M E T O D O S ===============================================
        public void ImprimirEuler(double x0, double y0, double h, double Ni)
        {
            int noI = 0;
            double yReal = y0, yEuler = y0, erEuler, yF = y0, hF = h;
            do
            {
                if (noI == 0)
                {
                    yEuler = Math.Round(_Modelo.funcion_Euler(x0, y0, 0), 6);
                    yReal = Math.Round(_Modelo.funcion_yReal(x0), 6);
                    erEuler = Math.Abs(Math.Round((100 * (yEuler - yReal) / yReal), 6));

                }
                else
                {
                    yEuler = Math.Round(_Modelo.funcion_Euler(x0, yEuler, hF), 6);
                    x0 = x0 + h;
                    yReal = Math.Round(_Modelo.funcion_yReal(x0), 6);
                    erEuler = Math.Abs(Math.Round((100 * (yEuler - yReal) / yReal), 6));
                }
                _vistaEuler.tabla.Rows.Add(noI, x0, yReal, yEuler, erEuler + " %");

                noI++;
            } while (noI <= Ni);

        }

    }
}
