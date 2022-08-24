using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KindergartenComplex.Teacher_Forms.Methodical_Work
{
    internal static class MethodicalWorkController
    {
        public static int AddMethodicalWork(string[] paramsList)
        {
            SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
            connection.Open();

            string sql = "INSERT INTO MethodicalWork(WorkSubject, WorkDay, EmployeeId) VALUES(@workSubject, @workDay, @employeeId) SELECT SCOPE_IDENTITY()";

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add("@workSubject", SqlDbType.VarChar).Value = paramsList[0];
            cmd.Parameters.Add("@workDay", SqlDbType.Date).Value = Convert.ToDateTime(paramsList[1]);
            cmd.Parameters.Add("@employeeId", SqlDbType.BigInt).Value = Convert.ToInt32(paramsList[2]);

            int rowId = Convert.ToInt32(cmd.ExecuteScalar());

            connection.Close();

            return rowId;
        }
        
        public static void EditMethodicalWork(string[] paramsList)
        {
            SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
            connection.Open();

            string sql = "UPDATE MethodicalWork SET MethodicalWork.WorkSubject = @workSubject, MethodicalWork.WorkDay = @workDay WHERE MethodicalWork.MethodicalWorkId = @methodicalWorkId";

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add("@workSubject", SqlDbType.VarChar).Value = paramsList[0];
            cmd.Parameters.Add("@workDay", SqlDbType.Date).Value = Convert.ToDateTime(paramsList[1]);
            cmd.Parameters.Add("@methodicalWorkId", SqlDbType.BigInt).Value = Convert.ToInt32(paramsList[2]);

            int rowCount = cmd.ExecuteNonQuery();

            connection.Close();
        }

        public static void DeleteMethodicalWork(DataGridView dataGridViewTable)
        {
            DialogResult dialogResult = MessageBox.Show("Удалить " + dataGridViewTable.SelectedRows.Count + " запись(ей)",
                "Удаление методической работы", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
                connection.Open();

                foreach (DataGridViewRow row in dataGridViewTable.SelectedRows)
                {
                    string sql = "DELETE FROM MethodicalWork WHERE MethodicalWork.MethodicalWorkId = @methodicalWorkId";

                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = sql;

                    cmd.Parameters.Add("@methodicalWorkId", SqlDbType.BigInt).Value = Convert.ToInt32(row.Cells[0].Value);

                    int rowCount = cmd.ExecuteNonQuery();

                    dataGridViewTable.Rows.Remove(row);
                }

                connection.Close();
            }
        }
    }
}
