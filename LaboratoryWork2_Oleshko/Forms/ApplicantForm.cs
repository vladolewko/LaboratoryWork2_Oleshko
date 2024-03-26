using LaboratoryWork2_Oleshko.Models;
using LaboratoryWork2_Oleshko.Utils;
using MaterialSkin;
using MaterialSkin.Controls;
using System;

namespace LaboratoryWork2_Oleshko.Forms
{
    public partial class ApplicantForm : MaterialForm
    {
        private Applicant applicant;
        public ApplicantForm()
        {
            InitializeComponent();
            MaterialSkinManager.Instance.AddFormToManage(this);
        }

        public ApplicantForm(Applicant applicant) : this()
        {
            this.applicant = applicant;
            ShowAdditionalDataFormIfNeeded();
            SetFormState();
        }

        private void ShowAdditionalDataFormIfNeeded()
        {
            if (IsAdditionalDataNeeded())
            {
                var additionalDataForm = new WriteAdditionalDataForm(applicant);
                additionalDataForm.Show();
                additionalDataForm.FormClosed += (c, arg) => Show();
            }
            else
            {
                Show();
            }
        }

        private bool IsAdditionalDataNeeded()
        {
            return string.IsNullOrEmpty(applicant.FirstName) || string.IsNullOrEmpty(applicant.LastName) ||
                   applicant.DateOfBirth == DateTime.MinValue;
        }

        private void SetFormState()
        {
            ClearForm();
            if (applicant.ApplicantStatus == Applicant.Status.Registered)
            {
                ShowFaculties();
            }
            else if (applicant.ApplicantStatus == Applicant.Status.AwaitingResponse)
            {
                ShowMessage("You have already written your exams. Please wait until they will be checked");
            }
            else if (applicant.ApplicantStatus == Applicant.Status.FailedExams)
            {
                ShowMessage("You have failed your exams. Good luck in the next year");
            }
            else if (applicant.ApplicantStatus == Applicant.Status.PassedExams)
            {
                ShowMessage("Congratulations! You have passed your exams.");
            }
        }

        private void ClearForm()
        {
            facultiesDataGridView.Visible = false;
            passExamsButton.Visible = false;
            messageLabel.Visible = false;
        }

        private void ShowFaculties()
        {
            facultiesDataGridView.Visible = true;
            passExamsButton.Visible = true;
            facultiesDataGridView.Rows.Clear();
            foreach (var faculty in FacultyManager.Faculties)
            {
                var exam = ExamManager.GetExamByFacultyId(faculty.Id);
                var answer = ApplicantAnswerManager.GetAnswerByApplicantId(applicant.Id);
                if (answer is null)
                {
                    facultiesDataGridView.Rows.Add(faculty.Id, exam.Id, faculty.Name,
                        faculty.ScoreToPass, exam.ExamName);
                }
            }
        }

        private void ShowMessage(string message)
        {
            messageLabel.Visible = true;
            messageLabel.Text = message;
        }

        private void passExamsButton_Click(object sender, EventArgs e)
        {
            var examId = Guid.Parse(facultiesDataGridView.CurrentRow.Cells[1].Value.ToString());
            var exam = ExamManager.GetExamById(examId);
            var examForm = new ExamForm(applicant, exam);
            Hide();
            examForm.Show();
            examForm.FormClosed += (c, arg) =>
            {
                SetFormState();
                Show();
            };
        }
    }
}
