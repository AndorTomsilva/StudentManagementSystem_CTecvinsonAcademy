using System;

namespace StudentManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager studentManager = new StudentManager();
            studentManager.LoadStudents();

            while (true)
            {
                Console.WriteLine("\n--- Student Management System ---");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View Students");
                Console.WriteLine("3. Edit Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Student newStudent = new Student();

                        Console.Write("Enter name: ");
                        newStudent.Name = Console.ReadLine();

                        Console.Write("Enter age: ");
                        newStudent.Age = long.Parse(Console.ReadLine());

                        Console.Write("Enter grade: ");
                        newStudent.Grade = Console.ReadLine();

                        studentManager.AddStudent(newStudent);
                        break;

                    case "2":
                        studentManager.DisplayStudents();
                        break;

                    case "3":
                        Console.Write("Enter the name of the student to edit: ");
                        string editName = Console.ReadLine();
                        studentManager.EditStudent(editName);
                        break;

                    case "4":
                        Console.Write("Enter the name of the student to delete: ");
                        string deleteName = Console.ReadLine();
                        studentManager.DeleteStudent(deleteName);
                        break;

                    case "5":
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}

