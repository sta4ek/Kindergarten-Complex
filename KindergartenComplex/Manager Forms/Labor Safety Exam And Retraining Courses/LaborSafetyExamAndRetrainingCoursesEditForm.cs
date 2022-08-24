using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KindergartenComplex.Manager_Forms.Labor_Safety_Exam
{
    public partial class LaborSafetyExamAndRetrainingCoursesEditForm : Form
    {
        private readonly DataGridViewRow _row;
        private DataTable _table;
        private bool _isExam;

        public LaborSafetyExamAndRetrainingCoursesEditForm(DataGridViewRow row, bool isExam)
        {
            _row = row;
            _isExam = isExam;

            InitializeComponent();

            Text = _isExam ? "Экзамен по охране труда | " : "Курсовая переподготовка | ";
            Text += AppParameters.KindergartenName;

            FillComboBoxEmployees();

            comboBoxEmployee.Text = _row.Cells[1].Value.ToString();
            dateTimePickerDate.Value = Convert.ToDateTime(_row.Cells[2].Value);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxEmployee.Text == _row.Cells[1].Value.ToString() &&
                dateTimePickerDate.Value == Convert.ToDateTime(_row.Cells[2].Value))
            {
                MessageBox.Show("Введённые данные не отличаются от данных в базе");
                return;
            }

            string[] paramsList = { GetEmployeeId(), dateTimePickerDate.Value.ToString(), _row.Cells[0].Value.ToString() };

            LaborSafetyExamAndRetrainingController.EditRow(paramsList, _isExam);

                _row.Cells[1].Value = comboBoxEmployee.Text;
            _row.Cells[2].Value = dateTimePickerDate.Value;

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
