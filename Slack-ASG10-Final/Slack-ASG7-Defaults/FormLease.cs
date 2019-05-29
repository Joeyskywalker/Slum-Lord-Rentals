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
    public partial class FormLease : Form
    {
        private Lease lease = new Lease();
        private readonly Property property = new Property();
        private readonly Tenant tenant = new Tenant();

        public FormLease(Lease lease, Property property, Tenant tenant)
        {
            InitializeComponent();
            this.lease = lease;
            this.property = property;
            this.tenant = tenant;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                lease.DateUpdated = DateTime.Parse(textBoxUpdated.Text);
                lease.MonthlyRate = Decimal.Parse(textBoxMonthlyRate.Text);
                lease.Description = textBoxDesciption.Text;
                lease.Notes = textBoxNotes.Text;
                lease.DateLeaseStarts = dateTimePickerStart.Value;
                lease.DateLeaseEnds = dateTimePickerEnd.Value;

                if (comboBoxStatus.Text == "Active")
                {
                    lease.StatusTypeID = 1;
                }
                else
                {
                    lease.StatusTypeID = 2;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Invalid Data! Double check the monthly rate");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FormLease_Load(object sender, EventArgs e)
        {
            //These are displayed and not saved when the user saves
            textBoxLeaseID.Text = lease.Id.ToString();
            textBoxPropertyID.Text = lease.PropertyID.ToString();
            textBoxPropertyID2.Text = lease.PropertyID.ToString();
            textBoxTenantID.Text = lease.TenantID.ToString();
            textBoxTenantID2.Text = lease.TenantID.ToString();
            textBoxAdded.Text = lease.DateAdded.ToString();
            textBoxAddedByID.Text = Properties.Settings.Default.EmployeeEmail;
            comboBoxStatus.Text = lease.getStatus();


            //Tenant
            textBoxTenantFIrstName.Text = tenant.FirstName;
            textBoxTenantLastName.Text = tenant.LastName;
            textBoxTenantEmail.Text = tenant.Email;
            textBoxTenantPhone.Text = tenant.Phone;

            //Property
            textBoxAddress.Text = property.Address;
            textBoxPrice.Text = property.Price.ToString();
            textBoxCity.Text = property.City;
            textBoxState.Text = property.State;
            textBoxZip.Text = property.Zip;
            textBoxBedrooms.Text = property.Bedrooms.ToString();
            textBoxBathrooms.Text = property.Bathrooms.ToString();

            if(property.OnsiteLaundry == true)
            {
                textBoxLaundry.Text = "Yes";
            }

            if (property.OnsiteParking == true)
            {
                textBoxParking.Text = "Yes";
            }

            //This need to be saved
            textBoxUpdated.Text = DateTime.Now.ToString();
            textBoxMonthlyRate.Text = lease.MonthlyRate.ToString();
            textBoxDesciption.Text = lease.Description;
            textBoxNotes.Text = lease.Notes;

            if (lease.DateLeaseStarts > DateTime.Parse("1/1/1900"))
            {
                dateTimePickerStart.Value = lease.DateLeaseStarts;
            }

            if (lease.DateLeaseEnds > DateTime.Parse("1/1/1900"))
            {
                dateTimePickerEnd.Value = lease.DateLeaseEnds;
            }

        }

        private void textBoxLeaseID_TextChanged(object sender, EventArgs e)
        {
            logItem function = new logItem();
            function.resizeTextBox(sender);
        }
    }
}
