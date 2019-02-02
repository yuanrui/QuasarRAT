using Quasar.Server.Controls;

namespace Quasar.Server.Forms
{
    partial class FrmRegistryEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistryEditor));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tvRegistryDirectory = new Quasar.Server.Controls.RegistryTreeView();
            this.imageRegistryDirectoryList = new System.Windows.Forms.ImageList(this.components);
            this.lstRegistryValues = new Quasar.Server.Controls.AeroListView();
            this.hName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageRegistryKeyTypeList = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.selectedStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyBinaryDataToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyNewtoolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.newToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.keyToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.stringValueToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryValueToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dWORD32bitValueToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.qWORD64bitValueToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.multiStringValueToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.expandableStringValueToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tv_ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.stringValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dWORD32bitValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qWORD64bitValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiStringValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandableStringValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedItem_ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyBinaryDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lst_ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.keyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.stringValueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryValueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dWORD32bitValueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.qWORD64bitValueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.multiStringValueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.expandableStringValueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.tv_ContextMenuStrip.SuspendLayout();
            this.selectedItem_ContextMenuStrip.SuspendLayout();
            this.lst_ContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            resources.ApplyResources(this.tableLayoutPanel, "tableLayoutPanel");
            this.tableLayoutPanel.Controls.Add(this.splitContainer, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.statusStrip, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.menuStrip, 0, 0);
            this.tableLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            // 
            // splitContainer
            // 
            resources.ApplyResources(this.splitContainer, "splitContainer");
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.tvRegistryDirectory);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.lstRegistryValues);
            // 
            // tvRegistryDirectory
            // 
            resources.ApplyResources(this.tvRegistryDirectory, "tvRegistryDirectory");
            this.tvRegistryDirectory.HideSelection = false;
            this.tvRegistryDirectory.ImageList = this.imageRegistryDirectoryList;
            this.tvRegistryDirectory.Name = "tvRegistryDirectory";
            this.tvRegistryDirectory.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.tvRegistryDirectory_AfterLabelEdit);
            this.tvRegistryDirectory.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvRegistryDirectory_BeforeExpand);
            this.tvRegistryDirectory.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvRegistryDirectory_BeforeSelect);
            this.tvRegistryDirectory.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvRegistryDirectory_NodeMouseClick);
            this.tvRegistryDirectory.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tvRegistryDirectory_KeyUp);
            // 
            // imageRegistryDirectoryList
            // 
            this.imageRegistryDirectoryList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageRegistryDirectoryList.ImageStream")));
            this.imageRegistryDirectoryList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageRegistryDirectoryList.Images.SetKeyName(0, "folder.png");
            // 
            // lstRegistryValues
            // 
            this.lstRegistryValues.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hName,
            this.hType,
            this.hValue});
            resources.ApplyResources(this.lstRegistryValues, "lstRegistryValues");
            this.lstRegistryValues.FullRowSelect = true;
            this.lstRegistryValues.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstRegistryValues.HideSelection = false;
            this.lstRegistryValues.Name = "lstRegistryValues";
            this.lstRegistryValues.SmallImageList = this.imageRegistryKeyTypeList;
            this.lstRegistryValues.UseCompatibleStateImageBehavior = false;
            this.lstRegistryValues.View = System.Windows.Forms.View.Details;
            this.lstRegistryValues.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lstRegistryKeys_AfterLabelEdit);
            this.lstRegistryValues.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstRegistryKeys_KeyUp);
            this.lstRegistryValues.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstRegistryKeys_MouseClick);
            // 
            // hName
            // 
            resources.ApplyResources(this.hName, "hName");
            // 
            // hType
            // 
            resources.ApplyResources(this.hType, "hType");
            // 
            // hValue
            // 
            resources.ApplyResources(this.hValue, "hValue");
            // 
            // imageRegistryKeyTypeList
            // 
            this.imageRegistryKeyTypeList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageRegistryKeyTypeList.ImageStream")));
            this.imageRegistryKeyTypeList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageRegistryKeyTypeList.Images.SetKeyName(0, "reg_string.png");
            this.imageRegistryKeyTypeList.Images.SetKeyName(1, "reg_binary.png");
            // 
            // statusStrip
            // 
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectedStripStatusLabel});
            this.statusStrip.Name = "statusStrip";
            // 
            // selectedStripStatusLabel
            // 
            this.selectedStripStatusLabel.Name = "selectedStripStatusLabel";
            resources.ApplyResources(this.selectedStripStatusLabel, "selectedStripStatusLabel");
            // 
            // menuStrip
            // 
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip.Name = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.menuStripExit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyToolStripMenuItem1,
            this.modifyBinaryDataToolStripMenuItem1,
            this.modifyNewtoolStripSeparator,
            this.newToolStripMenuItem2,
            this.toolStripSeparator6,
            this.deleteToolStripMenuItem2,
            this.renameToolStripMenuItem2});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            this.editToolStripMenuItem.DropDownOpening += new System.EventHandler(this.editToolStripMenuItem_DropDownOpening);
            // 
            // modifyToolStripMenuItem1
            // 
            resources.ApplyResources(this.modifyToolStripMenuItem1, "modifyToolStripMenuItem1");
            this.modifyToolStripMenuItem1.Name = "modifyToolStripMenuItem1";
            this.modifyToolStripMenuItem1.Click += new System.EventHandler(this.modifyRegistryValue_Click);
            // 
            // modifyBinaryDataToolStripMenuItem1
            // 
            resources.ApplyResources(this.modifyBinaryDataToolStripMenuItem1, "modifyBinaryDataToolStripMenuItem1");
            this.modifyBinaryDataToolStripMenuItem1.Name = "modifyBinaryDataToolStripMenuItem1";
            this.modifyBinaryDataToolStripMenuItem1.Click += new System.EventHandler(this.modifyBinaryDataRegistryValue_Click);
            // 
            // modifyNewtoolStripSeparator
            // 
            this.modifyNewtoolStripSeparator.Name = "modifyNewtoolStripSeparator";
            resources.ApplyResources(this.modifyNewtoolStripSeparator, "modifyNewtoolStripSeparator");
            // 
            // newToolStripMenuItem2
            // 
            this.newToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keyToolStripMenuItem2,
            this.toolStripSeparator7,
            this.stringValueToolStripMenuItem2,
            this.binaryValueToolStripMenuItem2,
            this.dWORD32bitValueToolStripMenuItem2,
            this.qWORD64bitValueToolStripMenuItem2,
            this.multiStringValueToolStripMenuItem2,
            this.expandableStringValueToolStripMenuItem2});
            this.newToolStripMenuItem2.Name = "newToolStripMenuItem2";
            resources.ApplyResources(this.newToolStripMenuItem2, "newToolStripMenuItem2");
            // 
            // keyToolStripMenuItem2
            // 
            this.keyToolStripMenuItem2.Name = "keyToolStripMenuItem2";
            resources.ApplyResources(this.keyToolStripMenuItem2, "keyToolStripMenuItem2");
            this.keyToolStripMenuItem2.Click += new System.EventHandler(this.createNewRegistryKey_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            // 
            // stringValueToolStripMenuItem2
            // 
            this.stringValueToolStripMenuItem2.Name = "stringValueToolStripMenuItem2";
            resources.ApplyResources(this.stringValueToolStripMenuItem2, "stringValueToolStripMenuItem2");
            this.stringValueToolStripMenuItem2.Click += new System.EventHandler(this.createStringRegistryValue_Click);
            // 
            // binaryValueToolStripMenuItem2
            // 
            this.binaryValueToolStripMenuItem2.Name = "binaryValueToolStripMenuItem2";
            resources.ApplyResources(this.binaryValueToolStripMenuItem2, "binaryValueToolStripMenuItem2");
            this.binaryValueToolStripMenuItem2.Click += new System.EventHandler(this.createBinaryRegistryValue_Click);
            // 
            // dWORD32bitValueToolStripMenuItem2
            // 
            this.dWORD32bitValueToolStripMenuItem2.Name = "dWORD32bitValueToolStripMenuItem2";
            resources.ApplyResources(this.dWORD32bitValueToolStripMenuItem2, "dWORD32bitValueToolStripMenuItem2");
            this.dWORD32bitValueToolStripMenuItem2.Click += new System.EventHandler(this.createDwordRegistryValue_Click);
            // 
            // qWORD64bitValueToolStripMenuItem2
            // 
            this.qWORD64bitValueToolStripMenuItem2.Name = "qWORD64bitValueToolStripMenuItem2";
            resources.ApplyResources(this.qWORD64bitValueToolStripMenuItem2, "qWORD64bitValueToolStripMenuItem2");
            this.qWORD64bitValueToolStripMenuItem2.Click += new System.EventHandler(this.createQwordRegistryValue_Click);
            // 
            // multiStringValueToolStripMenuItem2
            // 
            this.multiStringValueToolStripMenuItem2.Name = "multiStringValueToolStripMenuItem2";
            resources.ApplyResources(this.multiStringValueToolStripMenuItem2, "multiStringValueToolStripMenuItem2");
            this.multiStringValueToolStripMenuItem2.Click += new System.EventHandler(this.createMultiStringRegistryValue_Click);
            // 
            // expandableStringValueToolStripMenuItem2
            // 
            this.expandableStringValueToolStripMenuItem2.Name = "expandableStringValueToolStripMenuItem2";
            resources.ApplyResources(this.expandableStringValueToolStripMenuItem2, "expandableStringValueToolStripMenuItem2");
            this.expandableStringValueToolStripMenuItem2.Click += new System.EventHandler(this.createExpandStringRegistryValue_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // deleteToolStripMenuItem2
            // 
            resources.ApplyResources(this.deleteToolStripMenuItem2, "deleteToolStripMenuItem2");
            this.deleteToolStripMenuItem2.Name = "deleteToolStripMenuItem2";
            this.deleteToolStripMenuItem2.Click += new System.EventHandler(this.menuStripDelete_Click);
            // 
            // renameToolStripMenuItem2
            // 
            resources.ApplyResources(this.renameToolStripMenuItem2, "renameToolStripMenuItem2");
            this.renameToolStripMenuItem2.Name = "renameToolStripMenuItem2";
            this.renameToolStripMenuItem2.Click += new System.EventHandler(this.menuStripRename_Click);
            // 
            // tv_ContextMenuStrip
            // 
            this.tv_ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteToolStripMenuItem,
            this.renameToolStripMenuItem});
            this.tv_ContextMenuStrip.Name = "contextMenuStrip";
            resources.ApplyResources(this.tv_ContextMenuStrip, "tv_ContextMenuStrip");
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keyToolStripMenuItem,
            this.toolStripSeparator2,
            this.stringValueToolStripMenuItem,
            this.binaryValueToolStripMenuItem,
            this.dWORD32bitValueToolStripMenuItem,
            this.qWORD64bitValueToolStripMenuItem,
            this.multiStringValueToolStripMenuItem,
            this.expandableStringValueToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            resources.ApplyResources(this.newToolStripMenuItem, "newToolStripMenuItem");
            // 
            // keyToolStripMenuItem
            // 
            this.keyToolStripMenuItem.Name = "keyToolStripMenuItem";
            resources.ApplyResources(this.keyToolStripMenuItem, "keyToolStripMenuItem");
            this.keyToolStripMenuItem.Click += new System.EventHandler(this.createNewRegistryKey_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // stringValueToolStripMenuItem
            // 
            this.stringValueToolStripMenuItem.Name = "stringValueToolStripMenuItem";
            resources.ApplyResources(this.stringValueToolStripMenuItem, "stringValueToolStripMenuItem");
            this.stringValueToolStripMenuItem.Click += new System.EventHandler(this.createStringRegistryValue_Click);
            // 
            // binaryValueToolStripMenuItem
            // 
            this.binaryValueToolStripMenuItem.Name = "binaryValueToolStripMenuItem";
            resources.ApplyResources(this.binaryValueToolStripMenuItem, "binaryValueToolStripMenuItem");
            this.binaryValueToolStripMenuItem.Click += new System.EventHandler(this.createBinaryRegistryValue_Click);
            // 
            // dWORD32bitValueToolStripMenuItem
            // 
            this.dWORD32bitValueToolStripMenuItem.Name = "dWORD32bitValueToolStripMenuItem";
            resources.ApplyResources(this.dWORD32bitValueToolStripMenuItem, "dWORD32bitValueToolStripMenuItem");
            this.dWORD32bitValueToolStripMenuItem.Click += new System.EventHandler(this.createDwordRegistryValue_Click);
            // 
            // qWORD64bitValueToolStripMenuItem
            // 
            this.qWORD64bitValueToolStripMenuItem.Name = "qWORD64bitValueToolStripMenuItem";
            resources.ApplyResources(this.qWORD64bitValueToolStripMenuItem, "qWORD64bitValueToolStripMenuItem");
            this.qWORD64bitValueToolStripMenuItem.Click += new System.EventHandler(this.createQwordRegistryValue_Click);
            // 
            // multiStringValueToolStripMenuItem
            // 
            this.multiStringValueToolStripMenuItem.Name = "multiStringValueToolStripMenuItem";
            resources.ApplyResources(this.multiStringValueToolStripMenuItem, "multiStringValueToolStripMenuItem");
            this.multiStringValueToolStripMenuItem.Click += new System.EventHandler(this.createMultiStringRegistryValue_Click);
            // 
            // expandableStringValueToolStripMenuItem
            // 
            this.expandableStringValueToolStripMenuItem.Name = "expandableStringValueToolStripMenuItem";
            resources.ApplyResources(this.expandableStringValueToolStripMenuItem, "expandableStringValueToolStripMenuItem");
            this.expandableStringValueToolStripMenuItem.Click += new System.EventHandler(this.createExpandStringRegistryValue_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // deleteToolStripMenuItem
            // 
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteRegistryKey_Click);
            // 
            // renameToolStripMenuItem
            // 
            resources.ApplyResources(this.renameToolStripMenuItem, "renameToolStripMenuItem");
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameRegistryKey_Click);
            // 
            // selectedItem_ContextMenuStrip
            // 
            this.selectedItem_ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyToolStripMenuItem,
            this.modifyBinaryDataToolStripMenuItem,
            this.modifyToolStripSeparator1,
            this.deleteToolStripMenuItem1,
            this.renameToolStripMenuItem1});
            this.selectedItem_ContextMenuStrip.Name = "selectedItem_ContextMenuStrip";
            resources.ApplyResources(this.selectedItem_ContextMenuStrip, "selectedItem_ContextMenuStrip");
            // 
            // modifyToolStripMenuItem
            // 
            resources.ApplyResources(this.modifyToolStripMenuItem, "modifyToolStripMenuItem");
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Click += new System.EventHandler(this.modifyRegistryValue_Click);
            // 
            // modifyBinaryDataToolStripMenuItem
            // 
            resources.ApplyResources(this.modifyBinaryDataToolStripMenuItem, "modifyBinaryDataToolStripMenuItem");
            this.modifyBinaryDataToolStripMenuItem.Name = "modifyBinaryDataToolStripMenuItem";
            this.modifyBinaryDataToolStripMenuItem.Click += new System.EventHandler(this.modifyBinaryDataRegistryValue_Click);
            // 
            // modifyToolStripSeparator1
            // 
            this.modifyToolStripSeparator1.Name = "modifyToolStripSeparator1";
            resources.ApplyResources(this.modifyToolStripSeparator1, "modifyToolStripSeparator1");
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            resources.ApplyResources(this.deleteToolStripMenuItem1, "deleteToolStripMenuItem1");
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteRegistryValue_Click);
            // 
            // renameToolStripMenuItem1
            // 
            this.renameToolStripMenuItem1.Name = "renameToolStripMenuItem1";
            resources.ApplyResources(this.renameToolStripMenuItem1, "renameToolStripMenuItem1");
            this.renameToolStripMenuItem1.Click += new System.EventHandler(this.renameRegistryValue_Click);
            // 
            // lst_ContextMenuStrip
            // 
            this.lst_ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1});
            this.lst_ContextMenuStrip.Name = "lst_ContextMenuStrip";
            resources.ApplyResources(this.lst_ContextMenuStrip, "lst_ContextMenuStrip");
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keyToolStripMenuItem1,
            this.toolStripSeparator4,
            this.stringValueToolStripMenuItem1,
            this.binaryValueToolStripMenuItem1,
            this.dWORD32bitValueToolStripMenuItem1,
            this.qWORD64bitValueToolStripMenuItem1,
            this.multiStringValueToolStripMenuItem1,
            this.expandableStringValueToolStripMenuItem1});
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            resources.ApplyResources(this.newToolStripMenuItem1, "newToolStripMenuItem1");
            // 
            // keyToolStripMenuItem1
            // 
            this.keyToolStripMenuItem1.Name = "keyToolStripMenuItem1";
            resources.ApplyResources(this.keyToolStripMenuItem1, "keyToolStripMenuItem1");
            this.keyToolStripMenuItem1.Click += new System.EventHandler(this.createNewRegistryKey_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // stringValueToolStripMenuItem1
            // 
            this.stringValueToolStripMenuItem1.Name = "stringValueToolStripMenuItem1";
            resources.ApplyResources(this.stringValueToolStripMenuItem1, "stringValueToolStripMenuItem1");
            this.stringValueToolStripMenuItem1.Click += new System.EventHandler(this.createStringRegistryValue_Click);
            // 
            // binaryValueToolStripMenuItem1
            // 
            this.binaryValueToolStripMenuItem1.Name = "binaryValueToolStripMenuItem1";
            resources.ApplyResources(this.binaryValueToolStripMenuItem1, "binaryValueToolStripMenuItem1");
            this.binaryValueToolStripMenuItem1.Click += new System.EventHandler(this.createBinaryRegistryValue_Click);
            // 
            // dWORD32bitValueToolStripMenuItem1
            // 
            this.dWORD32bitValueToolStripMenuItem1.Name = "dWORD32bitValueToolStripMenuItem1";
            resources.ApplyResources(this.dWORD32bitValueToolStripMenuItem1, "dWORD32bitValueToolStripMenuItem1");
            this.dWORD32bitValueToolStripMenuItem1.Click += new System.EventHandler(this.createDwordRegistryValue_Click);
            // 
            // qWORD64bitValueToolStripMenuItem1
            // 
            this.qWORD64bitValueToolStripMenuItem1.Name = "qWORD64bitValueToolStripMenuItem1";
            resources.ApplyResources(this.qWORD64bitValueToolStripMenuItem1, "qWORD64bitValueToolStripMenuItem1");
            this.qWORD64bitValueToolStripMenuItem1.Click += new System.EventHandler(this.createQwordRegistryValue_Click);
            // 
            // multiStringValueToolStripMenuItem1
            // 
            this.multiStringValueToolStripMenuItem1.Name = "multiStringValueToolStripMenuItem1";
            resources.ApplyResources(this.multiStringValueToolStripMenuItem1, "multiStringValueToolStripMenuItem1");
            this.multiStringValueToolStripMenuItem1.Click += new System.EventHandler(this.createMultiStringRegistryValue_Click);
            // 
            // expandableStringValueToolStripMenuItem1
            // 
            this.expandableStringValueToolStripMenuItem1.Name = "expandableStringValueToolStripMenuItem1";
            resources.ApplyResources(this.expandableStringValueToolStripMenuItem1, "expandableStringValueToolStripMenuItem1");
            this.expandableStringValueToolStripMenuItem1.Click += new System.EventHandler(this.createExpandStringRegistryValue_Click);
            // 
            // FrmRegistryEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.tableLayoutPanel);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmRegistryEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRegistryEditor_FormClosing);
            this.Load += new System.EventHandler(this.FrmRegistryEditor_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tv_ContextMenuStrip.ResumeLayout(false);
            this.selectedItem_ContextMenuStrip.ResumeLayout(false);
            this.lst_ContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.SplitContainer splitContainer;
        private Controls.RegistryTreeView tvRegistryDirectory;
        private Controls.AeroListView lstRegistryValues;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel selectedStripStatusLabel;
        private System.Windows.Forms.ImageList imageRegistryDirectoryList;
        private System.Windows.Forms.ColumnHeader hName;
        private System.Windows.Forms.ColumnHeader hType;
        private System.Windows.Forms.ColumnHeader hValue;
        private System.Windows.Forms.ImageList imageRegistryKeyTypeList;
        private System.Windows.Forms.ContextMenuStrip tv_ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem stringValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dWORD32bitValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qWORD64bitValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiStringValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandableStringValueToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip selectedItem_ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyBinaryDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip lst_ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem keyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stringValueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem binaryValueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dWORD32bitValueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem qWORD64bitValueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem multiStringValueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem expandableStringValueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifyBinaryDataToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator modifyNewtoolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem keyToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem stringValueToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem binaryValueToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem dWORD32bitValueToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem qWORD64bitValueToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem multiStringValueToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem expandableStringValueToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator modifyToolStripSeparator1;
    }
}