using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace KindergartenComplex.Manager_Forms.Attendance_Reports
{
    public partial class AttendanceReportForm : Form
    {
        private DataTable _table;

        public AttendanceReportForm()
        {
            InitializeComponent();

            Text += AppParameters.KindergartenName;

            FillComboBoxGroups();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FillTable($"SELECT Tbl.Дата, Tbl.[Присутствовало воспитанников], Tbl2.[Всего воспитанников] FROM (SELECT Attendance.CheckDay AS 'Дата', COUNT(Attendance.Presence) AS 'Присутствовало воспитанников' FROM Attendance INNER JOIN Pupils ON Pupils.PupilId = Attendance.PupilId WHERE Pupils.GroupId = {GetGroupId()} AND MONTH(Attendance.CheckDay) = {dateTimePickerWorkMonth.Value.Month} AND Attendance.Presence = 1 GROUP BY Attendance.CheckDay) AS Tbl INNER JOIN (SELECT Attendance.CheckDay AS 'Дата', COUNT(Attendance.Presence) AS 'Всего воспитанников' FROM Attendance INNER JOIN Pupils ON Pupils.PupilId = Attendance.PupilId WHERE Pupils.GroupId = {GetGroupId()} AND MONTH(Attendance.CheckDay) = {dateTimePickerWorkMonth.Value.Month} GROUP BY Attendance.CheckDay) AS Tbl2 ON Tbl2.Дата = Tbl.Дата");
            labelHint.Visible = false;
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintDocument document = new PrintDocument();
            printPreviewDialog.ClientSize = new Size(500, 400);
            printPreviewDialog.Location = new Point(0, 0);
            document.PrintPage += Doc_PrintPage;
            printPreviewDialog.Document = document;
            printPreviewDialog.WindowState = FormWindowState.Maximized;
            printPreviewDialog.ShowDialog();
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            string result = "\t\t\t Отчёт о посещаемости за месяц" + "\n\n" +
                            "Группа: " + comboBoxGroup.Text + "\n" +
                            "Месяц: " + dateTimePickerWorkMonth.Value.ToString("MMMM yyyy") + "\n\n" +
                            "Дата - Присутствовало воспитанников - Всего воспитанников" + "\n\n";

            foreach (DataGridViewRow row in dataGridViewAttendanceReport.Rows)
            {
                result += Convert.ToDateTime(row.Cells[0].Value).ToString("dd.MM.yyyy") + " - " + row.Cells[1].Value + "\t - " + row.Cells[2].Value + "\n";
            }

            e.Graphics.DrawString(result, new Font("Consolas", 14), Brushes.Black, 0, 0);
        }

        private void FillTable(string sqlCommand)
        {
            using (SqlConnection connection = new SqlConnection(AppParameters.ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, connection);

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    dataGridViewAttendanceReport.Columns.Clear();
                    labelNoRows.Visible = true;
                    buttonPrint.Enabled = false;
                }
                else
                {
                    labelNoRows.Visible = false;
                    buttonPrint.Enabled = true;
                    dataGridViewAttendanceReport.DataSource = ds.Tables[0];
                }

            }
        }

        private void FillComboBoxGroups()
        {
            using (SqlConnection connection = new SqlConnection(AppParameters.ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(@"SELECT Groups.GroupName, Groups.GroupId FROM Groups", connection);

                _table = new DataTable();
                da.Fill(_table);
                comboBoxGroup.DataSource = _table;
                comboBoxGroup.DisplayMember = _table.Columns[0].ColumnName;
            }
        }

        private string GetGroupId()
        {
            string groupId = "";

            foreach (DataRow row in _table.Rows)
            {
                var cells = row.ItemArray;

                if (cells[0].ToString() == comboBoxGroup.Text)
                {
                    groupId = cells[1].ToString();
                    break;
                }
            }

            return groupId;
        }
    }
}
