using System;

class Program
{
    static void Main()
    {
        int[,] studMarks = new int[4, 3];

        // Input the roll numbers and marks for each student
        for (int i = 0; i < 4; i++)
        {
            Console.Write("Enter Roll No for Student " + (i + 1) + ": ");
            studMarks[i, 0] = int.Parse(Console.ReadLine());

            Console.Write("Enter Semester 1 marks for Student " + (i + 1) + ": ");
            studMarks[i, 1] = int.Parse(Console.ReadLine());

            Console.Write("Enter Semester 2 marks for Student " + (i + 1) + ": ");
            studMarks[i, 2] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nRollNo\tsem1\tsem2\tTotal");

        // Calculate the total marks and print the details
        for (int i = 0; i < 4; i++)
        {
            int rollNo = studMarks[i, 0];
            int sem1Marks = studMarks[i, 1];
            int sem2Marks = studMarks[i, 2];
            int totalMarks = sem1Marks + sem2Marks;

            Console.WriteLine($"{rollNo}\t{sem1Marks}\t{sem2Marks}\t{totalMarks}");
        }

        Console.ReadLine(); // Wait for user to press Enter
    }
}