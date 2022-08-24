using System.Windows.Forms;

namespace KindergartenComplex
{
    public partial class DetailsForm : Form
    {
        public DetailsForm(DataGridViewColumnCollection header, DataGridViewRow row)
        {
            InitializeComponent();

            Text += AppParameters.KindergartenName;

            richTextBoxDetails.SelectionCharOffset = 70;

            int maxLength = 0;

            foreach (DataGridViewColumn column in header)
            {
                if (column.HeaderText.Length > maxLength)
                {
                    maxLength = column.HeaderText.Length;
                }
            }

            for (int i = 1; i < header.Count; i++)
            {
                string str = header[i].HeaderText + ":";
                richTextBoxDetails.Text += str.PadRight(maxLength + 5) + row.Cells[i].Value + "\n";
            }
        }
    }
}