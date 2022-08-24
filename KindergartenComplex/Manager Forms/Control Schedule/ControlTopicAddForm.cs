using System;
using System.Windows.Forms;

namespace KindergartenComplex.Manager_Forms.Control_Schedule
{
    public partial class ControlTopicAddForm : Form
    {
        public ControlTopicAddForm()
        {
            InitializeComponent();

            Text += AppParameters.KindergartenName;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ControlTopicsController.AddTopic(textBoxITopic.Text);

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxITopic_TextChanged(object sender, EventArgs e)
        {
            buttonAdd.Enabled = textBoxITopic.Text != "";
        }
    }
}
