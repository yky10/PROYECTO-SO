using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace administradorTareas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
			// USANDO COMPUTER Y ENVIRONMENT
			LabelInfo1.Text = "System.Environment.OSVersion:\n\n" + System.Environment.OSVersion.ToString();
			Computer pc = new Computer();
			LabelInfo2.Text = "Computer.Info.OSFullName:\n\n" + pc.Info.OSFullName.ToString();
			//
			// USANDO REGISTRO DE WINDOWS
			string Clave1 = @"SOFTWARE\Wow6432Node\Microsoft\Windows NT\CurrentVersion";
			string Clave2 = @"SYSTEM\CurrentControlSet\Control\Session Manager\Environment";
			//
			Microsoft.Win32.RegistryKey principal = Microsoft.Win32.Registry.LocalMachine; //rama LocalMachine
			Microsoft.Win32.RegistryKey subclave1 = principal.OpenSubKey(Clave1); //clave SOFTWARE ... CurrentVersion
			Microsoft.Win32.RegistryKey subclave2 = principal.OpenSubKey(Clave2); //clave SYSTEM ...  Environment
																				  //
			string nombre = subclave1.GetValue("ProductName").ToString();
			string compilacion = subclave1.GetValue("CurrentBuild").ToString();
			string release = subclave1.GetValue("ReleaseId").ToString();
			string arquitectura = subclave2.GetValue("PROCESSOR_ARCHITECTURE").ToString();
			if (arquitectura.Equals("AMD64"))
				arquitectura = "64 bits";
			else
				arquitectura = "32 bits";
			//
			LabelInfo3.Text = "ProductName:\n" + nombre + "\n\nCurrentBuild:\n" + compilacion + "\n\nReleaseId:\n" + release + "\n\nProcessor_Architecture:\n" + arquitectura;
		}
    }
}
