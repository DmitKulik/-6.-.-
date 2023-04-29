

using System.Drawing;
using System.Xml.Linq;

namespace Module_6._OOP._Introduction

{
    class Program
    {
        static void Main(string[] args)
        //Задание 6.3.1
        {
            var department = GetCurrentDepartment();

            string Type = "Банк";
            string Name = "Санкт-Петербург";

            if (department?.Company?.Type == "Банк" && department?.City?.Name == "Санкт-Петербург")
            {
                Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", department?.Company?.Name ?? "Неизвестная компания");
            }
        }
        static Department GetCurrentDepartment()
        {
            // logic
        }
        class Company
        {
            public string Type;
            public string Name;
        }

        class Department
        {
            public Company Company;
            public City City;
        }

        class City
        {
            public string Name;
        }


    }



}