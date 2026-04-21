using CredenSoftUInuevo.Forms;
using System;
using System.Windows.Forms;

namespace CredenSoftUInuevo
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           
            Application.Run(new FrmLogin());
        }
    }
}