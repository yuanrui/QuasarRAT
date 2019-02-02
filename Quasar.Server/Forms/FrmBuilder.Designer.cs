using Quasar.Server.Controls;

namespace Quasar.Server.Forms
{
    partial class FrmBuilder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuilder));
            this.btnBuild = new System.Windows.Forms.Button();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.picUAC2 = new System.Windows.Forms.PictureBox();
            this.picUAC1 = new System.Windows.Forms.PictureBox();
            this.rbSystem = new System.Windows.Forms.RadioButton();
            this.rbProgramFiles = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeHostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.builderTabs = new Quasar.Server.Controls.DotNetBarTabControl();
            this.generalPage = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.line6 = new Quasar.Server.Controls.Line();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTag = new System.Windows.Forms.Label();
            this.txtMutex = new System.Windows.Forms.TextBox();
            this.btnMutex = new System.Windows.Forms.Button();
            this.line5 = new Quasar.Server.Controls.Line();
            this.lblMutex = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.connectionPage = new System.Windows.Forms.TabPage();
            this.numericUpDownPort = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDelay = new System.Windows.Forms.NumericUpDown();
            this.line3 = new Quasar.Server.Controls.Line();
            this.label4 = new System.Windows.Forms.Label();
            this.line1 = new Quasar.Server.Controls.Line();
            this.label1 = new System.Windows.Forms.Label();
            this.lstHosts = new System.Windows.Forms.ListBox();
            this.btnAddHost = new System.Windows.Forms.Button();
            this.lblMS = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.lblDelay = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.installationPage = new System.Windows.Forms.TabPage();
            this.chkHideSubDirectory = new System.Windows.Forms.CheckBox();
            this.line7 = new Quasar.Server.Controls.Line();
            this.label10 = new System.Windows.Forms.Label();
            this.line4 = new Quasar.Server.Controls.Line();
            this.label5 = new System.Windows.Forms.Label();
            this.chkInstall = new System.Windows.Forms.CheckBox();
            this.lblInstallName = new System.Windows.Forms.Label();
            this.txtInstallName = new System.Windows.Forms.TextBox();
            this.txtRegistryKeyName = new System.Windows.Forms.TextBox();
            this.lblExtension = new System.Windows.Forms.Label();
            this.lblRegistryKeyName = new System.Windows.Forms.Label();
            this.chkStartup = new System.Windows.Forms.CheckBox();
            this.rbAppdata = new System.Windows.Forms.RadioButton();
            this.chkHide = new System.Windows.Forms.CheckBox();
            this.lblInstallDirectory = new System.Windows.Forms.Label();
            this.lblInstallSubDirectory = new System.Windows.Forms.Label();
            this.lblPreviewPath = new System.Windows.Forms.Label();
            this.txtInstallSubDirectory = new System.Windows.Forms.TextBox();
            this.txtPreviewPath = new System.Windows.Forms.TextBox();
            this.assemblyPage = new System.Windows.Forms.TabPage();
            this.iconPreview = new System.Windows.Forms.PictureBox();
            this.btnBrowseIcon = new System.Windows.Forms.Button();
            this.txtIconPath = new System.Windows.Forms.TextBox();
            this.line8 = new Quasar.Server.Controls.Line();
            this.label11 = new System.Windows.Forms.Label();
            this.chkChangeAsmInfo = new System.Windows.Forms.CheckBox();
            this.txtFileVersion = new System.Windows.Forms.TextBox();
            this.line9 = new Quasar.Server.Controls.Line();
            this.lblProductName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.chkChangeIcon = new System.Windows.Forms.CheckBox();
            this.lblFileVersion = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductVersion = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblProductVersion = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtOriginalFilename = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblOriginalFilename = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtTrademarks = new System.Windows.Forms.TextBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblTrademarks = new System.Windows.Forms.Label();
            this.txtCopyright = new System.Windows.Forms.TextBox();
            this.surveillanceTab = new System.Windows.Forms.TabPage();
            this.chkHideLogDirectory = new System.Windows.Forms.CheckBox();
            this.txtLogDirectoryName = new System.Windows.Forms.TextBox();
            this.lblLogDirectory = new System.Windows.Forms.Label();
            this.line10 = new Quasar.Server.Controls.Line();
            this.label14 = new System.Windows.Forms.Label();
            this.chkKeylogger = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picUAC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUAC1)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.builderTabs.SuspendLayout();
            this.generalPage.SuspendLayout();
            this.connectionPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).BeginInit();
            this.installationPage.SuspendLayout();
            this.assemblyPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPreview)).BeginInit();
            this.surveillanceTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuild
            // 
            resources.ApplyResources(this.btnBuild, "btnBuild");
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // picUAC2
            // 
            this.picUAC2.Image = global::Quasar.Server.Properties.Resources.uac_shield;
            resources.ApplyResources(this.picUAC2, "picUAC2");
            this.picUAC2.Name = "picUAC2";
            this.picUAC2.TabStop = false;
            this.tooltip.SetToolTip(this.picUAC2, resources.GetString("picUAC2.ToolTip"));
            // 
            // picUAC1
            // 
            this.picUAC1.Image = global::Quasar.Server.Properties.Resources.uac_shield;
            resources.ApplyResources(this.picUAC1, "picUAC1");
            this.picUAC1.Name = "picUAC1";
            this.picUAC1.TabStop = false;
            this.tooltip.SetToolTip(this.picUAC1, resources.GetString("picUAC1.ToolTip"));
            // 
            // rbSystem
            // 
            resources.ApplyResources(this.rbSystem, "rbSystem");
            this.rbSystem.Name = "rbSystem";
            this.rbSystem.TabStop = true;
            this.tooltip.SetToolTip(this.rbSystem, resources.GetString("rbSystem.ToolTip"));
            this.rbSystem.UseVisualStyleBackColor = true;
            this.rbSystem.CheckedChanged += new System.EventHandler(this.HasChangedSettingAndFilePath);
            // 
            // rbProgramFiles
            // 
            resources.ApplyResources(this.rbProgramFiles, "rbProgramFiles");
            this.rbProgramFiles.Name = "rbProgramFiles";
            this.rbProgramFiles.TabStop = true;
            this.tooltip.SetToolTip(this.rbProgramFiles, resources.GetString("rbProgramFiles.ToolTip"));
            this.rbProgramFiles.UseVisualStyleBackColor = true;
            this.rbProgramFiles.CheckedChanged += new System.EventHandler(this.HasChangedSettingAndFilePath);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeHostToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.contextMenuStrip.Name = "ctxtMenuHosts";
            resources.ApplyResources(this.contextMenuStrip, "contextMenuStrip");
            // 
            // removeHostToolStripMenuItem
            // 
            this.removeHostToolStripMenuItem.Image = global::Quasar.Server.Properties.Resources.delete;
            this.removeHostToolStripMenuItem.Name = "removeHostToolStripMenuItem";
            resources.ApplyResources(this.removeHostToolStripMenuItem, "removeHostToolStripMenuItem");
            this.removeHostToolStripMenuItem.Click += new System.EventHandler(this.removeHostToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Image = global::Quasar.Server.Properties.Resources.broom;
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            resources.ApplyResources(this.clearToolStripMenuItem, "clearToolStripMenuItem");
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // builderTabs
            // 
            resources.ApplyResources(this.builderTabs, "builderTabs");
            this.builderTabs.Controls.Add(this.generalPage);
            this.builderTabs.Controls.Add(this.connectionPage);
            this.builderTabs.Controls.Add(this.installationPage);
            this.builderTabs.Controls.Add(this.assemblyPage);
            this.builderTabs.Controls.Add(this.surveillanceTab);
            this.builderTabs.Multiline = true;
            this.builderTabs.Name = "builderTabs";
            this.builderTabs.SelectedIndex = 0;
            this.builderTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            // 
            // generalPage
            // 
            this.generalPage.BackColor = System.Drawing.SystemColors.Control;
            this.generalPage.Controls.Add(this.label9);
            this.generalPage.Controls.Add(this.line6);
            this.generalPage.Controls.Add(this.label8);
            this.generalPage.Controls.Add(this.txtTag);
            this.generalPage.Controls.Add(this.label7);
            this.generalPage.Controls.Add(this.lblTag);
            this.generalPage.Controls.Add(this.txtMutex);
            this.generalPage.Controls.Add(this.btnMutex);
            this.generalPage.Controls.Add(this.line5);
            this.generalPage.Controls.Add(this.lblMutex);
            this.generalPage.Controls.Add(this.label6);
            resources.ApplyResources(this.generalPage, "generalPage");
            this.generalPage.Name = "generalPage";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // line6
            // 
            this.line6.LineAlignment = Quasar.Server.Controls.Line.Alignment.Horizontal;
            resources.ApplyResources(this.line6, "line6");
            this.line6.Name = "line6";
            this.line6.TabStop = false;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // txtTag
            // 
            resources.ApplyResources(this.txtTag, "txtTag");
            this.txtTag.Name = "txtTag";
            this.txtTag.TextChanged += new System.EventHandler(this.HasChangedSetting);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // lblTag
            // 
            resources.ApplyResources(this.lblTag, "lblTag");
            this.lblTag.Name = "lblTag";
            // 
            // txtMutex
            // 
            resources.ApplyResources(this.txtMutex, "txtMutex");
            this.txtMutex.Name = "txtMutex";
            this.txtMutex.TextChanged += new System.EventHandler(this.HasChangedSetting);
            // 
            // btnMutex
            // 
            resources.ApplyResources(this.btnMutex, "btnMutex");
            this.btnMutex.Name = "btnMutex";
            this.btnMutex.UseVisualStyleBackColor = true;
            this.btnMutex.Click += new System.EventHandler(this.btnMutex_Click);
            // 
            // line5
            // 
            this.line5.LineAlignment = Quasar.Server.Controls.Line.Alignment.Horizontal;
            resources.ApplyResources(this.line5, "line5");
            this.line5.Name = "line5";
            this.line5.TabStop = false;
            // 
            // lblMutex
            // 
            resources.ApplyResources(this.lblMutex, "lblMutex");
            this.lblMutex.Name = "lblMutex";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // connectionPage
            // 
            this.connectionPage.BackColor = System.Drawing.SystemColors.Control;
            this.connectionPage.Controls.Add(this.numericUpDownPort);
            this.connectionPage.Controls.Add(this.numericUpDownDelay);
            this.connectionPage.Controls.Add(this.line3);
            this.connectionPage.Controls.Add(this.label4);
            this.connectionPage.Controls.Add(this.line1);
            this.connectionPage.Controls.Add(this.label1);
            this.connectionPage.Controls.Add(this.lstHosts);
            this.connectionPage.Controls.Add(this.btnAddHost);
            this.connectionPage.Controls.Add(this.lblMS);
            this.connectionPage.Controls.Add(this.lblHost);
            this.connectionPage.Controls.Add(this.txtHost);
            this.connectionPage.Controls.Add(this.lblDelay);
            this.connectionPage.Controls.Add(this.lblPort);
            resources.ApplyResources(this.connectionPage, "connectionPage");
            this.connectionPage.Name = "connectionPage";
            // 
            // numericUpDownPort
            // 
            resources.ApplyResources(this.numericUpDownPort, "numericUpDownPort");
            this.numericUpDownPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPort.Name = "numericUpDownPort";
            this.numericUpDownPort.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownDelay
            // 
            resources.ApplyResources(this.numericUpDownDelay, "numericUpDownDelay");
            this.numericUpDownDelay.Maximum = new decimal(new int[] {
            600000,
            0,
            0,
            0});
            this.numericUpDownDelay.Name = "numericUpDownDelay";
            this.numericUpDownDelay.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownDelay.ValueChanged += new System.EventHandler(this.HasChangedSetting);
            // 
            // line3
            // 
            this.line3.LineAlignment = Quasar.Server.Controls.Line.Alignment.Horizontal;
            resources.ApplyResources(this.line3, "line3");
            this.line3.Name = "line3";
            this.line3.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // line1
            // 
            this.line1.LineAlignment = Quasar.Server.Controls.Line.Alignment.Horizontal;
            resources.ApplyResources(this.line1, "line1");
            this.line1.Name = "line1";
            this.line1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lstHosts
            // 
            this.lstHosts.ContextMenuStrip = this.contextMenuStrip;
            this.lstHosts.FormattingEnabled = true;
            resources.ApplyResources(this.lstHosts, "lstHosts");
            this.lstHosts.Name = "lstHosts";
            this.lstHosts.TabStop = false;
            // 
            // btnAddHost
            // 
            resources.ApplyResources(this.btnAddHost, "btnAddHost");
            this.btnAddHost.Name = "btnAddHost";
            this.btnAddHost.UseVisualStyleBackColor = true;
            this.btnAddHost.Click += new System.EventHandler(this.btnAddHost_Click);
            // 
            // lblMS
            // 
            resources.ApplyResources(this.lblMS, "lblMS");
            this.lblMS.Name = "lblMS";
            // 
            // lblHost
            // 
            resources.ApplyResources(this.lblHost, "lblHost");
            this.lblHost.Name = "lblHost";
            // 
            // txtHost
            // 
            resources.ApplyResources(this.txtHost, "txtHost");
            this.txtHost.Name = "txtHost";
            // 
            // lblDelay
            // 
            resources.ApplyResources(this.lblDelay, "lblDelay");
            this.lblDelay.Name = "lblDelay";
            // 
            // lblPort
            // 
            resources.ApplyResources(this.lblPort, "lblPort");
            this.lblPort.Name = "lblPort";
            // 
            // installationPage
            // 
            this.installationPage.BackColor = System.Drawing.SystemColors.Control;
            this.installationPage.Controls.Add(this.chkHideSubDirectory);
            this.installationPage.Controls.Add(this.line7);
            this.installationPage.Controls.Add(this.label10);
            this.installationPage.Controls.Add(this.line4);
            this.installationPage.Controls.Add(this.label5);
            this.installationPage.Controls.Add(this.picUAC2);
            this.installationPage.Controls.Add(this.picUAC1);
            this.installationPage.Controls.Add(this.chkInstall);
            this.installationPage.Controls.Add(this.rbSystem);
            this.installationPage.Controls.Add(this.lblInstallName);
            this.installationPage.Controls.Add(this.rbProgramFiles);
            this.installationPage.Controls.Add(this.txtInstallName);
            this.installationPage.Controls.Add(this.txtRegistryKeyName);
            this.installationPage.Controls.Add(this.lblExtension);
            this.installationPage.Controls.Add(this.lblRegistryKeyName);
            this.installationPage.Controls.Add(this.chkStartup);
            this.installationPage.Controls.Add(this.rbAppdata);
            this.installationPage.Controls.Add(this.chkHide);
            this.installationPage.Controls.Add(this.lblInstallDirectory);
            this.installationPage.Controls.Add(this.lblInstallSubDirectory);
            this.installationPage.Controls.Add(this.lblPreviewPath);
            this.installationPage.Controls.Add(this.txtInstallSubDirectory);
            this.installationPage.Controls.Add(this.txtPreviewPath);
            resources.ApplyResources(this.installationPage, "installationPage");
            this.installationPage.Name = "installationPage";
            // 
            // chkHideSubDirectory
            // 
            resources.ApplyResources(this.chkHideSubDirectory, "chkHideSubDirectory");
            this.chkHideSubDirectory.Name = "chkHideSubDirectory";
            this.chkHideSubDirectory.UseVisualStyleBackColor = true;
            // 
            // line7
            // 
            this.line7.LineAlignment = Quasar.Server.Controls.Line.Alignment.Horizontal;
            resources.ApplyResources(this.line7, "line7");
            this.line7.Name = "line7";
            this.line7.TabStop = false;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // line4
            // 
            this.line4.LineAlignment = Quasar.Server.Controls.Line.Alignment.Horizontal;
            resources.ApplyResources(this.line4, "line4");
            this.line4.Name = "line4";
            this.line4.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // chkInstall
            // 
            resources.ApplyResources(this.chkInstall, "chkInstall");
            this.chkInstall.Name = "chkInstall";
            this.chkInstall.UseVisualStyleBackColor = true;
            this.chkInstall.CheckedChanged += new System.EventHandler(this.chkInstall_CheckedChanged);
            // 
            // lblInstallName
            // 
            resources.ApplyResources(this.lblInstallName, "lblInstallName");
            this.lblInstallName.Name = "lblInstallName";
            // 
            // txtInstallName
            // 
            resources.ApplyResources(this.txtInstallName, "txtInstallName");
            this.txtInstallName.Name = "txtInstallName";
            this.txtInstallName.TextChanged += new System.EventHandler(this.HasChangedSettingAndFilePath);
            this.txtInstallName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInstallname_KeyPress);
            // 
            // txtRegistryKeyName
            // 
            resources.ApplyResources(this.txtRegistryKeyName, "txtRegistryKeyName");
            this.txtRegistryKeyName.Name = "txtRegistryKeyName";
            this.txtRegistryKeyName.TextChanged += new System.EventHandler(this.HasChangedSetting);
            // 
            // lblExtension
            // 
            resources.ApplyResources(this.lblExtension, "lblExtension");
            this.lblExtension.Name = "lblExtension";
            // 
            // lblRegistryKeyName
            // 
            resources.ApplyResources(this.lblRegistryKeyName, "lblRegistryKeyName");
            this.lblRegistryKeyName.Name = "lblRegistryKeyName";
            // 
            // chkStartup
            // 
            resources.ApplyResources(this.chkStartup, "chkStartup");
            this.chkStartup.Name = "chkStartup";
            this.chkStartup.UseVisualStyleBackColor = true;
            this.chkStartup.CheckedChanged += new System.EventHandler(this.chkStartup_CheckedChanged);
            // 
            // rbAppdata
            // 
            resources.ApplyResources(this.rbAppdata, "rbAppdata");
            this.rbAppdata.Checked = true;
            this.rbAppdata.Name = "rbAppdata";
            this.rbAppdata.TabStop = true;
            this.rbAppdata.UseVisualStyleBackColor = true;
            this.rbAppdata.CheckedChanged += new System.EventHandler(this.HasChangedSettingAndFilePath);
            // 
            // chkHide
            // 
            resources.ApplyResources(this.chkHide, "chkHide");
            this.chkHide.Name = "chkHide";
            this.chkHide.UseVisualStyleBackColor = true;
            this.chkHide.CheckedChanged += new System.EventHandler(this.HasChangedSetting);
            // 
            // lblInstallDirectory
            // 
            resources.ApplyResources(this.lblInstallDirectory, "lblInstallDirectory");
            this.lblInstallDirectory.Name = "lblInstallDirectory";
            // 
            // lblInstallSubDirectory
            // 
            resources.ApplyResources(this.lblInstallSubDirectory, "lblInstallSubDirectory");
            this.lblInstallSubDirectory.Name = "lblInstallSubDirectory";
            // 
            // lblPreviewPath
            // 
            resources.ApplyResources(this.lblPreviewPath, "lblPreviewPath");
            this.lblPreviewPath.Name = "lblPreviewPath";
            // 
            // txtInstallSubDirectory
            // 
            resources.ApplyResources(this.txtInstallSubDirectory, "txtInstallSubDirectory");
            this.txtInstallSubDirectory.Name = "txtInstallSubDirectory";
            this.txtInstallSubDirectory.TextChanged += new System.EventHandler(this.HasChangedSettingAndFilePath);
            this.txtInstallSubDirectory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInstallsub_KeyPress);
            // 
            // txtPreviewPath
            // 
            resources.ApplyResources(this.txtPreviewPath, "txtPreviewPath");
            this.txtPreviewPath.Name = "txtPreviewPath";
            this.txtPreviewPath.ReadOnly = true;
            this.txtPreviewPath.TabStop = false;
            // 
            // assemblyPage
            // 
            this.assemblyPage.BackColor = System.Drawing.SystemColors.Control;
            this.assemblyPage.Controls.Add(this.iconPreview);
            this.assemblyPage.Controls.Add(this.btnBrowseIcon);
            this.assemblyPage.Controls.Add(this.txtIconPath);
            this.assemblyPage.Controls.Add(this.line8);
            this.assemblyPage.Controls.Add(this.label11);
            this.assemblyPage.Controls.Add(this.chkChangeAsmInfo);
            this.assemblyPage.Controls.Add(this.txtFileVersion);
            this.assemblyPage.Controls.Add(this.line9);
            this.assemblyPage.Controls.Add(this.lblProductName);
            this.assemblyPage.Controls.Add(this.label12);
            this.assemblyPage.Controls.Add(this.chkChangeIcon);
            this.assemblyPage.Controls.Add(this.lblFileVersion);
            this.assemblyPage.Controls.Add(this.txtProductName);
            this.assemblyPage.Controls.Add(this.txtProductVersion);
            this.assemblyPage.Controls.Add(this.lblDescription);
            this.assemblyPage.Controls.Add(this.lblProductVersion);
            this.assemblyPage.Controls.Add(this.txtDescription);
            this.assemblyPage.Controls.Add(this.txtOriginalFilename);
            this.assemblyPage.Controls.Add(this.lblCompanyName);
            this.assemblyPage.Controls.Add(this.lblOriginalFilename);
            this.assemblyPage.Controls.Add(this.txtCompanyName);
            this.assemblyPage.Controls.Add(this.txtTrademarks);
            this.assemblyPage.Controls.Add(this.lblCopyright);
            this.assemblyPage.Controls.Add(this.lblTrademarks);
            this.assemblyPage.Controls.Add(this.txtCopyright);
            resources.ApplyResources(this.assemblyPage, "assemblyPage");
            this.assemblyPage.Name = "assemblyPage";
            // 
            // iconPreview
            // 
            resources.ApplyResources(this.iconPreview, "iconPreview");
            this.iconPreview.Name = "iconPreview";
            this.iconPreview.TabStop = false;
            // 
            // btnBrowseIcon
            // 
            resources.ApplyResources(this.btnBrowseIcon, "btnBrowseIcon");
            this.btnBrowseIcon.Name = "btnBrowseIcon";
            this.btnBrowseIcon.UseVisualStyleBackColor = true;
            this.btnBrowseIcon.Click += new System.EventHandler(this.btnBrowseIcon_Click);
            // 
            // txtIconPath
            // 
            resources.ApplyResources(this.txtIconPath, "txtIconPath");
            this.txtIconPath.Name = "txtIconPath";
            // 
            // line8
            // 
            this.line8.LineAlignment = Quasar.Server.Controls.Line.Alignment.Horizontal;
            resources.ApplyResources(this.line8, "line8");
            this.line8.Name = "line8";
            this.line8.TabStop = false;
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // chkChangeAsmInfo
            // 
            resources.ApplyResources(this.chkChangeAsmInfo, "chkChangeAsmInfo");
            this.chkChangeAsmInfo.Name = "chkChangeAsmInfo";
            this.chkChangeAsmInfo.UseVisualStyleBackColor = true;
            this.chkChangeAsmInfo.CheckedChanged += new System.EventHandler(this.chkChangeAsmInfo_CheckedChanged);
            // 
            // txtFileVersion
            // 
            resources.ApplyResources(this.txtFileVersion, "txtFileVersion");
            this.txtFileVersion.Name = "txtFileVersion";
            this.txtFileVersion.TextChanged += new System.EventHandler(this.HasChangedSetting);
            // 
            // line9
            // 
            this.line9.LineAlignment = Quasar.Server.Controls.Line.Alignment.Horizontal;
            resources.ApplyResources(this.line9, "line9");
            this.line9.Name = "line9";
            this.line9.TabStop = false;
            // 
            // lblProductName
            // 
            resources.ApplyResources(this.lblProductName, "lblProductName");
            this.lblProductName.Name = "lblProductName";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // chkChangeIcon
            // 
            resources.ApplyResources(this.chkChangeIcon, "chkChangeIcon");
            this.chkChangeIcon.Name = "chkChangeIcon";
            this.chkChangeIcon.UseVisualStyleBackColor = true;
            this.chkChangeIcon.CheckedChanged += new System.EventHandler(this.chkChangeIcon_CheckedChanged);
            // 
            // lblFileVersion
            // 
            resources.ApplyResources(this.lblFileVersion, "lblFileVersion");
            this.lblFileVersion.Name = "lblFileVersion";
            // 
            // txtProductName
            // 
            resources.ApplyResources(this.txtProductName, "txtProductName");
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.TextChanged += new System.EventHandler(this.HasChangedSetting);
            // 
            // txtProductVersion
            // 
            resources.ApplyResources(this.txtProductVersion, "txtProductVersion");
            this.txtProductVersion.Name = "txtProductVersion";
            this.txtProductVersion.TextChanged += new System.EventHandler(this.HasChangedSetting);
            // 
            // lblDescription
            // 
            resources.ApplyResources(this.lblDescription, "lblDescription");
            this.lblDescription.Name = "lblDescription";
            // 
            // lblProductVersion
            // 
            resources.ApplyResources(this.lblProductVersion, "lblProductVersion");
            this.lblProductVersion.Name = "lblProductVersion";
            // 
            // txtDescription
            // 
            resources.ApplyResources(this.txtDescription, "txtDescription");
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.TextChanged += new System.EventHandler(this.HasChangedSetting);
            // 
            // txtOriginalFilename
            // 
            resources.ApplyResources(this.txtOriginalFilename, "txtOriginalFilename");
            this.txtOriginalFilename.Name = "txtOriginalFilename";
            this.txtOriginalFilename.TextChanged += new System.EventHandler(this.HasChangedSetting);
            // 
            // lblCompanyName
            // 
            resources.ApplyResources(this.lblCompanyName, "lblCompanyName");
            this.lblCompanyName.Name = "lblCompanyName";
            // 
            // lblOriginalFilename
            // 
            resources.ApplyResources(this.lblOriginalFilename, "lblOriginalFilename");
            this.lblOriginalFilename.Name = "lblOriginalFilename";
            // 
            // txtCompanyName
            // 
            resources.ApplyResources(this.txtCompanyName, "txtCompanyName");
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.TextChanged += new System.EventHandler(this.HasChangedSetting);
            // 
            // txtTrademarks
            // 
            resources.ApplyResources(this.txtTrademarks, "txtTrademarks");
            this.txtTrademarks.Name = "txtTrademarks";
            this.txtTrademarks.TextChanged += new System.EventHandler(this.HasChangedSetting);
            // 
            // lblCopyright
            // 
            resources.ApplyResources(this.lblCopyright, "lblCopyright");
            this.lblCopyright.Name = "lblCopyright";
            // 
            // lblTrademarks
            // 
            resources.ApplyResources(this.lblTrademarks, "lblTrademarks");
            this.lblTrademarks.Name = "lblTrademarks";
            // 
            // txtCopyright
            // 
            resources.ApplyResources(this.txtCopyright, "txtCopyright");
            this.txtCopyright.Name = "txtCopyright";
            this.txtCopyright.TextChanged += new System.EventHandler(this.HasChangedSetting);
            // 
            // surveillanceTab
            // 
            this.surveillanceTab.BackColor = System.Drawing.SystemColors.Control;
            this.surveillanceTab.Controls.Add(this.chkHideLogDirectory);
            this.surveillanceTab.Controls.Add(this.txtLogDirectoryName);
            this.surveillanceTab.Controls.Add(this.lblLogDirectory);
            this.surveillanceTab.Controls.Add(this.line10);
            this.surveillanceTab.Controls.Add(this.label14);
            this.surveillanceTab.Controls.Add(this.chkKeylogger);
            resources.ApplyResources(this.surveillanceTab, "surveillanceTab");
            this.surveillanceTab.Name = "surveillanceTab";
            // 
            // chkHideLogDirectory
            // 
            resources.ApplyResources(this.chkHideLogDirectory, "chkHideLogDirectory");
            this.chkHideLogDirectory.Name = "chkHideLogDirectory";
            this.chkHideLogDirectory.UseVisualStyleBackColor = true;
            this.chkHideLogDirectory.CheckedChanged += new System.EventHandler(this.HasChangedSetting);
            // 
            // txtLogDirectoryName
            // 
            resources.ApplyResources(this.txtLogDirectoryName, "txtLogDirectoryName");
            this.txtLogDirectoryName.Name = "txtLogDirectoryName";
            this.txtLogDirectoryName.TextChanged += new System.EventHandler(this.HasChangedSetting);
            this.txtLogDirectoryName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogDirectoryName_KeyPress);
            // 
            // lblLogDirectory
            // 
            resources.ApplyResources(this.lblLogDirectory, "lblLogDirectory");
            this.lblLogDirectory.Name = "lblLogDirectory";
            // 
            // line10
            // 
            this.line10.LineAlignment = Quasar.Server.Controls.Line.Alignment.Horizontal;
            resources.ApplyResources(this.line10, "line10");
            this.line10.Name = "line10";
            this.line10.TabStop = false;
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // chkKeylogger
            // 
            resources.ApplyResources(this.chkKeylogger, "chkKeylogger");
            this.chkKeylogger.Name = "chkKeylogger";
            this.chkKeylogger.UseVisualStyleBackColor = true;
            this.chkKeylogger.CheckedChanged += new System.EventHandler(this.chkKeylogger_CheckedChanged);
            // 
            // FrmBuilder
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.builderTabs);
            this.Controls.Add(this.btnBuild);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBuilder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBuilder_FormClosing);
            this.Load += new System.EventHandler(this.FrmBuilder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUAC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUAC1)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.builderTabs.ResumeLayout(false);
            this.generalPage.ResumeLayout(false);
            this.generalPage.PerformLayout();
            this.connectionPage.ResumeLayout(false);
            this.connectionPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).EndInit();
            this.installationPage.ResumeLayout(false);
            this.installationPage.PerformLayout();
            this.assemblyPage.ResumeLayout(false);
            this.assemblyPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPreview)).EndInit();
            this.surveillanceTab.ResumeLayout(false);
            this.surveillanceTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.CheckBox chkInstall;
        private System.Windows.Forms.TextBox txtInstallName;
        private System.Windows.Forms.Label lblInstallName;
        private System.Windows.Forms.TextBox txtMutex;
        private System.Windows.Forms.Label lblMutex;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.Label lblInstallDirectory;
        private System.Windows.Forms.RadioButton rbAppdata;
        private System.Windows.Forms.TextBox txtInstallSubDirectory;
        private System.Windows.Forms.Label lblInstallSubDirectory;
        private System.Windows.Forms.Label lblPreviewPath;
        private System.Windows.Forms.TextBox txtPreviewPath;
        private System.Windows.Forms.Button btnMutex;
        private System.Windows.Forms.CheckBox chkHide;
        private System.Windows.Forms.TextBox txtRegistryKeyName;
        private System.Windows.Forms.Label lblRegistryKeyName;
        private System.Windows.Forms.CheckBox chkStartup;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Label lblMS;
        private System.Windows.Forms.RadioButton rbSystem;
        private System.Windows.Forms.RadioButton rbProgramFiles;
        private System.Windows.Forms.PictureBox picUAC1;
        private System.Windows.Forms.PictureBox picUAC2;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.CheckBox chkChangeIcon;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtOriginalFilename;
        private System.Windows.Forms.Label lblOriginalFilename;
        private System.Windows.Forms.TextBox txtTrademarks;
        private System.Windows.Forms.Label lblTrademarks;
        private System.Windows.Forms.TextBox txtCopyright;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtFileVersion;
        private System.Windows.Forms.Label lblFileVersion;
        private System.Windows.Forms.TextBox txtProductVersion;
        private System.Windows.Forms.Label lblProductVersion;
        private System.Windows.Forms.CheckBox chkChangeAsmInfo;
        private System.Windows.Forms.CheckBox chkKeylogger;
        private Controls.DotNetBarTabControl builderTabs;
        private System.Windows.Forms.TabPage connectionPage;
        private System.Windows.Forms.TabPage installationPage;
        private System.Windows.Forms.TabPage assemblyPage;
        private System.Windows.Forms.TabPage surveillanceTab;
        private System.Windows.Forms.ListBox lstHosts;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.Button btnAddHost;
        private System.Windows.Forms.ToolStripMenuItem removeHostToolStripMenuItem;
        private Controls.Line line1;
        private System.Windows.Forms.Label label1;
        private Controls.Line line3;
        private System.Windows.Forms.Label label4;
        private Controls.Line line4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage generalPage;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTag;
        private Controls.Line line5;
        private System.Windows.Forms.Label label6;
        private Controls.Line line6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Controls.Line line7;
        private System.Windows.Forms.Label label10;
        private Controls.Line line8;
        private System.Windows.Forms.Label label11;
        private Controls.Line line9;
        private System.Windows.Forms.Label label12;
        private Controls.Line line10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.Button btnBrowseIcon;
        private System.Windows.Forms.TextBox txtIconPath;
        private System.Windows.Forms.PictureBox iconPreview;
        private System.Windows.Forms.Label lblLogDirectory;
        private System.Windows.Forms.TextBox txtLogDirectoryName;
        private System.Windows.Forms.CheckBox chkHideLogDirectory;
        private System.Windows.Forms.NumericUpDown numericUpDownDelay;
        private System.Windows.Forms.NumericUpDown numericUpDownPort;
        private System.Windows.Forms.CheckBox chkHideSubDirectory;
    }
}
