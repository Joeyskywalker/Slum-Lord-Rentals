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
    public partial class FormDefaults : Form
    {
        public FormDefaults()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
            Properties.Settings.Default.DefaultCity = textBoxCity.Text;
            Properties.Settings.Default.DefaultState = textBoxState.Text;
            Properties.Settings.Default.DefaultZip = textBoxZip.Text;
            Properties.Settings.Default.EmployeeEmail = textBoxEmaployeeEmail.Text;

            Properties.Settings.Default.Save();
            this.Close();


        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDefaults_Load(object sender, EventArgs e)
        {
            textBoxCity.Text = Properties.Settings.Default.DefaultCity;
            textBoxState.Text = Properties.Settings.Default.DefaultState;
            textBoxZip.Text = Properties.Settings.Default.DefaultZip;
            textBoxEmaployeeEmail.Text = Properties.Settings.Default.EmployeeEmail;
        }
    }
}
