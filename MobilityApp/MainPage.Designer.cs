namespace MobilityApp
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EF_Core_Crud = new Label();
            External_Service = new Label();
            GoEfCore = new Button();
            GoExternalService = new Button();
            SuspendLayout();
            // 
            // EF_Core_Crud
            // 
            EF_Core_Crud.AutoSize = true;
            EF_Core_Crud.Location = new Point(191, 85);
            EF_Core_Crud.Name = "EF_Core_Crud";
            EF_Core_Crud.Size = new Size(81, 15);
            EF_Core_Crud.TabIndex = 8;
            EF_Core_Crud.Text = "EF Core CRUD";
            EF_Core_Crud.Click += EF_Core_Crud_Click;
            // 
            // External_Service
            // 
            External_Service.AutoSize = true;
            External_Service.Location = new Point(507, 85);
            External_Service.Name = "External_Service";
            External_Service.Size = new Size(123, 15);
            External_Service.TabIndex = 9;
            External_Service.Text = "External Service CRUD";
            External_Service.Click += External_Service_Click;
            // 
            // GoEfCore
            // 
            GoEfCore.Location = new Point(138, 140);
            GoEfCore.Name = "GoEfCore";
            GoEfCore.Size = new Size(205, 70);
            GoEfCore.TabIndex = 10;
            GoEfCore.Text = "Go EfCore";
            GoEfCore.UseVisualStyleBackColor = true;
            GoEfCore.Click += GoEfCore_Click;
            // 
            // GoExternalService
            // 
            GoExternalService.Location = new Point(470, 140);
            GoExternalService.Name = "GoExternalService";
            GoExternalService.Size = new Size(205, 70);
            GoExternalService.TabIndex = 11;
            GoExternalService.Text = "Go External Service";
            GoExternalService.UseVisualStyleBackColor = true;
            GoExternalService.Click += GoExternalService_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GoExternalService);
            Controls.Add(GoEfCore);
            Controls.Add(External_Service);
            Controls.Add(EF_Core_Crud);
            Name = "MainPage";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void UpdateExternal_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Label EF_Core_Crud;
        private Label External_Service;
        private Button GoEfCore;
        private Button GoExternalService;
    }
}