using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KindergartenComplex.Manager_Forms.Provision
{
    public partial class ProvisionChartForm : Form
    {
        private readonly string _provisionType;

        public ProvisionChartForm(string provisionType)
        {
            _provisionType = provisionType == "Методическое" ? "Methodical" : "Resource";

            InitializeComponent();
            Text = provisionType + " обеспечение групп | " + AppParameters.KindergartenName;

            chartGroupProvision.Titles[0].Text = provisionType + " обеспечение групп, %";

            LoadChart();
        }

        private void LoadChart()
        {
            chartGroupProvision.ChartAreas[0].AxisX.Interval = 1;
            chartGroupProvision.Series[0].IsValueShownAsLabel = true;
            chartGroupProvision.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chartGroupProvision.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

            DataTable dataTable = GetGroupsIdsAndNames();

            foreach (DataRow row in dataTable.Rows)
            {
                int inStock = GetCountOfProvision(_provisionType, Convert.ToInt32(row[0]), $" AND {_provisionType}Availability.Mark = 1");
                chartGroupProvision.Series[0].Points.AddXY(row[1].ToString(), inStock);
                chartGroupProvision.Series[1].Points.AddXY(row[1].ToString(), GetCountOfProvision(_provisionType, Convert.ToInt32(row[0])) - inStock);
            }
        }

        private int GetCountOfProvision(string tableName, int groupId, string sqlAddition = "")
        {
            SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
            connection.Open();

            string sql = $"SELECT COUNT({tableName}Availability.{tableName}AvailabilityId) FROM {tableName}Availability WHERE {tableName}Availability.GroupId = {groupId}" + sqlAddition;

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            connection.Close();

            return count;
        }

        private DataTable GetGroupsIdsAndNames()
        {
            DataTable dataTable;

            using (SqlConnection connection = new SqlConnection(AppParameters.ConnectionString))
            {
                string sqlCommand = "SELECT Groups.GroupId, Groups.GroupName FROM Groups";

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, connection);

                dataTable = new DataTable();
                adapter.Fill(dataTable);
            }

            return dataTable;
        }
    }
}
