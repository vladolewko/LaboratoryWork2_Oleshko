using LaboratoryWork2_Oleshko.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LaboratoryWork2_Oleshko.Forms
{
    public partial class WriteAdditionalDataForm : MaterialForm
    {
        private Applicant applicant;
        private Teacher teacher;
        public WriteAdditionalDataForm()
        {
            InitializeComponent();
            MaterialSkinManager.Instance.AddFormToManage(this);
        }

        public WriteAdditionalDataForm(User user) : this()
        {
            if (user is Teacher teacher)
            {
                this.teacher = teacher;
                emailTextField.Visible = true;
                emailLabel.Visible = true;
                phoneNumberTextField.Visible = true;
                phoneNumberLabel.Visible = true;
                pictureBox.Image = Image.FromFile("../../Assets/teacher-icon.png");
            }
            else if (user is Applicant applicant)
            {
                this.applicant = applicant;
                dateOfBirthLabel.Visible = true;
                dateOfBirthTimePicker.Visible = true;
                dateOfBirthTimePicker.MinDate = DateTime.Now.AddYears(-25);
                dateOfBirthTimePicker.MaxDate = DateTime.Now.AddYears(-18);
                pictureBox.Image = Image.FromFile("../../Assets/applicant-icon.png");
            }
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            if(applicant != null)
            {
                if(string.IsNullOrEmpty(firstNameTextField.Text) || string.IsNullOrEmpty(lastNameTextField.Text))
                {
                    MessageBox.Show("Fill in all fields first.");
                    return;
                }

                applicant.FirstName = firstNameTextField.Text;
                applicant.LastName = lastNameTextField.Text;
                applicant.DateOfBirth = dateOfBirthTimePicker.Value;
            }
            else if(teacher != null)
            {
                if (string.IsNullOrEmpty(firstNameTextField.Text) || string.IsNullOrEmpty(lastNameTextField.Text)
                    || string.IsNullOrEmpty(emailTextField.Text) || string.IsNullOrEmpty(phoneNumberTextField.Text))
                {
                    MessageBox.Show("Fill in all fields first.");
                    return;
                }

                teacher.FirstName = firstNameTextField.Text;
                teacher.LastName = lastNameTextField.Text;
                teacher.PhoneNumber = phoneNumberTextField.Text;
                teacher.Email = emailTextField.Text;
            }

            MessageBox.Show("Data updated.");
            Close();
        }
    }
}
