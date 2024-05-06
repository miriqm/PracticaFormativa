using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PracticaFormativa.semana3;
using PracticaFormativa.Ventanas;

namespace PracticaFormativa
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form1());
            //Application.Run(new frmInicio()); //semana 3

            Application.Run(new frmVentana1());





        }
    }
}
