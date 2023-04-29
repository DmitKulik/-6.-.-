

using System.Drawing;

namespace Module_6._OOP._Introduction

{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal animal = new Animal { type = "Собака", name = "Вольт", age = 4 };

        }
        //Задание 6.2.8
        class Rectangle
        {
            public int a;
            public int b;

            public Rectangle()
            {
                int a = 6;
                int b = 4;
            }

            public Rectangle(int side) // a == b c одним параметром
            {
                a = side;
                b = side;
            }

            Rectangle(int first, int second) //с 2 параметрами, когда a != b  
            {
                a = first;
                b = second;
            }
            public int Square(out int c) => c = a * b; // метод посчета суммы
        }

    }



}