using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KindergartenComplex.Manager_Forms.Pupils
{
    public partial class PupilEditForm : Form
    {
        private DataTable _table;
        private readonly int _pupilId;
        private readonly DataGridViewRow _row;

        public PupilEditForm(DataGridViewRow row)
        {
            InitializeComponent();

            Text += AppParameters.KindergartenName;

            FillComboBoxGroup();

            toolTip.SetToolTip(textBoxMedicalDiagnosis, "Если нет, оставить пустым");
            toolTip.SetToolTip(textBoxDiet, "Если нет, оставить пустым");

            _row = row;
            _pupilId = Convert.ToInt32(row.Cells[0].Value);

            if (_row.Cells[8].Value.ToString() == "Да")
            {
                checkBoxUnderstudy.Checked = true;
            }

            textBoxFullname.Text = _row.Cells[1].Value.ToString();
            textBoxParents.Text = _row.Cells[3].Value.ToString();
            textBoxPhoneNumber.Text = _row.Cells[4].Value.ToString();
            textBoxLivingAddress.Text = _row.Cells[5].Value.ToString();
            textBoxHealthGroup.Text = _row.Cells[6].Value.ToString();
            textBoxMedicalDiagnosis.Text = _row.Cells[7].Value.ToString();
            comboBoxGroup.Text = _row.Cells[2].Value.ToString();
            textBoxPEGroup.Text = _row.Cells[9].Value.ToString();
            textBoxDiet.Text = _row.Cells[10].Value.ToString();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string isUnderstudy = "";

            if (checkBoxUnderstudy.Checked)
            {
                isUnderstudy = "Да";
            }

            if (textBoxFullname.Text == _row.Cells[1].Value.ToString() && textBoxParents.Text == _row.Cells[3].Value.ToString() &&
                textBoxPhoneNumber.Text == _row.Cells[4].Value.ToString() && textBoxLivingAddress.Text == _row.Cells[5].Value.ToString() &&
                textBoxHealthGroup.Text == _row.Cells[6].Value.ToString() && textBoxMedicalDiagnosis.Text == _row.Cells[7].Value.ToString() &&
                isUnderstudy == _row.Cells[8].Value.ToString() && comboBoxGroup.Text == _row.Cells[2].Value.ToString() &&
                textBoxPEGroup.Text == _row.Cells[9].Value.ToString() && textBoxDiet.Text == _row.Cells[10].Value.ToString())
            {
                MessageBox.Show("Введённые данные не отличаются от данных в базе");
                return;
            }

            string[] paramsList = { textBoxFullname.Text, textBoxParents.Text, textBoxPhoneNumber.Text, textBoxLivingAddress.Text, textBoxHealthGroup.Text, textBoxMedicalDiagnosis.Text, isUnderstudy, GetGroupId(), textBoxPEGroup.Text, textBoxDiet.Text, _pupilId.ToString() };

            PupilController.EditPupil(paramsList);

            _row.Cells[1].Value = textBoxFullname.Text;
            _row.Cells[2].Value = comboBoxGroup.Text;
            _row.Cells[3].Value = textBoxParents.Text;
            _row.Cells[4].Value = textBoxPhoneNumber.Text;
            _row.Cells[5].Value = textBoxLivingAddress.Text;
            _row.Cells[6].Value = textBoxHealthGroup.Text;
            _row.Cells[7].Value = textBoxMedicalDiagnosis.Text;
            _row.Cells[8].Value = isUnderstudy;
            _row.Cells[9].Value = textBoxPEGroup.Text;
            _row.Cells[10].Value = textBoxDiet.Text;

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxFullname_TextChanged(object sender, EventArgs e)
        {
            EmptinessTextBoxesCheck();
        }

        private void textBoxParents_TextChanged(object sender, EventArgs e)
        {
            EmptinessTextBoxesCheck();
        }

        private void textBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            EmptinessTextBoxesCheck();
        }

        private void textBoxLivingAddress_TextChanged(object sender, EventArgs e)
        {
            EmptinessTextBoxesCheck();
        }

        private void textBoxHealthGroup_TextChanged(object sender, EventArgs e)
        {
            EmptinessTextBoxesCheck();
        }

        private void textBoxPEGroup_TextChanged(object sender, EventArgs e)
        {
            EmptinessTextBoxesCheck();
        }

        private void EmptinessTextBoxesCheck()
        {
            if (textBoxFullname.Text == "" || textBoxParents.Text == "" || textBoxPhoneNumber.Text == "" || textBoxLivingAddress.Text == "" || textBoxHealthGroup.Text == "" || textBoxPEGroup.Text == "")
            {
                buttonEdit.Enabled = false;
            }
            else
            {
                buttonEdit.Enabled = true;
            }
        }

        private void FillComboBoxGroup()
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
