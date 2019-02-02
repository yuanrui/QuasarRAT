using Quasar.Server.Controls;

namespace Quasar.Server.Forms
{
    partial class FrmReverseProxy
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReverseProxy));
            this.btnStart = new System.Windows.Forms.Button();
            this.lblLocalServerPort = new System.Windows.Forms.Label();
            this.nudServerPort = new System.Windows.Forms.NumericUpDown();
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstConnections = new Quasar.Server.Controls.AeroListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.killConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblProxyInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLoadBalance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudServerPort)).BeginInit();
            this.tabCtrl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblLocalServerPort
            // 
            resources.ApplyResources(this.lblLocalServerPort, "lblLocalServerPort");
            this.lblLocalServerPort.Name = "lblLocalServerPort";
            // 
            // nudServerPort
            // 
            resources.ApplyResources(this.nudServerPort, "nudServerPort");
            this.nudServerPort.Maximum = new decimal(new int[] {
            65534,
            0,
            0,
            0});
            this.nudServerPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudServerPort.Name = "nudServerPort";
            this.nudServerPort.Value = new decimal(new int[] {
            3128,
            0,
            0,
            0});
            this.nudServerPort.ValueChanged += new System.EventHandler(this.nudServerPort_ValueChanged);
            // 
            // tabCtrl
            // 
            resources.ApplyResources(this.tabCtrl, "tabCtrl");
            this.tabCtrl.Controls.Add(this.tabPage1);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstConnections);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstConnections
            // 
            this.lstConnections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstConnections.ContextMenuStrip = this.contextMenuStrip;
            resources.ApplyResources(this.lstConnections, "lstConnections");
            this.lstConnections.FullRowSelect = true;
            this.lstConnections.GridLines = true;
            this.lstConnections.Name = "lstConnections";
            this.lstConnections.UseCompatibleStateImageBehavior = false;
            this.lstConnections.View = System.Windows.Forms.View.Details;
            this.lstConnections.VirtualMode = true;
            this.lstConnections.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.LvConnections_RetrieveVirtualItem);
            // 
            // columnHeader6
            // 
            resources.ApplyResources(this.columnHeader6, "columnHeader6");
            // 
            // columnHeader7
            // 
            resources.ApplyResources(this.columnHeader7, "columnHeader7");
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // columnHeader5
            // 
            resources.ApplyResources(this.columnHeader5, "columnHeader5");
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.killConnectionToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip, "contextMenuStrip");
            // 
            // killConnectionToolStripMenuItem
            // 
            this.killConnectionToolStripMenuItem.Name = "killConnectionToolStripMenuItem";
            resources.ApplyResources(this.killConnectionToolStripMenuItem, "killConnectionToolStripMenuItem");
            this.killConnectionToolStripMenuItem.Click += new System.EventHandler(this.killConnectionToolStripMenuItem_Click);
            // 
            // btnStop
            // 
            resources.ApplyResources(this.btnStop, "btnStop");
            this.btnStop.Name = "btnStop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblProxyInfo
            // 
            resources.ApplyResources(this.lblProxyInfo, "lblProxyInfo");
            this.lblProxyInfo.Name = "lblProxyInfo";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblLoadBalance
            // 
            resources.ApplyResources(this.lblLoadBalance, "lblLoadBalance");
            this.lblLoadBalance.Name = "lblLoadBalance";
            // 
            // FrmReverseProxy
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.lblLoadBalance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProxyInfo);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.tabCtrl);
            this.Controls.Add(this.nudServerPort);
            this.Controls.Add(this.lblLocalServerPort);
            this.Controls.Add(this.btnStart);
            this.Name = "FrmReverseProxy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmReverseProxy_FormClosing);
            this.Load += new System.EventHandler(this.FrmReverseProxy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudServerPort)).EndInit();
            this.tabCtrl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblLocalServerPort;
        private System.Windows.Forms.NumericUpDown nudServerPort;
        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage tabPage1;
        private AeroListView lstConnections;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblProxyInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem killConnectionToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLoadBalance;
    }
}