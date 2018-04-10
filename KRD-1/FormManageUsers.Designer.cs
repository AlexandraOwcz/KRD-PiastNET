namespace KRD_1
{
    partial class FormManageUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageUsers));
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.pictureBoxLoupe = new System.Windows.Forms.PictureBox();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.buttonStatus = new System.Windows.Forms.Button();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoupe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(3, 3);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(378, 20);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(31, 65);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(42, 13);
            this.labelSearch.TabIndex = 1;
            this.labelSearch.Text = "Szukaj:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(35, 13);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(110, 40);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(151, 12);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(101, 40);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Edytuj";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(374, 13);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(119, 40);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.SystemColors.Window;
            this.panelSearch.Controls.Add(this.pictureBoxLoupe);
            this.panelSearch.Controls.Add(this.textBoxSearch);
            this.panelSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelSearch.Location = new System.Drawing.Point(79, 59);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(414, 26);
            this.panelSearch.TabIndex = 5;
            // 
            // pictureBoxLoupe
            // 
            this.pictureBoxLoupe.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxLoupe.Image = global::KRD_1.Properties.Resources.loupe;
            this.pictureBoxLoupe.Location = new System.Drawing.Point(387, 0);
            this.pictureBoxLoupe.Name = "pictureBoxLoupe";
            this.pictureBoxLoupe.Size = new System.Drawing.Size(24, 26);
            this.pictureBoxLoupe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLoupe.TabIndex = 6;
            this.pictureBoxLoupe.TabStop = false;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(35, 91);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(459, 176);
            this.dataGridViewUsers.TabIndex = 6;
            // 
            // buttonStatus
            // 
            this.buttonStatus.Location = new System.Drawing.Point(258, 12);
            this.buttonStatus.Name = "buttonStatus";
            this.buttonStatus.Size = new System.Drawing.Size(110, 40);
            this.buttonStatus.TabIndex = 7;
            this.buttonStatus.Text = "Status";
            this.buttonStatus.UseVisualStyleBackColor = true;
            this.buttonStatus.Click += new System.EventHandler(this.buttonStatus_Click);
            // 
            // FormManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 294);
            this.Controls.Add(this.buttonStatus);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KRD ";
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoupe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.PictureBox pictureBoxLoupe;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button buttonStatus;
    }
}

