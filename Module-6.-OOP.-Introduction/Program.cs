

using System.Drawing;
using System.Globalization;
using System.Xml.Linq;

namespace Module_6._OOP._Introduction

{
    class Program
    {
        static void Main(string[] args)
        {
        }
        //Задание 7.1.4
        class Employee
        {
            public string Name;
            public int Age;
            public int Salary;
        }

        class ProjectManager : Employee
        {
            public string NameProjectName;
            
        }

        class Developer : Employee
        {
            public string ProgrammingLanguage;

        }
        //Задание 7.1.5
        class Apple
        {
            
        }
        class Banana : Apple
        {
            
        }
        class Pear : Banana
        {

        }
        class Potato : Pear
        {

        }
        class Carrot : Potato
        {

        }









    }
}














