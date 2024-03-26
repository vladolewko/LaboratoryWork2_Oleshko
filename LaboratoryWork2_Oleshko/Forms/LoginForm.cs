using LaboratoryWork2_Oleshko.Models;
using LaboratoryWork2_Oleshko.Utils;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LaboratoryWork2_Oleshko.Forms
{
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
            MaterialSkinManager.Instance.AddFormToManage(this);
        }

        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            var form = new RegistrationForm();
            form.FormClosed += (c, arg) => 
            {
                ClearFormData();
                Show();
            };
            form.Show();
        }

        private void guideLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new GuidePageForm();
            form.Show();
            Hide();
            form.FormClosed += (c, arg) =>
            {
                ClearFormData();
                Show();
            };
        }

        private void seePasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (seePasswordCheckBox.Checked)
            {
                passwordTextField.PasswordChar = '\0';
            }
            else
            {
                passwordTextField.PasswordChar = '*';
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = loginTextField.Text;
            string password = passwordTextField.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Fill in all data.");
                return;
            }

            if (amITeacherCheckBox.Checked)
            {
                LoginAsTeacher(login, password);
            }
            else
            {
                LoginAsApplicant(login, password);
            }
        }

        private void LoginAsTeacher(string login, string password)
        {
            var foundTeacher = TeacherManager.FindTeacherByLogin(login);

            if (foundTeacher is null)
            {
                MessageBox.Show("Teacher with current login does not exist.");
                return;
            }

            if (!foundTeacher.CheckPassword(password))
            {
                MessageBox.Show("Incorrect password.");
                return;
            }

            OpenFormAndHandleClosing(new TeacherForm(foundTeacher));
        }

        private void LoginAsApplicant(string login, string password)
        {
            var foundApplicant = ApplicantManager.FindApplicantByLogin(login);

            if (foundApplicant is null)
            {
                MessageBox.Show("Applicant with current login does not exist.");
                return;
            }

            if (!foundApplicant.CheckPassword(password))
            {
                MessageBox.Show("Incorrect password.");
                return;
            }

            OpenFormAndHandleClosing(new ApplicantForm(foundApplicant));
        }

        private void OpenFormAndHandleClosing(Form form)
        {
            Hide();
            form.FormClosed += (s, arg) =>
            {
                ClearFormData();
                Show();
            };
            MessageBox.Show("You successfully logged in.");
        }

        private void ClearFormData()
        {
            loginTextField.Clear();
            passwordTextField.Clear();
            amITeacherCheckBox.Checked = false;
            seePasswordCheckBox.Checked = false;
        }
    }
}
