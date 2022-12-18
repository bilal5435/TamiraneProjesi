
namespace TamirhaneApp
{
    partial class AlertForm
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
            this.lblAllert = new System.Windows.Forms.Label();
            this.lblAlertNew = new System.Windows.Forms.Label();
            this.btnCloseAlertForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAllert
            // 
            this.lblAllert.AutoSize = true;
            this.lblAllert.Location = new System.Drawing.Point(62, 56);
            this.lblAllert.Name = "lblAllert";
            this.lblAllert.Size = new System.Drawing.Size(0, 17);
            this.lblAllert.TabIndex = 0;
            // 
            // lblAlertNew
            // 
            this.lblAlertNew.AutoSize = true;
            this.lblAlertNew.Location = new System.Drawing.Point(68, 56);
            this.lblAlertNew.Name = "lblAlertNew";
            this.lblAlertNew.Size = new System.Drawing.Size(0, 17);
            this.lblAlertNew.TabIndex = 1;
            // 
            // btnCloseAlertForm
            // 
            this.btnCloseAlertForm.Location = new System.Drawing.Point(318, 114);
            this.btnCloseAlertForm.Name = "btnCloseAlertForm";
            this.btnCloseAlertForm.Size = new System.Drawing.Size(75, 23);
            this.btnCloseAlertForm.TabIndex = 2;
            this.btnCloseAlertForm.Text = "Kapat";
            this.btnCloseAlertForm.UseVisualStyleBackColor = true;
            this.btnCloseAlertForm.Click += new System.EventHandler(this.btnCloseAlertForm_Click);
            // 
            // AlertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 149);
            this.Controls.Add(this.btnCloseAlertForm);
            this.Controls.Add(this.lblAlertNew);
            this.Controls.Add(this.lblAllert);
            this.MaximizeBox = false;
            this.Name = "AlertForm";
            this.Text = "Uyarı";
            this.Load += new System.EventHandler(this.AlertForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAllert;
        public System.Windows.Forms.Label lblAlertNew;
        private System.Windows.Forms.Button btnCloseAlertForm;
    }
}