using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KindergartenComplex.Manager_Forms.Labor_Safety_Exam
{
    public partial class LaborSafetyExamAndRetrainingCoursesForm : Form
    {
        private readonly bool _isExam;

        public LaborSafetyExamAndRetrainingCoursesForm(bool isExam)
        {
            _isExam = isExam;

            InitializeComponent();

            if (_isExam)
            {
                labelHeader.Text = Text = "Экзамен по охране труда";
                Text = "Экзамен по охране труда | ";
                LaborSafetyExamAndRetrainingController.FillTable(dataGridViewLaborSafetyExam, "SELECT LaborSafetyExam.LaborSafetyExamId, Employees.Fullname AS 'ФИО', LaborSafetyExam.ExamDate AS 'Дата', LaborSafetyExam.Mark AS 'Отметка о выполнении' FROM LaborSafetyExam INNER JOIN Employees ON Employees.EmployeeId = LaborSafetyExam.EmployeeId");
            }
            else
            {
                labelHeader.Text = Text = "Курсовая переподготовка";
                Text = "Курсовая переподготовка | ";
                LaborSafetyExamAndRetrainingController.FillTable(dataGridViewLaborSafetyExam, "SELECT RetrainingCourses.RetrainingCourseId, Employees.Fullname AS 'ФИО', RetrainingCourses.CourseDate AS 'Дата', RetrainingCourses.Mark AS 'Отметка о выполнении' FROM RetrainingCourses INNER JOIN Employees ON Employees.EmployeeId = RetrainingCourses.EmployeeId");
            }

            Text += AppParameters.KindergartenName;

            dataGridViewLaborSafetyExam.Columns[1].ReadOnly = true;
            dataGridViewLaborSafetyExam.Columns[2].ReadOnly = true;

            dataGridViewLaborSafetyExam.Columns[1].FillWeight = 200;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var laborSafetyExamAndRetrainingCoursesAddForm = new LaborSafetyExamAndRetrainingCoursesAddForm(_isExam, dataGridViewLaborSafetyExam);
            laborSafetyExamAndRetrainingCoursesAddForm.ShowDialog();
        }

        private void dataGridViewLaborSafetyExam_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                LaborSafetyExamAndRetrainingController.SetMark(_isExam, Convert.ToInt32(dataGridViewLaborSafetyExam.Rows[e.RowIndex].Cells[0].Value), Convert.ToBoolean(dataGridViewLaborSafetyExam.Rows[e.RowIndex].Cells[3].Value));
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)dataGridViewLaborSafetyExam.DataSource).DefaultView.RowFilter =
                $"{dataGridViewLaborSafetyExam.Columns[1].HeaderText} like '{textBoxSearch.Text}%'";
        }

        private void подробноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDetails();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var laborSafetyExamAndRetrainingCoursesEditForm = new LaborSafetyExamAndRetrainingCoursesEditForm(dataGridViewLaborSafetyExam.SelectedRows[0], _isExam);
            laborSafetyExamAndRetrainingCoursesEditForm.ShowDialog();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            LaborSafetyExamAndRetrainingController.DeleteRow(dataGridViewLaborSafetyExam, _isExam);
        }

        private void dataGridViewLaborSafetyExam_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenDetails();
        }

        private void dataGridViewLaborSafetyExam_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridViewTableMouseDown(e);
        }

        private void OpenDetails()
        {
            var detailsForm = new DetailsForm(dataGridViewLaborSafetyExam.Columns, dataGridViewLaborSafetyExam.SelectedRows[0]);
            detailsForm.ShowDialog();
        }

        private void DataGridViewTableMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int hti = dataGridViewLaborSafetyExam.HitTest(e.X, e.Y).RowIndex;

                if (hti >= 0)
                {
                    if (!dataGridViewLaborSafetyExam.Rows[hti].Selected)
                    {
                        dataGridViewLaborSafetyExam.ClearSelection();
                        dataGridViewLaborSafetyExam.Rows[hti].Selected = true;
                    }

                    if (dataGridViewLaborSafetyExam.SelectedRows.Count > 1)
                    {
                        подробноToolStripMenuItem.Enabled = false;
                        изменитьToolStripMenuItem.Enabled = false;
                    }
                    else
                    {
                        подробноToolStripMenuItem.Enabled = true;
                        изменитьToolStripMenuItem.Enabled = true;
                    }

                    contextMenuStrip.Show(dataGridViewLaborSafetyExam, new Point(e.X, e.Y));
                }
            }
        }
    }
}
