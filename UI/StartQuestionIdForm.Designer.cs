namespace UI
{
    partial class StartQuestionIdForm
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
            this.QuestionIdLabel = new System.Windows.Forms.Label();
            this.QuestionIdTextBox = new System.Windows.Forms.TextBox();
            this.continueButton = new System.Windows.Forms.Button();
            this.PanelIdLabel = new System.Windows.Forms.Label();
            this.PanelIdTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // QuestionIdLabel
            // 
            this.QuestionIdLabel.AutoSize = true;
            this.QuestionIdLabel.Location = new System.Drawing.Point(14, 9);
            this.QuestionIdLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.QuestionIdLabel.Name = "QuestionIdLabel";
            this.QuestionIdLabel.Size = new System.Drawing.Size(294, 35);
            this.QuestionIdLabel.TabIndex = 0;
            this.QuestionIdLabel.Text = "Question ID to start with";
            // 
            // QuestionIdTextBox
            // 
            this.QuestionIdTextBox.Location = new System.Drawing.Point(20, 60);
            this.QuestionIdTextBox.Name = "QuestionIdTextBox";
            this.QuestionIdTextBox.Size = new System.Drawing.Size(609, 40);
            this.QuestionIdTextBox.TabIndex = 1;
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(243, 221);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(165, 50);
            this.continueButton.TabIndex = 2;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // PanelIdLabel
            // 
            this.PanelIdLabel.AutoSize = true;
            this.PanelIdLabel.Location = new System.Drawing.Point(14, 115);
            this.PanelIdLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PanelIdLabel.Name = "PanelIdLabel";
            this.PanelIdLabel.Size = new System.Drawing.Size(250, 35);
            this.PanelIdLabel.TabIndex = 0;
            this.PanelIdLabel.Text = "Panel ID to start with";
            // 
            // PanelIdTextBox
            // 
            this.PanelIdTextBox.Location = new System.Drawing.Point(20, 166);
            this.PanelIdTextBox.Name = "PanelIdTextBox";
            this.PanelIdTextBox.Size = new System.Drawing.Size(609, 40);
            this.PanelIdTextBox.TabIndex = 1;
            // 
            // StartQuestionIdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 310);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.PanelIdTextBox);
            this.Controls.Add(this.QuestionIdTextBox);
            this.Controls.Add(this.PanelIdLabel);
            this.Controls.Add(this.QuestionIdLabel);
            this.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "StartQuestionIdForm";
            this.Text = "Question ID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuestionIdLabel;
        private System.Windows.Forms.TextBox QuestionIdTextBox;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Label PanelIdLabel;
        private System.Windows.Forms.TextBox PanelIdTextBox;
    }
}