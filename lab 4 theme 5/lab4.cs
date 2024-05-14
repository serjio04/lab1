using System;
using System.Collections.Generic;
using System.Linq;

// Определяем класс "Студент"
class Student : IComparable<Student>
{
    // Определяем свойства класса
    public string FullName { get; set; }
    public List<byte> Grades { get; set; }

    // Определяем конструктор класса
    public Student(string fullName, List<byte> grades)
    {
        FullName = fullName;
        Grades = grades;
    }

    // Реализуем интерфейс IComparable для сортировки студентов по имени
    public int CompareTo(Student other)
    {
        return FullName.CompareTo(other.FullName);
    }

    // Метод расчета стипендии
    public decimal CalculateScholarship()
    {
        if (Grades.Contains(2))
        {
            return 0;
        }
        else if (Grades.Contains(3) && !Grades.Contains(2))
        {
            return 1000;
        }
        else if (Grades.Min() >= 4)
        {
            return 1500;
        }
        else if (Grades.All(grade => grade == 5))
        {
            return 2500;
        }
        else
        {
            return 0;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создаем коллекцию студентов
        List<Student> students = new List<Student>();

        // Заполняем коллекцию пятью произвольными студентами
        students.Add(new Student("Иванов Иван Иванович", new List<byte> { 5, 4, 5, 5, 3 }));
        students.Add(new Student("Петров Петр Петрович", new List<byte> { 4, 5, 4, 4, 4 }));
        students.Add(new Student("Сидоров Сидор Сидорович", new List<byte> { 3, 4, 3, 3, 3 }));
        students.Add(new Student("Алексеев Алексей Алексеевич", new List<byte> { 2, 3, 3, 3, 3 }));
        students.Add(new Student("Николаев Николай Николаевич", new List<byte> { 5, 5, 5, 5, 5 }));

        // Описываем запрос LINQ для сортировки студентов по имени, у которых стипендия больше 0
        var sortedStudents = students.Where(student => student.CalculateScholarship() > 0)
                                     .OrderBy(student => student.FullName);

        // Выводим отсортированный список студентов в консоль
        foreach (var student in sortedStudents)
        {
            Console.WriteLine(student.FullName);
        }
    }
}
