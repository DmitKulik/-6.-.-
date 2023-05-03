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

        //Задание 7.2.3
        class BaseClass {
            public virtual void Display() {
                Console.WriteLine("Метод класса BaseClass");
            }
        }
        class DerivedClass : BaseClass {
            public override void Display() {
                Console.WriteLine("Метод класса DerivedClass");
            }
        }




        class Citizen
        {
            public virtual double Age{ get; set; }

            public void SayYourAge()
            {
                Console.WriteLine("Мне {0} лет", Age);
            }
        }

        class CivilServant : Citizen
        {
            private double age;
            public override double Age
            {
                get
                {
                    return age;
                }
                set
                {
                    if (value < 18)
                    {
                        Console.WriteLine("Для работы госслужащим гражданин должен быть не младше 18 лет");
                    }
                    else
                    {
                        age = value;
                    }
                }
            }
        }

        class President : CivilServant
        {
            private double age;
            public override double Age
            {
                get
                {
                    return age;
                }
                set
                {
                    if (value < 35)
                    {
                        Console.WriteLine("Для работы президентом гражданин должен быть не младше 35 лет");
                    }
                    else
                    {
                        age = value;
                    }
                }
            }
        }
    }
}














