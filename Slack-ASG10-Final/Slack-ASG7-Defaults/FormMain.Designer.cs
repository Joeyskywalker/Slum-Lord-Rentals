namespace Slack_ASG7_Defaults
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonAddTenant = new System.Windows.Forms.Button();
            this.buttonEditTenant = new System.Windows.Forms.Button();
            this.listBoxTenants = new System.Windows.Forms.ListBox();
            this.menuStripDefaults = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxProperties = new System.Windows.Forms.ListBox();
            this.buttonEditProperty = new System.Windows.Forms.Button();
            this.buttonAddProperty = new System.Windows.Forms.Button();
            this.listBoxLeases = new System.Windows.Forms.ListBox();
            this.buttonEditLease = new System.Windows.Forms.Button();
            this.buttonAddLease = new System.Windows.Forms.Button();
            this.checkBoxActiveTenants = new System.Windows.Forms.CheckBox();
            this.checkBoxInactiveTenants = new System.Windows.Forms.CheckBox();
            this.checkBoxInactiveProperties = new System.Windows.Forms.CheckBox();
            this.checkBoxActiveProperties = new System.Windows.Forms.CheckBox();
            this.checkBoxInactiveLeases = new System.Windows.Forms.CheckBox();
            this.checkBoxActiveLeases = new System.Windows.Forms.CheckBox();
            this.menuStripDefaults.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddTenant
            // 
            this.buttonAddTenant.Location = new System.Drawing.Point(65, 278);
            this.buttonAddTenant.Name = "buttonAddTenant";
            this.buttonAddTenant.Size = new System.Drawing.Size(91, 29);
            this.buttonAddTenant.TabIndex = 1;
            this.buttonAddTenant.Text = "Add Tenant";
            this.buttonAddTenant.UseVisualStyleBackColor = true;
            this.buttonAddTenant.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEditTenant
            // 
            this.buttonEditTenant.Location = new System.Drawing.Point(201, 278);
            this.buttonEditTenant.Name = "buttonEditTenant";
            this.buttonEditTenant.Size = new System.Drawing.Size(89, 29);
            this.buttonEditTenant.TabIndex = 2;
            this.buttonEditTenant.Text = "Edit Tenant";
            this.buttonEditTenant.UseVisualStyleBackColor = true;
            this.buttonEditTenant.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // listBoxTenants
            // 
            this.listBoxTenants.FormattingEnabled = true;
            this.listBoxTenants.Location = new System.Drawing.Point(65, 64);
            this.listBoxTenants.Name = "listBoxTenants";
            this.listBoxTenants.Size = new System.Drawing.Size(225, 199);
            this.listBoxTenants.TabIndex = 3;
            // 
            // menuStripDefaults
            // 
            this.menuStripDefaults.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStripDefaults.Location = new System.Drawing.Point(0, 0);
            this.menuStripDefaults.Name = "menuStripDefaults";
            this.menuStripDefaults.Size = new System.Drawing.Size(876, 24);
            this.menuStripDefaults.TabIndex = 4;
            this.menuStripDefaults.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultsToolStripMenuItem,
            this.logToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // defaultsToolStripMenuItem
            // 
            this.defaultsToolStripMenuItem.Name = "defaultsToolStripMenuItem";
            this.defaultsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.defaultsToolStripMenuItem.Text = "Defaults";
            this.defaultsToolStripMenuItem.Click += new System.EventHandler(this.defaultsToolStripMenuItem_Click);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logToolStripMenuItem.Text = "Log";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // listBoxProperties
            // 
            this.listBoxProperties.FormattingEnabled = true;
            this.listBoxProperties.Location = new System.Drawing.Point(332, 64);
            this.listBoxProperties.Name = "listBoxProperties";
            this.listBoxProperties.Size = new System.Drawing.Size(225, 199);
            this.listBoxProperties.TabIndex = 7;
            // 
            // buttonEditProperty
            // 
            this.buttonEditProperty.Location = new System.Drawing.Point(468, 278);
            this.buttonEditProperty.Name = "buttonEditProperty";
            this.buttonEditProperty.Size = new System.Drawing.Size(89, 29);
            this.buttonEditProperty.TabIndex = 4;
            this.buttonEditProperty.Text = "Edit Property";
            this.buttonEditProperty.UseVisualStyleBackColor = true;
            this.buttonEditProperty.Click += new System.EventHandler(this.buttonEditProperty_Click);
            // 
            // buttonAddProperty
            // 
            this.buttonAddProperty.Location = new System.Drawing.Point(332, 278);
            this.buttonAddProperty.Name = "buttonAddProperty";
            this.buttonAddProperty.Size = new System.Drawing.Size(91, 29);
            this.buttonAddProperty.TabIndex = 3;
            this.buttonAddProperty.Text = "Add Property";
            this.buttonAddProperty.UseVisualStyleBackColor = true;
            this.buttonAddProperty.Click += new System.EventHandler(this.buttonAddProperty_Click);
            // 
            // listBoxLeases
            // 
            this.listBoxLeases.FormattingEnabled = true;
            this.listBoxLeases.Location = new System.Drawing.Point(597, 64);
            this.listBoxLeases.Name = "listBoxLeases";
            this.listBoxLeases.Size = new System.Drawing.Size(225, 199);
            this.listBoxLeases.TabIndex = 10;
            // 
            // buttonEditLease
            // 
            this.buttonEditLease.Location = new System.Drawing.Point(733, 278);
            this.buttonEditLease.Name = "buttonEditLease";
            this.buttonEditLease.Size = new System.Drawing.Size(89, 29);
            this.buttonEditLease.TabIndex = 6;
            this.buttonEditLease.Text = "Edit Lease";
            this.buttonEditLease.UseVisualStyleBackColor = true;
            this.buttonEditLease.Click += new System.EventHandler(this.buttonEditLease_Click);
            // 
            // buttonAddLease
            // 
            this.buttonAddLease.Location = new System.Drawing.Point(597, 278);
            this.buttonAddLease.Name = "buttonAddLease";
            this.buttonAddLease.Size = new System.Drawing.Size(91, 29);
            this.buttonAddLease.TabIndex = 5;
            this.buttonAddLease.Text = "Add Lease";
            this.buttonAddLease.UseVisualStyleBackColor = true;
            this.buttonAddLease.Click += new System.EventHandler(this.buttonAddLease_Click);
            // 
            // checkBoxActiveTenants
            // 
            this.checkBoxActiveTenants.AutoSize = true;
            this.checkBoxActiveTenants.Checked = true;
            this.checkBoxActiveTenants.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxActiveTenants.Location = new System.Drawing.Point(84, 41);
            this.checkBoxActiveTenants.Name = "checkBoxActiveTenants";
            this.checkBoxActiveTenants.Size = new System.Drawing.Size(56, 17);
            this.checkBoxActiveTenants.TabIndex = 11;
            this.checkBoxActiveTenants.Text = "Active";
            this.checkBoxActiveTenants.UseVisualStyleBackColor = true;
            this.checkBoxActiveTenants.Click += new System.EventHandler(this.checkBoxes_Click);
            // 
            // checkBoxInactiveTenants
            // 
            this.checkBoxInactiveTenants.AutoSize = true;
            this.checkBoxInactiveTenants.Location = new System.Drawing.Point(201, 41);
            this.checkBoxInactiveTenants.Name = "checkBoxInactiveTenants";
            this.checkBoxInactiveTenants.Size = new System.Drawing.Size(64, 17);
            this.checkBoxInactiveTenants.TabIndex = 12;
            this.checkBoxInactiveTenants.Text = "Inactive";
            this.checkBoxInactiveTenants.UseVisualStyleBackColor = true;
            this.checkBoxInactiveTenants.Click += new System.EventHandler(this.checkBoxes_Click);
            // 
            // checkBoxInactiveProperties
            // 
            this.checkBoxInactiveProperties.AutoSize = true;
            this.checkBoxInactiveProperties.Location = new System.Drawing.Point(471, 41);
            this.checkBoxInactiveProperties.Name = "checkBoxInactiveProperties";
            this.checkBoxInactiveProperties.Size = new System.Drawing.Size(64, 17);
            this.checkBoxInactiveProperties.TabIndex = 14;
            this.checkBoxInactiveProperties.Text = "Inactive";
            this.checkBoxInactiveProperties.UseVisualStyleBackColor = true;
            this.checkBoxInactiveProperties.Click += new System.EventHandler(this.checkBoxes_Click);
            // 
            // checkBoxActiveProperties
            // 
            this.checkBoxActiveProperties.AutoSize = true;
            this.checkBoxActiveProperties.Checked = true;
            this.checkBoxActiveProperties.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxActiveProperties.Location = new System.Drawing.Point(354, 41);
            this.checkBoxActiveProperties.Name = "checkBoxActiveProperties";
            this.checkBoxActiveProperties.Size = new System.Drawing.Size(56, 17);
            this.checkBoxActiveProperties.TabIndex = 13;
            this.checkBoxActiveProperties.Text = "Active";
            this.checkBoxActiveProperties.UseVisualStyleBackColor = true;
            this.checkBoxActiveProperties.Click += new System.EventHandler(this.checkBoxes_Click);
            // 
            // checkBoxInactiveLeases
            // 
            this.checkBoxInactiveLeases.AutoSize = true;
            this.checkBoxInactiveLeases.Location = new System.Drawing.Point(736, 41);
            this.checkBoxInactiveLeases.Name = "checkBoxInactiveLeases";
            this.checkBoxInactiveLeases.Size = new System.Drawing.Size(64, 17);
            this.checkBoxInactiveLeases.TabIndex = 16;
            this.checkBoxInactiveLeases.Text = "Inactive";
            this.checkBoxInactiveLeases.UseVisualStyleBackColor = true;
            this.checkBoxInactiveLeases.Click += new System.EventHandler(this.checkBoxes_Click);
            // 
            // checkBoxActiveLeases
            // 
            this.checkBoxActiveLeases.AutoSize = true;
            this.checkBoxActiveLeases.Checked = true;
            this.checkBoxActiveLeases.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxActiveLeases.Location = new System.Drawing.Point(619, 41);
            this.checkBoxActiveLeases.Name = "checkBoxActiveLeases";
            this.checkBoxActiveLeases.Size = new System.Drawing.Size(56, 17);
            this.checkBoxActiveLeases.TabIndex = 15;
            this.checkBoxActiveLeases.Text = "Active";
            this.checkBoxActiveLeases.UseVisualStyleBackColor = true;
            this.checkBoxActiveLeases.Click += new System.EventHandler(this.checkBoxes_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 340);
            this.Controls.Add(this.checkBoxInactiveLeases);
            this.Controls.Add(this.checkBoxActiveLeases);
            this.Controls.Add(this.checkBoxInactiveProperties);
            this.Controls.Add(this.checkBoxActiveProperties);
            this.Controls.Add(this.checkBoxInactiveTenants);
            this.Controls.Add(this.checkBoxActiveTenants);
            this.Controls.Add(this.listBoxLeases);
            this.Controls.Add(this.buttonEditLease);
            this.Controls.Add(this.buttonAddLease);
            this.Controls.Add(this.listBoxProperties);
            this.Controls.Add(this.buttonEditProperty);
            this.Controls.Add(this.buttonAddProperty);
            this.Controls.Add(this.listBoxTenants);
            this.Controls.Add(this.buttonEditTenant);
            this.Controls.Add(this.buttonAddTenant);
            this.Controls.Add(this.menuStripDefaults);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripDefaults;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slack-ASG7-Defaults";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripDefaults.ResumeLayout(false);
            this.menuStripDefaults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddTenant;
        private System.Windows.Forms.Button buttonEditTenant;
        private System.Windows.Forms.ListBox listBoxTenants;
        private System.Windows.Forms.MenuStrip menuStripDefaults;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultsToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxProperties;
        private System.Windows.Forms.Button buttonEditProperty;
        private System.Windows.Forms.Button buttonAddProperty;
        private System.Windows.Forms.ListBox listBoxLeases;
        private System.Windows.Forms.Button buttonEditLease;
        private System.Windows.Forms.Button buttonAddLease;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxActiveTenants;
        private System.Windows.Forms.CheckBox checkBoxInactiveTenants;
        private System.Windows.Forms.CheckBox checkBoxInactiveProperties;
        private System.Windows.Forms.CheckBox checkBoxActiveProperties;
        private System.Windows.Forms.CheckBox checkBoxInactiveLeases;
        private System.Windows.Forms.CheckBox checkBoxActiveLeases;
    }
}

