using System;

namespace LaboratoryWork2_Oleshko.Models
{
    public abstract class EnvironmentObject
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set;}

        public EnvironmentObject()
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.Now;
            LastModifiedDate = DateTime.Now;
        }
    }
}
