using LaboratoryWork2_Oleshko.Models;
using LaboratoryWork2_Oleshko.Utils;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LaboratoryWork2_Oleshko.Forms
{
    public partial class ExamForm : MaterialForm
    {
        private Applicant applicant;
        private Exam exam;
        public ExamForm()
        {
            InitializeComponent();
            MaterialSkinManager.Instance.AddFormToManage(this);
        }

        public ExamForm(Applicant applicant, Exam exam) : this()
        {
            this.applicant = applicant;
            this.exam = exam;
            DisplayQuestionAndAnswers();
        }

        private void DisplayQuestionAndAnswers()
        {
            questionLabel.Text = "Question: " + exam.Question;

            for (int i = 0; i < exam.Answers.Count; i++)
            {
                string answerLabelName = "answerLabel" + (i + 1);
                Label answerLabel = (Label)Controls.Find(answerLabelName, true).FirstOrDefault();
                answerLabel.Text = $"{exam.Answers[i]}";
            }
        }

        private void sendAnswerButton_Click(object sender, EventArgs e)
        {
            int answerIndex = GetSelectedAnswerIndex();

            if (answerIndex == -1)
            {
                MessageBox.Show("Choose an answer first.");
                return;
            }

            SendApplicantAnswer(answerIndex);
        }

        private int GetSelectedAnswerIndex()
        {
            if (answerRadioButton1.Checked)
            {
                return 0;
            }
            else if (answerRadioButton2.Checked)
            {
                return 1;
            }
            else if (answerRadioButton3.Checked)
            {
                return 2;
            }
            else if (answerRadioButton4.Checked)
            {
                return 3;
            }

            return -1;
        }

        private void SendApplicantAnswer(int answerIndex)
        {
            var applicantAnswer = new Answer
            {
                ApplicantId = applicant.Id,
                ExamId = exam.Id,
                AnswerIndex = answerIndex
            };

            ApplicantAnswerManager.Answers.Add(applicantAnswer);
            applicant.ApplicantStatus = Applicant.Status.AwaitingResponse;
            MessageBox.Show("Answer sent.");
            Close();
        }
    }
}
