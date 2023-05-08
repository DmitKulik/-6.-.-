

using System.Diagnostics.Metrics;

namespace Module_6._OOP._Introduction

{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.Display();
            B b = new B();
            b.Display();
            C c = new C();
            a.Display();
            D d = new D();
            b.Display();
            E e = new E();
            c.Display();

        }

        //Задание 7.2.7 uuuu

        class A
        {
            public virtual void Display()
            {
                Console.WriteLine("Вызван метод класса A");

            }

        }
        class B : A
        {
            public new void Display()
            {
                Console.WriteLine("Вызван метод класса B");
            }
        }
        class C : A
        {
            public override void Display()
            {
                Console.WriteLine("Вызван метод класса C");
            }
        }
        class D : B
        {
            public new void Display()
            {
                Console.WriteLine("Вызван метод класса D");
            }
        }
        class E : C
        {
            public new void Display()
            {
                Console.WriteLine("Вызван метод класса E");
            }
        }
    }
}













