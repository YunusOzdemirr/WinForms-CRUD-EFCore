namespace Mobility.PrimeThreadApp
{
    partial class PrimePageThread
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
            Thread2ListBox2 = new ListBox();
            ThreadPrime2 = new Button();
            SuspendLayout();
            // 
            // Thread2ListBox2
            // 
            Thread2ListBox2.FormattingEnabled = true;
            Thread2ListBox2.ItemHeight = 15;
            Thread2ListBox2.Location = new Point(280, 192);
            Thread2ListBox2.Name = "Thread2ListBox2";
            Thread2ListBox2.Size = new Size(240, 124);
            Thread2ListBox2.TabIndex = 8;
            Thread2ListBox2.SelectedIndexChanged += Thread2ListBox2_SelectedIndexChanged;
            // 
            // ThreadPrime2
            // 
            ThreadPrime2.Location = new Point(280, 135);
            ThreadPrime2.Name = "ThreadPrime2";
            ThreadPrime2.Size = new Size(240, 23);
            ThreadPrime2.TabIndex = 7;
            ThreadPrime2.Text = "ThreadPrime2";
            ThreadPrime2.UseVisualStyleBackColor = true;
            ThreadPrime2.Click += ThreadPrime2_Click;
            // 
            // PrimePageThread
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Thread2ListBox2);
            Controls.Add(ThreadPrime2);
            Name = "PrimePageThread";
            Text = "PrimePageThread";
            ResumeLayout(false);
        }

        #endregion

        private ListBox Thread2ListBox2;
        private Button ThreadPrime2;
    }
}