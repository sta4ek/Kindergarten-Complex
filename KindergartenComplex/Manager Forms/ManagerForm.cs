using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using KindergartenComplex.Manager_Forms.Academic_Plan;
using KindergartenComplex.Manager_Forms.Attendance_Reports;
using KindergartenComplex.Manager_Forms.Control_List;
using KindergartenComplex.Manager_Forms.Control_Schedule;
using KindergartenComplex.Manager_Forms.Employees;
using KindergartenComplex.Manager_Forms.Groups;
using KindergartenComplex.Manager_Forms.Labor_Safety_Exam;
using KindergartenComplex.Manager_Forms.Methodical_Work_Reports;
using KindergartenComplex.Manager_Forms.Provision;
using KindergartenComplex.Manager_Forms.Pupils;
using KindergartenComplex.Manager_Forms.SickLeave_Reports;
using KindergartenComplex.Manager_Forms.SickLeaves;
using KindergartenComplex.Manager_Forms.User_Registration;
using KindergartenComplex.Manager_Forms.Vacations;

namespace KindergartenComplex
{
    public partial class ManagerForm : Form
    {
        private readonly int _accountId;
        private readonly string _positionName;
        private readonly string _fullName;
        private DataGridView _dataGridViewTable;
        private const string MethodicalProvision = "Методическое";
        private const string ResourceProvision = "Ресурсное";

        public ManagerForm(int accountId, string fullName, string positionName)
        {
            _accountId = accountId;
            _positionName = positionName;
            _fullName = fullName;

            InitializeComponent();

            Text = _fullName + ", " + _positionName + " | " + AppParameters.KindergartenName;

            string[] name = _fullName.Split(' ');
            labelShortName.Text = name[0] + " " + name[1][0] + ". " + name[2][0] + ".";

            Point shortNamePoint = new Point(Width - labelShortName.Width - 28, 4);
            labelShortName.Location = shortNamePoint;

            FillTables();

            dataGridViewEmployees.Columns[1].FillWeight = 200;

            dataGridViewGroups.Columns[1].FillWeight = 30;

            dataGridViewPupils.Columns[1].FillWeight = 200;
            dataGridViewPupils.Columns[3].FillWeight = 230;
            dataGridViewPupils.Columns[8].FillWeight = 60;

            LoadChart();

            CheckForControlSchedule();
            CheckControlForToday();
        }

        private void ManagerForm_FormClosed(object sender, FormClosedEventArgs e)
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
                    _dataGridViewTable = dataGridViewEmployees;
                    FillTable("SELECT Employees.EmployeeId, Employees.Fullname AS 'ФИО', Positions.PositionName AS 'Должность', Employees.EmploymentDate AS 'Дата приема на работу', Employees.Education AS 'Образование', Employees.Qualification AS 'Квалификационная категория', Employees.PhoneNumber AS 'Номер телефона' FROM Employees INNER JOIN Positions ON Employees.PositionId = Positions.PositionId");

                    ((DataTable)_dataGridViewTable.DataSource).DefaultView.RowFilter = string.Empty;
                    textBoxSearch.Text = string.Empty;

                    labelOpenedTable.Text = "Список сотрудников";
                    break;
                case 1:
                    _dataGridViewTable = dataGridViewGroups;
                    FillTable("SELECT Groups.GroupId, Groups.GroupName AS 'Название группы', Employees.Fullname AS 'Воспитатель' FROM Groups INNER JOIN Employees ON Groups.EmployeeId = Employees.EmployeeId");

                    ((DataTable)_dataGridViewTable.DataSource).DefaultView.RowFilter = string.Empty;
                    textBoxSearch.Text = string.Empty;

                    labelOpenedTable.Text = "Список групп";
                    break;
                case 2:
                    _dataGridViewTable = dataGridViewPupils;
                    FillTable("SELECT Pupils.PupilId, Pupils.Fullname AS 'ФИО', Groups.GroupName AS 'Группа', Pupils.Parents AS 'ФИО родителей', Pupils.PhoneNumber AS 'Номера телефонов родителей', Pupils.LivingAddress AS 'Адрес проживания', Pupils.HealthGroup AS 'Группа здоровья', Pupils.MedicalDiagnosis AS 'Медицинский диагноз', Pupils.Understudy AS 'Дублер', Pupils.PEGroup AS 'Группа по физич. культуре', Pupils.Diet AS 'Диета' FROM Pupils INNER JOIN Groups ON Pupils.GroupId = Groups.GroupId");

