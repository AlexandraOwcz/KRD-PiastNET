namespace KRD_1
{
    partial class FormManagePackages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManagePackages));
            this.buttonChangeStatus = new System.Windows.Forms.Button();
            this.comboBoxChangeStatus = new System.Windows.Forms.ComboBox();
            this.dataGridViewDisplayPackages = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayPackages)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonChangeStatus
            // 
            this.buttonChangeStatus.Location = new System.Drawing.Point(346, 12);
            this.buttonChangeStatus.Name = "buttonChangeStatus";
            this.buttonChangeStatus.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeStatus.TabIndex = 0;
            this.buttonChangeStatus.Text = "Zmień status";
            this.buttonChangeStatus.UseVisualStyleBackColor = true;
            this.buttonChangeStatus.Click += new System.EventHandler(this.buttonChangeStatus_Click);
            // 
            // comboBoxChangeStatus
            // 
            this.comboBoxChangeStatus.FormattingEnabled = true;
            this.comboBoxChangeStatus.Items.AddRange(new object[] {
            "dostarczono",
            "w drodze",
            "w magazynie",
            "w systemie"});
            this.comboBoxChangeStatus.Location = new System.Drawing.Point(209, 12);
            this.comboBoxChangeStatus.Name = "comboBoxChangeStatus";
            this.comboBoxChangeStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChangeStatus.TabIndex = 1;
            // 
            // dataGridViewDisplayPackages
            // 
            this.dataGridViewDisplayPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplayPackages.Location = new System.Drawing.Point(25, 52);
            this.dataGridViewDisplayPackages.Name = "dataGridViewDisplayPackages";
            this.dataGridViewDisplayPackages.Size = new System.Drawing.Size(392, 201);
            this.dataGridViewDisplayPackages.TabIndex = 2;
            // 
            // FormManagePackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 299);
            this.Controls.Add(this.dataGridViewDisplayPackages);
            this.Controls.Add(this.comboBoxChangeStatus);
            this.Controls.Add(this.buttonChangeStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormManagePackages";
            this.Text = "Zarządzaj paczkami";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayPackages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonChangeStatus;
        private System.Windows.Forms.ComboBox comboBoxChangeStatus;
        private System.Windows.Forms.DataGridView dataGridViewDisplayPackages;
    }
}