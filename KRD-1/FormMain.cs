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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonManageUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formManager = new FormManageUsers();
            formManager.Closed += (s, args) => this.Close();
            formManager.ShowDialog();
        }

        private void buttonManagePackages_Click(object sender, EventArgs e)
        {
            var formPackages = new FormManagePackages();
            formPackages.ShowDialog();
        }
    }
}
