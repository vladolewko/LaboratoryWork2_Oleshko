using System;
using System.Collections.Generic;

namespace LaboratoryWork2_Oleshko.Models
{
    public sealed class Exam : EnvironmentObject
    {
        public string ExamName { get; set; }
        public string Question { get; set; }
        public List<string> Answers { get; set; }
        public int IndexOfCorrectAnswer {  get; set; }
        public Guid FacultyId { get; set; }

        public Exam() :base()
        {
            ExamName = string.Empty;
            Question = string.Empty;
            Answers = new List<string>();
            IndexOfCorrectAnswer = 0;
            FacultyId = Guid.Empty;
        }
    }
}
