using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using demo_server_monitor.controllers;

namespace demo_server_monitor
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
      
            ServerInformationsController serverInfoController = new ServerInformationsController();
            serverInfoController.setServerInformations();

         
            Application.Run(new menu(serverInfoController));
        }
    }
}
