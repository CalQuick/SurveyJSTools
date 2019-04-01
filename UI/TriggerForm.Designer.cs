namespace UI
{
    partial class TriggerForm
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
            this.triggerIdLabel = new System.Windows.Forms.Label();
            this.triggerIdTextBox = new System.Windows.Forms.TextBox();
            this.completedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // triggerIdLabel
            // 
            this.triggerIdLabel.AutoSize = true;
            this.triggerIdLabel.Location = new System.Drawing.Point(14, 9);
            this.triggerIdLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.triggerIdLabel.Name = "triggerIdLabel";
            this.triggerIdLabel.Size = new System.Drawing.Size(463, 35);
            this.triggerIdLabel.TabIndex = 0;
            this.triggerIdLabel.Text = "Input trigger numbers on different lines";
            // 
            // triggerIdTextBox
            // 
            this.triggerIdTextBox.Location = new System.Drawing.Point(20, 50);
            this.triggerIdTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.triggerIdTextBox.Multiline = true;
            this.triggerIdTextBox.Name = "triggerIdTextBox";
            this.triggerIdTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.triggerIdTextBox.Size = new System.Drawing.Size(684, 312);
            this.triggerIdTextBox.TabIndex = 1;
            // 
            // completedButton
            // 
            this.completedButton.Location = new System.Drawing.Point(283, 383);
            this.completedButton.Name = "completedButton";
            this.completedButton.Size = new System.Drawing.Size(162, 61);
            this.completedButton.TabIndex = 2;
            this.completedButton.Text = "Proceed";
            this.completedButton.UseVisualStyleBackColor = true;
            this.completedButton.Click += new System.EventHandler(this.completedButton_Click);
            // 
            // TriggerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 470);
            this.Controls.Add(this.completedButton);
            this.Controls.Add(this.triggerIdTextBox);
            this.Controls.Add(this.triggerIdLabel);
            this.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TriggerForm";
            this.Text = "TriggerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label triggerIdLabel;
        private System.Windows.Forms.TextBox triggerIdTextBox;
        private System.Windows.Forms.Button completedButton;
    }
}