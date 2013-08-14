using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SGA.Entity;
using SGA.Properties;
using SGA.Telas;
using SGA.Dao;

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

                funcionariosAlterado = login.funcionario;

                Menu menu = new Menu(login.funcionario);

                if (login.DialogResult == DialogResult.OK)
                {
                    Application.Run(menu);
                }

                if (menu.DialogResult == DialogResult.OK)
                {
                    funcionariosAlterado = menu.funcionario;
                }
                else
                {
                    break;
                }
            }
            if (funcionariosAlterado.alteracao)
            {
                Conexao.backup();
            }
        }
    }
}
