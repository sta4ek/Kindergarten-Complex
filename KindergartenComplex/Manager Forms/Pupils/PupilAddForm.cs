using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KindergartenComplex.Manager_Forms.Pupils
{
    public partial class PupilAddForm : Form
    {
        private DataTable _table;
        private readonly DataGridView _dataGridView;

        public PupilAddForm(DataGridView dataGridView)
        {
            _dataGridView = dataGridView;

            InitializeComponent();

            Text += AppParameters.KindergartenName;

            FillComboBoxGroup();

            toolTip.SetToolTip(textBoxMedicalDiagnosis, "Если нет, оставить пустым");
            toolTip.SetToolTip(textBoxDiet, "Если нет, оставить пустым");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string isUnderstudy = "";

            if (checkBoxUnderstudy.Checked)
            {
                isUnderstudy = "Да";
            }

            string[] paramsList = { textBoxFullname.Text, textBoxParents.Text, textBoxPhoneNumber.Text, textBoxLivingAddress.Text, textBoxHealthGroup.Text, textBoxMedicalDiagnosis.Text, isUnderstudy, GetGroupId(), textBoxPEGroup.Text, textBoxDiet.Text };

            int rowId = PupilController.AddPupil(paramsList);

            ((DataTable)_dataGridView.DataSource).Rows.Add(rowId, textBoxFullname.Text, comboBoxGroup.Text, textBoxParents.Text, textBoxPhoneNumber.Text, textBoxLivingAddress.Text, textBoxHealthGroup.Text, textBoxMedicalDiagnosis.Text, isUnderstudy, textBoxPEGroup.Text, textBoxDiet.Text);

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
                buttonAdd.Enabled = false;
            }
            else
            {
                buttonAdd.Enabled = true;
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
