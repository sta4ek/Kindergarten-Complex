using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace KindergartenComplex.Teacher_Forms.Provision
{
    internal static class ProvisionMonitoringController
    {
        public static void CheckProvision(string provisionTableName, int groupId, string groupType)
        {
            string sqlCommand = $"SELECT COUNT(*) FROM {provisionTableName}Availability WHERE {provisionTableName}Availability.GroupId = @groupId";

            SqlConnection con = new SqlConnection(AppParameters.ConnectionString);
            con.Open();

            SqlCommand command = con.CreateCommand();
            command.CommandText = sqlCommand;

            command.Parameters.Add("@groupId", SqlDbType.BigInt).Value = groupId;

            var availabilityCount = command.ExecuteScalar();

            if (availabilityCount.ToString() == "0")
            {
                FillEmpty(provisionTableName, groupId, groupType);
            }
            else
            {
                string sql = $"SELECT COUNT (*) FROM {provisionTableName}Provision WHERE {provisionTableName}Provision.GroupType = '{groupType}'";

                SqlCommand com = con.CreateCommand();
                com.CommandText = sql;

                com.Parameters.Add("@groupId", SqlDbType.BigInt).Value = groupId;

                var provisionCount = com.ExecuteScalar();

                if (Convert.ToInt32(provisionCount) > Convert.ToInt32(availabilityCount))
                {
                    AddMissing(provisionTableName, groupId, groupType);
                }
            }

            con.Close();
        }

        private static void FillEmpty(string provisionTableName, int groupId, string groupType)
        {
            SqlConnection con = new SqlConnection(AppParameters.ConnectionString);
            con.Open();

            foreach (var provisionId in GetProvisionIdList(provisionTableName, groupType))
            {
                string sql = $"INSERT INTO {provisionTableName}Availability ({provisionTableName}ProvisionId, GroupId, Mark) VALUES(@provisionId, @groupId, @mark)";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.Add("@provisionId", SqlDbType.BigInt).Value = provisionId;
                cmd.Parameters.Add("@groupId", SqlDbType.BigInt).Value = groupId;
                cmd.Parameters.Add("@mark", SqlDbType.Bit).Value = 0;

                int rowCount = cmd.ExecuteNonQuery();
            }

            con.Close();
        }

        private static List<int> GetProvisionIdList(string provisionTableName, string groupType)
        {
            List<int> provisionIdList = new List<int>();

            using (SqlConnection connection = new SqlConnection(AppParameters.ConnectionString))
            {
                string sqlCommand = $"SELECT {provisionTableName}Provision.{provisionTableName}ProvisionId FROM {provisionTableName}Provision WHERE {provisionTableName}Provision.GroupType = '{groupType}'";

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, connection);

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    provisionIdList.Add(Convert.ToInt32(row[0]));
                }
            }

            return provisionIdList;
        }

        private static List<int> GetAvailabilityIdList(string provisionTableName, int groupId)
        {
            List<int> availabilityIdList = new List<int>();

            using (SqlConnection connection = new SqlConnection(AppParameters.ConnectionString))
            {
                string sqlCommand = $"SELECT {provisionTableName}Availability.{provisionTableName}ProvisionId FROM {provisionTableName}Availability WHERE {provisionTableName}Availability.GroupId = {groupId}";

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, connection);

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    availabilityIdList.Add(Convert.ToInt32(row[0]));
                }
            }

            return availabilityIdList;
        }

        private static void AddMissing(string provisionTableName, int groupId, string groupType)
        {
            List<int> provisionIdList = GetProvisionIdList(provisionTableName, groupType);
            List<int> availabilityIdList = GetAvailabilityIdList(provisionTableName, groupId);

            var idToAddList = provisionIdList.Except(availabilityIdList);

            SqlConnection con = new SqlConnection(AppParameters.ConnectionString);
            con.Open();

            foreach (var provisionId in idToAddList)
            {
                string sql = $"INSERT INTO {provisionTableName}Availability ({provisionTableName}ProvisionId, GroupId, Mark) VALUES(@provisionId, @groupId, @mark)";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.Add("@provisionId", SqlDbType.BigInt).Value = provisionId;
                cmd.Parameters.Add("@groupId", SqlDbType.BigInt).Value = groupId;
                cmd.Parameters.Add("@mark", SqlDbType.Bit).Value = 0;

                int rowCount = cmd.ExecuteNonQuery();
            }

            con.Close();
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

        public static void SetMark(string provisionTableName, int provisionId, bool checkBoxValue)
        {
            int mark = 0;

            if (checkBoxValue)
                mark = 1;

            SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
            connection.Open();

            string sql = $"UPDATE {provisionTableName}Availability SET {provisionTableName}Availability.Mark = @mark WHERE {provisionTableName}Availability.{provisionTableName}AvailabilityId = @provisionId";

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add("@mark", SqlDbType.Bit).Value = mark;
            cmd.Parameters.Add("@provisionId", SqlDbType.BigInt).Value = provisionId;

            int rowCount = cmd.ExecuteNonQuery();

            connection.Close();
        }
    }
}
