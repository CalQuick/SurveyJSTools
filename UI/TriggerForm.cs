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
    public partial class TriggerForm : Form
    {
        private MainForm _sender;

        public TriggerForm(MainForm senderForm)
        {
            InitializeComponent();
            _sender = senderForm;
        }

        private void completedButton_Click(object sender, EventArgs e)
        {
            _sender.TriggerFormCompleted(triggerIdTextBox.Text);
            this.Close();
        }
    }
}
