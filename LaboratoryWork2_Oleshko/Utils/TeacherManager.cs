using LaboratoryWork2_Oleshko.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace LaboratoryWork2_Oleshko.Utils
{
    public static class TeacherManager
    {
        public static List<Teacher> Teachers { get; set; }

        static TeacherManager()
        {
            Teachers = new List<Teacher>();
            ReadFromJson(Filenames.TeachersFileName);
        }

        public static void ReadFromJson(string filePath)
        {
            try
            {
                string jsonString = File.ReadAllText(filePath);
                Teachers = JsonSerializer.Deserialize<List<Teacher>>(jsonString);
            }
            catch (FileNotFoundException)
            {
                Teachers = new List<Teacher>();
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

                string jsonString = JsonSerializer.Serialize(Teachers, options);
                File.WriteAllText(filePath, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while writing to JSON file: {ex.Message}");
            }
        }

        public static Teacher FindTeacherByLogin(string login)
        {
            foreach(var teacher in Teachers)
            {
                if(teacher.Login ==  login)
                {
                    return teacher;
                }
            }

            return null;
        }

        public static bool IsTeacherWithLoginExists(string login)
        {
            foreach (var teacher in Teachers)
            {
                if (teacher.Login == login)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
