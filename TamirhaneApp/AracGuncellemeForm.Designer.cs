
namespace TamirhaneApp
{
    partial class AracGuncellemeForm
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
            this.btnAracSil = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAracGunMarka = new System.Windows.Forms.TextBox();
            this.txtAracGunModel = new System.Windows.Forms.TextBox();
            this.txtAracGunModelyili = new System.Windows.Forms.TextBox();
            this.txtAracGunPlaka = new System.Windows.Forms.TextBox();
            this.btnAracGuncelle = new System.Windows.Forms.Button();
            this.txtAracKayitNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAracSil
            // 
            this.btnAracSil.Location = new System.Drawing.Point(343, 253);
            this.btnAracSil.Name = "btnAracSil";
            this.btnAracSil.Size = new System.Drawing.Size(83, 33);
            this.btnAracSil.TabIndex = 17;
            this.btnAracSil.Text = "Sil";
            this.btnAracSil.UseVisualStyleBackColor = true;
            this.btnAracSil.Click += new System.EventHandler(this.btnAracSil_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Model Yılı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Plaka";
            // 
            // txtAracGunMarka
            // 
            this.txtAracGunMarka.Location = new System.Drawing.Point(206, 98);
            this.txtAracGunMarka.Name = "txtAracGunMarka";
            this.txtAracGunMarka.Size = new System.Drawing.Size(220, 22);
            this.txtAracGunMarka.TabIndex = 12;
            // 
            // txtAracGunModel
            // 
            this.txtAracGunModel.Location = new System.Drawing.Point(206, 147);
            this.txtAracGunModel.Name = "txtAracGunModel";
            this.txtAracGunModel.Size = new System.Drawing.Size(220, 22);
            this.txtAracGunModel.TabIndex = 11;
            // 
            // txtAracGunModelyili
            // 
            this.txtAracGunModelyili.Location = new System.Drawing.Point(206, 207);
            this.txtAracGunModelyili.Name = "txtAracGunModelyili";
            this.txtAracGunModelyili.Size = new System.Drawing.Size(220, 22);
            this.txtAracGunModelyili.TabIndex = 10;
            // 
            // txtAracGunPlaka
            // 
            this.txtAracGunPlaka.Location = new System.Drawing.Point(206, 52);
            this.txtAracGunPlaka.Name = "txtAracGunPlaka";
            this.txtAracGunPlaka.Size = new System.Drawing.Size(220, 22);
            this.txtAracGunPlaka.TabIndex = 9;
            // 
            // btnAracGuncelle
            // 
            this.btnAracGuncelle.Location = new System.Drawing.Point(230, 253);
            this.btnAracGuncelle.Name = "btnAracGuncelle";
            this.btnAracGuncelle.Size = new System.Drawing.Size(83, 33);
            this.btnAracGuncelle.TabIndex = 18;
            this.btnAracGuncelle.Text = "Güncelle";
            this.btnAracGuncelle.UseVisualStyleBackColor = true;
            this.btnAracGuncelle.Click += new System.EventHandler(this.btnAracGuncelle_Click);
            // 
            // txtAracKayitNo
            // 
            this.txtAracKayitNo.Location = new System.Drawing.Point(206, 12);
            this.txtAracKayitNo.Name = "txtAracKayitNo";
            this.txtAracKayitNo.Size = new System.Drawing.Size(220, 22);
            this.txtAracKayitNo.TabIndex = 19;
            this.txtAracKayitNo.Visible = false;
            // 
            // AracGuncellemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 323);
            this.Controls.Add(this.txtAracKayitNo);
            this.Controls.Add(this.btnAracGuncelle);
            this.Controls.Add(this.btnAracSil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAracGunMarka);
            this.Controls.Add(this.txtAracGunModel);
            this.Controls.Add(this.txtAracGunModelyili);
            this.Controls.Add(this.txtAracGunPlaka);
            this.Name = "AracGuncellemeForm";
            this.Text = "AracGuncellemeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAracSil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAracGuncelle;
        public System.Windows.Forms.TextBox txtAracGunMarka;
        public System.Windows.Forms.TextBox txtAracGunModel;
        public System.Windows.Forms.TextBox txtAracGunModelyili;
        public System.Windows.Forms.TextBox txtAracGunPlaka;
        public System.Windows.Forms.TextBox txtAracKayitNo;
    }
}