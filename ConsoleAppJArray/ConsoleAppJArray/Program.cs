using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of employees: ");
        int numEmployees = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of working days for each employee (max 5): ");
        int numWorkingDays = int.Parse(Console.ReadLine());

        // Validate the number of working days
        if (numWorkingDays > 5)
        {
            Console.WriteLine("Error: The number of working days must be less than or equal to 5.");
            return;
        }

        // Validate the number of employees
        if (numEmployees > 4)
        {
            Console.WriteLine("Error: The number of employees must be less than or equal to 4.");
            return;
        }

        // Initialize Jagged Array
        int[][] salaries = new int[numEmployees][];
        for (int i = 0; i < numEmployees; i++)
        {
            salaries[i] = new int[numWorkingDays];
        }

        // Input salaries for each employee
        for (int i = 0; i < numEmployees; i++)
        {
            Console.WriteLine($"\nEnter salary details for Employee {i + 1}:");
            for (int j = 0; j < numWorkingDays; j++)
            {
                Console.Write($"Enter salary for Day {j + 1}: ");
                salaries[i][j] = int.Parse(Console.ReadLine());
            }
        }

        // Display header
        Console.WriteLine("\nDay\tTotalSalary");

        // Display daily and total salary
        for (int j = 0; j < numWorkingDays; j++)
        {
            int totalSalary = 0;
            Console.Write($"Day{j + 1}\t");

            for (int i = 0; i < numEmployees; i++)
            {
                totalSalary += salaries[i][j];
            }

            Console.WriteLine($"{totalSalary}");
        }
    }
}
