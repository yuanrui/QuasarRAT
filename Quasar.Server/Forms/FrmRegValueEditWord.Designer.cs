using Quasar.Server.Controls;
using Quasar.Server.Enums;

namespace Quasar.Server.Forms
{
    partial class FrmRegValueEditWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegValueEditWord));
            this.valueNameTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.baseBox = new System.Windows.Forms.GroupBox();
            this.radioDecimal = new System.Windows.Forms.RadioButton();
            this.radioHexa = new System.Windows.Forms.RadioButton();
            this.valueDataTxtBox = new Quasar.Server.Controls.WordTextBox();
            this.baseBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // valueNameTxtBox
            // 
            resources.ApplyResources(this.valueNameTxtBox, "valueNameTxtBox");
            this.valueNameTxtBox.Name = "valueNameTxtBox";
            this.valueNameTxtBox.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.Name = "okButton";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // baseBox
            // 
            this.baseBox.Controls.Add(this.radioDecimal);
            this.baseBox.Controls.Add(this.radioHexa);
            resources.ApplyResources(this.baseBox, "baseBox");
            this.baseBox.Name = "baseBox";
            this.baseBox.TabStop = false;
            // 
            // radioDecimal
            // 
            resources.ApplyResources(this.radioDecimal, "radioDecimal");
            this.radioDecimal.Name = "radioDecimal";
            this.radioDecimal.UseVisualStyleBackColor = true;
            // 
            // radioHexa
            // 
            resources.ApplyResources(this.radioHexa, "radioHexa");
            this.radioHexa.Checked = true;
            this.radioHexa.Name = "radioHexa";
            this.radioHexa.TabStop = true;
            this.radioHexa.UseVisualStyleBackColor = true;
            this.radioHexa.CheckedChanged += new System.EventHandler(this.radioHex_CheckboxChanged);
            // 
            // valueDataTxtBox
            // 
            this.valueDataTxtBox.IsHexNumber = true;
            resources.ApplyResources(this.valueDataTxtBox, "valueDataTxtBox");
            this.valueDataTxtBox.Name = "valueDataTxtBox";
            this.valueDataTxtBox.Type = Quasar.Server.Enums.WordType.DWORD;
            // 
            // FrmRegValueEditWord
            // 
            this.AcceptButton = this.okButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.cancelButton;
            this.Controls.Add(this.valueDataTxtBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.baseBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valueNameTxtBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegValueEditWord";
            this.ShowIcon = false;
            this.baseBox.ResumeLayout(false);
            this.baseBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox valueNameTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.GroupBox baseBox;
        private System.Windows.Forms.RadioButton radioDecimal;
        private System.Windows.Forms.RadioButton radioHexa;
        private Controls.WordTextBox valueDataTxtBox;
    }
}