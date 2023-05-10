

using System.Diagnostics.Metrics;

namespace Module_6._OOP._Introduction

{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        // Задание 7.6.6


        class ElectricEngine : Engine { }

        class GasEngine : Engine { }

        class CarPart { }

        class Engine { }

        class Battery : CarPart { }

        class Differential : CarPart { }

        class Wheel : CarPart { }

        class Car<T1> where T1 : Engine //ограничение от класса
        {
            public T1 Engine;

            public virtual void ChangePart<T2>(T2 newPart) where T2 : CarPart //ограничение от класса
            {

            }
        }


    }
}













