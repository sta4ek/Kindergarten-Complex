using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KindergartenComplex.Manager_Forms.SickLeaves
{
    public partial class SickLeaveAddForm : Form
    {
        private DataTable _table;
        private readonly DataGridView _dataGridView;

        public SickLeaveAddForm(DataGridView dataGridView)
        {
            _dataGridView = dataGridView;

            InitializeComponent();

            Text += AppParameters.KindergartenName;

            FillComboBoxEmployee();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string[] paramsList = { GetEmployeeId(), dateTimePickerSickLeaveStart.Value.ToString(), dateTimePickerSickLeaveEnd.Value.ToString() };

            int rowId = SickLeaveController.AddSickLeave(paramsList);

            ((DataTable) _dataGridView.DataSource).Rows.Add(rowId, comboBoxEmployee.Text, dateTimePickerSickLeaveStart.Value,
                dateTimePickerSickLeaveEnd.Value);

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FillComboBoxEmployee()
        {
            using (SqlConnection connection = new SqlConnection(AppParameters.ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(@"SELECT Employees.Fullname, Employees.EmployeeId FROM Employees", connection);

                _table = new DataTable();
                da.Fill(_table);
                comboBoxEmployee.DataSource = _table;
                comboBoxEmployee.DisplayMember = _table.Columns[0].ColumnName;
            }
        }

        private string GetEmployeeId()
        {
            string employeeId = "";

            foreach (DataRow row in _table.Rows)
            {
                var cells = row.ItemArray;

                if (cells[0].ToString() == comboBoxEmployee.Text)
                {
                    employeeId = cells[1].ToString();
                    break;
                }
            }

            return employeeId;
        }

        private void dateTimePickerSickLeaveEnd_CloseUp(object sender, EventArgs e)
        {
            if (dateTimePickerSickLeaveEnd.Value < dateTimePickerSickLeaveStart.Value)
            {
                MessageBox.Show("Дата окончания больничного не может быть до даты начала!");
                dateTimePickerSickLeaveEnd.Value = dateTimePickerSickLeaveStart.Value;
            }
        }
    }
}
