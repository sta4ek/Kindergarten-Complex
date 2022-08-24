using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using KindergartenComplex.Teacher_Forms;
using KindergartenComplex.Teacher_Forms.Employee_Control_Schedule;
using KindergartenComplex.Teacher_Forms.Methodical_Work;
using KindergartenComplex.Teacher_Forms.Provision;
using KindergartenComplex.Teacher_Forms.Pupils_SickLeaves;
using KindergartenComplex.Teacher_Forms.Schedule;

namespace KindergartenComplex
{
    public partial class TeacherForm : Form
    {
        private readonly int _accountId;
        private readonly int _employeeId;
        private readonly string _fullName;
        private string _groupName;
        private int _groupId;
        private DataGridView _dataGridViewTable;
        private const string MethodicalProvisionTableName = "Methodical";
        private const string ResourceProvisionTableName = "Resource";

        public TeacherForm(int accountId, string fullName, int employeeId, string positionName)
        {
            _accountId = accountId;
            _employeeId = employeeId;
            _fullName = fullName;
            GetGroupNameAndId();

            InitializeComponent();

            ProvisionMonitoringController.CheckProvision(MethodicalProvisionTableName, _groupId, _groupName.Substring(0, _groupName.Length - 2));
            ProvisionMonitoringController.CheckProvision(ResourceProvisionTableName, _groupId, _groupName.Substring(0, _groupName.Length - 2));

            Text = _fullName + ", " + positionName + ", " + _groupName + " | " + AppParameters.KindergartenName;

            string[] name = _fullName.Split(' ');
            labelShortName.Text = $"{name[0]} {name[1][0]}. {name[2][0]}.";

            Point point = new Point(Width - labelShortName.Width - 28, 4);
            labelShortName.Location = point;

            _dataGridViewTable = dataGridViewAttendance;
            AttendanceManagement.CheckForToday(_groupId);

            AttendanceManagement.FillTable(_dataGridViewTable, _groupId, DateTime.Today);

            AttendanceManagement.FillListBox(listBoxAttendance, _groupId);

            labelAttendance.Text = $"Посещаемость за {DateTime.Today:dd.MM.yyyy}";

            dataGridViewAttendance.Columns[1].ReadOnly = true;

            _dataGridViewTable = dataGridViewPupils;

            FillTable("SELECT Pupils.PupilId, Pupils.Fullname AS 'ФИО', Pupils.Parents AS 'ФИО родителей', Pupils.PhoneNumber AS 'Номера телефонов родителей', Pupils.LivingAddress AS 'Адрес проживания', Pupils.HealthGroup AS 'Группа здоровья', Pupils.MedicalDiagnosis AS 'Медицинский диагноз', Pupils.Understudy AS 'Дублер', Pupils.PEGroup AS 'Группа по физич. культуре', Pupils.Diet AS 'Диета' FROM Pupils INNER JOIN Groups ON Pupils.GroupId = Groups.GroupId WHERE Groups.GroupId = '" + _groupId + "'");

            _dataGridViewTable = dataGridViewAttendance;

            dataGridViewAttendance.Columns[2].FillWeight = 50;

            dataGridViewPupils.Columns[1].FillWeight = 200;
            dataGridViewPupils.Columns[2].FillWeight = 230;
            dataGridViewPupils.Columns[7].FillWeight = 60;

            LoadChart();

            CheckControlForTodayAndTomorrow();
        }

        private void GetGroupNameAndId()
        {
            string sqlCommand = "SELECT Groups.GroupId, Groups.GroupName FROM Groups WHERE Groups.EmployeeId =  " + _employeeId;

            using (SqlConnection connection = new SqlConnection(AppParameters.ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, connection);

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                var cellsArray = ds.Tables[0].Rows[0].ItemArray;

                _groupId = Convert.ToInt32(cellsArray[0]);
                _groupName = cellsArray[1].ToString();
            }
        }

        private void TeacherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form authForm = Application.OpenForms[0];

            if (!authForm.Visible)
            {
                Application.Exit();
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Form authForm = Application.OpenForms[0];
            authForm.Show();
            Close();
        }

