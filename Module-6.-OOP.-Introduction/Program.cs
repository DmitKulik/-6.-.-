

namespace Module_6._OOP._Introduction

{
    class Program
    {
        static void Main(string[] args) {
            DerivedClass Deri = new DerivedClass();
            Deri.Display();
        }

        //Задание 7.2.3
        class BaseClass
        {
            
            public virtual void Display()
            {
                Console.WriteLine("Метод класса BaseClass");
            }
        }
        
        class DerivedClass : BaseClass
            {
                public override void Display()
                {
                    base.Display(); // + отработает метод основного класса
                    Console.WriteLine("Метод класса DerivedClass");
                }
            }

        }
}














