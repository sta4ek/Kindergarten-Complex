using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KindergartenComplex.Manager_Forms.Vacations
{
    internal static class VacationController
    {
        public static void DeleteVacation(DataGridView dataGridViewTable)
        {
            DialogResult dialogResult = MessageBox.Show("Удалить " + dataGridViewTable.SelectedRows.Count + " запись(ей)", "Удаление отпуска", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
                connection.Open();

                foreach (DataGridViewRow row in dataGridViewTable.SelectedRows)
                {
                    string sql = "DELETE FROM Vacations WHERE Vacations.VacationId = @vacationId";

                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = sql;

                    cmd.Parameters.Add("@vacationId", SqlDbType.BigInt).Value = Convert.ToInt32(row.Cells[0].Value);

                    int rowCount = cmd.ExecuteNonQuery();

                    dataGridViewTable.Rows.Remove(row);
                }

                connection.Close();
            }
        }

        public static int AddVacation(string[] paramsList)
        {
            SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
            connection.Open();

            string sql = "INSERT INTO Vacations(EmployeeId, VacationStart, VacationEnd) VALUES(@employeeId, @vacationStart, @vacationEnd) SELECT SCOPE_IDENTITY()";

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add("@employeeId", SqlDbType.BigInt).Value = Convert.ToInt32(paramsList[0]);
            cmd.Parameters.Add("@vacationStart", SqlDbType.Date).Value = Convert.ToDateTime(paramsList[1]);
            cmd.Parameters.Add("@vacationEnd", SqlDbType.Date).Value = Convert.ToDateTime(paramsList[2]);

            int rowId = Convert.ToInt32(cmd.ExecuteScalar());

            connection.Close();

            return rowId;
        }

        public static void EditVacation(string[] paramsList)
        {
            SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
            connection.Open();

            string sql = "UPDATE Vacations SET Vacations.VacationStart = @vacationStart, Vacations.VacationEnd = @vacationEnd, Vacations.EmployeeId = @employeeId WHERE Vacations.VacationId = @vacationId";

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add("@employeeId", SqlDbType.BigInt).Value = Convert.ToInt32(paramsList[0]);
            cmd.Parameters.Add("@vacationStart", SqlDbType.Date).Value = Convert.ToDateTime(paramsList[1]);
            cmd.Parameters.Add("@vacationEnd", SqlDbType.Date).Value = Convert.ToDateTime(paramsList[2]);
            cmd.Parameters.Add("@vacationId", SqlDbType.BigInt).Value = Convert.ToInt32(paramsList[3]);

            int rowCount = cmd.ExecuteNonQuery();

            connection.Close();
        }
    }
}
