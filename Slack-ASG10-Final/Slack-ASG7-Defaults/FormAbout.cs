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
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            labelVersion.Text = "Version: " + Application.ProductVersion.ToString();
        }

        private void buttonOK_MouseMove(object sender, MouseEventArgs e)
        {
            Random rand = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);

            int newX = rand.Next(220);
            int newY = rand.Next(220);

            buttonOK.Location = new Point (newX,newY);

        }

        private void FormAbout_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
