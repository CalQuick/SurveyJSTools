using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;
using Library.Models;


namespace UI
{
    public partial class MainForm : Form
    {
        public QuestionProcessor QuestionProcessor { get; set; } = new QuestionProcessor();
        public TriggerProcessor TriggerProcessor { get; set; } = new TriggerProcessor();
        public ProcessingType ProcessingAction { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void createQuestionsButton_Click(object sender, EventArgs e)
        {
            ProcessingAction = ProcessingType.QuestionCreation;

            // Open up next form to get further information
            Form startingQuestionIdForm = new StartQuestionIdForm(this);
            startingQuestionIdForm.Show();
        }

        public void StartingQuestionIdFormComplete(string questionId, string panelId)
        {
            
            // Id format has been passed back. Continue to send to Library
            switch (ProcessingAction)
            {
                case ProcessingType.QuestionCreation:
                    outputTextBox.Text = QuestionProcessor.ValidateAndProcessQuestions(questionId, inputTextBox.Text);
                    break;
                case ProcessingType.PanelCreation:
                    outputTextBox.Text = QuestionProcessor.ValidateAndProcessPanels(questionId, panelId, inputTextBox.Text);
                    break;
                default:
                    break;
            }
            
        }

        public void TriggerFormCompleted(string triggerId)
        {
            switch (ProcessingAction)
            {
                case ProcessingType.TriggerCreation:
                    outputTextBox.Text = TriggerProcessor.ValidateAndProcessTriggers(triggerId, inputTextBox.Text);
                    break;
                default:
                    break;
            }
        }

        private void createTriggersButton_Click(object sender, EventArgs e)
        {
            ProcessingAction = ProcessingType.TriggerCreation;

            // Open up next form to get further information
            Form startingQuestionIdForm = new TriggerForm(this);
            startingQuestionIdForm.Show();

        }

        private void createPanelsButton_Click(object sender, EventArgs e)
        {
            ProcessingAction = ProcessingType.PanelCreation;

            // Open up next form to get further information
            Form startingQuestionIdForm = new StartQuestionIdForm(this);
            startingQuestionIdForm.Show();
        }
    }
}