                    ((DataTable)_dataGridViewTable.DataSource).DefaultView.RowFilter = string.Empty;
                    textBoxSearch.Text = string.Empty;

                    labelOpenedTable.Text = "Список воспитанников";
                    break;
                case 3:
                    _dataGridViewTable = dataGridViewVacations;
                    FillTable("SELECT Vacations.VacationId, Employees.Fullname AS 'ФИО', Vacations.VacationStart AS 'Начало отпуска', Vacations.VacationEnd AS 'Окончание отпуска' FROM Vacations INNER JOIN Employees ON Vacations.EmployeeId = Employees.EmployeeId");

                    ((DataTable)_dataGridViewTable.DataSource).DefaultView.RowFilter = string.Empty;
                    textBoxSearch.Text = string.Empty;

                    labelOpenedTable.Text = "Назначение отпусков";
                    break;
                case 4:
                    _dataGridViewTable = dataGridViewSickLeaves;
                    FillTable("SELECT SickLeaves.SickLeaveId, Employees.Fullname AS 'ФИО', SickLeaves.SickLeaveStart AS 'Начало больничного', SickLeaves.SickLeaveEnd AS 'Окончание больничного' FROM SickLeaves INNER JOIN Employees ON SickLeaves.EmployeeId = Employees.EmployeeId");

                    ((DataTable)_dataGridViewTable.DataSource).DefaultView.RowFilter = string.Empty;
                    textBoxSearch.Text = string.Empty;

