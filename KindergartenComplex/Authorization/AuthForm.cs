using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace KindergartenComplex
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(AppParameters.ConnectionString))
            {
                string sqlExpression = "SELECT Accounts.AccountId, EmplPos.Fullname, EmplPos.PositionName, " +
                                       "Accounts.EmployeeId FROM Accounts INNER JOIN (SELECT Employees.EmployeeId, Employees.Fullname, " +
                                       "Positions.PositionName FROM Employees INNER JOIN Positions ON Employees.PositionId = Positions.PositionId) AS " +
                                       "EmplPos ON Accounts.EmployeeId = EmplPos.EmployeeId WHERE Accounts.UserName = @userName AND Accounts.UserPassword = @password";

                try
                {
                    connection.Open();
                }
                catch (Exception)
                {
                    MessageBox.Show("Не удается подключиться к базе данных");
                    return;
                }

                SqlCommand command = new SqlCommand(sqlExpression, connection);

                command.Parameters.Add("@userName", SqlDbType.VarChar).Value = textBoxLogin.Text;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = GetMd5Hash(textBoxPassword.Text);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    labelPasswordWarning.Visible = false;

                    while (reader.Read())
                    {
                        object accountId = reader.GetValue(0);
                        object fullName = reader.GetValue(1);
                        object positionName = reader.GetValue(2);
                        object employeeId = reader.GetValue(3);

                        string posName = positionName.ToString().ToLower();

                        if (posName.Contains("заведующ"))
                        {
                            posName = "заведующий";
                        }

                        switch (posName)
                        {
                            case "заведующий":
                                Hide();
                                ManagerForm managerForm = new ManagerForm(Convert.ToInt32(accountId),
                                    fullName.ToString(), positionName.ToString());
                                managerForm.Show();
                                break;
                            case "воспитатель":
                                Hide();
                                TeacherForm teacherForm = new TeacherForm(Convert.ToInt32(accountId), fullName.ToString(),
                                    Convert.ToInt32(employeeId), positionName.ToString());
                                teacherForm.Show();
                                break;
                            default:
                                MessageBox.Show("Поддержки должности " + positionName + " на данный момент нет.");
                                break;
                        }
                    }
                }
                else
                {
                    labelPasswordWarning.Visible = true;
                }
            }
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
            if (textBoxLogin.Text != "" && textBoxPassword.Text != "")
            {
                buttonLogIn.Enabled = true;
            }
            else
            {
                buttonLogIn.Enabled = false;
            }
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            LogPassIsEmpty();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            LogPassIsEmpty();
        }

        private void AuthForm_VisibleChanged(object sender, EventArgs e)
        {
            textBoxPassword.Text = string.Empty;
            textBoxLogin.Text = string.Empty;
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            try
            {
                AppParameters.GetParameters();
            }
            catch (Exception)
            {
                MessageBox.Show("Файл parameters.xml повреждён или отсутствует");
                Close();
            }

            Text += AppParameters.KindergartenName;
            labelName.Text = AppParameters.KindergartenName;
        }
    }
}
