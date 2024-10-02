using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace StudentManagementSystem
{
    public class StudentManager
    {
       public List<Student> students = new List<Student>();
       public readonly string filePath = @"C:\Users\BENJAMIN\source\repos\TecvinsonAssignment\StudentManagementSystem\StudentManagementSystem\StudentData\student.json";

        // Load student records from JSON file
        public void LoadStudents()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    students = JsonSerializer.Deserialize<List<Student>>(json) ?? new List<Student>();
                    Console.WriteLine("Student records loaded successfully.");
                }
                else
                {
                    Console.WriteLine("No student records found. A new file will be created.");
                }
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Error loading students: {ex.Message}. The JSON file may be corrupted.");
                // You can choose to reset the students list and create a new file.
                students = new List<Student>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }


        // Save student records to JSON file
        public void SaveStudents()
        {
            try
            {
                string json = JsonSerializer.Serialize(students);
                File.WriteAllText(filePath, json);
                Console.WriteLine("Student records saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving students: {ex.Message}");
            }
        }

        // Add a new student

        // Display student

        // Edit student

        // Delete student
    }
}
