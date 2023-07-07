namespace MobilityApp.Pages.EfCore
{
    partial class EfCorePage
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
            Label SalaryLabel;
            Label MailAddressLabel;
            Label LastNameLabel;
            Label FirstName1;
            Label IdLabel;
            Label label1;
            Salary = new TextBox();
            MailAddress = new TextBox();
            LastName = new TextBox();
            FirstName = new TextBox();
            EF_Core_Crud = new Label();
            Delete = new Button();
            Update = new Button();
            Create = new Button();
            Id = new TextBox();
            EmployeesGrid = new DataGridView();
            Age = new TextBox();
            SalaryLabel = new Label();
            MailAddressLabel = new Label();
            LastNameLabel = new Label();
            FirstName1 = new Label();
            IdLabel = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)EmployeesGrid).BeginInit();
            SuspendLayout();
            // 
            // SalaryLabel
            // 
            SalaryLabel.AutoSize = true;
            SalaryLabel.CausesValidation = false;
            SalaryLabel.Location = new Point(574, 157);
            SalaryLabel.Name = "SalaryLabel";
            SalaryLabel.Size = new Size(38, 15);
            SalaryLabel.TabIndex = 15;
            SalaryLabel.Text = "Salary";
            SalaryLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // MailAddressLabel
            // 
            MailAddressLabel.AutoSize = true;
            MailAddressLabel.CausesValidation = false;
            MailAddressLabel.Location = new Point(574, 128);
            MailAddressLabel.Name = "MailAddressLabel";
            MailAddressLabel.Size = new Size(72, 15);
            MailAddressLabel.TabIndex = 13;
            MailAddressLabel.Text = "MailAddress";
            MailAddressLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.CausesValidation = false;
            LastNameLabel.Location = new Point(574, 99);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(60, 15);
            LastNameLabel.TabIndex = 11;
            LastNameLabel.Text = "LastName";
            LastNameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // FirstName1
            // 
            FirstName1.AutoSize = true;
            FirstName1.CausesValidation = false;
            FirstName1.Location = new Point(574, 70);
            FirstName1.Name = "FirstName1";
            FirstName1.Size = new Size(61, 15);
            FirstName1.TabIndex = 9;
            FirstName1.Text = "FirstName";
            FirstName1.TextAlign = ContentAlignment.TopCenter;
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.CausesValidation = false;
            IdLabel.Location = new Point(574, 41);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(17, 15);
            IdLabel.TabIndex = 22;
            IdLabel.Text = "Id";
            IdLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // Salary
            // 
            Salary.Location = new Point(672, 149);
            Salary.Name = "Salary";
            Salary.Size = new Size(100, 23);
            Salary.TabIndex = 14;
            Salary.TextChanged += Salary_TextChanged;
            // 
            // MailAddress
            // 
            MailAddress.Location = new Point(672, 120);
            MailAddress.Name = "MailAddress";
            MailAddress.Size = new Size(100, 23);
            MailAddress.TabIndex = 12;
            MailAddress.TextChanged += MailAddress_TextChanged;
            // 
            // LastName
            // 
            LastName.Location = new Point(672, 91);
            LastName.Name = "LastName";
            LastName.Size = new Size(100, 23);
            LastName.TabIndex = 10;
            LastName.TextChanged += LastName_TextChanged;
            // 
            // FirstName
            // 
            FirstName.Location = new Point(672, 62);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(100, 23);
            FirstName.TabIndex = 8;
            FirstName.TextChanged += FirstName_TextChanged;
            // 
            // EF_Core_Crud
            // 
            EF_Core_Crud.AutoSize = true;
            EF_Core_Crud.Location = new Point(14, 20);
            EF_Core_Crud.Name = "EF_Core_Crud";
            EF_Core_Crud.Size = new Size(81, 15);
            EF_Core_Crud.TabIndex = 20;
            EF_Core_Crud.Text = "EF Core CRUD";
            // 
            // Delete
            // 
            Delete.Location = new Point(574, 274);
            Delete.Name = "Delete";
            Delete.Size = new Size(198, 30);
            Delete.TabIndex = 19;
            Delete.Text = "Delete Employee";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Update
            // 
            Update.Location = new Point(672, 238);
            Update.Name = "Update";
            Update.Size = new Size(100, 30);
            Update.TabIndex = 18;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // Create
            // 
            Create.Location = new Point(574, 238);
            Create.Name = "Create";
            Create.Size = new Size(92, 30);
            Create.TabIndex = 16;
            Create.Text = "Create";
            Create.UseVisualStyleBackColor = true;
            Create.Click += Create_Click;
            // 
            // Id
            // 
            Id.Location = new Point(672, 33);
            Id.Name = "Id";
            Id.Size = new Size(100, 23);
            Id.TabIndex = 21;
            Id.TextChanged += Id_TextChanged;
            // 
            // EmployeesGrid
            // 
            EmployeesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeesGrid.Location = new Point(14, 62);
            EmployeesGrid.Name = "EmployeesGrid";
            EmployeesGrid.RowTemplate.Height = 25;
            EmployeesGrid.Size = new Size(507, 250);
            EmployeesGrid.TabIndex = 24;
            EmployeesGrid.CellContentClick += EmployeesGrid_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.CausesValidation = false;
            label1.Location = new Point(574, 197);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 26;
            label1.Text = "Age";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Age
            // 
            Age.Location = new Point(672, 189);
            Age.Name = "Age";
            Age.Size = new Size(100, 23);
            Age.TabIndex = 25;
            Age.TextChanged += Age_TextChanged;
            // 
            // EfCorePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Age);
            Controls.Add(EmployeesGrid);
            Controls.Add(IdLabel);
            Controls.Add(Id);
            Controls.Add(EF_Core_Crud);
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
            Name = "EfCorePage";
            Text = "EfCorePage";
            Load += EfCorePage_Load;
            ((System.ComponentModel.ISupportInitialize)EmployeesGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Salary;
        private TextBox MailAddress;
        private TextBox LastName;
        private TextBox FirstName;
        private Label EF_Core_Crud;
        private Button Delete;
        private Button Update;
        private Button Create;
        private TextBox Id;
        private DataGridView EmployeesGrid;
        private TextBox Age;
    }
}