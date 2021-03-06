﻿namespace TaskSlayer
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKill = new System.Windows.Forms.Button();
            this.listProcesses = new BrightIdeasSoftware.FastObjectListView();
            this.ProcessName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.MainWindow = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.WorkingSetMB = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.chkOnlyWithWindowName = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.listProcesses)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKill
            // 
            this.btnKill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKill.Location = new System.Drawing.Point(405, 556);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(111, 39);
            this.btnKill.TabIndex = 1;
            this.btnKill.Text = "Kill";
            this.btnKill.UseVisualStyleBackColor = true;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // listProcesses
            // 
            this.listProcesses.AllColumns.Add(this.ProcessName);
            this.listProcesses.AllColumns.Add(this.MainWindow);
            this.listProcesses.AllColumns.Add(this.WorkingSetMB);
            this.listProcesses.AllowColumnReorder = true;
            this.listProcesses.AlternateRowBackColor = System.Drawing.Color.Khaki;
            this.listProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listProcesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProcessName,
            this.MainWindow,
            this.WorkingSetMB});
            this.listProcesses.FullRowSelect = true;
            this.listProcesses.Location = new System.Drawing.Point(12, 12);
            this.listProcesses.Name = "listProcesses";
            this.listProcesses.ShowGroups = false;
            this.listProcesses.Size = new System.Drawing.Size(504, 538);
            this.listProcesses.TabIndex = 2;
            this.listProcesses.UseCompatibleStateImageBehavior = false;
            this.listProcesses.View = System.Windows.Forms.View.Details;
            this.listProcesses.VirtualMode = true;
            this.listProcesses.SelectedIndexChanged += new System.EventHandler(this.listProcesses_SelectedIndexChanged);
            // 
            // ProcessName
            // 
            this.ProcessName.AspectName = "ProcessName";
            this.ProcessName.Text = "Name";
            this.ProcessName.Width = 200;
            // 
            // MainWindow
            // 
            this.MainWindow.AspectName = "MainWindowTitle";
            this.MainWindow.FillsFreeSpace = true;
            this.MainWindow.Text = "Title";
            this.MainWindow.Width = 200;
            // 
            // WorkingSetMB
            // 
            this.WorkingSetMB.AspectName = "WorkingSetMB";
            this.WorkingSetMB.Text = "Memory (MB)";
            this.WorkingSetMB.Width = 80;
            // 
            // chkOnlyWithWindowName
            // 
            this.chkOnlyWithWindowName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkOnlyWithWindowName.AutoSize = true;
            this.chkOnlyWithWindowName.Checked = true;
            this.chkOnlyWithWindowName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOnlyWithWindowName.Location = new System.Drawing.Point(13, 557);
            this.chkOnlyWithWindowName.Name = "chkOnlyWithWindowName";
            this.chkOnlyWithWindowName.Size = new System.Drawing.Size(206, 17);
            this.chkOnlyWithWindowName.TabIndex = 3;
            this.chkOnlyWithWindowName.Text = "Only show processes with window title";
            this.chkOnlyWithWindowName.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 607);
            this.Controls.Add(this.chkOnlyWithWindowName);
            this.Controls.Add(this.listProcesses);
            this.Controls.Add(this.btnKill);
            this.Name = "frmMain";
            this.Text = "TaskSlayer";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listProcesses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnKill;
        private BrightIdeasSoftware.FastObjectListView listProcesses;
        private BrightIdeasSoftware.OLVColumn ProcessName;
        private BrightIdeasSoftware.OLVColumn MainWindow;
        private BrightIdeasSoftware.OLVColumn WorkingSetMB;
        private System.Windows.Forms.CheckBox chkOnlyWithWindowName;
    }
}

