using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace lab19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxCPU.Items.AddRange(GetHardwareInfo("Win32_Processor", "Name").ToArray());
            listBoxCPU.Items.AddRange(GetHardwareInfo("Win32_Processor", "Manufacturer").ToArray());
            listBoxCPU.Items.AddRange(GetHardwareInfo("Win32_Processor", "Description").ToArray());

            listBoxVideo.Items.AddRange(GetHardwareInfo("Win32_VideoController", "Name").ToArray());
            listBoxVideo.Items.AddRange(GetHardwareInfo("Win32_VideoController", "VideoProcessor").ToArray());
            listBoxVideo.Items.AddRange(GetHardwareInfo("Win32_VideoController", "DriverVersion").ToArray());
            listBoxVideo.Items.AddRange(GetHardwareInfo("Win32_VideoController", "AdapterRAM").ToArray());

            listBoxDVD.Items.AddRange(GetHardwareInfo("Win32_CDROMDrive", "Name").ToArray());
            listBoxDVD.Items.AddRange(GetHardwareInfo("Win32_CDROMDrive", "Drive").ToArray());

            listBoxDisk.Items.AddRange(GetHardwareInfo("Win32_DiskDrive", "Caption").ToArray());
            listBoxDisk.Items.AddRange(GetHardwareInfo("Win32_DiskDrive", "Size").ToArray());

            listBoxMB.Items.AddRange(GetHardwareInfo("Win32_BaseBoard", "Product").ToArray());
            listBoxMB.Items.AddRange(GetHardwareInfo("Win32_BaseBoard", "Manufacturer").ToArray());

            listBoxNetwork.Items.AddRange(GetHardwareInfo("Win32_NetworkAdapter", "Name").ToArray());
            listBoxNetwork.Items.AddRange(GetHardwareInfo("Win32_NetworkAdapter", "MACAddress").ToArray());

            listBoxBIOS.Items.AddRange(GetHardwareInfo("Win32_BIOS", "Manufacturer").ToArray());
            listBoxBIOS.Items.AddRange(GetHardwareInfo("Win32_BIOS", "SMBIOSBIOSVersion").ToArray());
            listBoxBIOS.Items.AddRange(GetHardwareInfo("Win32_BIOS", "ReleaseDate").ToArray());
        }
        private List<string> GetHardwareInfo(string wmiClass, string property)
        {
            List<string> result = new List<string>();
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM " + wmiClass);
                foreach (ManagementObject obj in searcher.Get())
                {
                    if (obj[property] != null)
                        result.Add(obj[property].ToString());
                }
            }
            catch (Exception ex)
            {
                result.Add("Error: " + ex.Message);
            }
            return result;
        }
    }
}
