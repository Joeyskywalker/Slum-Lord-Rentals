namespace Slack_ASG7_Defaults
{
    partial class FormProperty
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProperty));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxZip = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxOnsiteParking = new System.Windows.Forms.CheckBox();
            this.checkBoxOnsiteLaundry = new System.Windows.Forms.CheckBox();
            this.numericUpDownBedrooms = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownBathrooms = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerAvailableOn = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxAddedBy = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxDateUpdated = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxDateAdded = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxBrief = new System.Windows.Forms.TextBox();
            this.textBoxFull = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBedrooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBathrooms)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(113, 28);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(40, 20);
            this.textBoxId.TabIndex = 1;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxZip_TextChanged);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(113, 54);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(40, 20);
            this.textBoxAddress.TabIndex = 2;
            this.textBoxAddress.TextChanged += new System.EventHandler(this.textBoxZip_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(113, 80);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(40, 20);
            this.textBoxPrice.TabIndex = 3;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxZip_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price:";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(113, 106);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(40, 20);
            this.textBoxCity.TabIndex = 4;
            this.textBoxCity.TextChanged += new System.EventHandler(this.textBoxZip_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "City:";
            // 
            // textBoxState
            // 
            this.textBoxState.Location = new System.Drawing.Point(113, 132);
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(40, 20);
            this.textBoxState.TabIndex = 5;
            this.textBoxState.TextChanged += new System.EventHandler(this.textBoxZip_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "State:";
            // 
            // textBoxZip
            // 
            this.textBoxZip.Location = new System.Drawing.Point(113, 158);
            this.textBoxZip.Name = "textBoxZip";
            this.textBoxZip.Size = new System.Drawing.Size(40, 20);
            this.textBoxZip.TabIndex = 6;
            this.textBoxZip.TextChanged += new System.EventHandler(this.textBoxZip_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Zip:";
            // 
            // checkBoxOnsiteParking
            // 
            this.checkBoxOnsiteParking.AutoSize = true;
            this.checkBoxOnsiteParking.Location = new System.Drawing.Point(37, 294);
            this.checkBoxOnsiteParking.Name = "checkBoxOnsiteParking";
            this.checkBoxOnsiteParking.Size = new System.Drawing.Size(95, 17);
            this.checkBoxOnsiteParking.TabIndex = 11;
            this.checkBoxOnsiteParking.Text = "Onsite Parking";
            this.checkBoxOnsiteParking.UseVisualStyleBackColor = true;
            // 
            // checkBoxOnsiteLaundry
            // 
            this.checkBoxOnsiteLaundry.AutoSize = true;
            this.checkBoxOnsiteLaundry.Location = new System.Drawing.Point(138, 294);
            this.checkBoxOnsiteLaundry.Name = "checkBoxOnsiteLaundry";
            this.checkBoxOnsiteLaundry.Size = new System.Drawing.Size(97, 17);
            this.checkBoxOnsiteLaundry.TabIndex = 12;
            this.checkBoxOnsiteLaundry.Text = "Onsite Laundry";
            this.checkBoxOnsiteLaundry.UseVisualStyleBackColor = true;
            // 
            // numericUpDownBedrooms
            // 
            this.numericUpDownBedrooms.Location = new System.Drawing.Point(60, 347);
            this.numericUpDownBedrooms.Name = "numericUpDownBedrooms";
            this.numericUpDownBedrooms.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownBedrooms.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Bedrooms:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(158, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Bathrooms:";
            // 
            // numericUpDownBathrooms
            // 
            this.numericUpDownBathrooms.Location = new System.Drawing.Point(161, 347);
            this.numericUpDownBathrooms.Name = "numericUpDownBathrooms";
            this.numericUpDownBathrooms.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownBathrooms.TabIndex = 14;
            // 
            // dateTimePickerAvailableOn
            // 
            this.dateTimePickerAvailableOn.Location = new System.Drawing.Point(32, 396);
            this.dateTimePickerAvailableOn.Name = "dateTimePickerAvailableOn";
            this.dateTimePickerAvailableOn.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAvailableOn.TabIndex = 15;
            this.dateTimePickerAvailableOn.Value = new System.DateTime(2020, 6, 1, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(101, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Available On:";
            // 
            // textBoxAddedBy
            // 
            this.textBoxAddedBy.Enabled = false;
            this.textBoxAddedBy.Location = new System.Drawing.Point(113, 262);
            this.textBoxAddedBy.Name = "textBoxAddedBy";
            this.textBoxAddedBy.Size = new System.Drawing.Size(40, 20);
            this.textBoxAddedBy.TabIndex = 10;
            this.textBoxAddedBy.TextChanged += new System.EventHandler(this.textBoxZip_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Added by:";
            // 
            // textBoxDateUpdated
            // 
            this.textBoxDateUpdated.Enabled = false;
            this.textBoxDateUpdated.Location = new System.Drawing.Point(113, 236);
            this.textBoxDateUpdated.Name = "textBoxDateUpdated";
            this.textBoxDateUpdated.Size = new System.Drawing.Size(40, 20);
            this.textBoxDateUpdated.TabIndex = 9;
            this.textBoxDateUpdated.TextChanged += new System.EventHandler(this.textBoxZip_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Date Updated:";
            // 
            // textBoxDateAdded
            // 
            this.textBoxDateAdded.Enabled = false;
            this.textBoxDateAdded.Location = new System.Drawing.Point(113, 210);
            this.textBoxDateAdded.Name = "textBoxDateAdded";
            this.textBoxDateAdded.Size = new System.Drawing.Size(40, 20);
            this.textBoxDateAdded.TabIndex = 8;
            this.textBoxDateAdded.TextChanged += new System.EventHandler(this.textBoxZip_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Date Added:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 187);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Status:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(318, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Brief Description:";
            // 
            // textBoxBrief
            // 
            this.textBoxBrief.Location = new System.Drawing.Point(321, 50);
            this.textBoxBrief.Multiline = true;
            this.textBoxBrief.Name = "textBoxBrief";
            this.textBoxBrief.Size = new System.Drawing.Size(439, 39);
            this.textBoxBrief.TabIndex = 16;
            // 
            // textBoxFull
            // 
            this.textBoxFull.Location = new System.Drawing.Point(321, 132);
            this.textBoxFull.Multiline = true;
            this.textBoxFull.Name = "textBoxFull";
            this.textBoxFull.Size = new System.Drawing.Size(439, 261);
            this.textBoxFull.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(318, 109);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Full Description:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(321, 415);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 19;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(414, 415);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 20;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.comboBoxStatus.Location = new System.Drawing.Point(113, 183);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(79, 21);
            this.comboBoxStatus.TabIndex = 7;
            // 
            // FormProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxFull);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxBrief);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxAddedBy);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxDateUpdated);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxDateAdded);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePickerAvailableOn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDownBathrooms);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownBedrooms);
            this.Controls.Add(this.checkBoxOnsiteLaundry);
            this.Controls.Add(this.checkBoxOnsiteParking);
            this.Controls.Add(this.textBoxZip);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProperty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Property";
            this.Load += new System.EventHandler(this.FormProperty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBedrooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBathrooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxZip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxOnsiteParking;
        private System.Windows.Forms.CheckBox checkBoxOnsiteLaundry;
        private System.Windows.Forms.NumericUpDown numericUpDownBedrooms;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownBathrooms;
        private System.Windows.Forms.DateTimePicker dateTimePickerAvailableOn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxAddedBy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxDateUpdated;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxDateAdded;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxBrief;
        private System.Windows.Forms.TextBox textBoxFull;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxStatus;
    }
}