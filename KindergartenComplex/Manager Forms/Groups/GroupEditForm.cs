using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KindergartenComplex.Manager_Forms.Groups
{
    public partial class GroupEditForm : Form
    {
        private DataTable _table;
        private readonly DataGridViewRow _row;

        public GroupEditForm(DataGridViewRow row)
        {
            InitializeComponent();

            Text += AppParameters.KindergartenName;

            FillComboBoxEmployees();

            _row = row;

            textBoxGroupName.Text = _row.Cells[1].Value.ToString();
            comboBoxEmployee.Text = _row.Cells[2].Value.ToString();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxGroupName.Text == _row.Cells[1].Value.ToString() &&
                comboBoxEmployee.Text == _row.Cells[2].Value.ToString())
            {
                MessageBox.Show("Введённые данные не отличаются от данных в базе");
                return;
            }

            string[] paramsList = { textBoxGroupName.Text, GetEmployeeId(), _row.Cells[0].Value.ToString() };

            GroupController.EditGroup(paramsList);

            _row.Cells[1].Value = textBoxGroupName.Text;
            _row.Cells[2].Value = comboBoxEmployee.Text;

            Close();
        }

        private void textBoxGroupName_TextChanged(object sender, EventArgs e)
        {
            buttonEdit.Enabled = textBoxGroupName.Text != "";
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
