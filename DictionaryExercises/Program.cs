using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            string newStudent;
            int newId;
            string input;

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                Console.Write("Student: ");
                input = Console.ReadLine();
                newStudent = input;

                if (!Equals(newStudent, ""))
                {
                    Console.Write("ID: ");
                    input = Console.ReadLine();
                    newId = int.Parse(input);
                    students.Add(newId, newStudent);
                }

            } while (!Equals(newStudent, ""));

            // Print class roster
            Console.WriteLine("\nClass roster:");
            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Key + " - " + student.Value);
            }
        }
    }
}
