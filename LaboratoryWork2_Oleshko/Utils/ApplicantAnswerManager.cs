using LaboratoryWork2_Oleshko.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace LaboratoryWork2_Oleshko.Utils
{
    public static class ApplicantAnswerManager
    {
        public static List<Answer> Answers { get; set; }

        static ApplicantAnswerManager()
        {
            Answers = new List<Answer>();
            ReadFromJson(Filenames.ApplicantAnswerFileName);
        }

        public static void ReadFromJson(string filePath)
        {
            try
            {
                string jsonString = File.ReadAllText(filePath);
                Answers = JsonSerializer.Deserialize<List<Answer>>(jsonString);
            }
            catch (FileNotFoundException)
            {
                Answers = new List<Answer>();
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
                string jsonString = JsonSerializer.Serialize(Answers, options);
                File.WriteAllText(filePath, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while writing to JSON file: {ex.Message}");
            }
        }

        public static Answer GetAnswerByApplicantId(Guid applicantId)
        {
            foreach (var answer in Answers)
            {
                if (answer.ApplicantId == applicantId)
                {
                    return answer;
                }
            }
            return null;
        }
    }
}
