using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public abstract class AnimalBase
    {
        public Double weight { get; set; }
    }

    public abstract class MmamalBase: AnimalBase
    {
        
    }

    public abstract class NoMmamalBase : AnimalBase
    {

    }

    public abstract class OnaTerrestrials : MmamalBase
    {
        public Double holkaHeight { get; set; }
    }

    public abstract class PetBase : OnaTerrestrials
    {
        public String breed { get; set; }
    }

     public class kitty: PetBase
    {
        public  String color { get; set; }
    }
    public class doggy: PetBase
    {
        public Double woolHeight { get; set; }
    }

    public class dolphin : MmamalBase
    {
        public String lenght { get; set; }
        public Int64 ages { get; set; }
    }
    public class tiger : OnaTerrestrials
    {
        public String range { get; set; }
        public Int64 leftOnNature { get; set; }
    }
    public class Frog : AnimalBase
    {
        public String color { get; set; }
        public Boolean toxic { get; set; }
    }

   

