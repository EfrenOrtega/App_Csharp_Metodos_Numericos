using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Metodos_Numericos.Modelo;
using Metodos_Numericos.Controlador;

namespace Metodos_Numericos
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //MetodosNumericos_Modelo modelo = new MetodosNumericos_Modelo();
            //Euler vistaEuler = new Euler();
            //MetodosNumericos_Controlador controlador = new MetodosNumericos_Controlador(modelo, vistaEuler);

            Application.Run(new Loading());
        }
    }
}

