using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management;
using demo_server_monitor.models;
using LibreHardwareMonitor.Hardware;

namespace demo_server_monitor.controllers
{
    public class ServerInformationsController
    {
        private ServerInfo serverInfo;

        public ServerInformationsController()
        {
            serverInfo = new ServerInfo();
        }

        private bool IsServer()
        {
            // Verifica se o sistema operacional é um servidor (Windows Server)
            return Environment.OSVersion.ToString().Contains("Server");
        }

        public ServerInfo GetServerInfo()
        {
            return serverInfo;
        }

        public void setServerInformations()
        {
            if (IsServer())
            {
                serverInfo.cpuServerTemperature = GetCpuTemperatureUsingWMI();
            }
            else
            {
                serverInfo.cpuServerTemperature = GetCpuTemperatureUsingOpenHardwareMonitor();
            }

            serverInfo.cpuServerUsingPercent = GetCpuUsage();
            serverInfo.cpuMemoryUsingPercent = GetRamUsage();
        }

        private double GetCpuTemperatureUsingWMI()
        {
            // Acessar informações do WMI para obter a temperatura do CPU (exemplo para Windows Server)
            double temperature = 0.0;

            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_TemperatureProbe");
                ManagementObjectCollection objectCollection = searcher.Get();

                foreach (ManagementObject obj in objectCollection)
                {
                    string name = obj["Name"].ToString();
                    temperature = Convert.ToDouble(obj["CurrentReading"]) / 10.0;
                    break; // Vamos pegar apenas a primeira temperatura encontrada
                }
            }
            catch (Exception)
            {
                // Lidar com possíveis erros na obtenção da temperatura
                temperature = 0.0;
            }

            return temperature;
        }

        private double GetCpuTemperatureUsingOpenHardwareMonitor()
        {
            double temperature = 0.0;

            try
            {
                Computer computer = new Computer
                {
                    IsCpuEnabled = true
                };
                computer.Open();
                computer.IsCpuEnabled = true;

                foreach (var hardware in computer.Hardware)
                {
                    hardware.Update();

                    if (hardware.HardwareType == HardwareType.Cpu)
                    {
                        foreach (var sensor in hardware.Sensors)
                        {
                            if (sensor.SensorType == SensorType.Temperature && sensor.Name.ToLower().Contains("core"))
                            {
                                temperature = (double)sensor.Value;
                                break;
                            }
                        }
                    }
                }

                computer.Close();
            }
            catch (Exception ex)
            {
                // Lidar com possíveis erros ao acessar o Open Hardware Monitor
                Console.WriteLine("Erro ao obter a temperatura da CPU usando o OpenHardwareMonitorLib: " + ex.Message);
            }

            return temperature;
        }


        private float GetCpuUsage()
        {
            float cpuUsage = 0.0f;

            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PerfFormattedData_PerfOS_Processor WHERE Name='_Total'");
                ManagementObjectCollection objectCollection = searcher.Get();

                foreach (ManagementObject obj in objectCollection)
                {
                    cpuUsage = Convert.ToSingle(obj["PercentProcessorTime"]);
                    break; // Vamos pegar apenas a primeira entrada (que é _Total).
                }
            }
            catch (Exception ex)
            {
                // Lidar com possíveis erros ao acessar informações do WMI.
                Console.WriteLine("Erro ao obter o uso da CPU usando WMI: " + ex.Message);
            }

            return cpuUsage;
        }

        private float GetRamUsage()
        {
            float ramUsage = 0.0f;

            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PerfFormattedData_PerfOS_Memory");
                ManagementObjectCollection objectCollection = searcher.Get();

                foreach (ManagementObject obj in objectCollection)
                {
                    ramUsage = Convert.ToSingle(obj["PercentCommittedBytesInUse"]);
                    break; // Vamos pegar apenas a primeira entrada.
                }
            }
            catch (Exception ex)
            {
                // Lidar com possíveis erros ao obter o uso de memória.
                Console.WriteLine("Erro ao obter o uso de memória RAM: " + ex.Message);
                return 0.0f;
            }

            return ramUsage;
        }
    }
}
