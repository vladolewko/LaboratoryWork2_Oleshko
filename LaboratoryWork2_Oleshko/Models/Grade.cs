using System;

namespace LaboratoryWork2_Oleshko.Models
{
    public sealed class Grade : EnvironmentObject
    {
        public int Score {  get; set; }
        public Guid ApplicantId {  get; set; }
        public Guid ExamId { get; set; }

        public Grade() : base()
        {
            Score = 0;
            ApplicantId = Guid.Empty;
            ExamId = Guid.Empty;
        }
    }
}
