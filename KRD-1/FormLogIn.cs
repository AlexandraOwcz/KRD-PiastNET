using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KRD_1
{
    public partial class FormLogIn : Form
    {
        bool isLoggedIn = false;
        XMLParser parser = new XMLParser();
        public FormLogIn()
        {
            InitializeComponent();
            this.CenterToScreen();
            // Code password
            textBoxPassword.PasswordChar = '*';
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(textBoxUsername.Text) && !string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                bool isValid = XMLParser.IsValidLogin(textBoxUsername.Text, textBoxPassword.Text);
                if(isValid)
                {
                    this.Hide();
                    var main = new FormMain();
                    main.Closed += (s, args) => this.Close();
                    main.ShowDialog();
                }
                else
                    MessageBox.Show("Nie ma takiego użytkownika w bazie!",
                                "Uwaga!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
            }
            else
                MessageBox.Show("Uzupełnij dane!",
                                "Uwaga!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
        }

        private void buttonCheckStateOfPackages_Click(object sender, EventArgs e)
        {
            var formOfPackages = new FormManagePackages(isLoggedIn);
            formOfPackages.ShowDialog();
        }
    }
}
