using System;
using System.Collections.Generic;

namespace Problem3Queue
{
    
struct StudentRequest
{
    public string StudentNumber;
    public string StudentName;
    public string RequestType;
}

class Problem3
{
    static void Main()
    {
        Queue<StudentRequest> requestQueue =
            new Queue<StudentRequest>();

        while (true)
        {
            Console.WriteLine("\n========================================");
            Console.WriteLine("        STUDENT REQUEST QUEUE");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Add Request");
            Console.WriteLine("2. View Pending Requests");
            Console.WriteLine("3. Process Request");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            string choice = Console.ReadLine() ?? "";

            if (choice == "1")
            {
                StudentRequest request = new StudentRequest();

                Console.Write("Enter Student Number: ");
                request.StudentNumber = Console.ReadLine() ?? "";

                Console.Write("Enter Student Name: ");
                request.StudentName = Console.ReadLine() ?? "";

                Console.Write("Enter Request Type: ");
                request.RequestType = Console.ReadLine() ?? "";

                requestQueue.Enqueue(request);

                Console.WriteLine("Request added successfully!");
            }
            else if (choice == "2")
            {
                if (requestQueue.Count == 0)
                {
                    Console.WriteLine("No pending requests.");
                    continue;
                }

                Console.WriteLine("\nREQUEST QUEUE");

                int number = 1;

                foreach (StudentRequest request in requestQueue)
                {
                    Console.WriteLine(
                        $"{number}. {request.StudentName} - " +
                        $"{request.RequestType}");

                    number++;
                }
            }
            else if (choice == "3")
            {
                if (requestQueue.Count == 0)
                {
                    Console.WriteLine("No pending requests.");
                    continue;
                }

                StudentRequest request = requestQueue.Dequeue();

                Console.WriteLine(
                    $"Processing Request: {request.StudentName} - " +
                    $"{request.RequestType}");

                Console.WriteLine("Request processed successfully!");
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