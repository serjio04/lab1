using System;
using System.Collections.Generic;

// Абстрактный класс сотрудника
abstract class Employee
{
    public string Name { get; set; }

    public abstract int CalculateLoyaltyPoints();
}

// Конечный класс сотрудника со стажем 1 год
class Employee1Year : Employee
{
    public override int CalculateLoyaltyPoints()
    {
        return 10;
    }
}

// Конечный класс сотрудника со стажем 2 года
class Employee2Years : Employee
{
    public override int CalculateLoyaltyPoints()
    {
        return 20;
    }
}

// Конечный класс сотрудника со стажем 3 года
class Employee3Years : Employee
{
    public override int CalculateLoyaltyPoints()
    {
        return 50;
    }
}

// Класс-контейнер, который может содержать других сотрудников
class EmployeeGroup : Employee
{
    private readonly List<Employee> employees = new List<Employee>();

    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
    }

    public override int CalculateLoyaltyPoints()
    {
        int maxPoints = 0;

        foreach (var employee in employees)
        {
            int points = employee.CalculateLoyaltyPoints();
            if (points > maxPoints)
            {
                maxPoints = points;
            }
        }

        return maxPoints;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Создание сотрудников с разными стажами
        Employee employee1Year = new Employee1Year();
        Employee employee2Years = new Employee2Years();
        Employee employee3Years = new Employee3Years();

        // Создание контейнера для сотрудников
        EmployeeGroup employeeGroup = new EmployeeGroup();

        // Добавление сотрудников в контейнер
        employeeGroup.AddEmployee(employee1Year);
        employeeGroup.AddEmployee(employee2Years);
        employeeGroup.AddEmployee(employee3Years);

        // Вычисление баллов лояльности для всех сотрудников
        int loyaltyPoints = employeeGroup.CalculateLoyaltyPoints();

        Console.WriteLine("Баллы лояльности для сотрудников: " + loyaltyPoints);
    }
}