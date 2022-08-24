using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KindergartenComplex.Manager_Forms.Provision
{
    internal static class ProvisionController
    {
        public static void FillTables(DataGridView[] dataGridViewTables, string provisionType)
        {
            string[] sqlCommands;

            if (provisionType == "Методическое")
            {
                sqlCommands = new[]
                {
                    "SELECT MethodicalProvision.MethodicalProvisionId, MethodicalProvision.ItemName AS 'Название' FROM MethodicalProvision WHERE MethodicalProvision.GroupType = 'Первая младшая'",
                    "SELECT MethodicalProvision.MethodicalProvisionId, MethodicalProvision.ItemName AS 'Название' FROM MethodicalProvision WHERE MethodicalProvision.GroupType = 'Вторая младшая'",
                    "SELECT MethodicalProvision.MethodicalProvisionId, MethodicalProvision.ItemName AS 'Название' FROM MethodicalProvision WHERE MethodicalProvision.GroupType = 'Средняя'",
                    "SELECT MethodicalProvision.MethodicalProvisionId, MethodicalProvision.ItemName AS 'Название' FROM MethodicalProvision WHERE MethodicalProvision.GroupType = 'Старшая'"
                };
            }
            else
            {
                sqlCommands = new[]
                {
                    "SELECT ResourceProvision.ResourceProvisionId, ResourceProvision.ItemName AS 'Название' FROM ResourceProvision WHERE ResourceProvision.GroupType = 'Первая младшая'",
                    "SELECT ResourceProvision.ResourceProvisionId, ResourceProvision.ItemName AS 'Название' FROM ResourceProvision WHERE ResourceProvision.GroupType = 'Вторая младшая'",
                    "SELECT ResourceProvision.ResourceProvisionId, ResourceProvision.ItemName AS 'Название' FROM ResourceProvision WHERE ResourceProvision.GroupType = 'Средняя'",
                    "SELECT ResourceProvision.ResourceProvisionId, ResourceProvision.ItemName AS 'Название' FROM ResourceProvision WHERE ResourceProvision.GroupType = 'Старшая'"
                };
            }
            
            for (int i = 0; i < dataGridViewTables.Length; i++)
            {
                FillTable(dataGridViewTables[i], sqlCommands[i]);
            }
        }

        private static void FillTable(DataGridView dataGridViewTable, string sqlCommand)
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

        public static int AddProvision(string[] paramsList, string provisionType)
        {
            SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
            connection.Open();

            int rowId;

            if (provisionType == "Методическое")
            {
                string sql = "INSERT INTO MethodicalProvision(ItemName, GroupType) VALUES(@itemName, @groupType) SELECT SCOPE_IDENTITY()";

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.Add("@itemName", SqlDbType.VarChar).Value = paramsList[0];
                cmd.Parameters.Add("@groupType", SqlDbType.VarChar).Value = paramsList[1];

                rowId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            else
            {
                string sql = "INSERT INTO ResourceProvision(ItemName, GroupType) VALUES(@itemName, @groupType) SELECT SCOPE_IDENTITY()";

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.Add("@itemName", SqlDbType.VarChar).Value = paramsList[0];
                cmd.Parameters.Add("@groupType", SqlDbType.VarChar).Value = paramsList[1];

                rowId = Convert.ToInt32(cmd.ExecuteScalar());
            }

            connection.Close();

            return rowId;
        }

        public static void DeleteProvision(DataGridView dataGridViewTable, string provisionType)
        {
            DialogResult dialogResult = MessageBox.Show("Удалить " + dataGridViewTable.SelectedRows.Count + " запись(ей)",
                    "Удаление обеспечения", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
                connection.Open();

                if (provisionType == "Методическое")
                {
                    foreach (DataGridViewRow row in dataGridViewTable.SelectedRows)
                    {
                        string sql = "DELETE FROM MethodicalProvision WHERE MethodicalProvision.MethodicalProvisionId = @methodicalProvisionId";

                        SqlCommand cmd = connection.CreateCommand();
                        cmd.CommandText = sql;

                        cmd.Parameters.Add("@methodicalProvisionId", SqlDbType.BigInt).Value = Convert.ToInt32(row.Cells[0].Value);

                        int rowCount = cmd.ExecuteNonQuery();

                        dataGridViewTable.Rows.Remove(row);
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in dataGridViewTable.SelectedRows)
                    {
                        string sql = "DELETE FROM ResourceProvision WHERE ResourceProvision.ResourceProvisionId = @resourceProvisionId";

                        SqlCommand cmd = connection.CreateCommand();
                        cmd.CommandText = sql;

                        cmd.Parameters.Add("@resourceProvisionId", SqlDbType.BigInt).Value = row.Cells[0].Value.ToString();

                        int rowCount = cmd.ExecuteNonQuery();

                        dataGridViewTable.Rows.Remove(row);
                    }
                }

                connection.Close();
            }
        }

        public static void EditProvision(string[] paramsList, string provisionType)
        {
            SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
            connection.Open();

            if (provisionType == "Методическое")
            {
                string sql = "UPDATE MethodicalProvision SET MethodicalProvision.ItemName = @itemName WHERE MethodicalProvision.MethodicalProvisionId = @methodicalProvisionId";

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.Add("@itemName", SqlDbType.VarChar).Value = paramsList[0];
                cmd.Parameters.Add("@methodicalProvisionId", SqlDbType.BigInt).Value = Convert.ToInt32(paramsList[1]);

                int rowCount = cmd.ExecuteNonQuery();
            }
            else
            {
                string sql = "UPDATE ResourceProvision SET ResourceProvision.ItemName = @itemName WHERE ResourceProvision.ResourceProvisionId = @resourceProvisionId";

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.Add("@itemName", SqlDbType.VarChar).Value = paramsList[0];
                cmd.Parameters.Add("@resourceProvisionId", SqlDbType.BigInt).Value = Convert.ToInt32(paramsList[1]);

                int rowCount = cmd.ExecuteNonQuery();
            }

            connection.Close();
        }
    }
}
