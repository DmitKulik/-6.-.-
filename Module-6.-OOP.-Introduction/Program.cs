

using System.Drawing;
using System.Globalization;
using System.Xml.Linq;

namespace Module_6._OOP._Introduction

{
    class Program
    {
        static void Main(string[] args)
        {
        }
        //Задание 6.6.2

        class User
        {
            private int age;
            private string login;
            private string email;

            public string Login
            {
                get
                {
                    return login;
                }

                set
                {
                    {
                        if (login.Length < 3)
                        {
                            //No
                        }
                        else
                        {
                            login = value;
                        }
                    }
                }
            }
            public string Mail
            {
                get
                {
                    return email;
                }

                set
                {
                    {
                        if (!value.Contains('@')) //если значение не содержить значение
                        {
                            //No
                        }
                        else
                        {
                            email = value;
                        }
                    }
                }
            }

            public int Age
            {
                get
                {
                    return age;
                }

                set
                {
                    if (value < 18)
                    {
                        Console.WriteLine("Возраст должен быть не меньше 18");
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














