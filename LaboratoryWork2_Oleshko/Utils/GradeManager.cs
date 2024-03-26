using LaboratoryWork2_Oleshko.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace LaboratoryWork2_Oleshko.Utils
{
    public static class GradeManager
    {
        public static List<Grade> Grades { get; set; }

        static GradeManager()
        {
            Grades = new List<Grade>();
            ReadFromJson(Filenames.GradesFileName);
        }

        public static void ReadFromJson(string filePath)
        {
            try
            {
                string jsonString = File.ReadAllText(filePath);
                Grades = JsonSerializer.Deserialize<List<Grade>>(jsonString);
            }
            catch (FileNotFoundException)
            {
                Grades = new List<Grade>();
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
                string jsonString = JsonSerializer.Serialize(Grades, options);
                File.WriteAllText(filePath, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while writing to JSON file: {ex.Message}");
            }
        }

        public static Grade GetGradeByApplicantId(Guid id)
        {
            foreach(var grade in Grades)
            {
                if(grade.ApplicantId == id)
                {
                    return grade;
                }
            }
            return null;
        }
    }
}
