using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KindergartenComplex.Teacher_Forms.Pupils_SickLeaves
{
    public partial class PupilSickLeaveEditForm : Form
    {
        private readonly int _groupId;
        private DataTable _table;
        private readonly DataGridViewRow _row;
        private readonly int _sickLeaveId;

        public PupilSickLeaveEditForm(int groupId, DataGridViewRow row)
        {
            _groupId = groupId;
            _row = row;
            _sickLeaveId = Convert.ToInt32(row.Cells[0].Value);

            InitializeComponent();

            Text += AppParameters.KindergartenName;

            FillComboBoxPupil();

            comboBoxPupil.Text = _row.Cells[1].Value.ToString();
            dateTimePickerSickLeaveStart.Value = Convert.ToDateTime(_row.Cells[2].Value);
            dateTimePickerSickLeaveEnd.Value = Convert.ToDateTime(_row.Cells[3].Value);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxPupil.Text == _row.Cells[1].Value.ToString() &&
                dateTimePickerSickLeaveStart.Value == Convert.ToDateTime(_row.Cells[2].Value) &&
                dateTimePickerSickLeaveEnd.Value == Convert.ToDateTime(_row.Cells[3].Value))
            {
                MessageBox.Show("Введённые данные не отличаются от данных в базе");
                return;
            }

            string[] paramsList = { GetPupilId(), dateTimePickerSickLeaveStart.Value.ToString(), dateTimePickerSickLeaveEnd.Value.ToString(), _sickLeaveId.ToString() };

            PupilsSickLeaveController.EditSickLeave(paramsList);

            _row.Cells[1].Value = comboBoxPupil.Text;
            _row.Cells[2].Value = dateTimePickerSickLeaveStart.Value;
            _row.Cells[3].Value = dateTimePickerSickLeaveEnd.Value;

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
