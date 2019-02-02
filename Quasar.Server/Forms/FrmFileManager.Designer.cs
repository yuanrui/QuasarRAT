using Quasar.Server.Controls;

namespace Quasar.Server.Forms
{
    partial class FrmFileManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFileManager));
            this.contextMenuStripDirectory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.executeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.line2ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.addToStartupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.line3ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDirectoryInShellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgListDirectory = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.stripLblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStripTransfers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgListTransfers = new System.Windows.Forms.ImageList(this.components);
            this.TabControlFileManager = new Quasar.Server.Controls.DotNetBarTabControl();
            this.tabFileExplorer = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lstDirectory = new Quasar.Server.Controls.AeroListView();
            this.hName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblDrive = new System.Windows.Forms.Label();
            this.cmbDrives = new System.Windows.Forms.ComboBox();
            this.tabTransfers = new System.Windows.Forms.TabPage();
            this.btnOpenDLFolder = new System.Windows.Forms.Button();
            this.lstTransfers = new Quasar.Server.Controls.AeroListView();
            this.hID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hTransferType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hFilename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripDirectory.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.contextMenuStripTransfers.SuspendLayout();
            this.TabControlFileManager.SuspendLayout();
            this.tabFileExplorer.SuspendLayout();
            this.tabTransfers.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripDirectory
            // 
            this.contextMenuStripDirectory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadToolStripMenuItem,
            this.uploadToolStripMenuItem,
            this.lineToolStripMenuItem,
            this.executeToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.line2ToolStripMenuItem,
            this.addToStartupToolStripMenuItem,
            this.line3ToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.openDirectoryInShellToolStripMenuItem});
            this.contextMenuStripDirectory.Name = "ctxtMenu";
            resources.ApplyResources(this.contextMenuStripDirectory, "contextMenuStripDirectory");
            // 
            // downloadToolStripMenuItem
            // 
            resources.ApplyResources(this.downloadToolStripMenuItem, "downloadToolStripMenuItem");
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Click += new System.EventHandler(this.downloadToolStripMenuItem_Click);
            // 
            // uploadToolStripMenuItem
            // 
            resources.ApplyResources(this.uploadToolStripMenuItem, "uploadToolStripMenuItem");
            this.uploadToolStripMenuItem.Name = "uploadToolStripMenuItem";
            this.uploadToolStripMenuItem.Click += new System.EventHandler(this.uploadToolStripMenuItem_Click);
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            resources.ApplyResources(this.lineToolStripMenuItem, "lineToolStripMenuItem");
            // 
            // executeToolStripMenuItem
            // 
            resources.ApplyResources(this.executeToolStripMenuItem, "executeToolStripMenuItem");
            this.executeToolStripMenuItem.Name = "executeToolStripMenuItem";
            this.executeToolStripMenuItem.Click += new System.EventHandler(this.executeToolStripMenuItem_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Image = global::Quasar.Server.Properties.Resources.textfield_rename;
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            resources.ApplyResources(this.renameToolStripMenuItem, "renameToolStripMenuItem");
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::Quasar.Server.Properties.Resources.delete;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // line2ToolStripMenuItem
            // 
            this.line2ToolStripMenuItem.Name = "line2ToolStripMenuItem";
            resources.ApplyResources(this.line2ToolStripMenuItem, "line2ToolStripMenuItem");
            // 
            // addToStartupToolStripMenuItem
            // 
            this.addToStartupToolStripMenuItem.Image = global::Quasar.Server.Properties.Resources.application_add;
            this.addToStartupToolStripMenuItem.Name = "addToStartupToolStripMenuItem";
            resources.ApplyResources(this.addToStartupToolStripMenuItem, "addToStartupToolStripMenuItem");
            this.addToStartupToolStripMenuItem.Click += new System.EventHandler(this.addToStartupToolStripMenuItem_Click);
            // 
            // line3ToolStripMenuItem
            // 
            this.line3ToolStripMenuItem.Name = "line3ToolStripMenuItem";
            resources.ApplyResources(this.line3ToolStripMenuItem, "line3ToolStripMenuItem");
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::Quasar.Server.Properties.Resources.refresh;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            resources.ApplyResources(this.refreshToolStripMenuItem, "refreshToolStripMenuItem");
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // openDirectoryInShellToolStripMenuItem
            // 
            this.openDirectoryInShellToolStripMenuItem.Image = global::Quasar.Server.Properties.Resources.terminal;
            this.openDirectoryInShellToolStripMenuItem.Name = "openDirectoryInShellToolStripMenuItem";
            resources.ApplyResources(this.openDirectoryInShellToolStripMenuItem, "openDirectoryInShellToolStripMenuItem");
            this.openDirectoryInShellToolStripMenuItem.Click += new System.EventHandler(this.openDirectoryToolStripMenuItem_Click);
            // 
            // imgListDirectory
            // 
            this.imgListDirectory.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListDirectory.ImageStream")));
            this.imgListDirectory.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListDirectory.Images.SetKeyName(0, "back.png");
            this.imgListDirectory.Images.SetKeyName(1, "folder.png");
            this.imgListDirectory.Images.SetKeyName(2, "file.png");
            this.imgListDirectory.Images.SetKeyName(3, "application.png");
            this.imgListDirectory.Images.SetKeyName(4, "text.png");
            this.imgListDirectory.Images.SetKeyName(5, "archive.png");
            this.imgListDirectory.Images.SetKeyName(6, "word.png");
            this.imgListDirectory.Images.SetKeyName(7, "pdf.png");
            this.imgListDirectory.Images.SetKeyName(8, "image.png");
            this.imgListDirectory.Images.SetKeyName(9, "movie.png");
            this.imgListDirectory.Images.SetKeyName(10, "music.png");
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
            // contextMenuStripTransfers
            // 
            this.contextMenuStripTransfers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelToolStripMenuItem,
            this.toolStripMenuItem1,
            this.clearToolStripMenuItem});
            this.contextMenuStripTransfers.Name = "ctxtMenu2";
            resources.ApplyResources(this.contextMenuStripTransfers, "contextMenuStripTransfers");
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Image = global::Quasar.Server.Properties.Resources.cancel;
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            resources.ApplyResources(this.cancelToolStripMenuItem, "cancelToolStripMenuItem");
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Image = global::Quasar.Server.Properties.Resources.broom;
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            resources.ApplyResources(this.clearToolStripMenuItem, "clearToolStripMenuItem");
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // imgListTransfers
            // 
            this.imgListTransfers.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListTransfers.ImageStream")));
            this.imgListTransfers.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListTransfers.Images.SetKeyName(0, "cancel.png");
            this.imgListTransfers.Images.SetKeyName(1, "done.png");
            // 
            // TabControlFileManager
            // 
            resources.ApplyResources(this.TabControlFileManager, "TabControlFileManager");
            this.TabControlFileManager.Controls.Add(this.tabFileExplorer);
            this.TabControlFileManager.Controls.Add(this.tabTransfers);
            this.TabControlFileManager.Multiline = true;
            this.TabControlFileManager.Name = "TabControlFileManager";
            this.TabControlFileManager.SelectedIndex = 0;
            this.TabControlFileManager.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            // 
            // tabFileExplorer
            // 
            this.tabFileExplorer.BackColor = System.Drawing.SystemColors.Control;
            this.tabFileExplorer.Controls.Add(this.btnRefresh);
            this.tabFileExplorer.Controls.Add(this.lblPath);
            this.tabFileExplorer.Controls.Add(this.txtPath);
            this.tabFileExplorer.Controls.Add(this.lstDirectory);
            this.tabFileExplorer.Controls.Add(this.lblDrive);
            this.tabFileExplorer.Controls.Add(this.cmbDrives);
            resources.ApplyResources(this.tabFileExplorer, "tabFileExplorer");
            this.tabFileExplorer.Name = "tabFileExplorer";
            // 
            // btnRefresh
            // 
            resources.ApplyResources(this.btnRefresh, "btnRefresh");
            this.btnRefresh.Image = global::Quasar.Server.Properties.Resources.refresh;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblPath
            // 
            resources.ApplyResources(this.lblPath, "lblPath");
            this.lblPath.Name = "lblPath";
            // 
            // txtPath
            // 
            resources.ApplyResources(this.txtPath, "txtPath");
            this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            // 
            // lstDirectory
            // 
            this.lstDirectory.AllowDrop = true;
            resources.ApplyResources(this.lstDirectory, "lstDirectory");
            this.lstDirectory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hName,
            this.hSize,
            this.hType});
            this.lstDirectory.ContextMenuStrip = this.contextMenuStripDirectory;
            this.lstDirectory.FullRowSelect = true;
            this.lstDirectory.GridLines = true;
            this.lstDirectory.Name = "lstDirectory";
            this.lstDirectory.SmallImageList = this.imgListDirectory;
            this.lstDirectory.UseCompatibleStateImageBehavior = false;
            this.lstDirectory.View = System.Windows.Forms.View.Details;
            this.lstDirectory.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstDirectory_DragDrop);
            this.lstDirectory.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstDirectory_DragEnter);
            this.lstDirectory.DoubleClick += new System.EventHandler(this.lstDirectory_DoubleClick);
            // 
            // hName
            // 
            resources.ApplyResources(this.hName, "hName");
            // 
            // hSize
            // 
            resources.ApplyResources(this.hSize, "hSize");
            // 
            // hType
            // 
            resources.ApplyResources(this.hType, "hType");
            // 
            // lblDrive
            // 
            resources.ApplyResources(this.lblDrive, "lblDrive");
            this.lblDrive.Name = "lblDrive";
            // 
            // cmbDrives
            // 
            this.cmbDrives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDrives.FormattingEnabled = true;
            resources.ApplyResources(this.cmbDrives, "cmbDrives");
            this.cmbDrives.Name = "cmbDrives";
            this.cmbDrives.SelectedIndexChanged += new System.EventHandler(this.cmbDrives_SelectedIndexChanged);
            // 
            // tabTransfers
            // 
            this.tabTransfers.BackColor = System.Drawing.SystemColors.Control;
            this.tabTransfers.Controls.Add(this.btnOpenDLFolder);
            this.tabTransfers.Controls.Add(this.lstTransfers);
            resources.ApplyResources(this.tabTransfers, "tabTransfers");
            this.tabTransfers.Name = "tabTransfers";
            // 
            // btnOpenDLFolder
            // 
            resources.ApplyResources(this.btnOpenDLFolder, "btnOpenDLFolder");
            this.btnOpenDLFolder.Name = "btnOpenDLFolder";
            this.btnOpenDLFolder.UseVisualStyleBackColor = true;
            this.btnOpenDLFolder.Click += new System.EventHandler(this.btnOpenDLFolder_Click);
            // 
            // lstTransfers
            // 
            resources.ApplyResources(this.lstTransfers, "lstTransfers");
            this.lstTransfers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hID,
            this.hTransferType,
            this.hStatus,
            this.hFilename});
            this.lstTransfers.ContextMenuStrip = this.contextMenuStripTransfers;
            this.lstTransfers.FullRowSelect = true;
            this.lstTransfers.GridLines = true;
            this.lstTransfers.Name = "lstTransfers";
            this.lstTransfers.SmallImageList = this.imgListTransfers;
            this.lstTransfers.UseCompatibleStateImageBehavior = false;
            this.lstTransfers.View = System.Windows.Forms.View.Details;
            // 
            // hID
            // 
            resources.ApplyResources(this.hID, "hID");
            // 
            // hTransferType
            // 
            resources.ApplyResources(this.hTransferType, "hTransferType");
            // 
            // hStatus
            // 
            resources.ApplyResources(this.hStatus, "hStatus");
            // 
            // hFilename
            // 
            resources.ApplyResources(this.hFilename, "hFilename");
            // 
            // FrmFileManager
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.TabControlFileManager);
            this.Controls.Add(this.statusStrip);
            this.KeyPreview = true;
            this.Name = "FrmFileManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFileManager_FormClosing);
            this.Load += new System.EventHandler(this.FrmFileManager_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmFileManager_KeyDown);
            this.contextMenuStripDirectory.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.contextMenuStripTransfers.ResumeLayout(false);
            this.TabControlFileManager.ResumeLayout(false);
            this.tabFileExplorer.ResumeLayout(false);
            this.tabFileExplorer.PerformLayout();
            this.tabTransfers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDrive;
        private System.Windows.Forms.ImageList imgListDirectory;
        private System.Windows.Forms.ColumnHeader hName;
        private System.Windows.Forms.ColumnHeader hSize;
        private System.Windows.Forms.ColumnHeader hType;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDirectory;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.Button btnOpenDLFolder;
        private DotNetBarTabControl TabControlFileManager;
        private System.Windows.Forms.TabPage tabFileExplorer;
        private System.Windows.Forms.TabPage tabTransfers;
        private System.Windows.Forms.ColumnHeader hStatus;
        private System.Windows.Forms.ColumnHeader hFilename;
        private System.Windows.Forms.ColumnHeader hID;
        private System.Windows.Forms.ImageList imgListTransfers;
        private System.Windows.Forms.ToolStripMenuItem executeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator line3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator lineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator line2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToStartupToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTransfers;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDirectoryInShellToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbDrives;
        private AeroListView lstDirectory;
        private AeroListView lstTransfers;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel stripLblStatus;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ToolStripMenuItem uploadToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader hTransferType;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    }
}