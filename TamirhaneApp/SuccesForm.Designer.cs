
namespace TamirhaneApp
{
    partial class SuccesForm
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
            this.lblSucces = new System.Windows.Forms.Label();
            this.btnSuccesFormClose = new System.Windows.Forms.Button();
            this.lblSuccesDurum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSucces
            // 
            this.lblSucces.AutoSize = true;
            this.lblSucces.Location = new System.Drawing.Point(21, 28);
            this.lblSucces.Name = "lblSucces";
            this.lblSucces.Size = new System.Drawing.Size(0, 17);
            this.lblSucces.TabIndex = 0;
            // 
            // btnSuccesFormClose
            // 
            this.btnSuccesFormClose.Location = new System.Drawing.Point(240, 88);
            this.btnSuccesFormClose.Name = "btnSuccesFormClose";
            this.btnSuccesFormClose.Size = new System.Drawing.Size(75, 23);
            this.btnSuccesFormClose.TabIndex = 1;
            this.btnSuccesFormClose.Text = "Tamam";
            this.btnSuccesFormClose.UseVisualStyleBackColor = true;
            this.btnSuccesFormClose.Click += new System.EventHandler(this.btnSuccesFormClose_Click);
            // 
            // lblSuccesDurum
            // 
            this.lblSuccesDurum.AutoSize = true;
            this.lblSuccesDurum.Location = new System.Drawing.Point(21, 9);
            this.lblSuccesDurum.Name = "lblSuccesDurum";
            this.lblSuccesDurum.Size = new System.Drawing.Size(0, 17);
            this.lblSuccesDurum.TabIndex = 2;
            this.lblSuccesDurum.Visible = false;
            // 
            // SuccesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 123);
            this.Controls.Add(this.lblSuccesDurum);
            this.Controls.Add(this.btnSuccesFormClose);
            this.Controls.Add(this.lblSucces);
            this.MaximizeBox = false;
            this.Name = "SuccesForm";
            this.Text = "Başarılı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblSucces;
        private System.Windows.Forms.Button btnSuccesFormClose;
        public System.Windows.Forms.Label lblSuccesDurum;
    }
}