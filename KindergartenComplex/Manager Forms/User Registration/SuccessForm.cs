using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace KindergartenComplex.Manager_Forms.User_Registration
{
    public partial class SuccessForm : Form
    {
        private readonly string[] _paramsList;

        public SuccessForm(string[] paramsList)
        {
            _paramsList = paramsList;

            InitializeComponent();

            Text += AppParameters.KindergartenName;

            labelFullName.Text = _paramsList[2];
            labelSuccess.Text += @" " + paramsList[1];
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintAccountData();

            Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PrintAccountData()
        {
            PrintDocument document = new PrintDocument();
            document.PrintPage += Doc_PrintPage;
            printDialogAccountData.Document = document;
            DialogResult result = printDialogAccountData.ShowDialog();

            if (result == DialogResult.OK)
            {
                document.Print();
            }
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            string sourceString = "Сотрудник: " + _paramsList[2] + "\n" +
                                  "Имя пользователя: " + _paramsList[0] + "\n" +
                                  "Пароль: " + _paramsList[1];

            e.Graphics.DrawString(sourceString, new Font("Consolas", 14), Brushes.Black, 0, 0);
        }
    }
}
