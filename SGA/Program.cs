using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SGA.Entity;
using SGA.Properties;
using SGA.Telas;

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
            Funcionario funcionariosAlterado = new Funcionario();
            //Application.Run(new Menu());
            while (1 == 1)
            {
                CredencialAcesso login = new CredencialAcesso(funcionariosAlterado);

                Application.Run(login);
                Menu menu = new Menu(login.funcionario);

                if (login.DialogResult == DialogResult.OK)
                {

                    Application.Run(menu);
                }
                if (menu.DialogResult != DialogResult.Retry || menu.DialogResult != DialogResult.OK)
                {
                    if (menu.DialogResult == DialogResult.OK)
                    {
                        new Mensagem("Alteração Feita !", "informacao", Resources.erro).ShowDialog();
                    }
                    break;
                }
            }

        }
    }
}
