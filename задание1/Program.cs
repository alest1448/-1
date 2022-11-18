using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie
{
    internal class Program
    {
        public class Info
        {
            public static void name()
            {
                Console.WriteLine("What is your name?");
                string name = Console.ReadLine();
                Console.WriteLine($"Hello, {name}!");
            }
            static private int age;
            static private int wee;
            public static void age_()
            {
                Console.WriteLine("How you old?");
                age = Convert.ToInt32(Console.ReadLine());
                wee = age + 18;
                if (age >= 18)
                {
                    Console.WriteLine($"You are old. We are {wee} for two.");


                }
                else
                {
                    Console.WriteLine($"You are small. We are {wee} for two.");

                }

            }




        }
        static void Main(string[] args)
        {
            Info.name();
            Info.age_();

        }

    }
}
