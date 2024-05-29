using System;
using System.Collections.Generic;

class Employee
{
    public string Name { get; set; }
    public int YearsOfWork { get; set; }
    public int LoyaltyPoints { get; set; }

    public Employee(string name, int yearsOfWork)
    {
        Name = name;
        YearsOfWork = yearsOfWork;
        LoyaltyPoints = 0;
    }

    public void CalculateLoyaltyPoints()
    {
        if (YearsOfWork == 1)
        {
            LoyaltyPoints = 10;
        }
        else if (YearsOfWork == 2)
        {
            LoyaltyPoints = 20;
        }
        else if (YearsOfWork >= 3)
        {
            LoyaltyPoints = 50;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();

        // Создаем сотрудников
        employees.Add(new Employee("Иванов", 2));
        employees.Add(new Employee("Петров", 3));
        employees.Add(new Employee("Сидоров", 4));

        // Начисляем баллы лояльности сотрудникам
        foreach (var employee in employees)
        {
            employee.CalculateLoyaltyPoints();
        }

        // Выводим информацию о сотрудниках
        foreach (var employee in employees)
        {
            Console.WriteLine("Сотрудник: " + employee.Name);
            Console.WriteLine("Баллы лояльности: " + employee.LoyaltyPoints);
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
