using System;
using System.Data;
using System.Windows.Forms;

namespace KindergartenComplex.Teacher_Forms.Methodical_Work
{
    public partial class MethodicalWorkAddForm : Form
    {
        private readonly int _employeeId;
        private readonly DataGridView _dataGridView;

        public MethodicalWorkAddForm(int employeeId, DataGridView dataGridView)
        {
            _dataGridView = dataGridView;
            _employeeId = employeeId;

            InitializeComponent();

            Text += AppParameters.KindergartenName;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string[] paramsList = { textBoxWorkSubject.Text, dateTimePickerWorkDay.Value.ToString(), _employeeId.ToString() };

            int rowId = MethodicalWorkController.AddMethodicalWork(paramsList);

            ((DataTable)_dataGridView.DataSource).Rows.Add(rowId, textBoxWorkSubject.Text, dateTimePickerWorkDay.Value);

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxWorkSubject_TextChanged(object sender, EventArgs e)
        {
            buttonAdd.Enabled = textBoxWorkSubject.Text != "";
        }
    }
}
