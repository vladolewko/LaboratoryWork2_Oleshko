using System.Windows.Forms;

namespace LaboratoryWork2_Oleshko.Models
{
    public sealed class Faculty : EnvironmentObject
    {
        public string Name { get; set; }
        public double ScoreToPass {  get; set; }

        public Faculty() : base() 
        {
            Name = string.Empty;
            ScoreToPass = 0.0;
        }

        private static Faculty firstFaculty;
        private Faculty Next { get; set; }
        public static void AddFaculty(Faculty newFaculty)
        {
            if (firstFaculty == null)
            {
                firstFaculty = newFaculty;
            }
            else
            {
                var current = firstFaculty;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newFaculty;
            }
        }

        public static void ViewFaculties()
        {
            var current = firstFaculty;
            while (current != null)
            {
                MessageBox.Show($"Id: {current.Id}, Name: {current.Name}");
                current = current.Next;
            }
        }
    }
}
