using System;
using System.Windows.Forms;

namespace KindergartenComplex.Manager_Forms.Control_Schedule
{
    public partial class ControlTopicEditForm : Form
    {
        private readonly DataGridViewRow _row;

        public ControlTopicEditForm(DataGridViewRow row)
        {
            _row = row;

            InitializeComponent();

            Text += AppParameters.KindergartenName;
            textBoxITopic.Text = _row.Cells[2].Value.ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxITopic.Text == _row.Cells[2].Value.ToString())
            {
                MessageBox.Show("Введённые данные не отличаются от данных в базе");
                return;
            }

            ControlTopicsController.EditTopic(textBoxITopic.Text, Convert.ToInt32(_row.Cells[0].Value));

            _row.Cells[2].Value = textBoxITopic.Text;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxITopic_TextChanged(object sender, EventArgs e)
        {
            buttonSave.Enabled = textBoxITopic.Text != "";
        }
    }
}
