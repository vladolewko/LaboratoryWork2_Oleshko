using LaboratoryWork2_Oleshko.Models;
using LaboratoryWork2_Oleshko.Utils;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace LaboratoryWork2_Oleshko.Forms
{
    public partial class RateApplicantForm : MaterialForm
    {
        private Answer applicantAnswer;
        public RateApplicantForm()
        {
            InitializeComponent();
            MaterialSkinManager.Instance.AddFormToManage(this);
        }

        public RateApplicantForm(Answer answer) : this()
        {
            applicantAnswer = answer;
            var exam = ExamManager.GetExamById(applicantAnswer.ExamId);

            applicantAnswerLabel.Text = "Applicant answer: " + GetAnswerText(applicantAnswer.AnswerIndex, exam);
            correctAnswerLabel.Text = "Correct answer: " + GetAnswerText(exam.IndexOfCorrectAnswer, exam);
            questionLabel.Text = "Question: " + exam.Question;
            SetFormTitle(answer.ApplicantId);
        }

        private string GetAnswerText(int answerIndex, Exam exam)
        {
            return exam.Answers[answerIndex];
        }

        private void SetFormTitle(Guid applicantId)
        {
            string applicantLastName = ApplicantManager.GetApplicantById(applicantId).LastName;
            Text = $"Rate: {applicantLastName}";
        }

        private void rateButton_Click(object sender, EventArgs e)
        {
            var grade = new Grade
            {
                ApplicantId = applicantAnswer.ApplicantId,
                ExamId = applicantAnswer.ExamId,
                Score = int.Parse(rateTextField.Text)
            };

            UpdateApplicantStatus(grade);

            GradeManager.Grades.Add(grade);

            MessageBox.Show("Applicant Rated.");
            Close();
        }

        private void UpdateApplicantStatus(Grade grade)
        {
            var applicant = ApplicantManager.GetApplicantById(applicantAnswer.ApplicantId);
            var exam = ExamManager.GetExamById(applicantAnswer.ExamId);
            var faculty = FacultyManager.GetFacultyById(exam.FacultyId);

            applicant.ApplicantStatus = grade.Score < faculty.ScoreToPass ?
                Applicant.Status.FailedExams : Applicant.Status.PassedExams;
        }

        private void rateTextField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
