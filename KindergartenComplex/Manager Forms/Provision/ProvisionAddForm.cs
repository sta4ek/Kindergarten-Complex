using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace KindergartenComplex.Manager_Forms.Provision
{
    public partial class ProvisionAddForm : Form
    {
        private readonly string _provisionType;
        private readonly DataGridView _dataGridView;

        public ProvisionAddForm(string provisionType, string groupType, DataGridView dataGridView)
        {
            _dataGridView = dataGridView;
            _provisionType = provisionType;

            InitializeComponent();

            Text += AppParameters.KindergartenName;

            FillComboBoxGroupType();
            comboBoxGroupType.Text = groupType;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string[] paramsList = { textBoxItemName.Text, comboBoxGroupType.Text };

            int rowId = ProvisionController.AddProvision(paramsList, _provisionType);

            ((DataTable)_dataGridView.DataSource).Rows.Add(rowId, textBoxItemName.Text);

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FillComboBoxGroupType()
        {
            List<string> groupTypesList = new List<string> { "Первая младшая", "Вторая младшая", "Средняя", "Старшая"};

            comboBoxGroupType.DataSource = groupTypesList;
        }

        private void textBoxItemName_TextChanged(object sender, EventArgs e)
        {
            buttonAdd.Enabled = textBoxItemName.Text != "";
        }
    }
}
