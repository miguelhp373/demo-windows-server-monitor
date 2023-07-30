using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_server_monitor.models
{
    public class ServerInfo
    {
        public double cpuServerTemperature { get; set; }
        public double cpuServerUsingPercent { get; set; }
        public double cpuMemoryUsingPercent { get; set; }
    }
}
