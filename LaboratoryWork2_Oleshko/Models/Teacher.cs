namespace LaboratoryWork2_Oleshko.Models
{
    public sealed class Teacher : User
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Teacher() : base() 
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
            PhoneNumber = string.Empty;
        }
    }
}
