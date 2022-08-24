using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KindergartenComplex.Teacher_Forms.Provision
{
    public partial class ProvisionMonitoringForm : Form
    {
        private readonly string _provisionTableName;

        public ProvisionMonitoringForm(string provisionTableName, int groupId)
        {
            _provisionTableName = provisionTableName;

            InitializeComponent();

            if (_provisionTableName == "Resource")
            {
                labelHeader.Text = Text = "Мониторинг ресурсного обеспечения";
                Point labelHeaderPoint = new Point(395, 19);
                labelHeader.Location = labelHeaderPoint;
            }

            Text += AppParameters.KindergartenName;

            ProvisionMonitoringController.FillTable(dataGridViewProvision, $"SELECT {_provisionTableName}Availability.{_provisionTableName}AvailabilityId, {_provisionTableName}Provision.ItemName  AS 'Название', {_provisionTableName}Availability.Mark  AS 'Отметка о наличии' FROM {_provisionTableName}Availability INNER JOIN {_provisionTableName}Provision ON {_provisionTableName}Availability.{_provisionTableName}ProvisionId = {_provisionTableName}Provision.{_provisionTableName}ProvisionId WHERE {_provisionTableName}Availability.GroupId = {groupId}");

            dataGridViewProvision.Columns["Название"].ReadOnly = true;

            dataGridViewProvision.Columns["Название"].FillWeight = 700;
        }

        private void dataGridViewProvision_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                ProvisionMonitoringController.SetMark(_provisionTableName, Convert.ToInt32(dataGridViewProvision.Rows[e.RowIndex].Cells[0].Value), Convert.ToBoolean(dataGridViewProvision.Rows[e.RowIndex].Cells[2].Value));
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)dataGridViewProvision.DataSource).DefaultView.RowFilter =
                $"{dataGridViewProvision.Columns[1].HeaderText} like '{textBoxSearch.Text}%'";
        }
    }
}
