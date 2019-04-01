namespace UI
{
    partial class StartingQuestionIdForm
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
            this.startingNumTextBox = new System.Windows.Forms.TextBox();
            this.startingNumLabel = new System.Windows.Forms.Label();
            this.continueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startingNumTextBox
            // 
            this.startingNumTextBox.Location = new System.Drawing.Point(19, 54);
            this.startingNumTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.startingNumTextBox.Name = "startingNumTextBox";
            this.startingNumTextBox.Size = new System.Drawing.Size(595, 40);
            this.startingNumTextBox.TabIndex = 0;
            // 
            // startingNumLabel
            // 
            this.startingNumLabel.AutoSize = true;
            this.startingNumLabel.Location = new System.Drawing.Point(13, 13);
            this.startingNumLabel.Name = "startingNumLabel";
            this.startingNumLabel.Size = new System.Drawing.Size(601, 35);
            this.startingNumLabel.TabIndex = 1;
            this.startingNumLabel.Text = "What is the question id that you\'d like to start with?";
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(235, 116);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(163, 61);
            this.continueButton.TabIndex = 2;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            // 
            // StartingQuestionIdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 189);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.startingNumLabel);
            this.Controls.Add(this.startingNumTextBox);
            this.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "StartingQuestionIdForm";
            this.Text = "StartingQuestionIdForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox startingNumTextBox;
        private System.Windows.Forms.Label startingNumLabel;
        private System.Windows.Forms.Button continueButton;
    }
}