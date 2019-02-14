namespace Quasar.Server.Forms
{
    partial class FrmShowMessagebox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShowMessagebox));
            this.groupMsgSettings = new System.Windows.Forms.GroupBox();
            this.cmbMsgIcon = new System.Windows.Forms.ComboBox();
            this.lblMsgIcon = new System.Windows.Forms.Label();
            this.cmbMsgButtons = new System.Windows.Forms.ComboBox();
            this.lblMsgButtons = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.txtCaption = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.lblCaption = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupMsgSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupMsgSettings
            // 
            resources.ApplyResources(this.groupMsgSettings, "groupMsgSettings");
            this.groupMsgSettings.Controls.Add(this.cmbMsgIcon);
            this.groupMsgSettings.Controls.Add(this.lblMsgIcon);
            this.groupMsgSettings.Controls.Add(this.cmbMsgButtons);
            this.groupMsgSettings.Controls.Add(this.lblMsgButtons);
            this.groupMsgSettings.Controls.Add(this.txtText);
            this.groupMsgSettings.Controls.Add(this.txtCaption);
            this.groupMsgSettings.Controls.Add(this.lblText);
            this.groupMsgSettings.Controls.Add(this.lblCaption);
            this.groupMsgSettings.Name = "groupMsgSettings";
            this.groupMsgSettings.TabStop = false;
            // 
            // cmbMsgIcon
            // 
            resources.ApplyResources(this.cmbMsgIcon, "cmbMsgIcon");
            this.cmbMsgIcon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMsgIcon.FormattingEnabled = true;
            this.cmbMsgIcon.Name = "cmbMsgIcon";
            // 
            // lblMsgIcon
            // 
            resources.ApplyResources(this.lblMsgIcon, "lblMsgIcon");
            this.lblMsgIcon.Name = "lblMsgIcon";
            // 
            // cmbMsgButtons
            // 
            resources.ApplyResources(this.cmbMsgButtons, "cmbMsgButtons");
            this.cmbMsgButtons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMsgButtons.FormattingEnabled = true;
            this.cmbMsgButtons.Name = "cmbMsgButtons";
            // 
            // lblMsgButtons
            // 
            resources.ApplyResources(this.lblMsgButtons, "lblMsgButtons");
            this.lblMsgButtons.Name = "lblMsgButtons";
            // 
            // txtText
            // 
            resources.ApplyResources(this.txtText, "txtText");
            this.txtText.Name = "txtText";
            // 
            // txtCaption
            // 
            resources.ApplyResources(this.txtCaption, "txtCaption");
            this.txtCaption.Name = "txtCaption";
            // 
            // lblText
            // 
            resources.ApplyResources(this.lblText, "lblText");
            this.lblText.Name = "lblText";
            // 
            // lblCaption
            // 
            resources.ApplyResources(this.lblCaption, "lblCaption");
            this.lblCaption.Name = "lblCaption";
            // 
            // btnPreview
            // 
            resources.ApplyResources(this.btnPreview, "btnPreview");
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnSend
            // 
            resources.ApplyResources(this.btnSend, "btnSend");
            this.btnSend.Name = "btnSend";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // FrmShowMessagebox
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.groupMsgSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmShowMessagebox";
            this.Load += new System.EventHandler(this.FrmShowMessagebox_Load);
            this.groupMsgSettings.ResumeLayout(false);
            this.groupMsgSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupMsgSettings;
        private System.Windows.Forms.ComboBox cmbMsgIcon;
        private System.Windows.Forms.Label lblMsgIcon;
        private System.Windows.Forms.ComboBox cmbMsgButtons;
        private System.Windows.Forms.Label lblMsgButtons;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.TextBox txtCaption;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnSend;
    }
}