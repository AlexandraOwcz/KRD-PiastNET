﻿namespace KRD_1
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonManageUsers = new System.Windows.Forms.Button();
            this.buttonManagePackages = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonManageUsers
            // 
            this.buttonManageUsers.Location = new System.Drawing.Point(134, 72);
            this.buttonManageUsers.Name = "buttonManageUsers";
            this.buttonManageUsers.Size = new System.Drawing.Size(198, 69);
            this.buttonManageUsers.TabIndex = 0;
            this.buttonManageUsers.Text = "Zarzadzaj użytownikami";
            this.buttonManageUsers.UseVisualStyleBackColor = true;
            this.buttonManageUsers.Click += new System.EventHandler(this.buttonManageUsers_Click);
            // 
            // buttonManagePackages
            // 
            this.buttonManagePackages.Location = new System.Drawing.Point(134, 163);
            this.buttonManagePackages.Name = "buttonManagePackages";
            this.buttonManagePackages.Size = new System.Drawing.Size(198, 69);
            this.buttonManagePackages.TabIndex = 1;
            this.buttonManagePackages.Text = "Zarzadzaj paczkami";
            this.buttonManagePackages.UseVisualStyleBackColor = true;
            this.buttonManagePackages.Click += new System.EventHandler(this.buttonManagePackages_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 319);
            this.Controls.Add(this.buttonManagePackages);
            this.Controls.Add(this.buttonManageUsers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zarzadzaj uzytkownikami";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonManageUsers;
        private System.Windows.Forms.Button buttonManagePackages;
    }
}