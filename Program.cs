using System;
using System.Windows.Forms;

namespace CuentaAtras
{
    static class Program
    {
        
        // Iniciamos la aplicacion
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
