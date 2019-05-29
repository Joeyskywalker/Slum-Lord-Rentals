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
    public partial class FormMain : Form
    {

        FormDefaults defaultSettings = new FormDefaults();
        string employeeEmail = Properties.Settings.Default.EmployeeEmail;

        public FormMain()
        {
            InitializeComponent();
        }

        private void defaultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            defaultSettings.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            updateAllListBoxes();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();

            about.ShowDialog();
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLog log = new FormLog();

            log.ShowDialog();
        }

        private void checkBoxes_Click(object sender, EventArgs e)
        {
            updateAllListBoxes();
        }

        private void updateAllListBoxes()
        {
            Cursor.Current = Cursors.WaitCursor;

            //Tenants
            if (checkBoxActiveTenants.Checked == true && checkBoxInactiveTenants.Checked == true)
            {
                listBoxTenants.Items.Clear();
                SlumLordRentalSQL.loadTenantRecordsToListBox(listBoxTenants, 1, Properties.Settings.Default.EmployeeEmail);
                SlumLordRentalSQL.loadTenantRecordsToListBox(listBoxTenants, 2, Properties.Settings.Default.EmployeeEmail);
            }
            else if (checkBoxActiveTenants.Checked == true)
            {
                listBoxTenants.Items.Clear();
                SlumLordRentalSQL.loadTenantRecordsToListBox(listBoxTenants, 1, Properties.Settings.Default.EmployeeEmail);
            }
            else if (checkBoxInactiveTenants.Checked == true)
            {
                listBoxTenants.Items.Clear();
                SlumLordRentalSQL.loadTenantRecordsToListBox(listBoxTenants, 2, Properties.Settings.Default.EmployeeEmail);
            }
            else
            {
                listBoxTenants.Items.Clear();
            }

            //Properties
            if (checkBoxActiveProperties.Checked == true && checkBoxInactiveProperties.Checked == true)
            {
                listBoxProperties.Items.Clear();
                SlumLordRentalSQL.loadPropertyRecordsToListBox(listBoxProperties, 1, Properties.Settings.Default.EmployeeEmail);
                SlumLordRentalSQL.loadPropertyRecordsToListBox(listBoxProperties, 2, Properties.Settings.Default.EmployeeEmail);
            }
            else if (checkBoxActiveProperties.Checked == true)
            {
                listBoxProperties.Items.Clear();
                SlumLordRentalSQL.loadPropertyRecordsToListBox(listBoxProperties, 1, Properties.Settings.Default.EmployeeEmail);
            }
            else if (checkBoxInactiveProperties.Checked == true)
            {
                listBoxProperties.Items.Clear();
                SlumLordRentalSQL.loadPropertyRecordsToListBox(listBoxProperties, 2, Properties.Settings.Default.EmployeeEmail);
            }
            else
            {
                listBoxProperties.Items.Clear();
            }

            //Leases
            if (checkBoxActiveLeases.Checked == true && checkBoxInactiveLeases.Checked == true)
            {
                listBoxLeases.Items.Clear();
                SlumLordRentalSQL.loadLeaseRecordsToListBox(listBoxLeases, 1, employeeEmail);
                SlumLordRentalSQL.loadLeaseRecordsToListBox(listBoxLeases, 2, employeeEmail);
            }
            else if (checkBoxActiveLeases.Checked == true)
            {
                listBoxLeases.Items.Clear();
                SlumLordRentalSQL.loadLeaseRecordsToListBox(listBoxLeases, 1, employeeEmail);
            }
            else if (checkBoxInactiveLeases.Checked == true)
            {
                listBoxLeases.Items.Clear();
                SlumLordRentalSQL.loadLeaseRecordsToListBox(listBoxLeases, 2, employeeEmail);
            }
            else
            {
                listBoxLeases.Items.Clear();
            }

            Cursor.Current = Cursors.Default;
        }

        // --------- TENANT -------------

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Add Tenant Button
            Tenant defaultNewTenant = new Tenant("","","","",
                Properties.Settings.Default.DefaultCity,
                Properties.Settings.Default.DefaultState,
                Properties.Settings.Default.DefaultZip);

            FormTenant addTenant = new FormTenant(defaultNewTenant);

            addTenant.ShowDialog();

            if (addTenant.DialogResult == DialogResult.OK)
            {
                SlumLordRentalSQL.tenantInsert(defaultNewTenant, employeeEmail);
                listBoxTenants.Items.Clear();
                SlumLordRentalSQL.loadTenantRecordsToListBox(listBoxTenants, 1, employeeEmail);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //Edit Tenant Button
            int selectedTenant = -1;
            selectedTenant = listBoxTenants.SelectedIndex;

            if (selectedTenant > -1)
            {
                Tenant tenantToEdit = new Tenant();
                int tenantID = -1;

                tenantToEdit = (Tenant)listBoxTenants.SelectedItem;
                tenantID = tenantToEdit.Id;
                tenantToEdit = SlumLordRentalSQL.getTenantFromID(tenantID, employeeEmail);

                FormTenant editForm = new FormTenant(tenantToEdit);

                editForm.ShowDialog();

                if (editForm.DialogResult == DialogResult.OK)
                {
                    SlumLordRentalSQL.tenantUpdate(tenantToEdit,employeeEmail);
                    listBoxTenants.Items.Clear();
                    SlumLordRentalSQL.loadTenantRecordsToListBox(listBoxTenants, 1, employeeEmail);
                }
            }

        }

        // ---------- PROPERTY ------------------

        private void buttonAddProperty_Click(object sender, EventArgs e)
        {
            Property newProperty = new Property(
                Properties.Settings.Default.DefaultCity,
                Properties.Settings.Default.DefaultState,
                Properties.Settings.Default.DefaultZip);

            FormProperty formProperty = new FormProperty(newProperty);

            formProperty.ShowDialog();

            if (formProperty.DialogResult == DialogResult.OK)
            {
                SlumLordRentalSQL.propertyInsert(newProperty, employeeEmail);
                listBoxProperties.Items.Clear();
                SlumLordRentalSQL.loadPropertyRecordsToListBox(listBoxProperties, 1, employeeEmail);
            }
        }

        private void buttonEditProperty_Click(object sender, EventArgs e)
        {
            int selectedProerty = -1;
            selectedProerty = listBoxProperties.SelectedIndex;

            if (selectedProerty > -1)
            {
                Property propertyToEdit = new Property();
                int propertyID = -1;

                propertyToEdit = (Property)listBoxProperties.SelectedItem;
                propertyID = propertyToEdit.Id;
                propertyToEdit = SlumLordRentalSQL.getPropertyFromID(propertyID, employeeEmail);

                FormProperty editForm = new FormProperty(propertyToEdit);

                editForm.ShowDialog();

                if (editForm.DialogResult == DialogResult.OK)
                {
                    SlumLordRentalSQL.propertyUpdate(propertyToEdit, employeeEmail);
                    listBoxProperties.Items.Clear();
                    SlumLordRentalSQL.loadPropertyRecordsToListBox(listBoxProperties, 1, employeeEmail);
                }

            }
        }

        // ----------- LEASE --------------------

        private void buttonAddLease_Click(object sender, EventArgs e)
        {
            if ((listBoxTenants.SelectedIndex > -1) && (listBoxProperties.SelectedIndex > -1))
            {
                int tenantID = -1;
                int propertyID = -1;


                // Get the Tenant Object, need the ID for Lease Object
                Tenant tenant = new Tenant();
                tenant = (Tenant)listBoxTenants.SelectedItem;

                tenantID = tenant.Id;
                tenant = SlumLordRentalSQL.getTenantFromID(tenantID, employeeEmail);

                // Get the Property object, need the ID
                Property property = new Property();
                property = (Property)listBoxProperties.SelectedItem;

                propertyID = property.Id;
                property = SlumLordRentalSQL.getPropertyFromID(propertyID, employeeEmail);

                Lease lease = new Lease();
                lease.PropertyID = property.Id;
                lease.TenantID = tenant.Id;

                FormLease addLease = new FormLease(lease, property, tenant);

                addLease.ShowDialog();

                if (addLease.DialogResult == DialogResult.OK)
                {
                    SlumLordRentalSQL.leaseInsert(lease, employeeEmail);
                    listBoxLeases.Items.Clear();
                    SlumLordRentalSQL.loadLeaseRecordsToListBox(listBoxLeases, 1, employeeEmail);
                }
            }
        }

        private void buttonEditLease_Click(object sender, EventArgs e)
        {
            int selectedLease = listBoxLeases.SelectedIndex;

            if (selectedLease > -1)
            {
                int propertyID = -1;
                int tenantID = -1;
                int leaseID = -1;

                Lease lease = new Lease();
                lease = (Lease)listBoxLeases.SelectedItem;
                leaseID = lease.Id;
                lease = SlumLordRentalSQL.getLeaseFromID(leaseID, employeeEmail);

                Property property = new Property();
                propertyID = lease.PropertyID;
                property = SlumLordRentalSQL.getPropertyFromID(propertyID, employeeEmail);

                Tenant tenant = new Tenant();
                tenantID = lease.TenantID;
                tenant = SlumLordRentalSQL.getTenantFromID(tenantID, employeeEmail);

                FormLease editLease = new FormLease(lease, property, tenant);

                editLease.ShowDialog();

                if (editLease.DialogResult == DialogResult.OK)
                {
                    SlumLordRentalSQL.leaseUpdate(lease, employeeEmail);
                    listBoxLeases.Items[selectedLease] = listBoxLeases.Items[selectedLease];
                    listBoxLeases.Items.Clear();
                    SlumLordRentalSQL.loadLeaseRecordsToListBox(listBoxLeases, 1, employeeEmail);
                }
            }
        }


    }
}
