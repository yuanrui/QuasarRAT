using Quasar.Server.Controls;

namespace Quasar.Server.Forms
{
    partial class FrmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startupManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteShellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reverseProxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registryEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteExecuteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxtLine = new System.Windows.Forms.ToolStripSeparator();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standbyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.surveillanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordRecoveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyloggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteDesktopToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.userSupportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMessageboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteDesktopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elevateClientPermissionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uninstallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgFlags = new System.Windows.Forms.ImageList(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.listenToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.builderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hTag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hUserPC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hUserStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hCountry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hOS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hAccountType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.surveillanceToolStripMenuItem,
            this.userSupportToolStripMenuItem,
            this.connectionToolStripMenuItem,
            this.lineToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.contextMenuStrip.Name = "ctxtMenu";
            resources.ApplyResources(this.contextMenuStrip, "contextMenuStrip");
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemInformationToolStripMenuItem,
            this.fileManagerToolStripMenuItem,
            this.startupManagerToolStripMenuItem,
            this.taskManagerToolStripMenuItem,
            this.remoteShellToolStripMenuItem,
            this.connectionsToolStripMenuItem,
            this.reverseProxyToolStripMenuItem,
            this.registryEditorToolStripMenuItem,
            this.remoteExecuteToolStripMenuItem,
            this.ctxtLine,
            this.actionsToolStripMenuItem});
            this.systemToolStripMenuItem.Image = global::Quasar.Server.Properties.Resources.cog;
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            resources.ApplyResources(this.systemToolStripMenuItem, "systemToolStripMenuItem");
            // 
            // systemInformationToolStripMenuItem
            // 
            resources.ApplyResources(this.systemInformationToolStripMenuItem, "systemInformationToolStripMenuItem");
            this.systemInformationToolStripMenuItem.Name = "systemInformationToolStripMenuItem";
            this.systemInformationToolStripMenuItem.Click += new System.EventHandler(this.systemInformationToolStripMenuItem_Click);
            // 
            // fileManagerToolStripMenuItem
            // 
            resources.ApplyResources(this.fileManagerToolStripMenuItem, "fileManagerToolStripMenuItem");
            this.fileManagerToolStripMenuItem.Name = "fileManagerToolStripMenuItem";
            this.fileManagerToolStripMenuItem.Click += new System.EventHandler(this.fileManagerToolStripMenuItem_Click);
            // 
            // startupManagerToolStripMenuItem
            // 
            this.startupManagerToolStripMenuItem.Image = global::Quasar.Server.Properties.Resources.application_edit;
            this.startupManagerToolStripMenuItem.Name = "startupManagerToolStripMenuItem";
            resources.ApplyResources(this.startupManagerToolStripMenuItem, "startupManagerToolStripMenuItem");
            this.startupManagerToolStripMenuItem.Click += new System.EventHandler(this.startupManagerToolStripMenuItem_Click);
            // 
            // taskManagerToolStripMenuItem
            // 
            this.taskManagerToolStripMenuItem.Image = global::Quasar.Server.Properties.Resources.application_cascade;
            this.taskManagerToolStripMenuItem.Name = "taskManagerToolStripMenuItem";
            resources.ApplyResources(this.taskManagerToolStripMenuItem, "taskManagerToolStripMenuItem");
            this.taskManagerToolStripMenuItem.Click += new System.EventHandler(this.taskManagerToolStripMenuItem_Click);
            // 
            // remoteShellToolStripMenuItem
            // 
            resources.ApplyResources(this.remoteShellToolStripMenuItem, "remoteShellToolStripMenuItem");
            this.remoteShellToolStripMenuItem.Name = "remoteShellToolStripMenuItem";
            this.remoteShellToolStripMenuItem.Click += new System.EventHandler(this.remoteShellToolStripMenuItem_Click);
            // 
            // connectionsToolStripMenuItem
            // 
            this.connectionsToolStripMenuItem.Image = global::Quasar.Server.Properties.Resources.transmit_blue;
            this.connectionsToolStripMenuItem.Name = "connectionsToolStripMenuItem";
            resources.ApplyResources(this.connectionsToolStripMenuItem, "connectionsToolStripMenuItem");
            this.connectionsToolStripMenuItem.Click += new System.EventHandler(this.connectionsToolStripMenuItem_Click);
            // 
            // reverseProxyToolStripMenuItem
            // 
            this.reverseProxyToolStripMenuItem.Image = global::Quasar.Server.Properties.Resources.server_link;
            this.reverseProxyToolStripMenuItem.Name = "reverseProxyToolStripMenuItem";
            resources.ApplyResources(this.reverseProxyToolStripMenuItem, "reverseProxyToolStripMenuItem");
            this.reverseProxyToolStripMenuItem.Click += new System.EventHandler(this.reverseProxyToolStripMenuItem_Click);
            // 
            // registryEditorToolStripMenuItem
            // 
            this.registryEditorToolStripMenuItem.Image = global::Quasar.Server.Properties.Resources.registry;
            this.registryEditorToolStripMenuItem.Name = "registryEditorToolStripMenuItem";
            resources.ApplyResources(this.registryEditorToolStripMenuItem, "registryEditorToolStripMenuItem");
            this.registryEditorToolStripMenuItem.Click += new System.EventHandler(this.registryEditorToolStripMenuItem_Click);
            // 
            // remoteExecuteToolStripMenuItem
            // 
            this.remoteExecuteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localFileToolStripMenuItem,
            this.webFileToolStripMenuItem});
            this.remoteExecuteToolStripMenuItem.Image = global::Quasar.Server.Properties.Resources.lightning;
            this.remoteExecuteToolStripMenuItem.Name = "remoteExecuteToolStripMenuItem";
            resources.ApplyResources(this.remoteExecuteToolStripMenuItem, "remoteExecuteToolStripMenuItem");
            // 
            // localFileToolStripMenuItem
            // 
            this.localFileToolStripMenuItem.Image = global::Quasar.Server.Properties.Resources.drive_go;
            this.localFileToolStripMenuItem.Name = "localFileToolStripMenuItem";
            resources.ApplyResources(this.localFileToolStripMenuItem, "localFileToolStripMenuItem");
            this.localFileToolStripMenuItem.Click += new System.EventHandler(this.localFileToolStripMenuItem_Click);
            // 
            // webFileToolStripMenuItem
            // 
            this.webFileToolStripMenuItem.Image = global::Quasar.Server.Properties.Resources.world_go;
            this.webFileToolStripMenuItem.Name = "webFileToolStripMenuItem";
            resources.ApplyResources(this.webFileToolStripMenuItem, "webFileToolStripMenuItem");
            this.webFileToolStripMenuItem.Click += new System.EventHandler(this.webFileToolStripMenuItem_Click);
            // 
            // ctxtLine
            // 
            this.ctxtLine.Name = "ctxtLine";
            resources.ApplyResources(this.ctxtLine, "ctxtLine");
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shutdownToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.standbyToolStripMenuItem});
            this.actionsToolStripMenuItem.Image = global::Quasar.Server.Properties.Resources.actions;
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            resources.ApplyResources(this.actionsToolStripMenuItem, "actionsToolStripMenuItem");
            // 
            // shutdownToolStripMenuItem
            // 
            this.shutdownToolStripMenuItem.Image = global::Quasar.Server.Properties.Resources.shutdown;
            this.shutdownToolStripMenuItem.Name = "shutdownToolStripMenuItem";
            resources.ApplyResources(this.shutdownToolStripMenuItem, "shutdownToolStripMenuItem");
            this.shutdownToolStripMenuItem.Click += new System.EventHandler(this.shutdownToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Image = global::Quasar.Server.Properties.Resources.restart;
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            resources.ApplyResources(this.restartToolStripMenuItem, "restartToolStripMenuItem");
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // standbyToolStripMenuItem
            // 
            this.standbyToolStripMenuItem.Image = global::Quasar.Server.Properties.Resources.standby;
            this.standbyToolStripMenuItem.Name = "standbyToolStripMenuItem";
            resources.ApplyResources(this.standbyToolStripMenuItem, "standbyToolStripMenuItem");
            this.standbyToolStripMenuItem.Click += new System.EventHandler(this.standbyToolStripMenuItem_Click);
            // 
            // surveillanceToolStripMenuItem
            // 
            this.surveillanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passwordRecoveryToolStripMenuItem,
            this.keyloggerToolStripMenuItem,
            this.remoteDesktopToolStripMenuItem2});
            this.surveillanceToolStripMenuItem.Image = global::Quasar.Server.Properties.Resources.monitoring;
            this.surveillanceToolStripMenuItem.Name = "surveillanceToolStripMenuItem";
            resources.ApplyResources(this.surveillanceToolStripMenuItem, "surveillanceToolStripMenuItem");
            // 
            // passwordRecoveryToolStripMenuItem
            // 
            resources.ApplyResources(this.passwordRecoveryToolStripMenuItem, "passwordRecoveryToolStripMenuItem");
            this.passwordRecoveryToolStripMenuItem.Name = "passwordRecoveryToolStripMenuItem";
            this.passwordRecoveryToolStripMenuItem.Click += new System.EventHandler(this.passwordRecoveryToolStripMenuItem_Click);
            // 
            // keyloggerToolStripMenuItem
            // 
            this.keyloggerToolStripMenuItem.Image = global::Quasar.Server.Properties.Resources.keyboard_magnify;
            this.keyloggerToolStripMenuItem.Name = "keyloggerToolStripMenuItem";
            resources.ApplyResources(this.keyloggerToolStripMenuItem, "keyloggerToolStripMenuItem");
            this.keyloggerToolStripMenuItem.Click += new System.EventHandler(this.keyloggerToolStripMenuItem_Click);
            // 
            // remoteDesktopToolStripMenuItem2
            // 
            resources.ApplyResources(this.remoteDesktopToolStripMenuItem2, "remoteDesktopToolStripMenuItem2");
            this.remoteDesktopToolStripMenuItem2.Name = "remoteDesktopToolStripMenuItem2";
            this.remoteDesktopToolStripMenuItem2.Click += new System.EventHandler(this.remoteDesktopToolStripMenuItem_Click);
            // 
            // userSupportToolStripMenuItem
            // 
            this.userSupportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMessageboxToolStripMenuItem,
            this.remoteDesktopToolStripMenuItem,
            this.visitWebsiteToolStripMenuItem});
            this.userSupportToolStripMenuItem.Image = global::Quasar.Server.Properties.Resources.user;
            this.userSupportToolStripMenuItem.Name = "userSupportToolStripMenuItem";
            resources.ApplyResources(this.userSupportToolStripMenuItem, "userSupportToolStripMenuItem");
            // 
            // showMessageboxToolStripMenuItem
            // 
            resources.ApplyResources(this.showMessageboxToolStripMenuItem, "showMessageboxToolStripMenuItem");
            this.showMessageboxToolStripMenuItem.Name = "showMessageboxToolStripMenuItem";
            this.showMessageboxToolStripMenuItem.Click += new System.EventHandler(this.showMessageboxToolStripMenuItem_Click);
            // 
            // remoteDesktopToolStripMenuItem
            // 
            resources.ApplyResources(this.remoteDesktopToolStripMenuItem, "remoteDesktopToolStripMenuItem");
            this.remoteDesktopToolStripMenuItem.Name = "remoteDesktopToolStripMenuItem";
            this.remoteDesktopToolStripMenuItem.Click += new System.EventHandler(this.remoteDesktopToolStripMenuItem_Click);
            // 
            // visitWebsiteToolStripMenuItem
            // 
            resources.ApplyResources(this.visitWebsiteToolStripMenuItem, "visitWebsiteToolStripMenuItem");
            this.visitWebsiteToolStripMenuItem.Name = "visitWebsiteToolStripMenuItem";
            this.visitWebsiteToolStripMenuItem.Click += new System.EventHandler(this.visitWebsiteToolStripMenuItem_Click);
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elevateClientPermissionsToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.reconnectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.uninstallToolStripMenuItem});
            resources.ApplyResources(this.connectionToolStripMenuItem, "connectionToolStripMenuItem");
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            // 
            // elevateClientPermissionsToolStripMenuItem
            // 
            this.elevateClientPermissionsToolStripMenuItem.Image = global::Quasar.Server.Properties.Resources.uac_shield;
            this.elevateClientPermissionsToolStripMenuItem.Name = "elevateClientPermissionsToolStripMenuItem";
            resources.ApplyResources(this.elevateClientPermissionsToolStripMenuItem, "elevateClientPermissionsToolStripMenuItem");
            this.elevateClientPermissionsToolStripMenuItem.Click += new System.EventHandler(this.elevateClientPermissionsToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            resources.ApplyResources(this.updateToolStripMenuItem, "updateToolStripMenuItem");
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // reconnectToolStripMenuItem
            // 
            resources.ApplyResources(this.reconnectToolStripMenuItem, "reconnectToolStripMenuItem");
            this.reconnectToolStripMenuItem.Name = "reconnectToolStripMenuItem";
            this.reconnectToolStripMenuItem.Click += new System.EventHandler(this.reconnectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            resources.ApplyResources(this.disconnectToolStripMenuItem, "disconnectToolStripMenuItem");
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // uninstallToolStripMenuItem
            // 
            resources.ApplyResources(this.uninstallToolStripMenuItem, "uninstallToolStripMenuItem");
            this.uninstallToolStripMenuItem.Name = "uninstallToolStripMenuItem";
            this.uninstallToolStripMenuItem.Click += new System.EventHandler(this.uninstallToolStripMenuItem_Click);
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            resources.ApplyResources(this.lineToolStripMenuItem, "lineToolStripMenuItem");
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            resources.ApplyResources(this.selectAllToolStripMenuItem, "selectAllToolStripMenuItem");
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // imgFlags
            // 
            this.imgFlags.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgFlags.ImageStream")));
            this.imgFlags.TransparentColor = System.Drawing.Color.Transparent;
            this.imgFlags.Images.SetKeyName(0, "ad.png");
            this.imgFlags.Images.SetKeyName(1, "ae.png");
            this.imgFlags.Images.SetKeyName(2, "af.png");
            this.imgFlags.Images.SetKeyName(3, "ag.png");
            this.imgFlags.Images.SetKeyName(4, "ai.png");
            this.imgFlags.Images.SetKeyName(5, "al.png");
            this.imgFlags.Images.SetKeyName(6, "am.png");
            this.imgFlags.Images.SetKeyName(7, "an.png");
            this.imgFlags.Images.SetKeyName(8, "ao.png");
            this.imgFlags.Images.SetKeyName(9, "ar.png");
            this.imgFlags.Images.SetKeyName(10, "as.png");
            this.imgFlags.Images.SetKeyName(11, "at.png");
            this.imgFlags.Images.SetKeyName(12, "au.png");
            this.imgFlags.Images.SetKeyName(13, "aw.png");
            this.imgFlags.Images.SetKeyName(14, "ax.png");
            this.imgFlags.Images.SetKeyName(15, "az.png");
            this.imgFlags.Images.SetKeyName(16, "ba.png");
            this.imgFlags.Images.SetKeyName(17, "bb.png");
            this.imgFlags.Images.SetKeyName(18, "bd.png");
            this.imgFlags.Images.SetKeyName(19, "be.png");
            this.imgFlags.Images.SetKeyName(20, "bf.png");
            this.imgFlags.Images.SetKeyName(21, "bg.png");
            this.imgFlags.Images.SetKeyName(22, "bh.png");
            this.imgFlags.Images.SetKeyName(23, "bi.png");
            this.imgFlags.Images.SetKeyName(24, "bj.png");
            this.imgFlags.Images.SetKeyName(25, "bm.png");
            this.imgFlags.Images.SetKeyName(26, "bn.png");
            this.imgFlags.Images.SetKeyName(27, "bo.png");
            this.imgFlags.Images.SetKeyName(28, "br.png");
            this.imgFlags.Images.SetKeyName(29, "bs.png");
            this.imgFlags.Images.SetKeyName(30, "bt.png");
            this.imgFlags.Images.SetKeyName(31, "bv.png");
            this.imgFlags.Images.SetKeyName(32, "bw.png");
            this.imgFlags.Images.SetKeyName(33, "by.png");
            this.imgFlags.Images.SetKeyName(34, "bz.png");
            this.imgFlags.Images.SetKeyName(35, "ca.png");
            this.imgFlags.Images.SetKeyName(36, "catalonia.png");
            this.imgFlags.Images.SetKeyName(37, "cc.png");
            this.imgFlags.Images.SetKeyName(38, "cd.png");
            this.imgFlags.Images.SetKeyName(39, "cf.png");
            this.imgFlags.Images.SetKeyName(40, "cg.png");
            this.imgFlags.Images.SetKeyName(41, "ch.png");
            this.imgFlags.Images.SetKeyName(42, "ci.png");
            this.imgFlags.Images.SetKeyName(43, "ck.png");
            this.imgFlags.Images.SetKeyName(44, "cl.png");
            this.imgFlags.Images.SetKeyName(45, "cm.png");
            this.imgFlags.Images.SetKeyName(46, "cn.png");
            this.imgFlags.Images.SetKeyName(47, "co.png");
            this.imgFlags.Images.SetKeyName(48, "cr.png");
            this.imgFlags.Images.SetKeyName(49, "cs.png");
            this.imgFlags.Images.SetKeyName(50, "cu.png");
            this.imgFlags.Images.SetKeyName(51, "cv.png");
            this.imgFlags.Images.SetKeyName(52, "cx.png");
            this.imgFlags.Images.SetKeyName(53, "cy.png");
            this.imgFlags.Images.SetKeyName(54, "cz.png");
            this.imgFlags.Images.SetKeyName(55, "de.png");
            this.imgFlags.Images.SetKeyName(56, "dj.png");
            this.imgFlags.Images.SetKeyName(57, "dk.png");
            this.imgFlags.Images.SetKeyName(58, "dm.png");
            this.imgFlags.Images.SetKeyName(59, "do.png");
            this.imgFlags.Images.SetKeyName(60, "dz.png");
            this.imgFlags.Images.SetKeyName(61, "ec.png");
            this.imgFlags.Images.SetKeyName(62, "ee.png");
            this.imgFlags.Images.SetKeyName(63, "eg.png");
            this.imgFlags.Images.SetKeyName(64, "eh.png");
            this.imgFlags.Images.SetKeyName(65, "england.png");
            this.imgFlags.Images.SetKeyName(66, "er.png");
            this.imgFlags.Images.SetKeyName(67, "es.png");
            this.imgFlags.Images.SetKeyName(68, "et.png");
            this.imgFlags.Images.SetKeyName(69, "europeanunion.png");
            this.imgFlags.Images.SetKeyName(70, "fam.png");
            this.imgFlags.Images.SetKeyName(71, "fi.png");
            this.imgFlags.Images.SetKeyName(72, "fj.png");
            this.imgFlags.Images.SetKeyName(73, "fk.png");
            this.imgFlags.Images.SetKeyName(74, "fm.png");
            this.imgFlags.Images.SetKeyName(75, "fo.png");
            this.imgFlags.Images.SetKeyName(76, "fr.png");
            this.imgFlags.Images.SetKeyName(77, "ga.png");
            this.imgFlags.Images.SetKeyName(78, "gb.png");
            this.imgFlags.Images.SetKeyName(79, "gd.png");
            this.imgFlags.Images.SetKeyName(80, "ge.png");
            this.imgFlags.Images.SetKeyName(81, "gf.png");
            this.imgFlags.Images.SetKeyName(82, "gh.png");
            this.imgFlags.Images.SetKeyName(83, "gi.png");
            this.imgFlags.Images.SetKeyName(84, "gl.png");
            this.imgFlags.Images.SetKeyName(85, "gm.png");
            this.imgFlags.Images.SetKeyName(86, "gn.png");
            this.imgFlags.Images.SetKeyName(87, "gp.png");
            this.imgFlags.Images.SetKeyName(88, "gq.png");
            this.imgFlags.Images.SetKeyName(89, "gr.png");
            this.imgFlags.Images.SetKeyName(90, "gs.png");
            this.imgFlags.Images.SetKeyName(91, "gt.png");
            this.imgFlags.Images.SetKeyName(92, "gu.png");
            this.imgFlags.Images.SetKeyName(93, "gw.png");
            this.imgFlags.Images.SetKeyName(94, "gy.png");
            this.imgFlags.Images.SetKeyName(95, "hk.png");
            this.imgFlags.Images.SetKeyName(96, "hm.png");
            this.imgFlags.Images.SetKeyName(97, "hn.png");
            this.imgFlags.Images.SetKeyName(98, "hr.png");
            this.imgFlags.Images.SetKeyName(99, "ht.png");
            this.imgFlags.Images.SetKeyName(100, "hu.png");
            this.imgFlags.Images.SetKeyName(101, "id.png");
            this.imgFlags.Images.SetKeyName(102, "ie.png");
            this.imgFlags.Images.SetKeyName(103, "il.png");
            this.imgFlags.Images.SetKeyName(104, "in.png");
            this.imgFlags.Images.SetKeyName(105, "io.png");
            this.imgFlags.Images.SetKeyName(106, "iq.png");
            this.imgFlags.Images.SetKeyName(107, "ir.png");
            this.imgFlags.Images.SetKeyName(108, "is.png");
            this.imgFlags.Images.SetKeyName(109, "it.png");
            this.imgFlags.Images.SetKeyName(110, "jm.png");
            this.imgFlags.Images.SetKeyName(111, "jo.png");
            this.imgFlags.Images.SetKeyName(112, "jp.png");
            this.imgFlags.Images.SetKeyName(113, "ke.png");
            this.imgFlags.Images.SetKeyName(114, "kg.png");
            this.imgFlags.Images.SetKeyName(115, "kh.png");
            this.imgFlags.Images.SetKeyName(116, "ki.png");
            this.imgFlags.Images.SetKeyName(117, "km.png");
            this.imgFlags.Images.SetKeyName(118, "kn.png");
            this.imgFlags.Images.SetKeyName(119, "kp.png");
            this.imgFlags.Images.SetKeyName(120, "kr.png");
            this.imgFlags.Images.SetKeyName(121, "kw.png");
            this.imgFlags.Images.SetKeyName(122, "ky.png");
            this.imgFlags.Images.SetKeyName(123, "kz.png");
            this.imgFlags.Images.SetKeyName(124, "la.png");
            this.imgFlags.Images.SetKeyName(125, "lb.png");
            this.imgFlags.Images.SetKeyName(126, "lc.png");
            this.imgFlags.Images.SetKeyName(127, "li.png");
            this.imgFlags.Images.SetKeyName(128, "lk.png");
            this.imgFlags.Images.SetKeyName(129, "lr.png");
            this.imgFlags.Images.SetKeyName(130, "ls.png");
            this.imgFlags.Images.SetKeyName(131, "lt.png");
            this.imgFlags.Images.SetKeyName(132, "lu.png");
            this.imgFlags.Images.SetKeyName(133, "lv.png");
            this.imgFlags.Images.SetKeyName(134, "ly.png");
            this.imgFlags.Images.SetKeyName(135, "ma.png");
            this.imgFlags.Images.SetKeyName(136, "mc.png");
            this.imgFlags.Images.SetKeyName(137, "md.png");
            this.imgFlags.Images.SetKeyName(138, "me.png");
            this.imgFlags.Images.SetKeyName(139, "mg.png");
            this.imgFlags.Images.SetKeyName(140, "mh.png");
            this.imgFlags.Images.SetKeyName(141, "mk.png");
            this.imgFlags.Images.SetKeyName(142, "ml.png");
            this.imgFlags.Images.SetKeyName(143, "mm.png");
            this.imgFlags.Images.SetKeyName(144, "mn.png");
            this.imgFlags.Images.SetKeyName(145, "mo.png");
            this.imgFlags.Images.SetKeyName(146, "mp.png");
            this.imgFlags.Images.SetKeyName(147, "mq.png");
            this.imgFlags.Images.SetKeyName(148, "mr.png");
            this.imgFlags.Images.SetKeyName(149, "ms.png");
            this.imgFlags.Images.SetKeyName(150, "mt.png");
            this.imgFlags.Images.SetKeyName(151, "mu.png");
            this.imgFlags.Images.SetKeyName(152, "mv.png");
            this.imgFlags.Images.SetKeyName(153, "mw.png");
            this.imgFlags.Images.SetKeyName(154, "mx.png");
            this.imgFlags.Images.SetKeyName(155, "my.png");
            this.imgFlags.Images.SetKeyName(156, "mz.png");
            this.imgFlags.Images.SetKeyName(157, "na.png");
            this.imgFlags.Images.SetKeyName(158, "nc.png");
            this.imgFlags.Images.SetKeyName(159, "ne.png");
            this.imgFlags.Images.SetKeyName(160, "nf.png");
            this.imgFlags.Images.SetKeyName(161, "ng.png");
            this.imgFlags.Images.SetKeyName(162, "ni.png");
            this.imgFlags.Images.SetKeyName(163, "nl.png");
            this.imgFlags.Images.SetKeyName(164, "no.png");
            this.imgFlags.Images.SetKeyName(165, "np.png");
            this.imgFlags.Images.SetKeyName(166, "nr.png");
            this.imgFlags.Images.SetKeyName(167, "nu.png");
            this.imgFlags.Images.SetKeyName(168, "nz.png");
            this.imgFlags.Images.SetKeyName(169, "om.png");
            this.imgFlags.Images.SetKeyName(170, "pa.png");
            this.imgFlags.Images.SetKeyName(171, "pe.png");
            this.imgFlags.Images.SetKeyName(172, "pf.png");
            this.imgFlags.Images.SetKeyName(173, "pg.png");
            this.imgFlags.Images.SetKeyName(174, "ph.png");
            this.imgFlags.Images.SetKeyName(175, "pk.png");
            this.imgFlags.Images.SetKeyName(176, "pl.png");
            this.imgFlags.Images.SetKeyName(177, "pm.png");
            this.imgFlags.Images.SetKeyName(178, "pn.png");
            this.imgFlags.Images.SetKeyName(179, "pr.png");
            this.imgFlags.Images.SetKeyName(180, "ps.png");
            this.imgFlags.Images.SetKeyName(181, "pt.png");
            this.imgFlags.Images.SetKeyName(182, "pw.png");
            this.imgFlags.Images.SetKeyName(183, "py.png");
            this.imgFlags.Images.SetKeyName(184, "qa.png");
            this.imgFlags.Images.SetKeyName(185, "re.png");
            this.imgFlags.Images.SetKeyName(186, "ro.png");
            this.imgFlags.Images.SetKeyName(187, "rs.png");
            this.imgFlags.Images.SetKeyName(188, "ru.png");
            this.imgFlags.Images.SetKeyName(189, "rw.png");
            this.imgFlags.Images.SetKeyName(190, "sa.png");
            this.imgFlags.Images.SetKeyName(191, "sb.png");
            this.imgFlags.Images.SetKeyName(192, "sc.png");
            this.imgFlags.Images.SetKeyName(193, "scotland.png");
            this.imgFlags.Images.SetKeyName(194, "sd.png");
            this.imgFlags.Images.SetKeyName(195, "se.png");
            this.imgFlags.Images.SetKeyName(196, "sg.png");
            this.imgFlags.Images.SetKeyName(197, "sh.png");
            this.imgFlags.Images.SetKeyName(198, "si.png");
            this.imgFlags.Images.SetKeyName(199, "sj.png");
            this.imgFlags.Images.SetKeyName(200, "sk.png");
            this.imgFlags.Images.SetKeyName(201, "sl.png");
            this.imgFlags.Images.SetKeyName(202, "sm.png");
            this.imgFlags.Images.SetKeyName(203, "sn.png");
            this.imgFlags.Images.SetKeyName(204, "so.png");
            this.imgFlags.Images.SetKeyName(205, "sr.png");
            this.imgFlags.Images.SetKeyName(206, "st.png");
            this.imgFlags.Images.SetKeyName(207, "sv.png");
            this.imgFlags.Images.SetKeyName(208, "sy.png");
            this.imgFlags.Images.SetKeyName(209, "sz.png");
            this.imgFlags.Images.SetKeyName(210, "tc.png");
            this.imgFlags.Images.SetKeyName(211, "td.png");
            this.imgFlags.Images.SetKeyName(212, "tf.png");
            this.imgFlags.Images.SetKeyName(213, "tg.png");
            this.imgFlags.Images.SetKeyName(214, "th.png");
            this.imgFlags.Images.SetKeyName(215, "tj.png");
            this.imgFlags.Images.SetKeyName(216, "tk.png");
            this.imgFlags.Images.SetKeyName(217, "tl.png");
            this.imgFlags.Images.SetKeyName(218, "tm.png");
            this.imgFlags.Images.SetKeyName(219, "tn.png");
            this.imgFlags.Images.SetKeyName(220, "to.png");
            this.imgFlags.Images.SetKeyName(221, "tr.png");
            this.imgFlags.Images.SetKeyName(222, "tt.png");
            this.imgFlags.Images.SetKeyName(223, "tv.png");
            this.imgFlags.Images.SetKeyName(224, "tw.png");
            this.imgFlags.Images.SetKeyName(225, "tz.png");
            this.imgFlags.Images.SetKeyName(226, "ua.png");
            this.imgFlags.Images.SetKeyName(227, "ug.png");
            this.imgFlags.Images.SetKeyName(228, "um.png");
            this.imgFlags.Images.SetKeyName(229, "us.png");
            this.imgFlags.Images.SetKeyName(230, "uy.png");
            this.imgFlags.Images.SetKeyName(231, "uz.png");
            this.imgFlags.Images.SetKeyName(232, "va.png");
            this.imgFlags.Images.SetKeyName(233, "vc.png");
            this.imgFlags.Images.SetKeyName(234, "ve.png");
            this.imgFlags.Images.SetKeyName(235, "vg.png");
            this.imgFlags.Images.SetKeyName(236, "vi.png");
            this.imgFlags.Images.SetKeyName(237, "vn.png");
            this.imgFlags.Images.SetKeyName(238, "vu.png");
            this.imgFlags.Images.SetKeyName(239, "wales.png");
            this.imgFlags.Images.SetKeyName(240, "wf.png");
            this.imgFlags.Images.SetKeyName(241, "ws.png");
            this.imgFlags.Images.SetKeyName(242, "ye.png");
            this.imgFlags.Images.SetKeyName(243, "yt.png");
            this.imgFlags.Images.SetKeyName(244, "za.png");
            this.imgFlags.Images.SetKeyName(245, "zm.png");
            this.imgFlags.Images.SetKeyName(246, "zw.png");
            this.imgFlags.Images.SetKeyName(247, "xy.png");
            // 
            // notifyIcon
            // 
            resources.ApplyResources(this.notifyIcon, "notifyIcon");
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // tableLayoutPanel
            // 
            resources.ApplyResources(this.tableLayoutPanel, "tableLayoutPanel");
            this.tableLayoutPanel.Controls.Add(this.statusStrip, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.menuStrip, 0, 0);
            this.tableLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            // 
            // statusStrip
            // 
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listenToolStripStatusLabel});
            this.statusStrip.Name = "statusStrip";
            // 
            // listenToolStripStatusLabel
            // 
            this.listenToolStripStatusLabel.Name = "listenToolStripStatusLabel";
            resources.ApplyResources(this.listenToolStripStatusLabel, "listenToolStripStatusLabel");
            // 
            // menuStrip
            // 
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.builderToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Name = "menuStrip";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            resources.ApplyResources(this.fIleToolStripMenuItem, "fIleToolStripMenuItem");
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            resources.ApplyResources(this.closeToolStripMenuItem, "closeToolStripMenuItem");
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // builderToolStripMenuItem
            // 
            this.builderToolStripMenuItem.Name = "builderToolStripMenuItem";
            resources.ApplyResources(this.builderToolStripMenuItem, "builderToolStripMenuItem");
            this.builderToolStripMenuItem.Click += new System.EventHandler(this.builderToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // hIP
            // 
            resources.ApplyResources(this.hIP, "hIP");
            // 
            // hTag
            // 
            resources.ApplyResources(this.hTag, "hTag");
            // 
            // hUserPC
            // 
            resources.ApplyResources(this.hUserPC, "hUserPC");
            // 
            // hVersion
            // 
            resources.ApplyResources(this.hVersion, "hVersion");
            // 
            // hStatus
            // 
            resources.ApplyResources(this.hStatus, "hStatus");
            // 
            // hUserStatus
            // 
            resources.ApplyResources(this.hUserStatus, "hUserStatus");
            // 
            // hCountry
            // 
            resources.ApplyResources(this.hCountry, "hCountry");
            // 
            // hOS
            // 
            resources.ApplyResources(this.hOS, "hOS");
            // 
            // hAccountType
            // 
            resources.ApplyResources(this.hAccountType, "hAccountType");
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.tableLayoutPanel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader hIP;
        private System.Windows.Forms.ColumnHeader hVersion;
        private System.Windows.Forms.ColumnHeader hCountry;
        private System.Windows.Forms.ColumnHeader hOS;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader hTag;
        private System.Windows.Forms.ImageList imgFlags;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader hStatus;
        private System.Windows.Forms.ToolStripMenuItem uninstallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem surveillanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remoteDesktopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileManagerToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader hAccountType;
        private System.Windows.Forms.ToolStripMenuItem systemInformationToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader hUserStatus;
        private System.Windows.Forms.ToolStripMenuItem passwordRecoveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remoteShellToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ctxtLine;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shutdownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standbyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startupManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keyloggerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reverseProxyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registryEditorToolStripMenuItem;
        private AeroListView lstClients;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ColumnHeader hUserPC;
        private System.Windows.Forms.ToolStripSeparator lineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem builderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel listenToolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem connectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userSupportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMessageboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitWebsiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remoteExecuteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elevateClientPermissionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remoteDesktopToolStripMenuItem2;
    }
}

