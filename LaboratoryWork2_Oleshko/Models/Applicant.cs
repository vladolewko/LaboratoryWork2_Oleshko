using System;

namespace LaboratoryWork2_Oleshko.Models
{
    public sealed class Applicant : User  
    {
        public enum Status
        {
            Registered,
            AwaitingResponse,
            FailedExams,
            PassedExams
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Status ApplicantStatus { get; set; }

        public Applicant() : base()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            DateOfBirth = DateTime.MinValue;
            ApplicantStatus = Status.Registered;
        }
    }
}
