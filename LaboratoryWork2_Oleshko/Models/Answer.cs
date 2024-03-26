using System;

namespace LaboratoryWork2_Oleshko.Models
{
    public class Answer : EnvironmentObject
    {
        public Guid ApplicantId { get; set; }
        public Guid ExamId { get; set; }
        public int AnswerIndex { get; set; }

        public Answer()
        {
            ApplicantId = Guid.Empty;
            ExamId = Guid.Empty;
            AnswerIndex = -1;
        }
    }
}
