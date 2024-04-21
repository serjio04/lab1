using System;
using System.Collections.Generic;

namespace samplesolution
{
    // бaзовый класс для всех шаблонов
    public class Template
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Template(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }

    // класс, представляющий коллекцию шаблонов
    public class TemplateCollection<T> where T : Template
    {
        private List<T> templates;

        public TemplateCollection(List<T> templates)
        {
            this.templates = templates;
        }

        public void PrintTemplates()
        {
            foreach (var template in templates)
            {
                Console.WriteLine($"{template.Name} - {template.Price}");
            }
        }
    }

    // класс, представляющий шаблон
    public class WebsiteTemplate : Template
    {
        public WebsiteTemplate(string name, double price) : base(name, price)
        {
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                // создание экземпляра шаблонов
                var templates = new List<WebsiteTemplate>
                {
                    new WebsiteTemplate("template 1", 10.99),
                    new WebsiteTemplate("template 2", 15.99),
                    new WebsiteTemplate("template 3", 19.99)
                };

                // создание экземпляра коллекции шаблонов и передача ему экземпляров шаблонов
                var templateCollection = new TemplateCollection<WebsiteTemplate>(templates);

                // вывод информации по каждому шаблону
                templateCollection.PrintTemplates();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}