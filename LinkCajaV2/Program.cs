using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkCajaV2
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Moneda MX siempre 
            CultureInfo culturaMX = new CultureInfo("es-MX");
            CultureInfo.DefaultThreadCurrentCulture = culturaMX;
            CultureInfo.DefaultThreadCurrentUICulture = culturaMX; 

            Thread.CurrentThread.CurrentCulture = culturaMX;
            Thread.CurrentThread.CurrentUICulture = culturaMX;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
