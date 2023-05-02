

using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Xml.Linq;

namespace Module_6._OOP._Introduction

{
    class Program
    {
        static void Main(string[] args)
        //Задание 7.1.7  Впишите пропущенный код для параметров в Console.WriteLine вместо ??? так,
        //чтобы в консоли выводилось
        {
            SmartHelper helper = new SmartHelper("Олег");
            helper.Greetings("Грег");

            Console.ReadKey();
        }
       
        class SmartHelper
        {
            private string name;

            public SmartHelper(string name)
            {
                this.name = name;
            }

            public void Greetings(string name)
            {
                Console.WriteLine("Привет, {0}, я интеллектуальный помощник {1}", name, this.name);
            }
        }
        class BaseClass
        {
            protected string Name;

            public BaseClass(string name)
            {
                Name = name;
            }
        }

        class DerivedClass : BaseClass
        {
            public string Description;

            public int Counter;
        }

        public DerivedClass(string name, string description) : base(name)
        {
            Description = description;
        }

        public DerivedClass(string name, string description, int counter) : base(name)
        {
            Description = description;
            Counter = counter;
        }
    }
}














