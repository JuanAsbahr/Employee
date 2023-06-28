using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using Employees.Entities;
using System.Globalization;
internal class Program
{
    static void Main(string[] args)
    {
        List<Employee> list = new List<Employee>();
        
        Console.Write("Enter the number of employees: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine();

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine($"Employee #{i} Data");
            Console.Write("Outsourced (y/n)? ");
            char ch = char.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Hours: ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Value per hour: ");
            double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (ch == 'y')
            {
                Console.Write("Additional charge: ");
                double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
            }
            else
            {
                list.Add(new Employee(name, hours, valuePerHour));
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("PAYMENTS:");
        foreach (Employee emp in list)
        {
            Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2"), CultureInfo.InvariantCulture);
        }

    }
}