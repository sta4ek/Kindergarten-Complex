using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KindergartenComplex.Manager_Forms.SickLeaves
{
    internal static class SickLeaveController
    {
        public static void DeleteSickLeave(DataGridView dataGridViewTable)
        {
            DialogResult dialogResult = MessageBox.Show("Удалить " + dataGridViewTable.SelectedRows.Count + " запись(ей)", "Удаление больничного", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
                connection.Open();

                foreach (DataGridViewRow row in dataGridViewTable.SelectedRows)
                {
                    string sql = "DELETE FROM SickLeaves WHERE SickLeaves.SickLeaveId = @sickLeaveId";

                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = sql;

                    cmd.Parameters.Add("@sickLeaveId", SqlDbType.BigInt).Value = Convert.ToInt32(row.Cells[0].Value);

                    int rowCount = cmd.ExecuteNonQuery();

                    dataGridViewTable.Rows.Remove(row);
                }

                connection.Close();
            }
        }

        public static int AddSickLeave(string[] paramsList)
        {
            SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
            connection.Open();

            string sql = "INSERT INTO SickLeaves(EmployeeId, SickLeaveStart, SickLeaveEnd) VALUES(@employeeId, @sickLeaveStart, @sickLeaveEnd) SELECT SCOPE_IDENTITY()";

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add("@employeeId", SqlDbType.BigInt).Value = Convert.ToInt32(paramsList[0]);
            cmd.Parameters.Add("@sickLeaveStart", SqlDbType.Date).Value = Convert.ToDateTime(paramsList[1]);
            cmd.Parameters.Add("@sickLeaveEnd", SqlDbType.Date).Value = Convert.ToDateTime(paramsList[2]);

            int rowId = Convert.ToInt32(cmd.ExecuteScalar());

            connection.Close();

            return rowId;
        }

        public static void EditSickLeave(string[] paramsList)
        {
            SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
            connection.Open();

            string sql = "UPDATE SickLeaves SET SickLeaves.SickLeaveStart = @sickLeaveStart, SickLeaves.SickLeaveEnd = @sickLeaveEnd, SickLeaves.EmployeeId = @employeeId WHERE SickLeaves.SickLeaveId = @sickLeaveId";

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add("@employeeId", SqlDbType.BigInt).Value = Convert.ToInt32(paramsList[0]);
            cmd.Parameters.Add("@sickLeaveStart", SqlDbType.Date).Value = Convert.ToDateTime(paramsList[1]);
            cmd.Parameters.Add("@sickLeaveEnd", SqlDbType.Date).Value = Convert.ToDateTime(paramsList[2]);
            cmd.Parameters.Add("@sickLeaveId", SqlDbType.BigInt).Value = Convert.ToInt32(paramsList[3]);

            int rowCount = cmd.ExecuteNonQuery();

            connection.Close();
        }
    }
}
