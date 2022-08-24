using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KindergartenComplex.Manager_Forms.Employees
{
    public partial class EmployeeEditForm : Form
    {
        private DataTable _table;
        private readonly int _employeeId;
        private readonly DataGridViewRow _row;

        public EmployeeEditForm(DataGridViewRow row)
        {
            InitializeComponent();

            Text += AppParameters.KindergartenName;

            FillComboBoxEmployees();

            _row = row;
            _employeeId = Convert.ToInt32(row.Cells[0].Value);

            textBoxFullName.Text = _row.Cells[1].Value.ToString();
            comboBoxPosition.Text = _row.Cells[2].Value.ToString();
            dateTimePickerEmploymentDate.Value = Convert.ToDateTime(_row.Cells[3].Value);
            textBoxEducation.Text = _row.Cells[4].Value.ToString();
            textBoxQualification.Text = _row.Cells[5].Value.ToString();
            textBoxPhoneNumber.Text = _row.Cells[6].Value.ToString();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxFullName.Text == _row.Cells[1].Value.ToString() && comboBoxPosition.Text == _row.Cells[2].Value.ToString() &&
                dateTimePickerEmploymentDate.Value == Convert.ToDateTime(_row.Cells[3].Value) &&
                textBoxEducation.Text == _row.Cells[4].Value.ToString() && textBoxQualification.Text == _row.Cells[5].Value.ToString() &&
                textBoxPhoneNumber.Text == _row.Cells[6].Value.ToString())
            {
                MessageBox.Show("Введённые данные не отличаются от данных в базе");
                return;
            }

            if (EmployeeController.IsAssignedToGroup(_employeeId))
            {
                MessageBox.Show("Воспитатель закреплён за группой");
                return;
            }

            string[] paramsList = { textBoxFullName.Text, GetPositionId(), dateTimePickerEmploymentDate.Value.ToString(), textBoxEducation.Text, textBoxQualification.Text, textBoxPhoneNumber.Text, _employeeId.ToString() };

            EmployeeController.EditEmployee(paramsList, _row.Cells[2].Value.ToString(), comboBoxPosition.Text);

            _row.Cells[1].Value = textBoxFullName.Text;
            _row.Cells[2].Value = comboBoxPosition.Text;
            _row.Cells[3].Value = dateTimePickerEmploymentDate.Value;
            _row.Cells[4].Value = textBoxEducation.Text;
            _row.Cells[5].Value = textBoxQualification.Text;
            _row.Cells[6].Value = textBoxPhoneNumber.Text;

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
                buttonEdit.Enabled = false;
            }
            else
            {
                buttonEdit.Enabled = true;
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
