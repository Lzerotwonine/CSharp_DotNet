using System;
using System.Windows.Forms;

namespace CD_Management
{
    internal static class Program
    {
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new View.MainMenu());
        }
    }
}
