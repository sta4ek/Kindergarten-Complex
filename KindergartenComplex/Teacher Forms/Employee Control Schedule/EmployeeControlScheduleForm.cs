using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using KindergartenComplex.Manager_Forms.Control_Schedule;

namespace KindergartenComplex.Teacher_Forms.Employee_Control_Schedule
{
    public partial class EmployeeControlScheduleForm : Form
    {
        private readonly int _employeeId;

        public EmployeeControlScheduleForm(int employeeId)
        {
            _employeeId = employeeId;

            InitializeComponent();

            Text += AppParameters.KindergartenName;

            ControlTopicsController.FillTable("SELECT ControlTopics.ControlTopicId, ControlTopics.TopicNumber AS '№ темы', ControlTopics.TopicName AS 'Название темы' FROM ControlTopics", dataGridViewControlTopics);
            dataGridViewControlTopics.Columns[1].FillWeight = 10;

            FillTable();
            SetDataGridViewHeaderText();
        }

        private void SetDataGridViewHeaderText()
        {
            int dayNumber = 1;

            for (int i = 3; i < dataGridViewEmployeeControlSchedule.Columns.Count; i++)
            {
                dataGridViewEmployeeControlSchedule.Columns[i].HeaderText = dayNumber.ToString();
                dayNumber++;
            }

            HideColumns();
        }

        private void HideColumns()
        {
            for (int i = dataGridViewEmployeeControlSchedule.Columns.Count - 3; i > DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month); i--)
            {
                dataGridViewEmployeeControlSchedule.Columns[i + 2].Visible = false;
            }
        }

        private void FillTable()
        {
            using (SqlConnection connection = new SqlConnection(AppParameters.ConnectionString))
            {
                string sql = $"SELECT * FROM ControlSchedule WHERE ControlSchedule.EmployeeId = {_employeeId}";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridViewEmployeeControlSchedule.DataSource = ds.Tables[0];

                dataGridViewEmployeeControlSchedule.Columns[0].Visible = false;
                dataGridViewEmployeeControlSchedule.Columns[1].Visible = false;
                dataGridViewEmployeeControlSchedule.Columns[2].Visible = false;
            }
        }
    }
}
