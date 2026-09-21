using System;
using System.Collections.Generic;

namespace Problem4Stacks
{
struct Operation
{
    public string Action;
    public string StudentNumber;
    public string StudentName;
}

class Problem4
{
    static void Main()
    {
        Stack<Operation> operationHistory = new Stack<Operation>();

        while (true)
        {
            Console.WriteLine("\n========================================");
            Console.WriteLine("         OPERATION HISTORY");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Record Operation");
            Console.WriteLine("2. View Operation History");
            Console.WriteLine("3. View Last Operation");
            Console.WriteLine("4. Remove Last Operation");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");

            string choice = Console.ReadLine() ?? "";

            if (choice == "1")
            {
                Operation operation = new Operation();

                Console.Write("Enter Action (Added/Updated/Deleted): ");
                operation.Action = Console.ReadLine() ?? "";

                Console.Write("Enter Student Number: ");
                operation.StudentNumber =
                    Console.ReadLine() ?? "";

                Console.Write("Enter Student Name: ");
                operation.StudentName =
                    Console.ReadLine() ?? "";

                operationHistory.Push(operation);

                Console.WriteLine("Operation recorded successfully!");
            }
            else if (choice == "2")
            {
                if (operationHistory.Count == 0)
                {
                    Console.WriteLine(
                        "No recorded operations.");
                    continue;
                }

                Console.WriteLine("\nOPERATION HISTORY");

                int number = 1;

                foreach (Operation operation in operationHistory)
                {
                    Console.WriteLine(
                        $"{number}. {operation.Action} " +
                        $"{operation.StudentName}");

                    number++;
                }
            }
            else if (choice == "3")
            {
                if (operationHistory.Count == 0)
                {
                    Console.WriteLine(
                        "No recorded operations.");
                    continue;
                }

                Operation lastOperation =
                    operationHistory.Peek();

                Console.WriteLine(
                    $"Last Operation: {lastOperation.Action} " +
                    $"{lastOperation.StudentName}");
            }
            else if (choice == "4")
            {
                if (operationHistory.Count == 0)
                {
                    Console.WriteLine(
                        "No recorded operations.");
                    continue;
                }

                operationHistory.Pop();

                Console.WriteLine(
                    "Last operation removed successfully!");
            }
            else if (choice == "5")
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