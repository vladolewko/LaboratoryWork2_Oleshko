using LaboratoryWork2_Oleshko.Models;
using LaboratoryWork2_Oleshko.Utils;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace LaboratoryWork2_Oleshko.Forms
{
    public partial class TeacherForm : MaterialForm
    {
        private Teacher teacher;

        public TeacherForm()
        {
            InitializeComponent();
            MaterialSkinManager.Instance.AddFormToManage(this);
        }

        public TeacherForm(Teacher teacher) : this()
        {
            this.teacher = teacher;
            ShowAdditionalDataFormIfNeeded();
            ShowApplicants();
            ShowFailedApplicants();
            ShowPassedApplicants();
        }

        private void ShowAdditionalDataFormIfNeeded()
        {
            if (IsAdditionalDataNeeded(teacher))
            {
                var additionalDataForm = new WriteAdditionalDataForm(teacher);
                additionalDataForm.Show();
                additionalDataForm.FormClosed += (c, arg) => Show();
            }
            else
            {
                Show();
            }
        }

        private bool IsAdditionalDataNeeded(Teacher teacher)
        {
            return string.IsNullOrEmpty(teacher.Email) || string.IsNullOrEmpty(teacher.FirstName) ||
                   string.IsNullOrEmpty(teacher.LastName) || string.IsNullOrEmpty(teacher.PhoneNumber);
        }

        private void ShowApplicants()
        {
            applicantsDataGridView.Rows.Clear();
            foreach(var answer in ApplicantAnswerManager.Answers)
            {
                var applicant = ApplicantManager.GetApplicantById(answer.ApplicantId);
                if(applicant.ApplicantStatus == Applicant.Status.AwaitingResponse)
                {
                    var exam = ExamManager.GetExamById(answer.ExamId);
                    var faculty = FacultyManager.GetFacultyById(exam.FacultyId);
                    applicantsDataGridView.Rows.Add(applicant.Id, faculty.Id, exam.Id, applicant.FirstName, faculty.Name, exam.ExamName, faculty.ScoreToPass); ;
                }
            }
        }

        private void ShowFailedApplicants()
        {
            ShowApplicantsByStatus(failedDataGridView, Applicant.Status.FailedExams);
        }

        private void ShowPassedApplicants()
        {
            ShowApplicantsByStatus(passedDataGridView, Applicant.Status.PassedExams);
        }

        private void ShowApplicantsByStatus(DataGridView dataGridView, Applicant.Status status)
        {
            dataGridView.Rows.Clear();
            foreach (var answer in ApplicantAnswerManager.Answers)
            {
                var applicant = ApplicantManager.GetApplicantById(answer.ApplicantId);
                if (applicant.ApplicantStatus == status)
                {
                    var exam = ExamManager.GetExamById(answer.ExamId);
                    var faculty = FacultyManager.GetFacultyById(exam.FacultyId);
                    var grade = GradeManager.GetGradeByApplicantId(applicant.Id);
                    dataGridView.Rows.Add(applicant.LastName, faculty.Name, exam.ExamName, grade.Score, faculty.ScoreToPass);
                }
            }
        }

        private void setMarksButton_Click(object sender, EventArgs e)
        {
            var applicantId = Guid.Parse(applicantsDataGridView.CurrentRow.Cells[0].Value.ToString());
            var applicant = ApplicantManager.GetApplicantById(applicantId);
            var applicantAnswer = ApplicantAnswerManager.GetAnswerByApplicantId(applicant.Id);

            var form = new RateApplicantForm(applicantAnswer);
            Hide();
            form.Show();
            form.FormClosed += (s, arg) =>
            {
                ShowApplicants();
                ShowFailedApplicants();
                ShowPassedApplicants();
                Show();
            };
        }
    }
}
