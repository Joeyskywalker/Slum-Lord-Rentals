using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slack_ASG7_Defaults
{
    public class logItem
    {
        private string tableName;
        private int recordID;
        private string changeType;
        private DateTime dateCreated;


        public string TableName { get => tableName; set => tableName = value; }
        public int RecordID { get => recordID; set => recordID = value; }
        public string ChangeType { get => changeType; set => changeType = value; }
        public DateTime DateCreated { get => dateCreated; set => dateCreated = value; }

        public logItem()
        {

        }


        public override string ToString()
        {
            string result = "";

            result = "Table: " + this.TableName + " Record: " + this.RecordID.ToString() + " Change Type: " + this.ChangeType + " Date: " + this.DateCreated.ToString() ;

            return result;
        }

        public void resizeTextBox(object sender)
        {
            TextBox textbox = (TextBox)sender;
            textbox.Width = (textbox.Text.Length) * 8;

            if (textbox.Width < 40)
            {
                textbox.Width = 40;
            }
            else if(textbox.Width > 140)
            {
                textbox.Width = 140;
            }

        }
    }
}
