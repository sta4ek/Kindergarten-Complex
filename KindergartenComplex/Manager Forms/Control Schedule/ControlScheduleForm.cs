using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace KindergartenComplex.Manager_Forms.Control_Schedule
{
    public partial class ControlScheduleForm : Form
    {
        private DataSet _ds;
        private SqlDataAdapter _adapter;
        private const string Sql = "SELECT * FROM ControlSchedule";
        private int _y;
        private int _successLabelMoveDown = -1;

        public ControlScheduleForm()
        {
            InitializeComponent();

            Text += AppParameters.KindergartenName;

            FillTable();
            SetDataGridViewHeaderText();

            dataGridViewControlSchedule.CellValidating += dataGridViewControlSchedule_CellValidating;
        }

        private void HideColumns()
        {
            for (int i = dataGridViewControlSchedule.Columns.Count - 3; i > DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month); i--)
            {
                dataGridViewControlSchedule.Columns[i + 2].Visible = false;
            }
        }

        private void SetDataGridViewHeaderText()
        {
            dataGridViewControlSchedule.Columns[2].HeaderText = "Воспитатель";

            int dayNumber = 1;

            for (int i = 3; i < dataGridViewControlSchedule.Columns.Count; i++)
            {
                dataGridViewControlSchedule.Columns[i].HeaderText = dayNumber.ToString();
                dayNumber++;
            }

            HideColumns();
        }

        private void FillTable()
        {
            using (SqlConnection connection = new SqlConnection(AppParameters.ConnectionString))
            {
                _adapter = new SqlDataAdapter(Sql, connection);

                _ds = new DataSet();
                _adapter.Fill(_ds);
                dataGridViewControlSchedule.DataSource = _ds.Tables[0];

                dataGridViewControlSchedule.Columns[0].Visible = false;
                dataGridViewControlSchedule.Columns[1].Visible = false;
                dataGridViewControlSchedule.Columns[2].ReadOnly = true;
                dataGridViewControlSchedule.Columns[2].FillWeight = 400;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveTable();

            labelSuccess.Visible = true;
            _y = Height;
            timer.Start();
        }

        private void SaveTable()
        {
            using (SqlConnection connection = new SqlConnection(AppParameters.ConnectionString))
            {
                _adapter = new SqlDataAdapter(Sql, connection);

                var commandBuilder = new SqlCommandBuilder(_adapter);

                _adapter.Update(_ds);
            }
        }

        private void dataGridViewControlSchedule_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Неверный формат введённых данных!");
        }

        private void DrawText(int y)
        {
            Point shortNamePoint = new Point(965, y);
            labelSuccess.Location = shortNamePoint;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (timer.Interval == 2000)
            {
                timer.Interval = 5;
            }

            if (_y <= 664)
            {
                _successLabelMoveDown = 1;
                timer.Interval = 2000;
            }

            if (_y > Height)
            {
                labelSuccess.Visible = false;
                timer.Stop();
                _successLabelMoveDown = -1;
            }

            _y += 5 * _successLabelMoveDown;

            DrawText(_y);
        }

        private void dataGridViewControlSchedule_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.FormattedValue.ToString() == "" || !int.TryParse(e.FormattedValue.ToString(), out _))
            {
                return;
            }

            if (!TopicAvailability(Convert.ToInt32(e.FormattedValue)))
            {
                MessageBox.Show("Неверный номер темы!");
                e.Cancel = true;
            }
        }

        private void buttonControlTopics_Click(object sender, EventArgs e)
        {
            var controlTopicsForm = new ControlTopicsForm();
            controlTopicsForm.ShowDialog();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)dataGridViewControlSchedule.DataSource).DefaultView.RowFilter =
                $"Fullname like '{textBoxSearch.Text}%'";
        }

        private bool TopicAvailability(int enteredNumber)
        {
            bool topicAvailability = false;
            DataTable dataTable;

            using (SqlConnection connection = new SqlConnection(AppParameters.ConnectionString))
            {
                string sqlCommand = "SELECT ControlTopics.TopicNumber FROM ControlTopics";

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, connection);

                dataTable = new DataTable();
                adapter.Fill(dataTable);
            }

            foreach (DataRow row in dataTable.Rows)
            {
                if (Convert.ToInt32(row[0]) == enteredNumber)
                {
                    topicAvailability = true;
                    break;
                }
            }

            return topicAvailability;
        }
    }
}
