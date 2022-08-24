using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KindergartenComplex.Manager_Forms.Provision
{
    public partial class ProvisionForm : Form
    {
        private DataGridView _dataGridViewTable;
        private readonly string _provisionType;

        public ProvisionForm(string provisionType)
        {
            _provisionType = provisionType;

            InitializeComponent();

            Text = _provisionType + " обеспечение | " + AppParameters.KindergartenName;

            if (_provisionType == "Ресурсное")
            {
                labelHeader.Text = _provisionType + " обеспечение";
                Point labelHeaderPoint = new Point(625, 19);
                labelHeader.Location = labelHeaderPoint;
            }

            _dataGridViewTable = dataGridViewFirstYoung;

            DataGridView[] dataGridViewTables =
            {
                dataGridViewFirstYoung,
                dataGridViewSecondYoung,
                dataGridViewMiddle,
                dataGridViewSenior
            };

            ProvisionController.FillTables(dataGridViewTables, _provisionType);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            ((DataTable) _dataGridViewTable.DataSource).DefaultView.RowFilter =
                $"{_dataGridViewTable.Columns[1].HeaderText} like '{textBoxSearch.Text}%'";
        }

        private void tabControlProvision_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControlProvision.SelectedIndex)
            {
                case 0:
                    _dataGridViewTable = dataGridViewFirstYoung;
                    ((DataTable) _dataGridViewTable.DataSource).DefaultView.RowFilter = string.Empty;
                    textBoxSearch.Text = string.Empty;
                    break;
                case 1:
                    _dataGridViewTable = dataGridViewSecondYoung;
                    ((DataTable) _dataGridViewTable.DataSource).DefaultView.RowFilter = string.Empty;
                    textBoxSearch.Text = string.Empty;
                    break;
                case 2:
                    _dataGridViewTable = dataGridViewMiddle;
                    ((DataTable) _dataGridViewTable.DataSource).DefaultView.RowFilter = string.Empty;
                    textBoxSearch.Text = string.Empty;
                    break;
                case 3:
                    _dataGridViewTable = dataGridViewSenior;
                    ((DataTable) _dataGridViewTable.DataSource).DefaultView.RowFilter = string.Empty;
                    textBoxSearch.Text = string.Empty;
                    break;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var provisionAddForm = new ProvisionAddForm(_provisionType, tabControlProvision.SelectedTab.Text, _dataGridViewTable);
            provisionAddForm.ShowDialog();
        }

        private void dataGridViewFirstYoung_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridViewTableMouseDown(e);
        }

        private void dataGridViewSecondYoung_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridViewTableMouseDown(e);
        }

        private void dataGridViewMiddle_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridViewTableMouseDown(e);
        }

        private void dataGridViewSenior_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridViewTableMouseDown(e);
        }

        private void DataGridViewTableMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int hti = _dataGridViewTable.HitTest(e.X, e.Y).RowIndex;

                if (hti >= 0)
                {
                    if (!_dataGridViewTable.Rows[hti].Selected)
                    {
                        _dataGridViewTable.ClearSelection();
                        _dataGridViewTable.Rows[hti].Selected = true;
                    }

                    if (_dataGridViewTable.SelectedRows.Count > 1)
                    {
                        подробноToolStripMenuItem.Enabled = false;
                        изменитьToolStripMenuItem.Enabled = false;
                    }
                    else
                    {
                        подробноToolStripMenuItem.Enabled = true;
                        изменитьToolStripMenuItem.Enabled = true;
                    }

                    contextMenuStrip.Show(_dataGridViewTable, new Point(e.X, e.Y));
                }
            }
        }

        private void OpenDetails()
        {
            var detailsForm = new DetailsForm(_dataGridViewTable.Columns, _dataGridViewTable.SelectedRows[0]);
            detailsForm.ShowDialog();
        }

        private void подробноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDetails();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var provisionEditForm = new ProvisionEditForm(_provisionType, _dataGridViewTable.SelectedRows[0]);
            provisionEditForm.ShowDialog();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProvisionController.DeleteProvision(_dataGridViewTable, _provisionType);
        }

        private void dataGridViewFirstYoung_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenDetails();
        }

        private void buttonChart_Click(object sender, EventArgs e)
        {
            var provisionChartForm = new ProvisionChartForm(_provisionType);
            provisionChartForm.ShowDialog();
        }

        private void dataGridViewSecondYoung_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenDetails();
        }

        private void dataGridViewMiddle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenDetails();
        }

        private void dataGridViewSenior_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenDetails();
        }
    }
}
