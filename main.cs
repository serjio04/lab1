using System;
using System.Collections.Generic;

namespace GenericsExample
{
    // Класс для представления шаблона сайта
    class Template
    {
        public decimal Cost { get; set; }  // Свойство для хранения стоимости шаблона
        public string Name { get; set; }   // Свойство для хранения названия шаблона

        // Конструктор класса Template
        public Template(decimal cost, string name)
        {
            Cost = cost;
            Name = name;
        }
    }

    // Класс для представления коллекции шаблонов сайта
    class TemplateCollection<T> where T : Template
    {
        private List<T> templates;  // Коллекция для хранения шаблонов

        // Конструктор класса TemplateCollection
        public TemplateCollection(params T[] templatesParams)
        {
            templates = new List<T>(templatesParams);
        }

        // Метод для вывода информации по каждому шаблону в консоль
        public void PrintTemplates()
        {
            foreach (T template in templates)
            {
                Console.WriteLine($"{template.Name} - {template.Cost}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создание экземпляра коллекции шаблонов
            TemplateCollection<Template> cmsTemplates = new TemplateCollection<Template>(
                new Template(10.99m, "Template 1"),
                new Template(19.99m, "Template 2"),
                new Template(14.99m, "Template 3")
            );

            // Вывод информации по каждому шаблону в коллекции
            cmsTemplates.PrintTemplates();
        }
    }
}