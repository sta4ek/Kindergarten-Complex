using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace KindergartenComplex.Manager_Forms.Methodical_Work_Reports
{
    public partial class MethodicalWorkReportForm : Form
    {
        private DataTable _table;

        public MethodicalWorkReportForm()
        {
            InitializeComponent();

            Text += AppParameters.KindergartenName;

            FillComboBoxEmployees();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FillTable($"SELECT MethodicalWork.WorkSubject  AS 'Предмет методической работы', MethodicalWork.WorkDay AS 'Дата' FROM MethodicalWork WHERE MethodicalWork.EmployeeId = {GetEmployeeId()} AND MONTH(MethodicalWork.WorkDay) = {dateTimePickerWorkMonth.Value.Month}");
            labelHint.Visible = false;
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
                    dataGridViewMethodicalWork.Columns.Clear();
                    labelNoRows.Visible = true;
                    buttonPrint.Enabled = false;
                }
                else
                {
                    labelNoRows.Visible = false;
                    buttonPrint.Enabled = true;
                    dataGridViewMethodicalWork.DataSource = ds.Tables[0];
                }
                
            }
        }

        private void FillComboBoxEmployees()
        {
            using (SqlConnection connection = new SqlConnection(AppParameters.ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(@"SELECT Employees.Fullname, Employees.EmployeeId FROM Employees INNER JOIN Positions ON Employees.PositionId = Positions.PositionId WHERE Positions.PositionName = 'Воспитатель'", connection);

                _table = new DataTable();
                da.Fill(_table);
                comboBoxEmployee.DataSource = _table;
                comboBoxEmployee.DisplayMember = _table.Columns[0].ColumnName;
            }
        }

        private string GetEmployeeId()
        {
            string employeeId = "";

            foreach (DataRow row in _table.Rows)
            {
                var cells = row.ItemArray;

                if (cells[0].ToString() == comboBoxEmployee.Text)
                {
                    employeeId = cells[1].ToString();
                    break;
                }
            }

            return employeeId;
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
            string result = "\t\t\t Отчёт о методической работе за месяц" + "\n\n" +
                            "Воспитатель: " + comboBoxEmployee.Text + "\n" +
                            "Группа: " + GetGroupName() + "\n" +
                            "Месяц: " + dateTimePickerWorkMonth.Value.ToString("MMMM yyyy") + "\n\n";

            foreach (DataGridViewRow row in dataGridViewMethodicalWork.Rows)
            {
                result += Convert.ToDateTime(row.Cells[1].Value).ToString("dd.MM.yyyy") + " - " + row.Cells[0].Value + "\n";
            }

            e.Graphics.DrawString(result, new Font("Consolas", 14), Brushes.Black, 0, 0);
        }

        private string GetGroupName()
        {
            SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
            connection.Open();

            string sql = "SELECT Groups.GroupName FROM Groups WHERE Groups.EmployeeId = @employeeId";

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add("@employeeId", SqlDbType.BigInt).Value = Convert.ToInt32(GetEmployeeId());

            object groupName = cmd.ExecuteScalar();

            connection.Close();

            return groupName.ToString();
        }
    }
}
