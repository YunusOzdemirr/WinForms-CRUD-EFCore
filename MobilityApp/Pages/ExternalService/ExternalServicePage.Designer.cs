namespace MobilityApp.Pages.ExternalService
{
    partial class ExternalServicePage
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
            Label IdLabel;
            Label SalaryLabel;
            Label MailAddressLabel;
            Label LastNameLabel;
            Label FirstName1;
            EmployeesGrid = new DataGridView();
            Id = new TextBox();
            ExternalServiceCrud = new Label();
            Delete = new Button();
            Update = new Button();
            Create = new Button();
            Salary = new TextBox();
            MailAddress = new TextBox();
            LastName = new TextBox();
            FirstName = new TextBox();
            IdLabel = new Label();
            SalaryLabel = new Label();
            MailAddressLabel = new Label();
            LastNameLabel = new Label();
            FirstName1 = new Label();
            ((System.ComponentModel.ISupportInitialize)EmployeesGrid).BeginInit();
            SuspendLayout();
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.CausesValidation = false;
            IdLabel.Location = new Point(572, 32);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(17, 15);
            IdLabel.TabIndex = 38;
            IdLabel.Text = "Id";
            IdLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // SalaryLabel
            // 
            SalaryLabel.AutoSize = true;
            SalaryLabel.CausesValidation = false;
            SalaryLabel.Location = new Point(572, 148);
            SalaryLabel.Name = "SalaryLabel";
            SalaryLabel.Size = new Size(38, 15);
            SalaryLabel.TabIndex = 32;
            SalaryLabel.Text = "Salary";
            SalaryLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // MailAddressLabel
            // 
            MailAddressLabel.AutoSize = true;
            MailAddressLabel.CausesValidation = false;
            MailAddressLabel.Location = new Point(572, 119);
            MailAddressLabel.Name = "MailAddressLabel";
            MailAddressLabel.Size = new Size(72, 15);
            MailAddressLabel.TabIndex = 30;
            MailAddressLabel.Text = "MailAddress";
            MailAddressLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.CausesValidation = false;
            LastNameLabel.Location = new Point(572, 90);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(60, 15);
            LastNameLabel.TabIndex = 28;
            LastNameLabel.Text = "LastName";
            LastNameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // FirstName1
            // 
            FirstName1.AutoSize = true;
            FirstName1.CausesValidation = false;
            FirstName1.Location = new Point(572, 61);
            FirstName1.Name = "FirstName1";
            FirstName1.Size = new Size(61, 15);
            FirstName1.TabIndex = 26;
            FirstName1.Text = "FirstName";
            FirstName1.TextAlign = ContentAlignment.TopCenter;
            // 
            // EmployeesGrid
            // 
            EmployeesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeesGrid.Location = new Point(12, 43);
            EmployeesGrid.Name = "EmployeesGrid";
            EmployeesGrid.RowTemplate.Height = 25;
            EmployeesGrid.Size = new Size(507, 244);
            EmployeesGrid.TabIndex = 39;
            EmployeesGrid.CellContentClick += EmployeesGrid_CellContentClick;
            // 
            // Id
            // 
            Id.Location = new Point(670, 24);
            Id.Name = "Id";
            Id.Size = new Size(100, 23);
            Id.TabIndex = 37;
            // 
            // ExternalServiceCrud
            // 
            ExternalServiceCrud.AutoSize = true;
            ExternalServiceCrud.Location = new Point(12, 11);
            ExternalServiceCrud.Name = "ExternalServiceCrud";
            ExternalServiceCrud.Size = new Size(112, 15);
            ExternalServiceCrud.TabIndex = 36;
            ExternalServiceCrud.Text = "ExternalServiceCrud";
            // 
            // Delete
            // 
            Delete.Location = new Point(572, 215);
            Delete.Name = "Delete";
            Delete.Size = new Size(198, 30);
            Delete.TabIndex = 35;
            Delete.Text = "Delete Employee";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Update
            // 
            Update.Location = new Point(670, 179);
            Update.Name = "Update";
            Update.Size = new Size(100, 30);
            Update.TabIndex = 34;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // Create
            // 
            Create.Location = new Point(572, 179);
            Create.Name = "Create";
            Create.Size = new Size(92, 30);
            Create.TabIndex = 33;
            Create.Text = "Create";
            Create.UseVisualStyleBackColor = true;
            Create.Click += Create_Click;
            // 
            // Salary
            // 
            Salary.Location = new Point(670, 140);
            Salary.Name = "Salary";
            Salary.Size = new Size(100, 23);
            Salary.TabIndex = 31;
            // 
            // MailAddress
            // 
            MailAddress.Location = new Point(670, 111);
            MailAddress.Name = "MailAddress";
            MailAddress.Size = new Size(100, 23);
            MailAddress.TabIndex = 29;
            // 
            // LastName
            // 
            LastName.Location = new Point(670, 82);
            LastName.Name = "LastName";
            LastName.Size = new Size(100, 23);
            LastName.TabIndex = 27;
            // 
            // FirstName
            // 
            FirstName.Location = new Point(670, 53);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(100, 23);
            FirstName.TabIndex = 25;
            // 
            // ExternalServicePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EmployeesGrid);
            Controls.Add(IdLabel);
            Controls.Add(Id);
            Controls.Add(ExternalServiceCrud);
            Controls.Add(Delete);
            Controls.Add(Update);
            Controls.Add(Create);
            Controls.Add(SalaryLabel);
            Controls.Add(Salary);
            Controls.Add(MailAddressLabel);
            Controls.Add(MailAddress);
            Controls.Add(LastNameLabel);
            Controls.Add(LastName);
            Controls.Add(FirstName1);
            Controls.Add(FirstName);
            Name = "ExternalServicePage";
            Text = "ExternalServicePage";
            Load += ExternalServicePage_Load;
            ((System.ComponentModel.ISupportInitialize)EmployeesGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView EmployeesGrid;
        private TextBox Id;
        private Label ExternalServiceCrud;
        private Button Delete;
        private Button Update;
        private Button Create;
        private TextBox Salary;
        private TextBox MailAddress;
        private TextBox LastName;
        private TextBox FirstName;
    }
}