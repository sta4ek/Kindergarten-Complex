using System;
using System.Windows.Forms;

namespace KindergartenComplex.Teacher_Forms.Methodical_Work
{
    public partial class MethodicalWorkEditForm : Form
    {
        private readonly DataGridViewRow _row;

        public MethodicalWorkEditForm(DataGridViewRow row)
        {
            _row = row;

            InitializeComponent();

            Text += AppParameters.KindergartenName;

            textBoxWorkSubject.Text = _row.Cells[1].Value.ToString();
            dateTimePickerWorkDay.Value = Convert.ToDateTime(_row.Cells[2].Value);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxWorkSubject.Text == _row.Cells[1].Value.ToString() &&
                dateTimePickerWorkDay.Value == Convert.ToDateTime(_row.Cells[2].Value))
            {
                MessageBox.Show("Введённые данные не отличаются от данных в базе");
                return;
            }

            string[] paramsList = { textBoxWorkSubject.Text, dateTimePickerWorkDay.Value.ToString(),  _row.Cells[0].Value.ToString() };

            MethodicalWorkController.EditMethodicalWork(paramsList);

            _row.Cells[1].Value = textBoxWorkSubject.Text;
            _row.Cells[2].Value = dateTimePickerWorkDay.Value;

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxWorkSubject_TextChanged(object sender, EventArgs e)
        {
            buttonEdit.Enabled = textBoxWorkSubject.Text != "";
        }
    }
}
