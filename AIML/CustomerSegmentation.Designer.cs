namespace AI_using_ML
{
    partial class CustomerSegmentation
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
            this.components = new System.ComponentModel.Container();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtEditAppID = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtEditAppName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnApplicationAdd = new System.Windows.Forms.Button();
            this.DGApplications = new System.Windows.Forms.DataGridView();
            this.ApplicationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplicationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplicationType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabCustomers = new System.Windows.Forms.TabControl();
            this.tabPage_Customer = new System.Windows.Forms.TabPage();
            this.DGCustomers = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgUseDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InactivityPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoneySpent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_UpdateApplication = new System.Windows.Forms.TabPage();
            this.cmbAppType = new System.Windows.Forms.ComboBox();
            this.dtpreleaseDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAppName = new System.Windows.Forms.TextBox();
            this.BtnApplicationUpdate = new System.Windows.Forms.Button();
            this.BtnEditAppAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAppID = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.machineLearningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Interested = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Buyers = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGApplications)).BeginInit();
            this.TabCustomers.SuspendLayout();
            this.tabPage_Customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGCustomers)).BeginInit();
            this.tabPage_UpdateApplication.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // applicationBindingSource
            // 
            this.applicationBindingSource.DataMember = "Application";
            // 
            // txtEditAppID
            // 
            this.txtEditAppID.Location = new System.Drawing.Point(143, 19);
            this.txtEditAppID.Name = "txtEditAppID";
            this.txtEditAppID.Size = new System.Drawing.Size(599, 20);
            this.txtEditAppID.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(143, 56);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(599, 20);
            this.textBox3.TabIndex = 10;
            // 
            // txtEditAppName
            // 
            this.txtEditAppName.Location = new System.Drawing.Point(143, 56);
            this.txtEditAppName.Name = "txtEditAppName";
            this.txtEditAppName.Size = new System.Drawing.Size(599, 20);
            this.txtEditAppName.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(599, 20);
            this.textBox1.TabIndex = 6;
            // 
            // BtnApplicationAdd
            // 
            this.BtnApplicationAdd.Location = new System.Drawing.Point(123, 211);
            this.BtnApplicationAdd.Name = "BtnApplicationAdd";
            this.BtnApplicationAdd.Size = new System.Drawing.Size(113, 23);
            this.BtnApplicationAdd.TabIndex = 11;
            this.BtnApplicationAdd.Text = "Add";
            this.BtnApplicationAdd.UseVisualStyleBackColor = true;
            // 
            // DGApplications
            // 
            this.DGApplications.AllowUserToAddRows = false;
            this.DGApplications.AllowUserToDeleteRows = false;
            this.DGApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGApplications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ApplicationID,
            this.ApplicationName,
            this.ApplicationType,
            this.ReleaseDate,
            this.CustomerCount});
            this.DGApplications.Location = new System.Drawing.Point(3, 16);
            this.DGApplications.Name = "DGApplications";
            this.DGApplications.ReadOnly = true;
            this.DGApplications.Size = new System.Drawing.Size(762, 211);
            this.DGApplications.TabIndex = 1;
            this.DGApplications.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGApplications_CellClick);
            // 
            // ApplicationID
            // 
            this.ApplicationID.HeaderText = "ApplicationID";
            this.ApplicationID.Name = "ApplicationID";
            this.ApplicationID.ReadOnly = true;
            // 
            // ApplicationName
            // 
            this.ApplicationName.HeaderText = "Application Name";
            this.ApplicationName.Name = "ApplicationName";
            this.ApplicationName.ReadOnly = true;
            this.ApplicationName.Width = 140;
            // 
            // ApplicationType
            // 
            this.ApplicationType.HeaderText = "Application Type";
            this.ApplicationType.Name = "ApplicationType";
            this.ApplicationType.ReadOnly = true;
            this.ApplicationType.Width = 140;
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.HeaderText = "Release Date";
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.ReadOnly = true;
            this.ReleaseDate.Width = 140;
            // 
            // CustomerCount
            // 
            this.CustomerCount.HeaderText = "Nuber of Customers";
            this.CustomerCount.Name = "CustomerCount";
            this.CustomerCount.ReadOnly = true;
            this.CustomerCount.Width = 200;
            // 
            // TabCustomers
            // 
            this.TabCustomers.Controls.Add(this.tabPage_Customer);
            this.TabCustomers.Controls.Add(this.tabPage_UpdateApplication);
            this.TabCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabCustomers.Location = new System.Drawing.Point(3, 16);
            this.TabCustomers.Name = "TabCustomers";
            this.TabCustomers.SelectedIndex = 0;
            this.TabCustomers.Size = new System.Drawing.Size(756, 232);
            this.TabCustomers.TabIndex = 2;
            // 
            // tabPage_Customer
            // 
            this.tabPage_Customer.Controls.Add(this.DGCustomers);
            this.tabPage_Customer.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Customer.Name = "tabPage_Customer";
            this.tabPage_Customer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Customer.Size = new System.Drawing.Size(748, 206);
            this.tabPage_Customer.TabIndex = 0;
            this.tabPage_Customer.Text = "Customers";
            this.tabPage_Customer.UseVisualStyleBackColor = true;
            // 
            // DGCustomers
            // 
            this.DGCustomers.AllowUserToAddRows = false;
            this.DGCustomers.AllowUserToDeleteRows = false;
            this.DGCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.AccessCount,
            this.AvgUseDuration,
            this.Age,
            this.InactivityPeriod,
            this.MoneySpent});
            this.DGCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGCustomers.Location = new System.Drawing.Point(3, 3);
            this.DGCustomers.Name = "DGCustomers";
            this.DGCustomers.ReadOnly = true;
            this.DGCustomers.Size = new System.Drawing.Size(742, 200);
            this.DGCustomers.TabIndex = 0;
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // AccessCount
            // 
            this.AccessCount.HeaderText = "Access Count";
            this.AccessCount.Name = "AccessCount";
            this.AccessCount.ReadOnly = true;
            // 
            // AvgUseDuration
            // 
            this.AvgUseDuration.HeaderText = "Average Use Duration";
            this.AvgUseDuration.Name = "AvgUseDuration";
            this.AvgUseDuration.ReadOnly = true;
            this.AvgUseDuration.Width = 180;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // InactivityPeriod
            // 
            this.InactivityPeriod.HeaderText = "Inactivity Period";
            this.InactivityPeriod.Name = "InactivityPeriod";
            this.InactivityPeriod.ReadOnly = true;
            this.InactivityPeriod.Width = 130;
            // 
            // MoneySpent
            // 
            this.MoneySpent.HeaderText = "Money Spent";
            this.MoneySpent.Name = "MoneySpent";
            this.MoneySpent.ReadOnly = true;
            this.MoneySpent.Width = 120;
            // 
            // tabPage_UpdateApplication
            // 
            this.tabPage_UpdateApplication.Controls.Add(this.cmbAppType);
            this.tabPage_UpdateApplication.Controls.Add(this.dtpreleaseDate);
            this.tabPage_UpdateApplication.Controls.Add(this.label3);
            this.tabPage_UpdateApplication.Controls.Add(this.txtAppName);
            this.tabPage_UpdateApplication.Controls.Add(this.BtnApplicationUpdate);
            this.tabPage_UpdateApplication.Controls.Add(this.BtnEditAppAdd);
            this.tabPage_UpdateApplication.Controls.Add(this.label4);
            this.tabPage_UpdateApplication.Controls.Add(this.label2);
            this.tabPage_UpdateApplication.Controls.Add(this.txtAppID);
            this.tabPage_UpdateApplication.Controls.Add(this.lblLogin);
            this.tabPage_UpdateApplication.Location = new System.Drawing.Point(4, 22);
            this.tabPage_UpdateApplication.Name = "tabPage_UpdateApplication";
            this.tabPage_UpdateApplication.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_UpdateApplication.Size = new System.Drawing.Size(748, 206);
            this.tabPage_UpdateApplication.TabIndex = 1;
            this.tabPage_UpdateApplication.Text = "Edit Applications";
            this.tabPage_UpdateApplication.UseVisualStyleBackColor = true;
            // 
            // cmbAppType
            // 
            this.cmbAppType.FormattingEnabled = true;
            this.cmbAppType.Items.AddRange(new object[] {
            "Installable",
            "Online"});
            this.cmbAppType.Location = new System.Drawing.Point(135, 118);
            this.cmbAppType.Name = "cmbAppType";
            this.cmbAppType.Size = new System.Drawing.Size(599, 21);
            this.cmbAppType.TabIndex = 17;
            // 
            // dtpreleaseDate
            // 
            this.dtpreleaseDate.Location = new System.Drawing.Point(135, 168);
            this.dtpreleaseDate.Name = "dtpreleaseDate";
            this.dtpreleaseDate.Size = new System.Drawing.Size(211, 20);
            this.dtpreleaseDate.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Realease Date";
            // 
            // txtAppName
            // 
            this.txtAppName.Location = new System.Drawing.Point(135, 79);
            this.txtAppName.Name = "txtAppName";
            this.txtAppName.Size = new System.Drawing.Size(599, 20);
            this.txtAppName.TabIndex = 14;
            // 
            // BtnApplicationUpdate
            // 
            this.BtnApplicationUpdate.Location = new System.Drawing.Point(546, 165);
            this.BtnApplicationUpdate.Name = "BtnApplicationUpdate";
            this.BtnApplicationUpdate.Size = new System.Drawing.Size(188, 23);
            this.BtnApplicationUpdate.TabIndex = 13;
            this.BtnApplicationUpdate.Text = "Update";
            this.BtnApplicationUpdate.UseVisualStyleBackColor = true;
            this.BtnApplicationUpdate.Click += new System.EventHandler(this.BtnApplicationUpdate_Click);
            // 
            // BtnEditAppAdd
            // 
            this.BtnEditAppAdd.Location = new System.Drawing.Point(352, 165);
            this.BtnEditAppAdd.Name = "BtnEditAppAdd";
            this.BtnEditAppAdd.Size = new System.Drawing.Size(188, 23);
            this.BtnEditAppAdd.TabIndex = 11;
            this.BtnEditAppAdd.Text = "Add";
            this.BtnEditAppAdd.UseVisualStyleBackColor = true;
            this.BtnEditAppAdd.Click += new System.EventHandler(this.BtnApplicationAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Application Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Application Type";
            // 
            // txtAppID
            // 
            this.txtAppID.Location = new System.Drawing.Point(135, 42);
            this.txtAppID.Name = "txtAppID";
            this.txtAppID.Size = new System.Drawing.Size(599, 20);
            this.txtAppID.TabIndex = 4;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(11, 45);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(73, 13);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Application ID";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.machineLearningToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(768, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.addToolStripMenuItem.Text = "&Add";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem.Text = "&Update";
            // 
            // machineLearningToolStripMenuItem
            // 
            this.machineLearningToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_Interested,
            this.menuItem_Buyers});
            this.machineLearningToolStripMenuItem.Name = "machineLearningToolStripMenuItem";
            this.machineLearningToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.machineLearningToolStripMenuItem.Text = "&MachineLearning";
            // 
            // menuItem_Interested
            // 
            this.menuItem_Interested.Name = "menuItem_Interested";
            this.menuItem_Interested.Size = new System.Drawing.Size(152, 22);
            this.menuItem_Interested.Text = "&Interested";
            this.menuItem_Interested.Click += new System.EventHandler(this.menuItem_Interested_Click);
            // 
            // menuItem_Buyers
            // 
            this.menuItem_Buyers.Name = "menuItem_Buyers";
            this.menuItem_Buyers.Size = new System.Drawing.Size(152, 22);
            this.menuItem_Buyers.Text = "&Buyers";
            this.menuItem_Buyers.Click += new System.EventHandler(this.menuItem_Buyers_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 524);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(768, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGApplications);
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 240);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Applications";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TabCustomers);
            this.groupBox2.Location = new System.Drawing.Point(0, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(762, 251);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customers and Application Edit";
            // 
            // CustomerSegmentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 546);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "CustomerSegmentation";
            this.Text = "CustomerSegmentation";
            this.Load += new System.EventHandler(this.CustomerSegmentation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGApplications)).EndInit();
            this.TabCustomers.ResumeLayout(false);
            this.tabPage_Customer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGCustomers)).EndInit();
            this.tabPage_UpdateApplication.ResumeLayout(false);
            this.tabPage_UpdateApplication.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource applicationBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.TextBox txtEditAppID;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtEditAppName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnApplicationAdd;
        private System.Windows.Forms.DataGridView DGApplications;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerCount;
        private System.Windows.Forms.TabControl TabCustomers;
        private System.Windows.Forms.TabPage tabPage_Customer;
        private System.Windows.Forms.DataGridView DGCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgUseDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn InactivityPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoneySpent;
        private System.Windows.Forms.TabPage tabPage_UpdateApplication;
        private System.Windows.Forms.ComboBox cmbAppType;
        private System.Windows.Forms.DateTimePicker dtpreleaseDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAppName;
        private System.Windows.Forms.Button BtnApplicationUpdate;
        private System.Windows.Forms.Button BtnEditAppAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAppID;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem machineLearningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Interested;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Buyers;
    }
}