

using System.Diagnostics.Metrics;

namespace Module_6._OOP._Introduction

{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass Deri = new DerivedClass();
            
        }

        //Задание 7.2.4

        class BaseClass
        {
            public virtual int Counter
            {
                get;
                set;
            }
        }

        class DerivedClass : BaseClass
        {
            public int counter;
            public override int Counter
            {
                get
                {
                    return counter;
                }
                set
                {
                    if (counter > 0)
                    {

                        counter = value;
                    }
                }
            }
        }
    }
}














