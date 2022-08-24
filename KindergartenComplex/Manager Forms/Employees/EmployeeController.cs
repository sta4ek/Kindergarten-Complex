using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KindergartenComplex.Manager_Forms.Employees
{
    internal static class EmployeeController
    {
        public static void DeleteEmployee(DataGridView dataGridViewTable)
        {
            DialogResult dialogResult = MessageBox.Show("Удалить " + dataGridViewTable.SelectedRows.Count + " запись(ей)",
                "Удаление сотрудника", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(AppParameters.ConnectionString);
                con.Open();

                foreach (DataGridViewRow row in dataGridViewTable.SelectedRows)
                {
                    string sql = "SELECT Groups.GroupName FROM Groups WHERE Groups.EmployeeId = @employeeId";

                    SqlCommand command = con.CreateCommand();
                    command.CommandText = sql;

                    command.Parameters.Add("@employeeId", SqlDbType.BigInt).Value = Convert.ToInt32(row.Cells[0].Value);

                    var groupName = command.ExecuteScalar();

                    if (groupName != null)
                    {
                        MessageBox.Show(
                            "Невозможно удалить сотрудника \"" + row.Cells[1].Value +
                            "\", так как он является воспитателем группы \"" + groupName +
                            "\". Смените воспитателя и попробуйте снова.", "Удаление сотрудника", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        string sqlDel = "DELETE FROM Employees WHERE Employees.EmployeeId = @employeeId";

                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandText = sqlDel;

                        cmd.Parameters.Add("@employeeId", SqlDbType.BigInt).Value = row.Cells[0].Value.ToString();

                        int rowCount = cmd.ExecuteNonQuery();

                        sqlDel = "DELETE FROM ControlSchedule WHERE ControlSchedule.EmployeeId = @employeeId";

                        cmd = con.CreateCommand();
                        cmd.CommandText = sqlDel;

                        cmd.Parameters.Add("@employeeId", SqlDbType.BigInt).Value = row.Cells[0].Value.ToString();

                        rowCount = cmd.ExecuteNonQuery();

                        dataGridViewTable.Rows.Remove(row);
                    }
                }

                con.Close();
            }
        }

        public static int AddEmployee(string[] paramsList, string positionName)
        {
            SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
            connection.Open();

            string sql = "INSERT INTO Employees(Fullname, PositionId, EmploymentDate, Education, Qualification, PhoneNumber) VALUES(@fullName, @positionId, @employmentDate, @education, @qualification, @phoneNumber) SELECT SCOPE_IDENTITY()";

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add("@fullName", SqlDbType.VarChar).Value = paramsList[0];
            cmd.Parameters.Add("@positionId", SqlDbType.BigInt).Value = Convert.ToInt32(paramsList[1]);
            cmd.Parameters.Add("@employmentDate", SqlDbType.Date).Value = Convert.ToDateTime(paramsList[2]);
            cmd.Parameters.Add("@education", SqlDbType.VarChar).Value = paramsList[3];
            cmd.Parameters.Add("@qualification", SqlDbType.VarChar).Value = paramsList[4];
            cmd.Parameters.Add("@phoneNumber", SqlDbType.VarChar).Value = paramsList[5];

            int employeeId = Convert.ToInt32(cmd.ExecuteScalar());

            if (positionName.ToLower() == "воспитатель")
            {
                sql = "INSERT INTO ControlSchedule(EmployeeId, Fullname) VALUES(@employeeId, @fullname)";

                cmd = connection.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.Add("@employeeId", SqlDbType.BigInt).Value = employeeId;
                cmd.Parameters.Add("@fullname", SqlDbType.VarChar).Value = paramsList[0];

                int rowCount = cmd.ExecuteNonQuery();
            }

            connection.Close();

            return employeeId;
        }

        public static void EditEmployee(string[] paramsList, string oldPosition, string newPosition)
        {
            SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
            connection.Open();

            string sql = "UPDATE Employees SET Employees.Fullname = @fullName, Employees.PositionId = @positionId, Employees.EmploymentDate = @employmentDate, Employees.Education = @education, Employees.Qualification = @qualification, Employees.PhoneNumber = @phoneNumber WHERE Employees.EmployeeId = @employeeId";

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add("@fullName", SqlDbType.VarChar).Value = paramsList[0];
            cmd.Parameters.Add("@positionId", SqlDbType.BigInt).Value = Convert.ToInt32(paramsList[1]);
            cmd.Parameters.Add("@employmentDate", SqlDbType.Date).Value = Convert.ToDateTime(paramsList[2]);
            cmd.Parameters.Add("@education", SqlDbType.VarChar).Value = paramsList[3];
            cmd.Parameters.Add("@qualification", SqlDbType.VarChar).Value = paramsList[4];
            cmd.Parameters.Add("@phoneNumber", SqlDbType.VarChar).Value = paramsList[5];
            cmd.Parameters.Add("@employeeId", SqlDbType.BigInt).Value = Convert.ToInt32(paramsList[6]);

            int rowCount = cmd.ExecuteNonQuery();

            if (oldPosition.ToLower() == "воспитатель" && newPosition.ToLower() == "воспитатель")
            {
                sql = "UPDATE ControlSchedule SET ControlSchedule.Fullname = @fullName WHERE ControlSchedule.EmployeeId = @employeeId";

                cmd = connection.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.Add("@fullName", SqlDbType.VarChar).Value = paramsList[0];
                cmd.Parameters.Add("@employeeId", SqlDbType.BigInt).Value = Convert.ToInt32(paramsList[6]);

                rowCount = cmd.ExecuteNonQuery();
            }

            if (oldPosition.ToLower().Contains("заведующ") && newPosition.ToLower() == "воспитатель")
            {
                sql = "INSERT INTO ControlSchedule(EmployeeId, Fullname) VALUES(@employeeId, @fullname)";

                cmd = connection.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.Add("@employeeId", SqlDbType.BigInt).Value = Convert.ToInt32(paramsList[6]);
                cmd.Parameters.Add("@fullname", SqlDbType.VarChar).Value = paramsList[0];

                rowCount = cmd.ExecuteNonQuery();
            }

            if (oldPosition.ToLower() == "воспитатель" && newPosition.ToLower().Contains("заведующ"))
            {
                sql = "DELETE FROM ControlSchedule WHERE ControlSchedule.EmployeeId = @employeeId";

                cmd = connection.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.Add("@employeeId", SqlDbType.BigInt).Value = Convert.ToInt32(paramsList[6]);

                rowCount = cmd.ExecuteNonQuery();
            }

            connection.Close();
        }

        public static bool IsAssignedToGroup(int employeeId)
        {
            bool isAssignedToGroup = false;

            SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
            connection.Open();

            string sql = "SELECT * FROM Groups WHERE Groups.EmployeeId = " + employeeId;

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            var row = cmd.ExecuteScalar();

            if (row != null)
            {
                isAssignedToGroup = true;
            }

            connection.Close();

            return isAssignedToGroup;
        }
    }
}
