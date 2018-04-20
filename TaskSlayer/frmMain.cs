using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TaskSlayer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Process[] processes;
            processes = Process.GetProcesses();

            foreach (Process proc in processes)
            {
                if (chkOnlyWithWindowName.Checked)
                    if (proc.MainWindowTitle != "")
                    {
                        processEntry newProcEntry = new processEntry(proc);
                        listProcesses.AddObject(newProcEntry);
                    }
            }
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            Process proc = ((processEntry)listProcesses.SelectedObject).proc;
            proc.Kill();
        }

        private void listProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    class processEntry
    {
        public processEntry() { }
        public processEntry(Process process) => proc = process;
        public Process proc;

        public int Id => proc.Id;
        public long WorkingSetMB => ((proc.WorkingSet64 / 1024) / 1024);
        public string ProcessName => proc.ProcessName;
        public string MainWindowTitle => proc.MainWindowTitle;
    }
}
