using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LyncChange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            RegistryKey Lync = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Office\16.0\Lync", true);
            if(Lync != null)
            {
                Lync.SetValue("AwayThreshold", "360", RegistryValueKind.DWord);
                Lync.SetValue("IdleThreshold", "360", RegistryValueKind.DWord);
                Lync.Close();
            }
            btnChange.BackColor = Color.Green;
            btnDefault.BackColor = default(Color);
        }

        private void BtnDefault_Click(object sender, EventArgs e)
        {
            RegistryKey Lync = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Office\16.0\Lync", true);
            if (Lync != null)
            {
                Lync.SetValue("AwayThreshold", "5", RegistryValueKind.DWord);
                Lync.SetValue("IdleThreshold", "5", RegistryValueKind.DWord);
                Lync.Close();
            }
            btnChange.BackColor =  default(Color);
            btnDefault.BackColor = Color.Green;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
