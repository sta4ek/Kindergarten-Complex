using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KindergartenComplex.Manager_Forms.Control_Schedule
{
    public partial class ControlTopicsForm : Form
    {
        public ControlTopicsForm()
        {
            InitializeComponent();

            Text += AppParameters.KindergartenName;

            ControlTopicsController.FillTable("SELECT ControlTopics.ControlTopicId, ControlTopics.TopicNumber AS '№ темы', ControlTopics.TopicName AS 'Название темы' FROM ControlTopics", dataGridViewControlTopics);

            dataGridViewControlTopics.Columns[1].FillWeight = 10;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var controlTopicAddForm = new ControlTopicAddForm();
            controlTopicAddForm.ShowDialog();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)dataGridViewControlTopics.DataSource).DefaultView.RowFilter =
                $"[{dataGridViewControlTopics.Columns[2].HeaderText}] like '{textBoxSearch.Text}%'";
        }

        private void подробноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDetails();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var controlTopicEditForm = new ControlTopicEditForm(dataGridViewControlTopics.SelectedRows[0]);
            controlTopicEditForm.ShowDialog();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlTopicsController.DeleteTopic(dataGridViewControlTopics);
        }

        private void dataGridViewControlTopics_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridViewTableMouseDown(e);
        }

        private void DataGridViewTableMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int hti = dataGridViewControlTopics.HitTest(e.X, e.Y).RowIndex;

                if (hti >= 0)
                {
                    if (!dataGridViewControlTopics.Rows[hti].Selected)
                    {
                        dataGridViewControlTopics.ClearSelection();
                        dataGridViewControlTopics.Rows[hti].Selected = true;
                    }

                    if (dataGridViewControlTopics.SelectedRows.Count > 1)
                    {
                        подробноToolStripMenuItem.Enabled = false;
                        изменитьToolStripMenuItem.Enabled = false;
                    }
                    else
                    {
                        подробноToolStripMenuItem.Enabled = true;
                        изменитьToolStripMenuItem.Enabled = true;
                    }

                    contextMenuStrip.Show(dataGridViewControlTopics, new Point(e.X, e.Y));
                }
            }
        }

        private void OpenDetails()
        {
            var detailsForm = new DetailsForm(dataGridViewControlTopics.Columns, dataGridViewControlTopics.SelectedRows[0]);
            detailsForm.ShowDialog();
        }

        private void dataGridViewControlTopics_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenDetails();
        }
    }
}
