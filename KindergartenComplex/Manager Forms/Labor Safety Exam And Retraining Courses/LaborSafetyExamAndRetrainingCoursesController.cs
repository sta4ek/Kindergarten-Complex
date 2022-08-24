using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KindergartenComplex.Manager_Forms.Labor_Safety_Exam
{
    internal static class LaborSafetyExamAndRetrainingController
    {
        public static void SetMark(bool isExam, int rowId, bool checkBoxValue)
        {
            int mark = 0;

            if (checkBoxValue)
                mark = 1;

            SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
            connection.Open();

            var sql = isExam ? "UPDATE LaborSafetyExam SET LaborSafetyExam.Mark = @mark WHERE LaborSafetyExam.LaborSafetyExamId = @rowId" : "UPDATE RetrainingCourses SET RetrainingCourses.Mark = @mark WHERE RetrainingCourses.RetrainingCourseId = @rowId";

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add("@mark", SqlDbType.Bit).Value = mark;
            cmd.Parameters.Add("@rowId", SqlDbType.BigInt).Value = rowId;

            int rowCount = cmd.ExecuteNonQuery();

            connection.Close();
        }

        public static void FillTable(DataGridView dataGridViewTable, string sqlCommand)
        {
            using (SqlConnection connection = new SqlConnection(AppParameters.ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, connection);

                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridViewTable.DataSource = ds.Tables[0];
                dataGridViewTable.Columns[0].Visible = false;
            }
        }

        public static int AddRow(string[] paramsList, bool isExam)
        {
            SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
            connection.Open();

            var sql = isExam ? "INSERT INTO LaborSafetyExam(EmployeeId, ExamDate, Mark) VALUES(@employeeId, @date, @mark) SELECT SCOPE_IDENTITY()" : "INSERT INTO RetrainingCourses(EmployeeId, CourseDate, Mark) VALUES(@employeeId, @date, @mark) SELECT SCOPE_IDENTITY()";

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add("@employeeId", SqlDbType.BigInt).Value = Convert.ToInt32(paramsList[0]);
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = Convert.ToDateTime(paramsList[1]);
            cmd.Parameters.Add("@mark", SqlDbType.Bit).Value = 0;

            int rowId = Convert.ToInt32(cmd.ExecuteScalar());

            connection.Close();

            return rowId;
        }

        public static void DeleteRow(DataGridView dataGridViewTable, bool isExam)
        {
            DialogResult dialogResult = MessageBox.Show("Удалить " + dataGridViewTable.SelectedRows.Count + " запись(ей)",
                "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
                connection.Open();

                foreach (DataGridViewRow row in dataGridViewTable.SelectedRows)
                {
                    var sql = isExam ? "DELETE FROM LaborSafetyExam WHERE LaborSafetyExam.LaborSafetyExamId = @rowId" : "DELETE FROM RetrainingCourses WHERE RetrainingCourses.RetrainingCourseId = @rowId";

                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = sql;

                    cmd.Parameters.Add("@rowId", SqlDbType.BigInt).Value = Convert.ToInt32(row.Cells[0].Value);

                    int rowCount = cmd.ExecuteNonQuery();

                    dataGridViewTable.Rows.Remove(row);
                }

                connection.Close();
            }
        }

        public static void EditRow(string[] paramsList, bool isExam)
        {
            SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
            connection.Open();

            var sql = isExam ? "UPDATE LaborSafetyExam SET LaborSafetyExam.EmployeeId = @employeeId, LaborSafetyExam.ExamDate = @date WHERE LaborSafetyExam.LaborSafetyExamId = @rowId" : "UPDATE RetrainingCourses SET RetrainingCourses.EmployeeId = @employeeId, RetrainingCourses.CourseDate = @date WHERE RetrainingCourses.RetrainingCourseId = @rowId";

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add("@employeeId", SqlDbType.BigInt).Value = paramsList[0];
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = Convert.ToDateTime(paramsList[1]);
            cmd.Parameters.Add("@rowId", SqlDbType.BigInt).Value = Convert.ToInt32(paramsList[2]);

            int rowCount = cmd.ExecuteNonQuery();

            connection.Close();
        }
    }
}
