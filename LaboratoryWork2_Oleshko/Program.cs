using LaboratoryWork2_Oleshko.Forms;
using LaboratoryWork2_Oleshko.Models;
using LaboratoryWork2_Oleshko.Utils;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratoryWork2_Oleshko
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Teal500,
                Primary.Teal700,
                Primary.Teal200,
                Accent.Pink200,
                TextShade.WHITE
            );

            Application.Run(new LoginForm());

            ApplicantAnswerManager.WriteToJson(Filenames.ApplicantAnswerFileName);
            ApplicantManager.WriteToJson(Filenames.ApplicantsFileName);
            ExamManager.WriteToJson(Filenames.ExamsFileName);
            FacultyManager.WriteToJson(Filenames.FacultiesFileName);
            GradeManager.WriteToJson(Filenames.GradesFileName);
            TeacherManager.WriteToJson(Filenames.TeachersFileName);
        }
    }
}
