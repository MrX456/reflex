/*
 * Formulário sobre o Reflex
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Management;
using Cypher;

/*
 * Reflex / Application / FrmSobre
 * @author MRX
 * Version : 1.0.0
 */

namespace Reflex
{
    partial class FrmSobre : Form
    {
        public FrmSobre()
        {
            InitializeComponent();
            this.SetPanelScroll();
            this.SetUserSpecs();
                       
        }

        private void SetPanelScroll()
        {
            panSobre.AutoScroll = false;
            panSobre.HorizontalScroll.Enabled = false;
            panSobre.HorizontalScroll.Visible = false;
            panSobre.HorizontalScroll.Maximum = 0;
            panSobre.AutoScroll = true;
        }

        private string GetArchiteture() 
        {
            if (Environment.Is64BitOperatingSystem)
                return "x64";
            else
                return "x86";
        }

        private string GetProcessor() 
        {
            string processor = null;
            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
            foreach (ManagementObject mo in mos.Get())
            {
              processor = (mo["Name"]).ToString();
            }
            return processor;
        }

        private void SetUserSpecs() 
        {
            lstDados.Items.Add("Versão : 1.0.0");
            lstDados.Items.Add("Nome Computador : " + Environment.MachineName);
            string windowsVersion = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductName", "").ToString();
            lstDados.Items.Add("Versão do Sistema : " + windowsVersion);
            lstDados.Items.Add("Arquitetura : " + this.GetArchiteture());
            lstDados.Items.Add("Processador : " + this.GetProcessor());
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmSobre_Load(object sender, EventArgs e)
        {
            Audio.PlaySobre();
        }

        private void FrmSobre_FormClosed(object sender, FormClosedEventArgs e)
        {
            Audio.StopSobre();
        }

        private void lblLnkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Misc.OpenRepository();
        }
    }
}
