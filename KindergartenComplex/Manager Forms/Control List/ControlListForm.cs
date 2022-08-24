using System;
using System.Data;
using System.Data.SqlClient;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Forms;

namespace KindergartenComplex.Manager_Forms.Control_List
{
    public partial class ControlListForm : Form
    {
        public ControlListForm()
        {
            InitializeComponent();

            Text += AppParameters.KindergartenName;

            FillTable();
        }

        private void FillTable()
        {
            using (SqlConnection connection = new SqlConnection(AppParameters.ConnectionString))
            {
                string sqlCommand = $"SELECT ControlSchedule.Fullname AS 'Воспитатель', ControlSchedule.Day{DateTime.Today.Day} AS '№ темы', ControlTopics.TopicName AS 'Название темы' FROM ControlSchedule INNER JOIN ControlTopics ON ControlTopics.TopicNumber = ControlSchedule.Day{DateTime.Today.Day} WHERE ControlSchedule.Day{DateTime.Today.Day} IS NOT NULL";

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, connection);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewControlList.DataSource = dataTable;
                dataGridViewControlList.Columns[0].FillWeight = 50;
                dataGridViewControlList.Columns[1].FillWeight = 15;
            }
        }

        private void buttonPrintCard_Click(object sender, EventArgs e)
        {
            try
            {
                Word.Application app = new Word.Application();

                var doc = app.Documents.Add(Environment.CurrentDirectory + "\\Карточки контроля\\ControlCard" + dataGridViewControlList.SelectedRows[0].Cells[1].Value + ".docx");
                doc.Activate();

                doc.PrintOut();

                doc.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
