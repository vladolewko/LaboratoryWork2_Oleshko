using LaboratoryWork2_Oleshko.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace LaboratoryWork2_Oleshko.Utils
{
    public static class ExamManager
    {
        public static List<Exam> Exams { get; set; }

        static ExamManager()
        {
            Exams = new List<Exam>();
            ReadFromJson(Filenames.ExamsFileName);
        }

        public static void ReadFromJson(string filePath)
        {
            try
            {
                string jsonString = File.ReadAllText(filePath);
                Exams = JsonSerializer.Deserialize<List<Exam>>(jsonString);
            }
            catch (FileNotFoundException)
            {
                Exams = new List<Exam>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while reading from JSON file: {ex.Message}");
            }
        }

        public static void WriteToJson(string filePath)
        {
            try
            {
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };
                string jsonString = JsonSerializer.Serialize(Exams, options);
                File.WriteAllText(filePath, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while writing to JSON file: {ex.Message}");
            }
        }

        public static Exam GetExamByFacultyId(Guid id)
        {
            foreach(var exam in Exams)
            {
                if(exam.FacultyId == id)
                {
                    return exam;
                }
            }

            return null;
        }

        public static Exam GetExamById(Guid id)
        {
            foreach(var exam in Exams)
            {
                if(exam.Id == id)
                {
                    return exam;
                }
            }

            return null;
        }
    }
}
