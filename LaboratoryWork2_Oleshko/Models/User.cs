namespace LaboratoryWork2_Oleshko.Models
{
    public abstract class User : EnvironmentObject
    {
        public string Login { get; set; }
        public string Password {  get; set; }

        public User() : base()
        {
            Login = string.Empty;
            Password = string.Empty;
        }

        public bool CheckPassword(string password)
        {
            return Password == password;
        }
    }
}
