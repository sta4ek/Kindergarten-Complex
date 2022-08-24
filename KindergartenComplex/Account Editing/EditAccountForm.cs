using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using KindergartenComplex.Account_Editing;
using KindergartenComplex.Manager_Forms.User_Registration;

namespace KindergartenComplex
{
    public partial class EditAccountForm : Form
    {
        private readonly int _accountId;

        public EditAccountForm(int accountId)
        {
            _accountId = accountId;

            InitializeComponent();
            Text += AppParameters.KindergartenName;

            textBoxLogin.Text = AccountEditingController.GetLogin(_accountId);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (RegistrationController.IsLoginAvailable(textBoxLogin.Text) || textBoxLogin.Text == AccountEditingController.GetLogin(_accountId))
            {
                labelLoginIsNotAvailable.Visible = false;

                string[] paramsList;

                if (textBoxLogin.Text != "" && textBoxOldPassword.Text == "")
                {
                    paramsList = new[] {textBoxLogin.Text, _accountId.ToString()};
                }
                else
                {
                    paramsList = new[]
                    {
                        textBoxLogin.Text, _accountId.ToString(), GetMd5Hash(textBoxOldPassword.Text),
                        GetMd5Hash(textBoxNewPassword.Text)
                    };
                }

                int rowCount = AccountEditingController.SaveChanges(paramsList);

                if (rowCount == 0)
                {
                    labelWrongOldPassword.Visible = true;
                }
                else
                {
                    Close();
                }
            }
            else
            {
                labelLoginIsNotAvailable.Visible = true;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxOldPassword_TextChanged(object sender, EventArgs e)
        {
            EmptinessTextBoxesCheck();
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            EmptinessTextBoxesCheck();
        }

        private void textBoxNewPassword_TextChanged(object sender, EventArgs e)
        {
            EmptinessTextBoxesCheck();
            PasswordsMatching();
        }

        private void textBoxConfirmationNewPassword_TextChanged(object sender, EventArgs e)
        {
            EmptinessTextBoxesCheck();
            PasswordsMatching();
        }

        private void EmptinessTextBoxesCheck()
        {
            if ((textBoxLogin.Text != "" && textBoxOldPassword.Text == "" && textBoxNewPassword.Text == "" && textBoxConfirmationNewPassword.Text == "") || (textBoxLogin.Text != "" && textBoxOldPassword.Text != "" && textBoxNewPassword.Text != "" && textBoxConfirmationNewPassword.Text != "") && textBoxNewPassword.Text == textBoxConfirmationNewPassword.Text)
            {
                buttonSave.Enabled = true;
            }
            else
            {
                buttonSave.Enabled = false;
            }
        }

        private void PasswordsMatching()
        {
            labelPasswordsAreNotMatching.Visible = textBoxNewPassword.Text != textBoxConfirmationNewPassword.Text;
        }

        private string GetMd5Hash(string text)
        {
            using (var hashAlg = MD5.Create())
            {
                byte[] hash = hashAlg.ComputeHash(Encoding.UTF8.GetBytes(text));
                var builder = new StringBuilder(hash.Length * 2);
                foreach (var t in hash)
                {
                    builder.Append(t.ToString("X2"));
                }
                return builder.ToString();
            }
        }
    }
}
