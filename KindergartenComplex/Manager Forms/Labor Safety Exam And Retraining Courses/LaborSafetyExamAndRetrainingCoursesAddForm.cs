using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KindergartenComplex.Manager_Forms.Labor_Safety_Exam
{
    public partial class LaborSafetyExamAndRetrainingCoursesAddForm : Form
    {
        private DataTable _table;
        private readonly bool _isExam;
        private readonly DataGridView _dataGridView;

        public LaborSafetyExamAndRetrainingCoursesAddForm(bool isExam, DataGridView dataGridView)
        {
            _dataGridView = dataGridView;
            _isExam = isExam;

            InitializeComponent();

            Text = _isExam ? "Экзамен по охране труда | " : "Курсовая переподготовка | ";
            Text += AppParameters.KindergartenName;

            FillComboBoxEmployees();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string[] paramsList = { GetEmployeeId(), dateTimePickerDate.Value.ToString() };

            int rowId = LaborSafetyExamAndRetrainingController.AddRow(paramsList, _isExam);

            ((DataTable)_dataGridView.DataSource).Rows.Add(rowId, comboBoxEmployee.Text, dateTimePickerDate.Value);

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
                SqlDataAdapter da = new SqlDataAdapter(@"SELECT Employees.Fullname, Employees.EmployeeId FROM Employees INNER JOIN Positions ON Employees.PositionId = Positions.PositionId WHERE Positions.PositionName = 'Воспитатель'", connection);

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
    }
}
