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
    public partial class FormAddOrEdit : Form
    {
        List<User> listOfUsers = new List<User>();
        // -1 when adding new user 
        int _changeUserAtIndex = -1;
        public int ChangeUserAtIndex
        {
            get
            {
                return this._changeUserAtIndex;
            }
            set
            {
                this._changeUserAtIndex = value;
                if(_changeUserAtIndex > -1)
                {
                    FillFormWhenEdit();
                }
            }
        }
        public FormAddOrEdit(List<User> listOfUsers)
        {
            this.listOfUsers = listOfUsers;
            InitializeComponent();
            // Initializing data source
            comboBoxCountry.DataSource = new[] { "Poland", "United States", "Germany"};
        }

        // dołożyć to!
        private void FillFormWhenEdit()
        {
            User currentUser = listOfUsers.ElementAt(_changeUserAtIndex);
            textBoxName.Text = currentUser.Name;
            textBoxSurname.Text = currentUser.Surname;
            textBoxStreet.Text = currentUser.Street;
            if(currentUser.Gender == 'K')
            {
                checkBoxWomen.Checked = true;
            }
            else // Gender == 'M' 
            {
                checkBoxMen.Checked = true;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Boolean canSave = true;
            foreach (Panel panel in Controls.OfType<Panel>())
            {
                foreach (TextBox textBox in panel.Controls.OfType<TextBox>())
                {
                    if (string.IsNullOrEmpty(textBox.Text.Trim()))
                    {
                        MessageBox.Show("Uzupełnij wszystkie dane!", "Uwaga!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        canSave = false;
                        break;
                    }
                }
            }
            if(canSave)
            {
                Char gender;
                if (checkBoxWomen.Checked)
                {
                    gender = 'K';
                }
                else // Gender == 'M' 
                {
                    gender = 'M';
                }
                if (_changeUserAtIndex != -1)
                {
                    listOfUsers.ElementAt(_changeUserAtIndex).Name = textBoxName.Text;
                    listOfUsers.ElementAt(_changeUserAtIndex).Surname = textBoxSurname.Text;
                    listOfUsers.ElementAt(_changeUserAtIndex).Street = textBoxStreet.Text;
                    listOfUsers.ElementAt(_changeUserAtIndex).Gender = gender;
                    listOfUsers.ElementAt(_changeUserAtIndex).Country = comboBoxCountry.SelectedItem.ToString();
                }
                else // Adding new user (index == -1)
                {
                    if(comboBoxCountry.SelectedIndex > -1)
                        listOfUsers.Add(new User() {
                            Name = textBoxName.Text, Surname = textBoxSurname.Text,
                            Street = textBoxStreet.Text, Gender = gender,
                            Country = comboBoxCountry.SelectedItem.ToString()});
                }
                FormManager.listOfUsers = listOfUsers;
                this.Close();
            }
        }
    }
}
