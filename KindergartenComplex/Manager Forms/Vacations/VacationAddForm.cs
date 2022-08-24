using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KindergartenComplex.Manager_Forms.Vacations
{
    public partial class VacationAddForm : Form
    {
        private DataTable _table;
        private readonly DataGridView _dataGridView;

        public VacationAddForm(DataGridView dataGridView)
        {
            _dataGridView = dataGridView;

            InitializeComponent();

            Text += AppParameters.KindergartenName;

            FillComboBoxEmployee();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string[] paramsList = { GetEmployeeId(), dateTimePickerVacationStart.Value.ToString(), dateTimePickerVacationEnd.Value.ToString() };

            int rowId = VacationController.AddVacation(paramsList);

            ((DataTable)_dataGridView.DataSource).Rows.Add(rowId, comboBoxEmployee.Text, dateTimePickerVacationStart.Value, dateTimePickerVacationEnd.Value);

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

        private void dateTimePickerVacationEnd_CloseUp(object sender, EventArgs e)
        {
            if (dateTimePickerVacationEnd.Value < dateTimePickerVacationStart.Value)
            {
                MessageBox.Show("Дата окончания отпуска не может быть до даты начала!");
                dateTimePickerVacationEnd.Value = dateTimePickerVacationStart.Value;
            }
        }
    }
}
