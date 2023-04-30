

using System.Drawing;
using System.Xml.Linq;

namespace Module_6._OOP._Introduction

{
    class Program
    {
        static void Main(string[] args)
        { 
        }


        enum TurnDirection //Добавили перечисление TurnDirection
                           //для обозначения направления поворота для указателя
                           //поворота машины (поворотник не включен, право, лево)
        {
            None = 0,
            Left,
            Right
        }

        class Car
        {
            private double Fuel;

            private int Mileage;

            private string color; //добавлен цвет, используя приватное поле color

            private TurnDirection turn; //Добавили закрытое поле для хранения этой информации

            public Car()
            {
                Fuel = 50;
                Mileage = 0;
                color = "White";
            }

            private void Move()
            {
                // Move a kilometer
                Mileage++;
                Fuel -= 0.5;
            }

            private void Turn(TurnDirection direction) //Закрытый метод для изменения его значения, чтобы водитель мог включать и выключать поворотники 
            {
                turn = direction;
            }

            public void FillTheCar()
            {
                Fuel = 50;
            }

            public string GetColor() // метод для получения цвета
            {
                return color;
            }

            public void ChangeColor(string newColor) // метод для изминения цвета
            {
                if (color != newColor)
                    color = newColor;
            }

            public bool IsTurningLeft() //Для внешнего же мира мы должны получать информацию о том, поворачивает ли машина влево — метод IsTurningLeft.
            {
                return turn == TurnDirection.Left;
            }

            public bool IsTurningRight() ////Для внешнего же мира мы должны получать информацию о том, поворачивает ли машина вправо метод IsTurningRight
            {
                return turn == TurnDirection.Right;
            }
        }

    }
}



