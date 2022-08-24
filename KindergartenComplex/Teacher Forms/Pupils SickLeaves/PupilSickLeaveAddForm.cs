using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KindergartenComplex.Teacher_Forms.Pupils_SickLeaves
{
    public partial class PupilSickLeaveAddForm : Form
    {
        private readonly int _groupId;
        private DataTable _table;
        private readonly DataGridView _dataGridView;

        public PupilSickLeaveAddForm(int groupId, DataGridView dataGridView)
        {
            _dataGridView = dataGridView;
            _groupId = groupId;

            InitializeComponent();

            Text += AppParameters.KindergartenName;

            FillComboBoxPupil();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string[] paramsList = { GetPupilId(), dateTimePickerSickLeaveStart.Value.ToString(), dateTimePickerSickLeaveEnd.Value.ToString() };

            int rowId = PupilsSickLeaveController.AddSickLeave(paramsList);

            ((DataTable)_dataGridView.DataSource).Rows.Add(rowId, comboBoxPupil.Text, dateTimePickerSickLeaveStart.Value, dateTimePickerSickLeaveEnd.Value);

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FillComboBoxPupil()
        {
            using (SqlConnection connection = new SqlConnection(AppParameters.ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(@"SELECT Pupils.Fullname, Pupils.PupilId FROM Pupils WHERE Pupils.GroupId = " + _groupId, connection);

                _table = new DataTable();
                da.Fill(_table);
                comboBoxPupil.DataSource = _table;
                comboBoxPupil.DisplayMember = _table.Columns[0].ColumnName;
            }
        }

        private string GetPupilId()
        {
            string pupilId = "";

            foreach (DataRow row in _table.Rows)
            {
                var cells = row.ItemArray;

                if (cells[0].ToString() == comboBoxPupil.Text)
                {
                    pupilId = cells[1].ToString();
                    break;
                }
            }

            return pupilId;
        }

        private void dateTimePickerSickLeaveEnd_CloseUp(object sender, EventArgs e)
        {
            if (dateTimePickerSickLeaveEnd.Value < dateTimePickerSickLeaveStart.Value)
            {
                MessageBox.Show("Дата окончания больничного не может быть до даты начала!");
                dateTimePickerSickLeaveEnd.Value = dateTimePickerSickLeaveStart.Value;
            }
        }
    }
}
