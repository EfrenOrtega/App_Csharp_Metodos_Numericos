using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Metodos_Numericos.Modelo;

namespace Metodos_Numericos.Controlador
{
    internal class NewtonRaphson_Controlador
    {
        private NewtonRaphson_Modelo _Modelo;
        private NewtonRaphson _vistaNewtonRaphson;

        public NewtonRaphson_Controlador(NewtonRaphson_Modelo Modelo, NewtonRaphson vistaNewtonRaphson)
        {
            this._Modelo = Modelo;
            this._vistaNewtonRaphson = vistaNewtonRaphson;

            this._vistaNewtonRaphson.btnCalcular.Click += new EventHandler(this.BtnCalcular_Click);
            this._vistaNewtonRaphson.BtnReiniciar.Click += new EventHandler(this.BtnReiniciar_Click);
            this._vistaNewtonRaphson.BtnRegresar.Click += new EventHandler(this.BtnRegresar_Click);
            this._vistaNewtonRaphson.BtnVerFormulas.Click += new EventHandler(this.BtnVerFormulas_Click);
        }

        // E V E N T O S ===============================================
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (_Modelo.ValidarCamposNewtonRaphson(_vistaNewtonRaphson))
            {
                double x0 = double.Parse(_vistaNewtonRaphson.txtX0.Text);

                _vistaNewtonRaphson.tabla.Rows.Clear();//Method to clean all rows of table.
                ImprimirNewtonRaphson(x0);
            }
        }
        private void BtnReiniciar_Click(object sender, EventArgs e)
        {
            _vistaNewtonRaphson.txtX0.Text = "";
            _vistaNewtonRaphson.tabla.Rows.Clear();
        }
        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this._vistaNewtonRaphson.Close();
            this._vistaNewtonRaphson.Dispose();
        }
        private void BtnVerFormulas_Click(object sender, EventArgs e)
        {
            Formulario Form = new Formulario();
            Form.BackgroundImage = Properties.Resources.FormulasNewton;
            Form.ShowDialog();
        }

        // M E T O D O S ===============================================
        public void ImprimirNewtonRaphson(double x0)
        {
            _Modelo.getValues(x0, _vistaNewtonRaphson);
        }
    }
}
