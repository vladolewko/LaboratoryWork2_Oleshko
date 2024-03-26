using LaboratoryWork2_Oleshko.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace LaboratoryWork2_Oleshko.Utils
{
    public static class FacultyManager
    {
        public static List<Faculty> Faculties { get; set; }

        static FacultyManager()
        {
            Faculties = new List<Faculty>();
            ReadFromJson(Filenames.FacultiesFileName);
        }

        public static void ReadFromJson(string filePath)
        {
            try
            {
                string jsonString = File.ReadAllText(filePath);
                Faculties = JsonSerializer.Deserialize<List<Faculty>>(jsonString);
            }
            catch (FileNotFoundException)
            {
                Faculties = new List<Faculty>();
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
                string jsonString = JsonSerializer.Serialize(Faculties, options);
                File.WriteAllText(filePath, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while writing to JSON file: {ex.Message}");
            }
        }

        public static Faculty GetFacultyById(Guid id)
        {
            foreach(var faculty in Faculties)
            {
                if(faculty.Id == id)
                {
                    return faculty;
                }
            }
            return null;
        }
    }
}
