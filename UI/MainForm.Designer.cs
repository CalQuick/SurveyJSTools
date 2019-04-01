namespace UI
{
    partial class MainForm
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.createQuestionsButton = new System.Windows.Forms.Button();
            this.createTriggersButton = new System.Windows.Forms.Button();
            this.createPanelsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(18, 47);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputTextBox.Size = new System.Drawing.Size(1351, 338);
            this.inputTextBox.TabIndex = 1;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(12, 9);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(141, 35);
            this.inputLabel.TabIndex = 0;
            this.inputLabel.Text = "Input JSON";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(12, 489);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(162, 35);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "Output JSON";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(18, 527);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextBox.Size = new System.Drawing.Size(1351, 374);
            this.outputTextBox.TabIndex = 1;
            // 
            // createQuestionsButton
            // 
            this.createQuestionsButton.Location = new System.Drawing.Point(18, 407);
            this.createQuestionsButton.Name = "createQuestionsButton";
            this.createQuestionsButton.Size = new System.Drawing.Size(224, 49);
            this.createQuestionsButton.TabIndex = 2;
            this.createQuestionsButton.Text = "Create Questions";
            this.createQuestionsButton.UseVisualStyleBackColor = true;
            this.createQuestionsButton.Click += new System.EventHandler(this.createQuestionsButton_Click);
            // 
            // createTriggersButton
            // 
            this.createTriggersButton.Location = new System.Drawing.Point(478, 407);
            this.createTriggersButton.Name = "createTriggersButton";
            this.createTriggersButton.Size = new System.Drawing.Size(224, 49);
            this.createTriggersButton.TabIndex = 2;
            this.createTriggersButton.Text = "Create Triggers";
            this.createTriggersButton.UseVisualStyleBackColor = true;
            this.createTriggersButton.Click += new System.EventHandler(this.createTriggersButton_Click);
            // 
            // createPanelsButton
            // 
            this.createPanelsButton.Location = new System.Drawing.Point(248, 407);
            this.createPanelsButton.Name = "createPanelsButton";
            this.createPanelsButton.Size = new System.Drawing.Size(224, 49);
            this.createPanelsButton.TabIndex = 3;
            this.createPanelsButton.Text = "Create Panels";
            this.createPanelsButton.UseVisualStyleBackColor = true;
            this.createPanelsButton.Click += new System.EventHandler(this.createPanelsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 928);
            this.Controls.Add(this.createPanelsButton);
            this.Controls.Add(this.createTriggersButton);
            this.Controls.Add(this.createQuestionsButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabel);
            this.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MainForm";
            this.Text = "Create Question JSON";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button createQuestionsButton;
        private System.Windows.Forms.Button createTriggersButton;
        private System.Windows.Forms.Button createPanelsButton;
    }
}

