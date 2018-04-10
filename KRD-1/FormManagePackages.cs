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
    public partial class FormManagePackages : Form
    {
        // List of packages
        List<Package> listOfPackages = new List<Package>();
        DataTable dataTableOfPackages = new DataTable();
        public FormManagePackages()
        {
            InitializeComponent();
            this.CenterToScreen();
            listOfPackages = XMLParser.LoadPackages();
            dataTableOfPackages.Columns.Add("Id", typeof(int));
            dataTableOfPackages.Columns.Add("Status", typeof(String));
            dataTableOfPackages.Columns.Add("Godzina", typeof(String));
            FillDataGridView();
        }

        private void FillDataGridView()
        {
            dataTableOfPackages.Clear();
            foreach (var item in listOfPackages)
            {
                dataTableOfPackages.Rows.Add(item.Id, item.Status, item.Hour);
            }

            dataGridViewDisplayPackages.DataSource = dataTableOfPackages;
        }

        private void buttonChangeStatus_Click(object sender, EventArgs e)
        {
            // Check if sth was selected in data grid view (row) and in combo box.
            if(comboBoxChangeStatus.SelectedIndex > -1 && (dataGridViewDisplayPackages.SelectedRows.Count == 1))
            {
                int index = dataGridViewDisplayPackages.SelectedRows[0].Index;
                XMLParser.ChangeStatusOfPackage(index, comboBoxChangeStatus.SelectedItem.ToString());
                // Can be done better -> to edit
                listOfPackages = XMLParser.LoadPackages();
                FillDataGridView();
            }
        }
    }
}
