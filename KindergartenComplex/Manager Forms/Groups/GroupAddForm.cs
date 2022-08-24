using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KindergartenComplex.Manager_Forms.Groups
{
    public partial class GroupAddForm : Form
    {
        private DataTable _table;
        private readonly DataGridView _dataGridView;

        public GroupAddForm(DataGridView dataGridView)
        {
            _dataGridView = dataGridView;

            InitializeComponent();

            Text += AppParameters.KindergartenName;

            FillComboBoxEmployees();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string[] paramsList = { textBoxGroupName.Text, GetEmployeeId() };

            int rowId = GroupController.AddGroup(paramsList);

            ((DataTable)_dataGridView.DataSource).Rows.Add(rowId, textBoxGroupName.Text, comboBoxEmployee.Text);

            Close();
        }

        private void textBoxGroupName_TextChanged(object sender, EventArgs e)
        {
            buttonAdd.Enabled = textBoxGroupName.Text != "";
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
