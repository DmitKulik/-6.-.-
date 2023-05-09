

using System.Diagnostics.Metrics;

namespace Module_6._OOP._Introduction

{
    class Program
    {
        static void Main(string[] args)
        {
            
           

        }
        // Задание 7.3.3
        abstract class ComputerPart
        {
            public abstract void Work();
        }
        class Processor : ComputerPart
        {
            public override void Work() {
                
            }
        }
        class MotherBoard : ComputerPart
        {
            public override void Work()
            {
                
            }
        }
        class GraphicCard : ComputerPart
        {
            public override void Work()
            {
                
            }
        }
    }
}













