using System;
using System.Collections.Generic;

namespace Problem2Dictionary
{
struct Student
{
    public string StudentNumber;
    public string Name;
    public string Program;
    public int YearLevel;
}

class Problem2
{
    static void Main()
    {
        Dictionary<string, Student> studentDictionary =
            new Dictionary<string, Student>();

        while (true)
        {
            Console.WriteLine("\n========================================");
            Console.WriteLine("      STUDENT LOOKUP USING DICTIONARY");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Search Student");
            Console.WriteLine("3. Display All Students");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            string choice = Console.ReadLine() ?? "";

            if (choice == "1")
            {
                Console.Write("Enter Student Number: ");
                string studentNumber = Console.ReadLine() ?? "";

                if (studentDictionary.ContainsKey(studentNumber))
                {
                    Console.WriteLine("Student Number already exists.");
                    continue;
                }

                Student student = new Student();

                student.StudentNumber = studentNumber;

                Console.Write("Enter Name: ");
                student.Name = Console.ReadLine() ?? "";

                Console.Write("Enter Program: ");
                student.Program = Console.ReadLine() ?? "";

                Console.Write("Enter Year Level: ");
                student.YearLevel =
                    int.Parse(Console.ReadLine() ?? "0");

                studentDictionary.Add(studentNumber, student);

                Console.WriteLine("Student added successfully!");
            }
            else if (choice == "2")
            {
                Console.Write("Enter Student Number to search: ");
                string studentNumber = Console.ReadLine() ?? "";

                if (studentDictionary.TryGetValue(
                    studentNumber, out Student student))
                {
                    Console.WriteLine("\nStudent Found!");
                    Console.WriteLine(
                        $"Student Number: {student.StudentNumber}");
                    Console.WriteLine($"Name: {student.Name}");
                    Console.WriteLine($"Program: {student.Program}");
                    Console.WriteLine(
                        $"Year Level: {student.YearLevel}");
                }
                else
                {
                    Console.WriteLine("Student not found.");
                }
            }
            else if (choice == "3")
            {
                if (studentDictionary.Count == 0)
                {
                    Console.WriteLine("No student records found.");
                    continue;
                }

                Console.WriteLine("\n========================================");
                Console.WriteLine("           STUDENT RECORDS");
                Console.WriteLine("========================================");

                foreach (var item in studentDictionary)
                {
                    Student student = item.Value;

                    Console.WriteLine(
                        $"Student Number: {student.StudentNumber}");
                    Console.WriteLine($"Name: {student.Name}");
                    Console.WriteLine($"Program: {student.Program}");
                    Console.WriteLine($"Year Level: {student.YearLevel}");
                    Console.WriteLine("----------------------------------------");
                }
            }
            else if (choice == "4")
            {
                Console.WriteLine("Program exited.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}
}