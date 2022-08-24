using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace KindergartenComplex.Manager_Forms.SickLeave_Reports
{
    public partial class SickLeaveReportForm : Form
    {
        private DataTable _table;

        public SickLeaveReportForm()
        {
            InitializeComponent();

            Text += AppParameters.KindergartenName;

            FillComboBoxGroups();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FillTable($"SELECT Pupils.Fullname, PupilsSickLeaves.SickLeaveStart, PupilsSickLeaves.SickLeaveEnd FROM PupilsSickLeaves INNER JOIN Pupils ON Pupils.PupilId = PupilsSickLeaves.PupilId WHERE Pupils.GroupId = {GetGroupId()} AND (MONTH(PupilsSickLeaves.SickLEaveStart) = {dateTimePickerWorkMonth.Value.Month} OR MONTH(PupilsSickLeaves.SickLEaveEnd) = {dateTimePickerWorkMonth.Value.Month})");
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
            string result = "\t\t\t Отчёт о заболеваемости за месяц" + "\n\n" +
                            "Группа: " + comboBoxGroup.Text + "\n" +
                            "Месяц: " + dateTimePickerWorkMonth.Value.ToString("MMMM yyyy") + "\n\n" + 
                            "ФИО воспитанника - Пропущено рабочих дней по болезни" + "\n\n";

            foreach (DataGridViewRow row in dataGridViewReport.Rows)
            {
                result += row.Cells[0].Value + " - " + row.Cells[1].Value + "\n";
            }

            e.Graphics.DrawString(result, new Font("Consolas", 14), Brushes.Black, 0, 0);
        }

        private void FillTable(string sqlCommand)
        {
            using (SqlConnection connection = new SqlConnection(AppParameters.ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, connection);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                DataTable dataTableOutput = SickLeaveReportController.CalculateSickLeavesDays(dataTable, dateTimePickerWorkMonth);

                if (dataTableOutput.Rows.Count == 0)
                {
                    dataGridViewReport.Columns.Clear();
                    labelNoRows.Visible = true;
                    buttonPrint.Enabled = false;
                }
                else
                {
                    labelNoRows.Visible = false;
                    buttonPrint.Enabled = true;
                    dataGridViewReport.DataSource = dataTableOutput;
                    dataGridViewReport.Columns[0].HeaderText = "ФИО воспитанника";
                    dataGridViewReport.Columns[1].HeaderText = "Дней пропущено";
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
