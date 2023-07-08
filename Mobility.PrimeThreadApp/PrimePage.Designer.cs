namespace Mobility.PrimeThreadApp
{
    partial class PrimePage
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
            ThreadPrime1 = new Button();
            ThreadPrime2 = new Button();
            Reset = new Button();
            Thread1ListBox1 = new ListBox();
            Thread2ListBox2 = new ListBox();
            txtThread1 = new TextBox();
            txtThread2 = new TextBox();
            SuspendLayout();
            // 
            // ThreadPrime1
            // 
            ThreadPrime1.Location = new Point(126, 261);
            ThreadPrime1.Name = "ThreadPrime1";
            ThreadPrime1.Size = new Size(240, 23);
            ThreadPrime1.TabIndex = 0;
            ThreadPrime1.Text = "ThreadPrime1";
            ThreadPrime1.UseVisualStyleBackColor = true;
            ThreadPrime1.Click += ThreadPrime1_Click;
            // 
            // ThreadPrime2
            // 
            ThreadPrime2.Location = new Point(468, 261);
            ThreadPrime2.Name = "ThreadPrime2";
            ThreadPrime2.Size = new Size(240, 23);
            ThreadPrime2.TabIndex = 1;
            ThreadPrime2.Text = "ThreadPrime2";
            ThreadPrime2.UseVisualStyleBackColor = true;
            ThreadPrime2.Click += ThreadPrime2_Click;
            // 
            // Reset
            // 
            Reset.Location = new Point(297, 351);
            Reset.Name = "Reset";
            Reset.Size = new Size(237, 45);
            Reset.TabIndex = 4;
            Reset.Text = "Reset";
            Reset.UseVisualStyleBackColor = true;
            Reset.Click += Reset_Click;
            // 
            // Thread1ListBox1
            // 
            Thread1ListBox1.FormattingEnabled = true;
            Thread1ListBox1.ItemHeight = 15;
            Thread1ListBox1.Location = new Point(126, 131);
            Thread1ListBox1.Name = "Thread1ListBox1";
            Thread1ListBox1.Size = new Size(240, 124);
            Thread1ListBox1.TabIndex = 5;
            // 
            // Thread2ListBox2
            // 
            Thread2ListBox2.FormattingEnabled = true;
            Thread2ListBox2.ItemHeight = 15;
            Thread2ListBox2.Location = new Point(468, 131);
            Thread2ListBox2.Name = "Thread2ListBox2";
            Thread2ListBox2.Size = new Size(240, 124);
            Thread2ListBox2.TabIndex = 6;
            Thread2ListBox2.SelectedIndexChanged += Thread2ListBox2_SelectedIndexChanged;
            // 
            // txtThread1
            // 
            txtThread1.Location = new Point(126, 102);
            txtThread1.Name = "txtThread1";
            txtThread1.Size = new Size(240, 23);
            txtThread1.TabIndex = 7;
            txtThread1.TextChanged += txtThread1_TextChanged;
            // 
            // txtThread2
            // 
            txtThread2.Location = new Point(468, 102);
            txtThread2.Name = "txtThread2";
            txtThread2.Size = new Size(240, 23);
            txtThread2.TabIndex = 8;
            txtThread2.TextChanged += txtThread2_TextChanged;
            // 
            // PrimePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtThread2);
            Controls.Add(txtThread1);
            Controls.Add(Thread2ListBox2);
            Controls.Add(Thread1ListBox1);
            Controls.Add(Reset);
            Controls.Add(ThreadPrime2);
            Controls.Add(ThreadPrime1);
            Name = "PrimePage";
            Text = "PrimePage";
            Load += PrimePage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ThreadPrime1;
        private Button ThreadPrime2;
        private Button Reset;
        private TextBox txtThread1;
        private TextBox txtThread2;
        private ListBox Thread1ListBox1;
        private ListBox Thread2ListBox2;
    }
}