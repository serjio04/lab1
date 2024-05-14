using System;

// Создаем свой класс исключения, наследуемый от базового класса Exception
public class NotATriangleException : Exception
{
    // В конструкторе вызываем конструктор базового класса с указанным сообщением
    public NotATriangleException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Введите три стороны треугольника: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            // Проверяем условие, образуют ли данные стороны треугольник
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                // Если не образуют, создаем исключение и выбрасываем его
                throw new NotATriangleException("Это не треугольник");
            }

            // Рассчитываем периметр треугольника
            int perimeter = a + b + c;
            Console.WriteLine("Периметр треугольника: " + perimeter);
        }
        catch (NotATriangleException ex)
        {
            // Перехватываем исключение нашего класса и выводим сообщение об ошибке
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            // Перехватываем все остальные исключения и выводим общее сообщение об ошибке
            Console.WriteLine("Произошла ошибка: " + ex.Message);
        }
        finally
        {
            // В блоке finally выводим сообщение о завершении работы программы
            Console.WriteLine("Работа закончена");
        }
    }
}