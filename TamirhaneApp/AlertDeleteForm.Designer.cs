
namespace TamirhaneApp
{
    partial class AlertDeleteForm
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
            this.btnEvet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHayir = new System.Windows.Forms.Button();
            this.lblDeletedItemId = new System.Windows.Forms.Label();
            this.lblSelectedOperation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEvet
            // 
            this.btnEvet.Location = new System.Drawing.Point(148, 83);
            this.btnEvet.Name = "btnEvet";
            this.btnEvet.Size = new System.Drawing.Size(75, 23);
            this.btnEvet.TabIndex = 0;
            this.btnEvet.Text = "Evet";
            this.btnEvet.UseVisualStyleBackColor = true;
            this.btnEvet.Click += new System.EventHandler(this.btnEvet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Silmek istediğinize emin misiniz?";
            // 
            // btnHayir
            // 
            this.btnHayir.Location = new System.Drawing.Point(41, 83);
            this.btnHayir.Name = "btnHayir";
            this.btnHayir.Size = new System.Drawing.Size(75, 23);
            this.btnHayir.TabIndex = 2;
            this.btnHayir.Text = "Hayır";
            this.btnHayir.UseVisualStyleBackColor = true;
            this.btnHayir.Click += new System.EventHandler(this.btnHayir_Click);
            // 
            // lblDeletedItemId
            // 
            this.lblDeletedItemId.AutoSize = true;
            this.lblDeletedItemId.Location = new System.Drawing.Point(12, 9);
            this.lblDeletedItemId.Name = "lblDeletedItemId";
            this.lblDeletedItemId.Size = new System.Drawing.Size(0, 17);
            this.lblDeletedItemId.TabIndex = 3;
            this.lblDeletedItemId.Visible = false;
            // 
            // lblSelectedOperation
            // 
            this.lblSelectedOperation.AutoSize = true;
            this.lblSelectedOperation.Location = new System.Drawing.Point(38, 118);
            this.lblSelectedOperation.Name = "lblSelectedOperation";
            this.lblSelectedOperation.Size = new System.Drawing.Size(0, 17);
            this.lblSelectedOperation.TabIndex = 4;
            this.lblSelectedOperation.Visible = false;
            // 
            // AlertDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 144);
            this.Controls.Add(this.lblSelectedOperation);
            this.Controls.Add(this.lblDeletedItemId);
            this.Controls.Add(this.btnHayir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEvet);
            this.MaximizeBox = false;
            this.Name = "AlertDeleteForm";
            this.Text = "Uyarı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEvet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHayir;
        public System.Windows.Forms.Label lblDeletedItemId;
        public System.Windows.Forms.Label lblSelectedOperation;
    }
}