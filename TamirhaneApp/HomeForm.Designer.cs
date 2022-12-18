
namespace TamirhaneApp
{
    partial class HomeForm
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
            this.datagridList = new System.Windows.Forms.DataGridView();
            this.lblListName = new System.Windows.Forms.Label();
            this.comboBoxIslemler = new System.Windows.Forms.ComboBox();
            this.btnNewAppointment = new System.Windows.Forms.Button();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.btnNewCar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblSelectedOperation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridList)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridList
            // 
            this.datagridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridList.Location = new System.Drawing.Point(12, 77);
            this.datagridList.Name = "datagridList";
            this.datagridList.RowHeadersWidth = 51;
            this.datagridList.RowTemplate.Height = 24;
            this.datagridList.Size = new System.Drawing.Size(624, 325);
            this.datagridList.TabIndex = 0;
            // 
            // lblListName
            // 
            this.lblListName.AutoSize = true;
            this.lblListName.Location = new System.Drawing.Point(295, 44);
            this.lblListName.Name = "lblListName";
            this.lblListName.Size = new System.Drawing.Size(0, 17);
            this.lblListName.TabIndex = 1;
            // 
            // comboBoxIslemler
            // 
            this.comboBoxIslemler.FormattingEnabled = true;
            this.comboBoxIslemler.Location = new System.Drawing.Point(12, 37);
            this.comboBoxIslemler.Name = "comboBoxIslemler";
            this.comboBoxIslemler.Size = new System.Drawing.Size(192, 24);
            this.comboBoxIslemler.TabIndex = 6;
            this.comboBoxIslemler.SelectedIndexChanged += new System.EventHandler(this.comboBoxIslemler_SelectedIndexChanged);
            // 
            // btnNewAppointment
            // 
            this.btnNewAppointment.Location = new System.Drawing.Point(12, 422);
            this.btnNewAppointment.Name = "btnNewAppointment";
            this.btnNewAppointment.Size = new System.Drawing.Size(138, 23);
            this.btnNewAppointment.TabIndex = 7;
            this.btnNewAppointment.Text = "Randevu Oluştur";
            this.btnNewAppointment.UseVisualStyleBackColor = true;
            this.btnNewAppointment.Click += new System.EventHandler(this.btnNewAppointment_Click);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(223, 422);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(108, 23);
            this.btnNewCustomer.TabIndex = 8;
            this.btnNewCustomer.Text = "Yeni Müşteri Oluştur";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // btnNewCar
            // 
            this.btnNewCar.Location = new System.Drawing.Point(498, 422);
            this.btnNewCar.Name = "btnNewCar";
            this.btnNewCar.Size = new System.Drawing.Size(138, 23);
            this.btnNewCar.TabIndex = 9;
            this.btnNewCar.Text = "Yeni Araç Oluştur";
            this.btnNewCar.UseVisualStyleBackColor = true;
            this.btnNewCar.Click += new System.EventHandler(this.btnNewCar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "İşlem";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(561, 37);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Düzenle";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblSelectedOperation
            // 
            this.lblSelectedOperation.AutoSize = true;
            this.lblSelectedOperation.Location = new System.Drawing.Point(590, 457);
            this.lblSelectedOperation.Name = "lblSelectedOperation";
            this.lblSelectedOperation.Size = new System.Drawing.Size(0, 17);
            this.lblSelectedOperation.TabIndex = 12;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 473);
            this.Controls.Add(this.lblSelectedOperation);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewCar);
            this.Controls.Add(this.btnNewCustomer);
            this.Controls.Add(this.btnNewAppointment);
            this.Controls.Add(this.comboBoxIslemler);
            this.Controls.Add(this.lblListName);
            this.Controls.Add(this.datagridList);
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView datagridList;
        public System.Windows.Forms.Label lblListName;
        private System.Windows.Forms.ComboBox comboBoxIslemler;
        private System.Windows.Forms.Button btnNewAppointment;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Button btnNewCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Label lblSelectedOperation;
    }
}