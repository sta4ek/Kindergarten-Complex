using System;
using System.Windows.Forms;

namespace KindergartenComplex.Manager_Forms.Provision
{
    public partial class ProvisionEditForm : Form
    {
        private readonly string _provisionType;
        private readonly DataGridViewRow _row;
        private readonly int _provisionId;

        public ProvisionEditForm(string provisionType, DataGridViewRow row)
        {
            _provisionType = provisionType;
            _row = row;
            _provisionId = Convert.ToInt32(row.Cells[0].Value);

            InitializeComponent();

            Text += AppParameters.KindergartenName;

            textBoxItemName.Text = _row.Cells[1].Value.ToString();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxItemName.Text == _row.Cells[1].Value.ToString())
            {
                MessageBox.Show("Введённые данные не отличаются от данных в базе");
                return;
            }

            string[] paramsList = { textBoxItemName.Text, _provisionId.ToString() };

            ProvisionController.EditProvision(paramsList, _provisionType);

            _row.Cells[1].Value = textBoxItemName.Text;

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxItemName_TextChanged(object sender, EventArgs e)
        {
            buttonEdit.Enabled = textBoxItemName.Text != "";
        }
    }
}
