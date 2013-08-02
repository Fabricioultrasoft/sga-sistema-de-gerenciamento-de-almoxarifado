using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SGA
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Menu());
            Login login = new Login();
            Application.Run(login);
            if (login.DialogResult == DialogResult.OK)
            {
                Application.Run(new Menu(login.funcionario));
            }
        }
    }
}
