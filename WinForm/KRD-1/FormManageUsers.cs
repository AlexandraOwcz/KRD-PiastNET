using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace KRD_1
{
    public partial class FormManageUsers : System.Windows.Forms.Form
    {
        public static List<User> listOfUsers = new List<User>();
        DataTable dataTableOfUsers = new DataTable();
        // Filtering columns od dataGridViewUsers by this column names
        string [] filterFields = { "Imie", "Nazwisko" };
        // XML - serializes and deserializes data
        XMLParser xml = new XMLParser();
        

        public FormManageUsers()
        {
            InitializeComponent();
            buttonAdd.Click += OpenFormAddOrEdit_Click;
            buttonEdit.Click += OpenFormAddOrEdit_Click;
            // Loading data from xml
            xml.DeserializeListOfUsers(listOfUsers);
            dataTableOfUsers.Columns.Add("Imie", typeof(String));
            dataTableOfUsers.Columns.Add("Nazwisko", typeof(String));
            dataTableOfUsers.Columns.Add("Ulica", typeof(String));
            dataTableOfUsers.Columns.Add("Plec", typeof(Char));
            dataTableOfUsers.Columns.Add("Kraj", typeof(String));
            // Filling data with list
            FillDataGridView();
            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void FillDataGridView()
        { 
            dataTableOfUsers.Clear();
            foreach (var item in listOfUsers)
            {
                dataTableOfUsers.Rows.Add(item.Name, item.Surname, 
                    item.Street, item.Gender, item.Country);
             }

            dataGridViewUsers.DataSource = dataTableOfUsers;
        }

        private void buttonName_Click(object sender, EventArgs e)
        {
            labelSearch.Text = textBoxSearch.Text;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Delete selected rows
            foreach (DataGridViewRow row in dataGridViewUsers.SelectedRows)
            {
                listOfUsers.RemoveAt(row.Index);
                dataGridViewUsers.Rows.RemoveAt(row.Index);
                dataGridViewUsers.Refresh();
            }
        }

        private void OpenFormAddOrEdit_Click(object sender, EventArgs e)
        {
            string buttonText = ((Button)sender).Text;
            var formAddOrEdit = new FormAddOrEdit(listOfUsers);
            // Adding closing event 
            formAddOrEdit.FormClosed += new FormClosedEventHandler(Form_Closed);
            switch (buttonText)
            {
                case "Dodaj":
                    formAddOrEdit.Text = "Dodaj";
                    break;
                case "Edytuj":
                    {
                        int selectedRowIndex = dataGridViewUsers.CurrentRow.Index;
                        if(selectedRowIndex > -1)
                            formAddOrEdit.ChangeUserAtIndex = selectedRowIndex;
                    }
                    formAddOrEdit.Text = "Edytuj";
                    break;
                default:
                    break;
            }
            formAddOrEdit.TopMost = true;
            // Showing add/edit dialog 
            formAddOrEdit.ShowDialog();
        }
        
        // Searching by Name and Surname columns 
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Search for: " + textBoxSearch.Text.ToString());
            dataTableOfUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%' OR [{2}] LIKE '%{1}%'",
                filterFields[0], textBoxSearch.Text, filterFields[1]);
            dataGridViewUsers.DataSource = dataTableOfUsers;
        }

        // This method is calling after closing FormAddOrEdit window
        void Form_Closed(object sender, FormClosedEventArgs e)
        {
            FormAddOrEdit form = (FormAddOrEdit)sender;
            MessageBox.Show("Zapisano zmiany...");
            FillDataGridView();
            xml.SerializeListOfUsers(listOfUsers);
        }
        
        private void buttonStatus_Click(object sender, EventArgs e)
        {
            // I don't know what it should do ?
        }
    }
}