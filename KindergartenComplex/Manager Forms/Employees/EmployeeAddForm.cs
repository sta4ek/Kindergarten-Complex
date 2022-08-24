using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KindergartenComplex.Manager_Forms.Employees
{
    public partial class EmployeeAddForm : Form
    {
        private DataTable _table;
        private readonly DataGridView _dataGridView;

        public EmployeeAddForm(DataGridView dataGridView)
        {
            _dataGridView = dataGridView;

            InitializeComponent();

            Text += AppParameters.KindergartenName;

            FillComboBoxEmployees();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string[] paramsList = { textBoxFullName.Text, GetPositionId(), dateTimePickerEmploymentDate.Value.ToString(), textBoxEducation.Text, textBoxQualification.Text, textBoxPhoneNumber.Text };

            int rowId = EmployeeController.AddEmployee(paramsList, comboBoxPosition.Text);

            ((DataTable)_dataGridView.DataSource).Rows.Add(rowId, textBoxFullName.Text, comboBoxPosition.Text, dateTimePickerEmploymentDate.Value, textBoxEducation.Text, textBoxQualification.Text, textBoxPhoneNumber.Text);

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxFullName_TextChanged(object sender, EventArgs e)
        {
            EmptinessTextBoxesCheck();
        }

        private void textBoxEducation_TextChanged(object sender, EventArgs e)
        {
            EmptinessTextBoxesCheck();
        }

        private void textBoxQualification_TextChanged(object sender, EventArgs e)
        {
            EmptinessTextBoxesCheck();
        }

        private void textBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            EmptinessTextBoxesCheck();
        }

        private void EmptinessTextBoxesCheck()
        {
            if (textBoxFullName.Text == "" || textBoxEducation.Text == "" || textBoxQualification.Text == "" || textBoxPhoneNumber.Text == "")
            {
                buttonAdd.Enabled = false;
            }
            else
            {
                buttonAdd.Enabled = true;
            }
        }

        private void FillComboBoxEmployees()
        {
            using (SqlConnection connection = new SqlConnection(AppParameters.ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(@"SELECT Positions.PositionName, Positions.PositionId FROM Positions", connection);

                _table = new DataTable();
                da.Fill(_table);
                comboBoxPosition.DataSource = _table;
                comboBoxPosition.DisplayMember = _table.Columns[0].ColumnName;
            }
        }

        private string GetPositionId()
        {
            string positionId = "";

            foreach (DataRow row in _table.Rows)
            {
                var cells = row.ItemArray;

                if (cells[0].ToString() == comboBoxPosition.Text)
                {
                    positionId = cells[1].ToString();
                    break;
                }
            }

            return positionId;
        }
    }
}
