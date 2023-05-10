

using System.Diagnostics.Metrics;

namespace Module_6._OOP._Introduction

{
    class Program
    {
        static void Main(string[] args)
        {

        }

        // Задание 7.6.12


        abstract class Engine { }

        class ElectricEngine : Engine { }

        class GasEngine : Engine { }

        abstract class CarPart { }

        class Battery : CarPart { }

        class Differential : CarPart { }

        class Wheel : CarPart { }

        abstract class Car<TEngine> where TEngine : Engine //ограничение от класса
        {
            public TEngine Engine;

            public virtual void ChangePart<TPart>(TPart newPart) where TPart : CarPart //ограничение от класса
            {

            }
        }
        class ElectricCar : Car<ElectricEngine>
        {
            public override void ChangePart<TPart>(TPart newPart)
            {

            }
        }

        class GasCar : Car<GasEngine>
        {
            public override void ChangePart<TPart>(TPart newPart)
            {

            }
        }

    }
}













