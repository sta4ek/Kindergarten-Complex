using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KindergartenComplex.Manager_Forms.SickLeaves
{
    public partial class SickLeaveEditForm : Form
    {
        private DataTable _table;
        private readonly int _sickLeaveId;
        private readonly DataGridViewRow _row;

        public SickLeaveEditForm(DataGridViewRow row)
        {
            InitializeComponent();

            Text += AppParameters.KindergartenName;

            FillComboBoxEmployees();

            _row = row;
            _sickLeaveId = Convert.ToInt32(row.Cells[0].Value);

            comboBoxEmployee.Text = _row.Cells[1].Value.ToString();
            dateTimePickerSickLeaveStart.Value = Convert.ToDateTime(_row.Cells[2].Value);
            dateTimePickerSickLeaveEnd.Value = Convert.ToDateTime(_row.Cells[3].Value);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxEmployee.Text == _row.Cells[1].Value.ToString() &&
                dateTimePickerSickLeaveStart.Value == Convert.ToDateTime(_row.Cells[2].Value) &&
                dateTimePickerSickLeaveEnd.Value == Convert.ToDateTime(_row.Cells[3].Value))
            {
                MessageBox.Show("Введённые данные не отличаются от данных в базе");
                return;
            }

            string[] paramsList = { GetEmployeeId(), dateTimePickerSickLeaveStart.Value.ToString(), dateTimePickerSickLeaveEnd.Value.ToString(), _sickLeaveId.ToString() };

            SickLeaveController.EditSickLeave(paramsList);

            _row.Cells[1].Value = comboBoxEmployee.Text;
            _row.Cells[2].Value = dateTimePickerSickLeaveStart.Value;
            _row.Cells[3].Value = dateTimePickerSickLeaveEnd.Value;

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FillComboBoxEmployees()
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
