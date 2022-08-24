using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace KindergartenComplex.Manager_Forms.User_Registration
{
    public partial class RegistrationForm : Form
    {
        private DataTable _table;

        public RegistrationForm()
        {
            InitializeComponent();

            Text += AppParameters.KindergartenName;

            FillComboBoxEmployees();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (RegistrationController.IsLoginAvailable(textBoxLogin.Text))
            {
                labelLoginIsNotAvailable.Visible = false;

                string[] paramsList = { textBoxLogin.Text, GetMd5Hash(textBoxPassword.Text), GetEmployeeId() };

                RegistrationController.RegisterUser(paramsList);

                paramsList[1] = textBoxPassword.Text;
                paramsList[2] = comboBoxEmployee.Text;

                var successForm = new SuccessForm(paramsList);
                successForm.ShowDialog();

                Close();
            }
            else
            {
                labelLoginIsNotAvailable.Visible = true;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FillComboBoxEmployees()
        {
            using (SqlConnection connection = new SqlConnection(AppParameters.ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(@"SELECT Tbl.Fullname, Tbl.EmployeeId FROM (SELECT Employees.Fullname, Employees.EmployeeId, ISNULL(Accounts.AccountId, -1) AS 'AccountId' FROM Employees LEFT JOIN Accounts ON Employees.EmployeeId = Accounts.EmployeeId) AS Tbl  WHERE Tbl.[AccountId] = -1", connection);

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

        private static string GetMd5Hash(string text)
        {
            using (var hashAlg = MD5.Create())
            {
                byte[] hash = hashAlg.ComputeHash(Encoding.UTF8.GetBytes(text));
                var builder = new StringBuilder(hash.Length * 2);
                foreach (var t in hash)
                {
                    builder.Append(t.ToString("X2"));
                }
                return builder.ToString();
            }
        }

        private void LogPassIsEmpty()
        {
            if (textBoxLogin.Text != "" && textBoxPassword.Text != "" && textBoxPasswordConfirmation.Text != "" && textBoxPassword.Text == textBoxPasswordConfirmation.Text)
            {
                buttonRegister.Enabled = true;
            }
            else
            {
                buttonRegister.Enabled = false;
            }
        }

        private void PasswordsMatching()
        {
            labelPasswordsAreNotMatching.Visible = textBoxPassword.Text != textBoxPasswordConfirmation.Text;
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            LogPassIsEmpty();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            LogPassIsEmpty();
            PasswordsMatching();
        }

        private void textBoxPasswordConfirmation_TextChanged(object sender, EventArgs e)
        {
            LogPassIsEmpty();
            PasswordsMatching();
        }
    }
}
