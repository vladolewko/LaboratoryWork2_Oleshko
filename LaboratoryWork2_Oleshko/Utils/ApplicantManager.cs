using LaboratoryWork2_Oleshko.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace LaboratoryWork2_Oleshko.Utils
{
    public static class ApplicantManager
    {
        public static List<Applicant> Applicants { get; set; }

        static ApplicantManager()
        {
            Applicants = new List<Applicant>();
            ReadFromJson(Filenames.ApplicantsFileName);
        }

        public static void ReadFromJson(string filePath)
        {
            try
            {
                string jsonString = File.ReadAllText(filePath);
                Applicants = JsonSerializer.Deserialize<List<Applicant>>(jsonString);
            }
            catch (FileNotFoundException)
            {
                Applicants = new List<Applicant>();
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
                string jsonString = JsonSerializer.Serialize(Applicants, options);
                File.WriteAllText(filePath, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while writing to JSON file: {ex.Message}");
            }
        }

        public static Applicant FindApplicantByLogin(string login)
        {
            foreach (var applicant in Applicants)
            {
                if (applicant.Login == login)
                {
                    return applicant;
                }
            }

            return null;
        }

        public static bool IsApplicantWithLoginExists(string login)
        {
            foreach (var applicant in Applicants)
            {
                if (applicant.Login == login)
                {
                    return true;
                }
            }

            return false;
        }

        public static Applicant GetApplicantById(Guid id)
        {
            foreach(var applicant in Applicants)
            {
                if(applicant.Id == id)
                {
                    return applicant;
                }
            }
            return null;
        }
    }
}
