using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KindergartenComplex.Manager_Forms.Control_Schedule
{
    static class ControlTopicsController
    {
        public static void FillTable(string sqlCommand, DataGridView dataGridViewTable)
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

        public static void DeleteTopic(DataGridView dataGridViewTable)
        {
            DialogResult dialogResult = MessageBox.Show("Удалить " + dataGridViewTable.SelectedRows.Count + " запись(ей)", "Удаление темы контроля", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
                connection.Open();

                foreach (DataGridViewRow row in dataGridViewTable.SelectedRows)
                {
                    string sql = "DELETE FROM ControlTopics WHERE ControlTopics.ControlTopicId = @controlTopicId";

                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = sql;

                    cmd.Parameters.Add("@controlTopicId", SqlDbType.BigInt).Value = Convert.ToInt32(row.Cells[0].Value);

                    int rowCount = cmd.ExecuteNonQuery();

                    dataGridViewTable.Rows.Remove(row);
                }

                connection.Close();
            }
        }

        public static void AddTopic(string topicName)
        {
            SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
            connection.Open();

            string sql = "INSERT INTO ControlTopics(TopicNumber, TopicName) VALUES(@topicNumber, @topicName)";

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add("@topicNumber", SqlDbType.Int).Value = GetTopicNumber();
            cmd.Parameters.Add("@topicName", SqlDbType.VarChar).Value = topicName;

            int rowCount = cmd.ExecuteNonQuery();

            connection.Close();
        }

        private static int GetTopicNumber()
        {
            int topicNumber = 1;

            SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
            connection.Open();

            string sql = "SELECT TOP(1) ControlTopics.TopicNumber FROM ControlTopics ORDER BY ControlTopics.ControlTopicId DESC";

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            var number = cmd.ExecuteScalar();

            connection.Close();

            if (number != null)
                topicNumber = Convert.ToInt32(number) + 1;

            return topicNumber;
        }

        public static void EditTopic(string topicName, int controlTopicId)
        {
            SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
            connection.Open();

            string sql = "UPDATE ControlTopics SET ControlTopics.TopicName = @topicName WHERE ControlTopics.ControlTopicId = @controlTopicId";

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add("@topicName", SqlDbType.VarChar).Value = topicName;
            cmd.Parameters.Add("@controlTopicId", SqlDbType.BigInt).Value = controlTopicId;

            int rowCount = cmd.ExecuteNonQuery();

            connection.Close();
        }
    }
}
