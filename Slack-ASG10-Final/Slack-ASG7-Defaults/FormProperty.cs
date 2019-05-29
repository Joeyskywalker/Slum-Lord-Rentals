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
    public partial class FormProperty : Form
    {
        private Property property;
        public Property Property { get => property; set => property = value; }

        public FormProperty()
        {
            InitializeComponent();
        }

        public FormProperty(Property property)
        {
            InitializeComponent();
            this.property = property;
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                property.Address = textBoxAddress.Text;
                property.Price = Convert.ToDecimal(textBoxPrice.Text);
                property.City = textBoxCity.Text;
                property.State = textBoxState.Text;
                property.Zip = textBoxZip.Text;

                property.DescriptionBrief = textBoxBrief.Text;
                property.DescriptionFull = textBoxFull.Text;

                property.OnsiteLaundry = checkBoxOnsiteLaundry.Checked;
                property.OnsiteParking = checkBoxOnsiteParking.Checked;

                property.Bedrooms = Decimal.ToInt32(numericUpDownBedrooms.Value);
                property.Bathrooms = Decimal.ToInt32(numericUpDownBathrooms.Value);

                property.AvailableOn = dateTimePickerAvailableOn.Value;

                if (comboBoxStatus.Text == "Active")
                {
                    property.StatusTypeID = 1;
                }
                else if (comboBoxStatus.Text == "Inactive")
                {
                    property.StatusTypeID = 2;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Invalid data! Double check the price.");
            }
        }

        private void FormProperty_Load(object sender, EventArgs e)
        {
            textBoxId.Text = property.Id.ToString();
            textBoxAddedBy.Text = property.AddedByName;
            textBoxAddress.Text = property.Address;
            textBoxPrice.Text = property.Price.ToString();
            textBoxCity.Text = property.City;
            textBoxState.Text = property.State;
            textBoxZip.Text = property.Zip;
            comboBoxStatus.Text = property.getStatus();
            textBoxDateAdded.Text = property.DateAdded.ToString();
            textBoxDateUpdated.Text = DateTime.Now.ToString();
            textBoxBrief.Text = property.DescriptionBrief;
            textBoxFull.Text = property.DescriptionFull;
            textBoxAddedBy.Text = Properties.Settings.Default.EmployeeEmail;

            checkBoxOnsiteLaundry.Checked = property.OnsiteLaundry;
            checkBoxOnsiteParking.Checked = property.OnsiteParking;

            numericUpDownBedrooms.Value = property.Bedrooms;
            numericUpDownBathrooms.Value = property.Bathrooms;

            if(property.AvailableOn > DateTime.Parse("1/1/1900")){
                dateTimePickerAvailableOn.Value = property.AvailableOn;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBoxZip_TextChanged(object sender, EventArgs e)
        {
            logItem function = new logItem();
            function.resizeTextBox(sender);
        }
    }
}
