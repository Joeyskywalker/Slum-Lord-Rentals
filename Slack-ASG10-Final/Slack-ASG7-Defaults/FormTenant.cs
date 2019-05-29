using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slack_ASG7_Defaults
{
    public partial class FormTenant : Form
    {

        private Tenant newTenant;

        public FormTenant(Tenant newTenant)
        {
            InitializeComponent();
            this.newTenant = newTenant;

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            newTenant.City = textBoxCity.Text;
            newTenant.FirstName = textBoxFirstName.Text;
            newTenant.LastName = textBoxLastName.Text;
            newTenant.State = textBoxState.Text;
            newTenant.Zip = textBoxZip.Text;
            newTenant.DateUpdated = Convert.ToDateTime(textBoxUpdated.Text);
            newTenant.Email = textBoxEmail.Text;
            newTenant.Phone = textBoxPhone.Text;

            if (comboBoxStatus.Text == "Active")
            {
                newTenant.StatusTypeID = 1;
            }
            else if(comboBoxStatus.Text == "Inactive")
            {
                newTenant.StatusTypeID = 2;
            }


            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAddTenant_Load(object sender, EventArgs e)
        {
            textBoxFirstName.Text = newTenant.FirstName;
            textBoxLastName.Text = newTenant.LastName;
            textBoxTenantID.Text = newTenant.Id.ToString();
            textBoxCity.Text = newTenant.City;
            textBoxState.Text = newTenant.State;
            textBoxZip.Text = newTenant.Zip;
            textBoxAddedByID.Text = Properties.Settings.Default.EmployeeEmail;
            textBoxUpdated.Text = DateTime.Now.ToString();
            textBoxAdded.Text = newTenant.DateAdded.ToString();
            textBoxEmail.Text = newTenant.Email;
            textBoxPhone.Text = newTenant.Phone;
            comboBoxStatus.Text = newTenant.getStatus();
        }


        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {
            logItem function = new logItem();
            function.resizeTextBox(sender);
        }
    }
}
