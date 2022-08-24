using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KindergartenComplex.Manager_Forms.Groups
{
    internal static class GroupController
    {
        public static void DeleteGroup(DataGridView dataGridViewTable)
        {
            DialogResult dialogResult = MessageBox.Show("Удаление группы приведёт к удалению всех воспитанников с такой группой. Удалить " + dataGridViewTable.SelectedRows.Count + " запись(ей)", "Удаление группы", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
                connection.Open();

                foreach (DataGridViewRow row in dataGridViewTable.SelectedRows)
                {
                    string sql = "DELETE FROM Groups WHERE Groups.GroupId = @groupId";

                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = sql;

                    cmd.Parameters.Add("@groupId", SqlDbType.BigInt).Value = Convert.ToInt32(row.Cells[0].Value);

                    int rowCount = cmd.ExecuteNonQuery();

                    dataGridViewTable.Rows.Remove(row);
                }

                connection.Close();
            }
        }

        public static int AddGroup(string[] paramsList)
        {
            SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
            connection.Open();

            string sql = "INSERT INTO Groups(GroupName, EmployeeId) VALUES(@groupName, @employeeId) SELECT SCOPE_IDENTITY()";

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add("@groupName", SqlDbType.VarChar).Value = paramsList[0];
            cmd.Parameters.Add("@employeeId", SqlDbType.BigInt).Value = Convert.ToInt32(paramsList[1]);

            int rowId = Convert.ToInt32(cmd.ExecuteScalar());

            connection.Close();

            return rowId;
        }

        public static void EditGroup(string[] paramsList)
        {
            SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
            connection.Open();

            string sql = "UPDATE Groups SET Groups.GroupName = @groupName, Groups.EmployeeId = @employeeId WHERE Groups.GroupId = @groupId";

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add("@groupName", SqlDbType.VarChar).Value = paramsList[0];
            cmd.Parameters.Add("@employeeId", SqlDbType.BigInt).Value = Convert.ToInt32(paramsList[1]);
            cmd.Parameters.Add("@groupId", SqlDbType.BigInt).Value = Convert.ToInt32(paramsList[2]);

            int rowCount = cmd.ExecuteNonQuery();

            connection.Close();
        }
    }
}
