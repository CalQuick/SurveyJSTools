using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class StartQuestionIdForm : Form
    {
        private MainForm _senderForm;

        public StartQuestionIdForm(MainForm sender)
        {
            InitializeComponent();
            _senderForm = sender;
            if (_senderForm.ProcessingAction == ProcessingType.QuestionCreation)
            {
                PanelIdLabel.Hide();
                PanelIdTextBox.Hide();
            }
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            _senderForm.StartingQuestionIdFormComplete(QuestionIdTextBox.Text, PanelIdTextBox.Text);
            this.Close();
        }
    }
}
