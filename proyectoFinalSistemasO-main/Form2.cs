using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Win32;
using System.Management;

namespace administradorTareas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            //Referir al namespace \\root\cimv2
            ManagementScope scope = new ManagementScope("\\root\\cimv2");
            //Crear un objeto para consultar una tabla del namespace
            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_LogicalDisk where drivetype=3");
            //Ejecutar el query
            ManagementObjectSearcher mos = new ManagementObjectSearcher(scope, query);

            //Iterar en los resultados del query
            foreach (ManagementObject item in mos.Get())
            {
                long hddSizeBytes = Int64.Parse(item["Size"].ToString());
                double hddSizeGBytes = hddSizeBytes / 1024 / 1024 / 1024;

                label2.Text = hddSizeGBytes.ToString();
                //Console.WriteLine("Tamaño = " + hddSizeGBytes + "Gb");
            }
            //Console.ReadLine();

            String path = "HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0";
            RegistryKey key = Registry.LocalMachine.OpenSubKey(path);
            String processor = key.GetValue("ProcessorNameString").ToString();
            label6.Text = processor.ToString();
            //Console.WriteLine("Procesador=" + processor);
            //Console.ReadLine();
        }


    }
}
