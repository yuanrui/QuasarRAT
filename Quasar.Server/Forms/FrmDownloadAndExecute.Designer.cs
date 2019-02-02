namespace Quasar.Server.Forms
{
    partial class FrmDownloadAndExecute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDownloadAndExecute));
            this.btnDownloadAndExecute = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.chkRunHidden = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnDownloadAndExecute
            // 
            resources.ApplyResources(this.btnDownloadAndExecute, "btnDownloadAndExecute");
            this.btnDownloadAndExecute.Name = "btnDownloadAndExecute";
            this.btnDownloadAndExecute.UseVisualStyleBackColor = true;
            this.btnDownloadAndExecute.Click += new System.EventHandler(this.btnDownloadAndExecute_Click);
            // 
            // txtURL
            // 
            resources.ApplyResources(this.txtURL, "txtURL");
            this.txtURL.Name = "txtURL";
            // 
            // lblURL
            // 
            resources.ApplyResources(this.lblURL, "lblURL");
            this.lblURL.Name = "lblURL";
            // 
            // chkRunHidden
            // 
            resources.ApplyResources(this.chkRunHidden, "chkRunHidden");
            this.chkRunHidden.Name = "chkRunHidden";
            this.chkRunHidden.UseVisualStyleBackColor = true;
            // 
            // FrmDownloadAndExecute
            // 
            this.AcceptButton = this.btnDownloadAndExecute;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.chkRunHidden);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.btnDownloadAndExecute);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDownloadAndExecute";
            this.Load += new System.EventHandler(this.FrmDownloadAndExecute_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownloadAndExecute;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.CheckBox chkRunHidden;
    }
}