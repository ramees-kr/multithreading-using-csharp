namespace Fibonacci.Threads
{
    partial class Fibonacci
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
            btnGenerate = new Button();
            txtNumber = new TextBox();
            listBoxOutput = new ListBox();
            SuspendLayout();
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(258, 36);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(94, 29);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(20, 36);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(218, 27);
            txtNumber.TabIndex = 1;
            // 
            // listBoxOutput
            // 
            listBoxOutput.FormattingEnabled = true;
            listBoxOutput.ItemHeight = 20;
            listBoxOutput.Location = new Point(20, 90);
            listBoxOutput.Name = "listBoxOutput";
            listBoxOutput.Size = new Size(332, 344);
            listBoxOutput.TabIndex = 2;
            // 
            // Fibonacci
            // 
            AcceptButton = btnGenerate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 461);
            Controls.Add(listBoxOutput);
            Controls.Add(txtNumber);
            Controls.Add(btnGenerate);
            Name = "Fibonacci";
            Text = "Fibonacci";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerate;
        private TextBox txtNumber;
        private ListBox listBoxOutput;
    }
}