using facturacion.Model;
using System;
using facturacion.Views;
using System.Windows.Forms;

namespace facturacion
{
    class Program
    {
        /// <summary>
        /// Entrada del programa.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
            
        }    
    }
}
