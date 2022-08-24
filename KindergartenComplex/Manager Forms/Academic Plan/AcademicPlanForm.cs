using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace KindergartenComplex.Manager_Forms.Academic_Plan
{
    public partial class AcademicPlanForm : Form
    {
        private readonly string _creatorFullName;
        private readonly string _positionName;

        private DataSet _ds;
        private SqlDataAdapter _adapter;
        private const string Sql = "SELECT AcademicPlan.AcademicPlanId, AcademicPlan.EducationalArea AS 'Предметная облать', AcademicPlan.FirstYoungHrs AS 'Превая младшая (часов)', AcademicPlan.SecondYoungHrs AS 'Вторая младшая (часов)', AcademicPlan.MiddleHrs AS 'Средняя (часов)', AcademicPlan.SeniorHrs AS 'Старшая (часов)' FROM AcademicPlan";

        private readonly int[] _groupMaxLoad = { 100, 180, 280, 375};

        private readonly int[] _groupClassDuration = { 10, 15, 20, 25 };

        private readonly List<Label> _labelsValuesList = new List<Label>();

        private int _y;
        private int _successLabelMoveDown = -1;

        public AcademicPlanForm(string creatorFullName, string positionName)
        {
            _creatorFullName = creatorFullName;
            _positionName = positionName;

            InitializeComponent();

            Text += AppParameters.KindergartenName;

            _labelsValuesList.Add(labelFirstYoungValue);
            _labelsValuesList.Add(labelSecondYoungValue);
            _labelsValuesList.Add(labelMiddleValue);
            _labelsValuesList.Add(labelSeniorValue);

            FillTable();

            ComplianceOut();
        }

        private void FillTable()
        {
            using (SqlConnection connection = new SqlConnection(AppParameters.ConnectionString))
            {
                _adapter = new SqlDataAdapter(Sql, connection);

                _ds = new DataSet();
                _adapter.Fill(_ds);
                dataGridViewAcademicPlan.DataSource = _ds.Tables[0];

                dataGridViewAcademicPlan.Columns[0].Visible = false;
                dataGridViewAcademicPlan.Columns[1].ReadOnly = true;

                dataGridViewAcademicPlan.Columns[1].FillWeight = 280;
                dataGridViewAcademicPlan.Columns[2].FillWeight = 110;
                dataGridViewAcademicPlan.Columns[3].FillWeight = 110;
            }

            foreach (DataGridViewColumn column in dataGridViewAcademicPlan.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveTable();

            labelSuccess.Visible = true;
            _y = Height;
            timer.Start();
        }

        private void DrawText(int y)
        {
            Point shortNamePoint = new Point(990, y);
            labelSuccess.Location = shortNamePoint;
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

        private void dataGridViewAcademicPlan_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Неверный формат введённых данных!");
        }

        private void ComplianceOut()
        {
            int j = 0;

            for (int i = 2; i < dataGridViewAcademicPlan.Columns.Count; i++)
            {
                double currentTotalHours = 0;

                foreach (DataGridViewRow row in dataGridViewAcademicPlan.Rows)
                {
                    currentTotalHours += Convert.ToDouble(row.Cells[i].Value);
                }

                _labelsValuesList[j].Text = (currentTotalHours * _groupClassDuration[j]).ToString();

                j++;
            }
        }

        private void dataGridViewAcademicPlan_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ComplianceCheckForColumn(e.ColumnIndex);
        }

        private void ComplianceCheckForColumn(int columnIndex)
        {
            double currentTotalHours = 0;

            foreach (DataGridViewRow row in dataGridViewAcademicPlan.Rows)
            {
                if (row.Cells[columnIndex].Value.ToString() == "")
                {
                    row.Cells[columnIndex].Value = 0;
                }

                currentTotalHours += Convert.ToDouble(row.Cells[columnIndex].Value);
            }

            _labelsValuesList[columnIndex - 2].Text = (currentTotalHours * _groupClassDuration[columnIndex - 2]).ToString();
            _labelsValuesList[columnIndex - 2].ForeColor = Color.Black;
            buttonSave.Enabled = true;
            menuStrip.Enabled = true;

            if (currentTotalHours * _groupClassDuration[columnIndex - 2] > _groupMaxLoad[columnIndex - 2])
            {
                _labelsValuesList[columnIndex - 2].ForeColor = Color.Red;
                buttonSave.Enabled = false;
                menuStrip.Enabled = false;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (timer.Interval == 2000)
            {
                timer.Interval = 5;
            }

            if (_y <= 675)
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

        private List<string> GetPlanValues()
        {
            List<string> planValues = new List<string>();

            foreach (DataGridViewRow row in dataGridViewAcademicPlan.Rows)
            {
                for (int i = 2; i < row.Cells.Count; i++)
                {
                    planValues.Add(row.Cells[i].Value.ToString());
                }
            }

            for (int i = 2; i < dataGridViewAcademicPlan.Columns.Count; i++)
            {
                double currentTotalHours = 0;

                foreach (DataGridViewRow row in dataGridViewAcademicPlan.Rows)
                {
                    currentTotalHours += Convert.ToDouble(row.Cells[i].Value);
                }

                planValues.Add(currentTotalHours.ToString());
            }

            planValues.AddRange(ExtraValues());

            return planValues;
        }

        private List<string> ExtraValues()
        {
            List<string> values = new List<string>();

            int nextYear = DateTime.Today.Year + 1;

            values.Add(DateTime.Today.Year + "/" + nextYear);
            values.Add(GetManagerName());
            values.Add(_positionName + " " +  _creatorFullName);
            values.Add(DateTime.Today.Year.ToString());
            values.Add(AppParameters.KindergartenName);
            values.Add(AppParameters.KindergartenName);

            return values;
        }

        private string GetManagerName()
        {
            SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
            connection.Open();

            string sql = "SELECT Employees.Fullname FROM Employees INNER JOIN Positions ON Employees.PositionId = Positions.PositionId WHERE Positions.PositionName = 'Заведующий'";

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            var fullName = cmd.ExecuteScalar();

            connection.Close();

            string[] name = fullName.ToString().Split(' ');

            return name[0] + " " + name[1][0] + ". " + name[2][0] + ".";
        }

        private void сохранитьВWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string docPath = saveFileDialog.FileName;

            progressBar.Visible = true;

            progressBar.PerformStep();

            Word.Application app = new Word.Application();
            Word.Document doc;

            try
            {
                doc = app.Documents.Add(Environment.CurrentDirectory + "\\bookmarks.docx");
                doc.Activate();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

                progressBar.Value = progressBar.Maximum;
                progressBar.Visible = false;
                return;
            }

            progressBar.PerformStep();

            Word.Bookmarks wBookmarks = doc.Bookmarks;
            Word.Range wRange;

            progressBar.PerformStep();

            int i = 0;

            List<string> planValues = GetPlanValues();

            foreach (Word.Bookmark mark in wBookmarks)
            {
                wRange = mark.Range;
                wRange.Text = planValues[i];
                i++;
                progressBar.PerformStep();
            }

            doc.SaveAs(docPath);
            doc.Close();
            progressBar.Value = progressBar.Maximum;
            progressBar.Visible = false;

            labelSuccess.Visible = true;
            _y = Height;
            timer.Start();
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Word.Application app = new Word.Application();
            Word.Document doc;

            try
            {
                doc = app.Documents.Add(Environment.CurrentDirectory + "\\bookmarks.docx");
                doc.Activate();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }

            Word.Bookmarks wBookmarks = doc.Bookmarks;
            Word.Range wRange;

            int i = 0;

            List<string> planValues = GetPlanValues();

            foreach (Word.Bookmark mark in wBookmarks)
            {
                wRange = mark.Range;
                wRange.Text = planValues[i];
                i++;
            }

            doc.SaveAs(Environment.CurrentDirectory + "\\academicPlanForPrint.docx");

            doc.PrintOut();

            doc.Close();

            File.Delete(Environment.CurrentDirectory + "\\academicPlanForPrint.docx");
        }
    }
}
