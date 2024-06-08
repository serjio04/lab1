using System;
using System.Collections.Generic;

// Базовый интерфейс для сотрудников и наград
public interface ILoyaltyComponent
{
    int GetLoyaltyPoints();
}

// Класс для представления сотрудника
public class Employee : ILoyaltyComponent
{
    public string Name { get; }
    public int YearsWorked { get; }

    public Employee(string name, int yearsWorked)
    {
        Name = name;
        YearsWorked = yearsWorked;
    }

    public int GetLoyaltyPoints()
    {
        if (YearsWorked >= 3)
        {
            return 50;
        }
        else if (YearsWorked >= 2)
        {
            return 20;
        }
        else if (YearsWorked >= 1)
        {
            return 10;
        }
        else
        {
            return 0;
        }
    }

    public override string ToString()
    {
        return $"{Name}: {GetLoyaltyPoints()} points";
    }
}

// Класс для представления группы сотрудников
public class EmployeeGroup : ILoyaltyComponent
{
    private List<ILoyaltyComponent> _employees = new List<ILoyaltyComponent>();

    public void Add(ILoyaltyComponent component)
    {
        _employees.Add(component);
    }

    public void Remove(ILoyaltyComponent component)
    {
        _employees.Remove(component);
    }

    public int GetLoyaltyPoints()
    {
        int totalPoints = 0;
        foreach (var employee in _employees)
        {
            totalPoints += employee.GetLoyaltyPoints();
        }
        return totalPoints;
    }

    public void DisplayLoyaltyPoints()
    {
        foreach (var employee in _employees)
        {
            Console.WriteLine(employee);
        }
    }
}

public class Program
{
    public static void Main()
    {
        // Создание сотрудников
        Employee emp1 = new Employee("Alice", 1);
        Employee emp2 = new Employee("Bob", 2);
        Employee emp3 = new Employee("Charlie", 3);

        // Создание группы сотрудников и добавление сотрудников в группу
        EmployeeGroup group = new EmployeeGroup();
        group.Add(emp1);
        group.Add(emp2);
        group.Add(emp3);

        // Вывод информации о начисленных баллах лояльности
        group.DisplayLoyaltyPoints();
        Console.WriteLine($"Total loyalty points for group: {group.GetLoyaltyPoints()}");
    }
}