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
            listProcesses.Columns.Add("Name",200);
 
            foreach (Process proc in processes)
            {
                string[] row = { proc.ProcessName };
                listProcesses.Items.Add(new ListViewItem(row));
            }
        }
    }
}