                    labelOpenedTable.Text = "Больничные сотрудников";
                    break;
            }
        }

        private void FillTables()
        {
            _dataGridViewTable = dataGridViewGroups;
            FillTable("SELECT Groups.GroupId, Groups.GroupName  AS 'Название группы', Employees.Fullname AS 'Воспитатель' FROM Groups INNER JOIN Employees ON Groups.EmployeeId = Employees.EmployeeId");
            _dataGridViewTable = dataGridViewPupils;
            FillTable("SELECT Pupils.PupilId, Pupils.Fullname AS 'ФИО', Groups.GroupName AS 'Группа', Pupils.Parents AS 'ФИО родителей', Pupils.PhoneNumber  AS 'Номера телефонов родителей', Pupils.LivingAddress AS 'Адрес проживания', Pupils.HealthGroup AS 'Группа здоровья', Pupils.MedicalDiagnosis AS 'Медицинский диагноз', Pupils.Understudy AS 'Дублёр', Pupils.PEGroup AS 'Группа по физич. культуре', Pupils.Diet AS 'Диета' FROM Pupils INNER JOIN Groups ON Pupils.GroupId = Groups.GroupId");
            _dataGridViewTable = dataGridViewVacations;
            FillTable("SELECT Vacations.VacationId, Employees.Fullname AS 'ФИО сотрудника', Vacations.VacationStart AS 'Начало отпуска', Vacations.VacationEnd AS 'Окончание отпуска' FROM Vacations INNER JOIN Employees ON Vacations.EmployeeId = Employees.EmployeeId");
            _dataGridViewTable = dataGridViewSickLeaves;
            FillTable("SELECT SickLeaves.SickLeaveId, Employees.Fullname AS 'ФИО сотрудника', SickLeaves.SickLeaveStart AS 'Начало больничного', SickLeaves.SickLeaveEnd AS 'Окончание больничного' FROM SickLeaves INNER JOIN Employees ON SickLeaves.EmployeeId = Employees.EmployeeId");
            _dataGridViewTable = dataGridViewEmployees;
            FillTable("SELECT Employees.EmployeeId, Employees.Fullname AS 'ФИО', Positions.PositionName AS 'Должность', Employees.EmploymentDate AS 'Дата приема на работу', Employees.Education AS 'Образование', Employees.Qualification AS 'Квалификационная категория', Employees.PhoneNumber AS 'Номер телефона' FROM Employees INNER JOIN Positions ON Employees.PositionId = Positions.PositionId");
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

        private void dataGridViewEmployees_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridViewTableMouseDown(e);
        }

        private void dataGridViewGroups_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridViewTableMouseDown(e);
        }

        private void dataGridViewPupils_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridViewTableMouseDown(e);
        }

        private void dataGridViewVacations_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridViewTableMouseDown(e);
        }

        private void dataGridViewSickLeaves_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridViewTableMouseDown(e);
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            switch (tabControlTables.SelectedIndex)
            {
                case 0:
                    var employeeAddForm = new EmployeeAddForm(_dataGridViewTable);
                    employeeAddForm.ShowDialog();
                    break;
                case 1:
                    var groupAddForm = new GroupAddForm(_dataGridViewTable);
                    groupAddForm.ShowDialog();
                    break;
                case 2:
                    var pupilAddForm = new PupilAddForm(_dataGridViewTable);
                    pupilAddForm.ShowDialog();
                    break;
                case 3:
                    var vacationAddForm = new VacationAddForm(_dataGridViewTable);
                    vacationAddForm.ShowDialog();
                    break;
                case 4:
                    var sickLeaveAddForm = new SickLeaveAddForm(_dataGridViewTable);
                    sickLeaveAddForm.ShowDialog();
                    break;
            }
        }

        private void подробноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDetails();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (tabControlTables.SelectedIndex)
            {
                case 0:
                    EmployeeController.DeleteEmployee(_dataGridViewTable);
                    break;
                case 1:
                    GroupController.DeleteGroup(_dataGridViewTable);
                    break;
                case 2:
                    PupilController.DeletePupil(_dataGridViewTable);
                    break;
                case 3:
                    VacationController.DeleteVacation(_dataGridViewTable);
                    break;
                case 4:
                    SickLeaveController.DeleteSickLeave(_dataGridViewTable);
                    break;
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (tabControlTables.SelectedIndex)
            {
                case 0:
                    var employeeEditForm = new EmployeeEditForm(_dataGridViewTable.SelectedRows[0]);
                    employeeEditForm.ShowDialog();
                    break;
                case 1:
                    var groupEditForm = new GroupEditForm(_dataGridViewTable.SelectedRows[0]);
                    groupEditForm.ShowDialog();
                    break;
                case 2:
                    var pupilEditForm = new PupilEditForm(_dataGridViewTable.SelectedRows[0]);
                    pupilEditForm.ShowDialog();
                    break;
                case 3:
                    var vacationEditForm = new VacationEditForm(_dataGridViewTable.SelectedRows[0]);
                    vacationEditForm.ShowDialog();
                    break;
                case 4:
                    var sickLeaveEditForm = new SickLeaveEditForm(_dataGridViewTable.SelectedRows[0]);
                    sickLeaveEditForm.ShowDialog();
                    break;
            }
        }

        private void dataGridViewEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenDetails();
        }

        private void dataGridViewGroups_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenDetails();
        }

        private void dataGridViewPupils_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenDetails();
        }

        private void dataGridViewVacations_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenDetails();
        }

        private void dataGridViewSickLeaves_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenDetails();
        }

        private void OpenDetails()
        {
            var detailsForm = new DetailsForm(_dataGridViewTable.Columns, _dataGridViewTable.SelectedRows[0]);
            detailsForm.ShowDialog();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            ((DataTable) _dataGridViewTable.DataSource).DefaultView.RowFilter = $"[{_dataGridViewTable.Columns[1].HeaderText}] like '{textBoxSearch.Text}%'";
        }

        private void buttonMethodicalProvision_Click(object sender, EventArgs e)
        {
            var provisionForm = new ProvisionForm(MethodicalProvision);
            provisionForm.ShowDialog();
        }

        private void buttonResourceProvision_Click(object sender, EventArgs e)
        {
            var provisionForm = new ProvisionForm(ResourceProvision);
            provisionForm.ShowDialog();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        private void buttonEditAccount_Click(object sender, EventArgs e)
        {
            var editAccountForm = new EditAccountForm(_accountId);
            editAccountForm.ShowDialog();
        }

        private void buttonMethodicalWorkReport_Click(object sender, EventArgs e)
        {
            var methodicalWorkReportForm = new MethodicalWorkReportForm();
            methodicalWorkReportForm.ShowDialog();
        }

        private void buttonLaborSafetyExam_Click(object sender, EventArgs e)
        {
            var laborSafetyExamForm = new LaborSafetyExamAndRetrainingCoursesForm(true);
            laborSafetyExamForm.Show();
        }

        private void buttonRetrainingCourse_Click(object sender, EventArgs e)
        {
            var laborSafetyExamForm = new LaborSafetyExamAndRetrainingCoursesForm(false);
            laborSafetyExamForm.Show();
        }

        private void buttonAcademicPlan_Click(object sender, EventArgs e)
        {
            var academicPlanForm = new AcademicPlanForm(_fullName, _positionName);
            academicPlanForm.ShowDialog();
        }

        private void buttonSickLeaveReport_Click(object sender, EventArgs e)
        {
            var sickLeaveReportForm = new SickLeaveReportForm();
            sickLeaveReportForm.ShowDialog();
        }

        private void buttonAttendanceReport_Click(object sender, EventArgs e)
        {
            var attendanceReportForm = new AttendanceReportForm();
            attendanceReportForm.ShowDialog();
        }

        private void LoadChart()
        {
            chartGeneralProvision.Series[0].IsValueShownAsLabel = true;

            int inStock = GetCountOfProvision("Methodical", " WHERE MethodicalAvailability.Mark = 1");
            chartGeneralProvision.Series[0].Points.AddXY(MethodicalProvision, inStock);
            chartGeneralProvision.Series[1].Points.AddXY(MethodicalProvision, GetCountOfProvision("Methodical") - inStock);

            inStock = GetCountOfProvision("Resource", " WHERE ResourceAvailability.Mark = 1");
            chartGeneralProvision.Series[0].Points.AddXY(ResourceProvision, inStock);
            chartGeneralProvision.Series[1].Points.AddXY(ResourceProvision, GetCountOfProvision("Resource") - inStock);

            chartGeneralProvision.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chartGeneralProvision.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
        }

        private int GetCountOfProvision(string tableName, string sqlAddition = "")
        {
            SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
            connection.Open();

            string sql = $"SELECT COUNT({tableName}Availability.{tableName}AvailabilityId) FROM {tableName}Availability" + sqlAddition;

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            connection.Close();

            return count;
        }

        private void CheckForControlSchedule()
        {
            SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
            connection.Open();

            string sql = "SELECT * FROM ControlSchedule";

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            var row = cmd.ExecuteScalar();

            connection.Close();

            if (row == null)
            {
                FillControlSchedule();
            }
        }

        private void FillControlSchedule()
        {
            List<int> employeesIdList = new List<int>();
            List<string> employeesFullnameList = new List<string>();

            using (SqlConnection connection = new SqlConnection(AppParameters.ConnectionString))
            {
                string sqlCommand = "SELECT Employees.EmployeeId, Employees.Fullname FROM Employees INNER JOIN Positions ON Positions.PositionId = Employees.PositionId WHERE Positions.PositionName = 'Воспитатель'";

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, connection);

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    employeesIdList.Add(Convert.ToInt32(row[0]));
                    employeesFullnameList.Add(row[1].ToString());
                }
            }

            SqlConnection con = new SqlConnection(AppParameters.ConnectionString);
            con.Open();

            for(int i = 0; i < employeesIdList.Count; i++)
            {
                string sql = "INSERT INTO ControlSchedule(EmployeeId, Fullname) VALUES(@employeeId, @fullname)";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.Add("@employeeId", SqlDbType.BigInt).Value = employeesIdList[i];
                cmd.Parameters.Add("@fullname", SqlDbType.VarChar).Value = employeesFullnameList[i];

                int rowCount = cmd.ExecuteNonQuery();
            }

            con.Close();
        }

        private void buttonControlSchedule_Click(object sender, EventArgs e)
        {
            var controlScheduleForm = new ControlScheduleForm();
            controlScheduleForm.ShowDialog();
        }

        private void CheckControlForToday()
        {
            using (SqlConnection connection = new SqlConnection(AppParameters.ConnectionString))
            {
                string sqlCommand = $"SELECT ControlSchedule.Fullname FROM ControlSchedule WHERE ControlSchedule.Day{DateTime.Today.Day} IS NOT NULL";

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, connection);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count == 0)
                {
                    linkLabelControlHint.Text += " Контроля нет";
                }
                else
                {
                    linkLabelControlHint.Enabled = true;

                    string[] name = dataTable.Rows[0][0].ToString().Split(' ');
                    linkLabelControlHint.Text += name[0] + " " + name[1][0] + ". " + name[2][0] + ".";

                    if (dataTable.Rows.Count - 1 > 0)
                    {
                        linkLabelControlHint.Text += " и еще " + (dataTable.Rows.Count - 1);
                    }
                }
            }
        }

        private void linkLabelControlHint_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ControlListForm controlListForm = new ControlListForm();
            controlListForm.ShowDialog();
        }
    }
}