

using System.Drawing;

namespace Module_6._OOP._Introduction

{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal { type = "Собака", name = "Вольт", age = 4 };

        }
        //Задание 6.2.2
        class Pen
        {
            public string color;
            public int cost;
        }
        public Pen()
        {
            string color = "черный";
            int cost = 100;
        }
        public Pen(string penColor, int penCost)
        {
            color = penColor;
            cost = penCost;
        }

    }



}