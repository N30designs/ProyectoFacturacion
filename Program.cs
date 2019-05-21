using facturacion.Model;
using facturacion.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            //consola.Ejecutar();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormularioPrincipal());


        }    
    }
}
