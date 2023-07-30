using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using demo_server_monitor.controllers;

namespace demo_server_monitor
{
    public partial class menu : Form
    {
        private ServerInformationsController serverInformationsController;

        public menu(ServerInformationsController controller)
        {
            InitializeComponent();
            serverInformationsController = controller;

            timer1.Interval = 5000; // Intervalo de 1000 ms (1 segundo).
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            refreshServerInformations();
        }

        public void refreshServerInformations()
        {
            serverInformationsController.setServerInformations(); // Atualiza as informações do servidor.

            var serverInfo = serverInformationsController.GetServerInfo();

            lbl_cpu_temperature_info.Text = serverInfo.cpuServerTemperature.ToString() + "ºC";
            lbl_cpu_speed_info.Text = Math.Round(serverInfo.cpuServerUsingPercent).ToString() + "%";
            lbl_ram_info.Text = Math.Round(serverInfo.cpuMemoryUsingPercent).ToString() + "%";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            refreshServerInformations();
        }
    }
}