        private void tabControlTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControlTables.SelectedIndex)
            {
                case 0:
                    _dataGridViewTable = dataGridViewAttendance;
                    labelTable.Visible = false;
                    buttonAdd.Visible = false;
                    labelAttendance.Visible = true;
                    buttonCloseAttendance.Visible = labelAttendance.Text != $"Посещаемость за {DateTime.Today:dd.MM.yyyy}";
                    break;
                case 1:
                    _dataGridViewTable = dataGridViewPupils;
                    FillTable("SELECT Pupils.PupilId, Pupils.Fullname AS 'ФИО', Pupils.Parents  AS 'ФИО родителей', Pupils.PhoneNumber AS 'Номера телефонов родителей', Pupils.LivingAddress AS 'Адрес проживания', Pupils.HealthGroup AS 'Группа здоровья', Pupils.MedicalDiagnosis AS 'Медицинский диагноз', Pupils.Understudy AS 'Дублер', Pupils.PEGroup AS 'Группа по физич. культуре', Pupils.Diet AS 'Диета' FROM Pupils INNER JOIN Groups ON Pupils.GroupId = Groups.GroupId WHERE Groups.GroupId = " + _groupId);
                    labelTable.Visible = true;
                    buttonAdd.Visible = false;
                    labelAttendance.Visible = false;
                    buttonCloseAttendance.Visible = false;
                    labelTable.Text = "Список воспитанников";
                    break;
                case 2:
                    _dataGridViewTable = dataGridViewMethodicalWork;
                    FillTable("SELECT MethodicalWork.MethodicalWorkId, MethodicalWork.WorkSubject AS 'Предмет методической работы', MethodicalWork.WorkDay  AS 'Дата' FROM MethodicalWork WHERE MethodicalWork.EmployeeId = " + _employeeId);
                    labelTable.Visible = true;
                    buttonAdd.Visible = true;
                    labelAttendance.Visible = false;
                    buttonCloseAttendance.Visible = false;
                    labelTable.Text = "Методическая работа";
                    break;
                case 3:
                    _dataGridViewTable = dataGridViewPupilsSickLeaves;
                    FillTable("SELECT PupilsSickLeaves.SickLeaveId, Pupils.Fullname AS 'ФИО', PupilsSickLeaves.SickLeaveStart AS 'Начало болезни',PupilsSickLeaves.SickLeaveEnd AS 'Окончание болезни' FROM PupilsSickLeaves INNER JOIN Pupils ON Pupils.PupilId = PupilsSickLeaves.PupilId WHERE Pupils.GroupId = " + _groupId);
                    labelTable.Visible = true;
                    buttonAdd.Visible = true;
                    labelAttendance.Visible = false;
                    buttonCloseAttendance.Visible = false;
                    labelTable.Text = "Больничные воспитанников";
                    break;
            }
        }

        private void FillTable(string sqlCommand)
        {
            using (SqlConnection connection = new SqlConnection(AppParameters.ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, connection);

                DataSet ds = new DataSet();
                adapter.Fill(ds);
                _dataGridViewTable.DataSource = ds.Tables[0];
                _dataGridViewTable.Columns[0].Visible = false;
            }
        }

        private void dataGridViewAttendance_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                AttendanceManagement.SetPresence(Convert.ToInt32(_dataGridViewTable.Rows[e.RowIndex].Cells[0].Value), Convert.ToBoolean(_dataGridViewTable.Rows[e.RowIndex].Cells[2].Value));
            }
        }

        private void listBoxAttendance_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tabControlTables.SelectedIndex = 0;

            int index = listBoxAttendance.IndexFromPoint(e.Location);

            if (index != ListBox.NoMatches)
            {
                labelAttendance.Text = "Посещаемость за " + listBoxAttendance.Text;
                AttendanceManagement.FillTable(_dataGridViewTable, _groupId, Convert.ToDateTime(listBoxAttendance.Text));
            }

            buttonCloseAttendance.Visible = listBoxAttendance.Text != $"{DateTime.Today:dd.MM.yyyy}";
        }

        private void buttonCloseAttendance_Click(object sender, EventArgs e)
        {
            AttendanceManagement.FillTable(_dataGridViewTable, _groupId, DateTime.Today);
            labelAttendance.Text = $"Посещаемость за {DateTime.Today:dd.MM.yyyy}";
            buttonCloseAttendance.Visible = false;
            listBoxAttendance.SelectedIndex = 0;
        }

        private void dateTimePickerSearchAttendance_CloseUp(object sender, EventArgs e)
        {
            tabControlTables.SelectedIndex = 0;

            if (listBoxAttendance.FindString(dateTimePickerSearchAttendance.Value.ToString("dd.MM.yyyy")) == ListBox.NoMatches)
            {
                MessageBox.Show($"За {dateTimePickerSearchAttendance.Value:dd.MM.yyyy} записей нет");
                return;
            }

            AttendanceManagement.FillTable(_dataGridViewTable, _groupId, dateTimePickerSearchAttendance.Value);
            labelAttendance.Text = $"Посещаемость за {dateTimePickerSearchAttendance.Value:dd.MM.yyyy}";
            buttonCloseAttendance.Visible = labelAttendance.Text != $"Посещаемость за {DateTime.Today:dd.MM.yyyy}";
        }

        private void buttonMethodicalProvision_Click(object sender, EventArgs e)
        {
            var provisionForm = new ProvisionMonitoringForm(MethodicalProvisionTableName, _groupId);
            provisionForm.Show();
        }

        private void buttonResourceProvision_Click(object sender, EventArgs e)
        {
            var provisionForm = new ProvisionMonitoringForm(ResourceProvisionTableName, _groupId);
            provisionForm.Show();
        }

        private void buttonEditAccount_Click(object sender, EventArgs e)
        {
            EditAccountForm editAccountForm = new EditAccountForm(_accountId);
            editAccountForm.ShowDialog();
        }

        private void DataGridViewTableMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int hti = _dataGridViewTable.HitTest(e.X, e.Y).RowIndex;

                if (hti >= 0)
                {
                    if (!_dataGridViewTable.Rows[hti].Selected)
                    {
                        _dataGridViewTable.ClearSelection();
                        _dataGridViewTable.Rows[hti].Selected = true;
                    }

                    if (_dataGridViewTable.SelectedRows.Count > 1)
                    {
                        подробноToolStripMenuItem.Enabled = false;
                        изменитьToolStripMenuItem.Enabled = false;
                    }
                    else
                    {
                        подробноToolStripMenuItem.Enabled = true;
                        изменитьToolStripMenuItem.Enabled = true;
                    }

                    contextMenuStrip.Show(_dataGridViewTable, new Point(e.X, e.Y));
                }
            }
        }

        private void dataGridViewMethodicalWork_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridViewTableMouseDown(e);
        }

        private void dataGridViewPupilsSickLeaves_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridViewTableMouseDown(e);
        }

        private void подробноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDetails();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (tabControlTables.SelectedIndex)
            {
                case 2:
                    var methodicalWorkEditForm = new MethodicalWorkEditForm(_dataGridViewTable.SelectedRows[0]);
                    methodicalWorkEditForm.ShowDialog();
                    break;
                case 3:
                    var pupilSickLeaveEditForm = new PupilSickLeaveEditForm(_groupId, _dataGridViewTable.SelectedRows[0]);
                    pupilSickLeaveEditForm.ShowDialog();
                    break;
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (tabControlTables.SelectedIndex)
            {
                case 2:
                    MethodicalWorkController.DeleteMethodicalWork(_dataGridViewTable);
                    break;
                case 3:
                    PupilsSickLeaveController.DeleteSickLeave(_dataGridViewTable);
                    break;
            }
        }
        
        private void OpenDetails()
        {
            var detailsForm = new DetailsForm(_dataGridViewTable.Columns, _dataGridViewTable.SelectedRows[0]);
            detailsForm.ShowDialog();
        }

        private void dataGridViewMethodicalWork_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenDetails();
        }

        private void dataGridViewPupilsSickLeaves_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenDetails();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            switch (tabControlTables.SelectedIndex)
            {
                case 2:
                    var methodicalWorkAddForm = new MethodicalWorkAddForm(_employeeId, _dataGridViewTable);
                    methodicalWorkAddForm.ShowDialog();
                    break;
                case 3:
                    var pupilSickLeaveAddForm = new PupilSickLeaveAddForm(_groupId, _dataGridViewTable);
                    pupilSickLeaveAddForm.ShowDialog();
                    break;
            }
        }

        private void buttonCreateSchedule_Click(object sender, EventArgs e)
        {
            if (!ScheduleAvailability())
            {
                if (MessageBox.Show("Для данной группы нет расписания. Составить?", "Составление расписания расписания", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var createScheduleForm = new CreateScheduleForm(_groupId, _groupName);
                    createScheduleForm.Show();
                }
            }
            else
            {
                ScheduleForm scheduleForm = new ScheduleForm(_groupId, _groupName);
                scheduleForm.ShowDialog();
            }
        }

        private bool ScheduleAvailability()
        {
            bool scheduleAvailability = false; 

            string sqlCommand = $"SELECT * FROM Schedule WHERE GroupId = {_groupId}";

            SqlConnection con = new SqlConnection(AppParameters.ConnectionString);
            con.Open();

            SqlCommand command = con.CreateCommand();
            command.CommandText = sqlCommand;

            var row = command.ExecuteScalar();

            con.Close();

            if (row != null)
            {
                scheduleAvailability = true;
            }

            return scheduleAvailability;
        }

        private void LoadChart()
        {
            int presenceCount = GetPresenceAndAllPupils(" AND Attendance.Presence = 1");
            int absenceCount = GetPresenceAndAllPupils() - presenceCount;

            double[] yValues = { presenceCount, absenceCount };
            string[] xValues = { "Присутствует", "Отсутствует" };
            chartAverageAttendance.Series[0].Points.DataBindXY(xValues, yValues);

            chartAverageAttendance.Series[0].Label = "#PERCENT{P}";
            chartAverageAttendance.Series[0].LegendText = "#VALX";
        }

        private int GetPresenceAndAllPupils(string sqlAddition = "")
        {
            SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
            connection.Open();

            string sql = $"SELECT COUNT(Attendance.PupilId) FROM Attendance INNER JOIN Pupils ON Pupils.PupilId = Attendance.PupilId WHERE Pupils.GroupId = {_groupId}" + sqlAddition;

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            connection.Close();

            return count;
        }

        private void CheckControlForTodayAndTomorrow()
        {
            using (SqlConnection connection = new SqlConnection(AppParameters.ConnectionString))
            {
                string sqlCommand = $"SELECT ISNULL(ControlSchedule.Day{DateTime.Today.Day}, -1) FROM ControlSchedule WHERE ControlSchedule.Fullname = '{_fullName}'";

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, connection);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (Convert.ToInt32(dataTable.Rows[0][0]) != -1)
                {
                    labelControlHint.Visible = true;
                    labelControlHint.Text += $" Сегодня, Тема № {dataTable.Rows[0][0]}";
                }
                else
                {
                    sqlCommand = $"SELECT ISNULL(ControlSchedule.Day{DateTime.Today.Day + 1}, -1) FROM ControlSchedule WHERE ControlSchedule.Fullname = '{_fullName}'";

                    adapter = new SqlDataAdapter(sqlCommand, connection);

                    dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (Convert.ToInt32(dataTable.Rows[0][0]) != -1)
                    {
                        labelControlHint.Visible = true;
                        labelControlHint.Text += $" Завтра, Тема № {dataTable.Rows[0][0]}";
                    }
                }
            }
        }

        private void buttonControlSchedule_Click(object sender, EventArgs e)
        {
            var employeeControlScheduleForm = new EmployeeControlScheduleForm(_employeeId);
            employeeControlScheduleForm.ShowDialog();
        }
    }
}