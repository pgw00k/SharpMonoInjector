using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SharpMonoInjector.WF
{
    public partial class MainForm : Form
    {
        protected OpenFileDialog _OFDDllFile = new OpenFileDialog()
        {
            Title = "Select a library to inject",
            Filter= "MSIL(CLR) Library File|*.dll",
        };

        public MainForm()
        {
            InitializeComponent();

            txtProcessName.Text = Properties.Settings.Default.ProcessName;
            txtInjectorPath.Text = Properties.Settings.Default.DLLPath;
            txtClassName.Text = Properties.Settings.Default.ClassName;
            txtMFName.Text = Properties.Settings.Default.Method;
        }

        private void btnLoadDll_Click(object sender, EventArgs e)
        {
            if(_OFDDllFile.ShowDialog() == DialogResult.OK)
            {
                txtInjectorPath.Text = _OFDDllFile.FileName;
            }
        }

        private void btnInjectStart_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ProcessName = txtProcessName.Text;
            Properties.Settings.Default.DLLPath = txtInjectorPath.Text;
            Properties.Settings.Default.ClassName = txtClassName.Text;
            Properties.Settings.Default.Method = txtMFName.Text;

            string strProcessName = txtProcessName.Text;
            string strDllPath = txtInjectorPath.Text;
            string strClassName = txtClassName.Text;
            string strMethodName = txtMFName.Text;

            InjectorManager.StartInjectTo(strProcessName, strDllPath, strClassName, strMethodName);
        }
    }
}
