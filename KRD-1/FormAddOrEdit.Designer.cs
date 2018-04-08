namespace KRD_1
{
    partial class FormAddOrEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddOrEdit));
            this.checkBoxMen = new System.Windows.Forms.CheckBox();
            this.checkBoxWomen = new System.Windows.Forms.CheckBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelOfControls = new System.Windows.Forms.Panel();
            this.panelOfControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxMen
            // 
            this.checkBoxMen.AutoSize = true;
            this.checkBoxMen.Location = new System.Drawing.Point(85, 140);
            this.checkBoxMen.Name = "checkBoxMen";
            this.checkBoxMen.Size = new System.Drawing.Size(62, 17);
            this.checkBoxMen.TabIndex = 0;
            this.checkBoxMen.Text = "Kobieta";
            this.checkBoxMen.UseVisualStyleBackColor = true;
            // 
            // checkBoxWomen
            // 
            this.checkBoxWomen.AutoSize = true;
            this.checkBoxWomen.Location = new System.Drawing.Point(166, 140);
            this.checkBoxWomen.Name = "checkBoxWomen";
            this.checkBoxWomen.Size = new System.Drawing.Size(79, 17);
            this.checkBoxWomen.TabIndex = 1;
            this.checkBoxWomen.Text = "Mezczyzna";
            this.checkBoxWomen.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(85, 16);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(85, 54);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurname.TabIndex = 3;
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(85, 89);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(100, 20);
            this.textBoxStreet.TabIndex = 4;
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(85, 179);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCountry.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 16);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Imie:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(12, 52);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(56, 13);
            this.labelSurname.TabIndex = 7;
            this.labelSurname.Text = "Nazwisko:";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(12, 88);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(34, 13);
            this.labelStreet.TabIndex = 8;
            this.labelStreet.Text = "Ulica:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(226, 281);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panelOfControls
            // 
            this.panelOfControls.Controls.Add(this.labelStreet);
            this.panelOfControls.Controls.Add(this.labelSurname);
            this.panelOfControls.Controls.Add(this.labelName);
            this.panelOfControls.Controls.Add(this.comboBoxCountry);
            this.panelOfControls.Controls.Add(this.textBoxStreet);
            this.panelOfControls.Controls.Add(this.textBoxSurname);
            this.panelOfControls.Controls.Add(this.textBoxName);
            this.panelOfControls.Controls.Add(this.checkBoxWomen);
            this.panelOfControls.Controls.Add(this.checkBoxMen);
            this.panelOfControls.Location = new System.Drawing.Point(23, 14);
            this.panelOfControls.Name = "panelOfControls";
            this.panelOfControls.Size = new System.Drawing.Size(258, 239);
            this.panelOfControls.TabIndex = 10;
            // 
            // FormAddOrEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 316);
            this.Controls.Add(this.panelOfControls);
            this.Controls.Add(this.buttonSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddOrEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddOrEdit";
            this.panelOfControls.ResumeLayout(false);
            this.panelOfControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxMen;
        private System.Windows.Forms.CheckBox checkBoxWomen;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panelOfControls;
    }
}