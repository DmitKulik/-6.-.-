using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Module_6._OOP._Introduction

{
    class Program
    {
        static void Main(string[] args) {
            
        }

        //Задание 7.2.4
        class BaseClass
        {
            public virtual int Counter { get; set; }
        }

        class DerivedClass : BaseClass {
            private int counter;
            public override int Counter
            {
                get { return counter; }
                set { if (value < 0) { Console.WriteLine("X");} else { counter = 9; } }
            }
        }

    }
}














