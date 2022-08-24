using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KindergartenComplex.Teacher_Forms
{
    internal static class AttendanceManagement
    {
        public static void CheckForToday(int groupId)
        {
            string sqlCommand = "SELECT Tbl.Fullname, Tbl.Presence FROM (SELECT Attendance.PupilId, Pupils.Fullname, Attendance.CheckDay, Attendance.Presence, Pupils.GroupId FROM Attendance INNER JOIN Pupils ON Attendance.PupilId = Pupils.PupilId) AS Tbl INNER JOIN Groups ON Tbl.GroupId = Groups.GroupId WHERE Groups.GroupId = @groupId AND Tbl.CheckDay = @checkDay";

            SqlConnection con = new SqlConnection(AppParameters.ConnectionString);
            con.Open();

            SqlCommand command = con.CreateCommand();
            command.CommandText = sqlCommand;

            command.Parameters.Add("@groupId", SqlDbType.BigInt).Value = groupId;
            command.Parameters.Add("@checkDay", SqlDbType.DateTime).Value = DateTime.Today;

            var row = command.ExecuteScalar();

            con.Close();

            if (row == null)
            {
                CreateRowsForToday(groupId);
            }
        }

        private static void CreateRowsForToday(int groupId)
        {
            List<int> pupilsIdList = new List<int>();

            using (SqlConnection connection = new SqlConnection(AppParameters.ConnectionString))
            {
                string sqlCommand = $"SELECT Pupils.PupilId FROM Pupils WHERE Pupils.GroupId = {groupId}";

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, connection);

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    pupilsIdList.Add(Convert.ToInt32(row[0]));
                }
            }

            SqlConnection con = new SqlConnection(AppParameters.ConnectionString);
            con.Open();

            foreach (var pupilId in pupilsIdList)
            {
                string sql = "INSERT INTO Attendance(PupilId, CheckDay, Presence) VALUES(@pupilId, @checkDay, @presence)";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.Add("@pupilId", SqlDbType.BigInt).Value = pupilId;
                cmd.Parameters.Add("@checkDay", SqlDbType.DateTime).Value = DateTime.Today;
                cmd.Parameters.Add("@presence", SqlDbType.Bit).Value = 0;

                int rowCount = cmd.ExecuteNonQuery();
            }

            con.Close();
        }

        public static void FillTable(DataGridView dataGridViewTable, int groupId, DateTime date)
        {
            string sqlCommand = $"SELECT Attendance.AttendanceId, Pupils.Fullname AS 'ФИО', Attendance.Presence AS 'Отметка о присутствии' FROM Attendance INNER JOIN Pupils ON Pupils.PupilId = Attendance.PupilId WHERE Pupils.GroupId = {groupId} AND Attendance.CheckDay = '{date:yyyy.MM.dd}'";
            
            using (SqlConnection connection = new SqlConnection(AppParameters.ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, connection);

                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridViewTable.DataSource = ds.Tables[0];
                dataGridViewTable.Columns[0].Visible = false;
            }
        }

        public static void SetPresence(int attendanceId, bool checkBoxValue)
        {
            int presence = 0;

            if (checkBoxValue)
                presence = 1;

            SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
            connection.Open();

            string sql = "UPDATE Attendance SET Attendance.Presence = @presence WHERE Attendance.AttendanceId = @attendanceId";

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add("@presence", SqlDbType.Bit).Value = presence;
            cmd.Parameters.Add("@attendanceId", SqlDbType.BigInt).Value = attendanceId;

            int rowCount = cmd.ExecuteNonQuery();

            connection.Close();
        }

        public static void FillListBox(ListBox listBoxAttendance, int groupId)
        {
            using (SqlConnection connection = new SqlConnection(AppParameters.ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter($"SELECT DISTINCT Attendance.CheckDay FROM Attendance INNER JOIN Pupils ON Pupils.PupilId = Attendance.PupilId WHERE Pupils.GroupId = {groupId} ORDER BY Attendance.CheckDay DESC", connection);

                DataTable table = new DataTable();
                da.Fill(table);
                listBoxAttendance.DataSource = table;
                listBoxAttendance.DisplayMember = table.Columns[0].ColumnName;
            }
        }
    }
}
