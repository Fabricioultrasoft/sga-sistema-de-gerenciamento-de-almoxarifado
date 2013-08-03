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
            while (1 == 1)
            {
                Login login = new Login();
                
                Application.Run(login);
                Menu menu = new Menu(login.funcionario);
                if (login.DialogResult == DialogResult.OK)
                {
                    
                    Application.Run(menu);
                    
                }
                if (menu.DialogResult != DialogResult.OK)
                {
                    break;
                }
            }
        }
    }
}
