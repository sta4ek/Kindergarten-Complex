using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace KindergartenComplex.Teacher_Forms.Schedule
{
    static class ScheduleController
    {
        public static string GetColumnName(string groupName)
        {
            string columnName = "";

            switch (groupName.Substring(0, groupName.Length - 2).ToLower())
            {
                case "первая младшая":
                    columnName = "FirstYoungHrs";
                    break;
                case "вторая младшая":
                    columnName = "SecondYoungHrs";
                    break;
                case "средняя":
                    columnName = "MiddleHrs";
                    break;
                case "старшая":
                    columnName = "SeniorHrs";
                    break;
            }

            return columnName;
        }

        public static List<string> GetSubjects(string columnName)
        {
            List<string> subjectsList = new List<string>();

            using (SqlConnection connection = new SqlConnection(AppParameters.ConnectionString))
            {
                string sqlCommand = $"SELECT AcademicPlan.EducationalArea, AcademicPlan.{columnName} FROM AcademicPlan";

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, connection);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    int subjectsCount = Convert.ToInt32(row[1]);

                    if (subjectsCount != 0)
                    {
                        while (subjectsCount > 0)
                        {
                            subjectsList.Add(row[0].ToString());
                            subjectsCount--;
                        }
                    }
                }
            }

            return subjectsList;
        }

        public static void FillListDays(int groupId, ref List<string>[] listDays, string[] daysOfWeek)
        {
            listDays = new[] { new List<string>(), new List<string>(), new List<string>(), new List<string>(), new List<string>() };

            using (SqlConnection connection = new SqlConnection(AppParameters.ConnectionString))
            {
                for (int i = 0; i < daysOfWeek.Length; i++)
                {
                    string sqlCommand = $"SELECT Schedule.EducationalArea FROM Schedule WHERE Schedule.DayOfTheWeek = '{daysOfWeek[i]}' AND Schedule.GroupId = {groupId}";

                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, connection);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        string subject = row[0].ToString();

                        listDays[i].Add(subject);
                    }
                }
            }
        }

        private static void CreateRows(DataGridView dataGridViewSchedule, List<string>[] listDays)
        {
            dataGridViewSchedule.Rows.Add(listDays.Select(listBox => listBox.Count).Concat(new[] { 0 }).Max());

            for (int i = 0; i < dataGridViewSchedule.Rows.Count; i++)
            {
                dataGridViewSchedule.Rows[i].Cells[0].Value = i + 1;
            }
        }

        public static void FillScheduleFromLists(List<string>[] listDays, DataGridView dataGridViewSchedule)
        {
            CreateRows(dataGridViewSchedule, listDays);

            for (int i = 0; i < listDays.Length; i++)
            {
                for (int j = 0; j < listDays[i].Count; j++)
                {
                    dataGridViewSchedule.Rows[j].Cells[i + 1].Value = listDays[i][j];
                }
            }
        }

        public static void SelectDayOfWeek(DataGridView dataGridViewSchedule)
        {
            foreach (DataGridViewColumn column in dataGridViewSchedule.Columns)
            {
                if (column.HeaderText.ToLower() == CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek))
                {
                    column.HeaderCell.Style.BackColor = Color.FromArgb(63, 63, 189);
                }
            }
        }

        public static void SaveSchedule(int groupId, List<string>[] listDays, string[] daysOfWeek)
        {
            SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
            connection.Open();

            string sql = "INSERT INTO Schedule(DayOfTheWeek, EducationalArea, GroupId) VALUES(@dayOfTheWeek, @educationalArea, @groupId)";

            for (int i = 0; i < listDays.Length; i++)
            {
                foreach (var subject in listDays[i])
                {
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = sql;

                    cmd.Parameters.Add("@dayOfTheWeek", SqlDbType.VarChar).Value = daysOfWeek[i];
                    cmd.Parameters.Add("@educationalArea", SqlDbType.VarChar).Value = subject;
                    cmd.Parameters.Add("@groupId", SqlDbType.BigInt).Value = groupId;

                    int rowCount = cmd.ExecuteNonQuery();
                }
            }

            connection.Close();
        }
    }

}
