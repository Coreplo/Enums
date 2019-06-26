using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        //enum is used to create an enumeration, a type that consists on a set of named constants called enumerator list
        //by default the first enumerator has value 0, the second 1 and so on (just increment the previous one by one)
        //enum values can also be assigned manually

        //every enum type has an undelying type which can be any integral type except char
        //the default type of enumerator underlying is int

        //an explicit cast is required to convert from enum type to integral
        //int x = (int)Days.Monday;

        //enums are often used in switch statements

        enum Days { Monday, Martedi, Tetarti, Jeudi=42, Freitag, sâmbătă, niedziela };

        enum TrafficLight {green, yellow, red };

        static void Main(string[] args)
        {

            Console.WriteLine(Days.Monday);        //Monday
            Console.WriteLine(Days.Martedi);       //
            Console.WriteLine(Days.Tetarti);       //
            Console.WriteLine(Days.Jeudi);         //
            Console.WriteLine(Days.Freitag);       //
            Console.WriteLine(Days.sâmbătă);       //
            Console.WriteLine(Days.niedziela);     //

            Console.WriteLine((int)Days.Monday);        //1
            Console.WriteLine((int)Days.Martedi);       //2 
            Console.WriteLine((int)Days.Tetarti);       //3
            Console.WriteLine((int)Days.Jeudi);         //42
            Console.WriteLine((int)Days.Freitag);       //43
            Console.WriteLine((int)Days.sâmbătă);       //44
            Console.WriteLine((int)Days.niedziela);     //45


            TrafficLight x = TrafficLight.red;          //I dont get this code....(scratch my head)
            switch (x)
            {
                case TrafficLight.green:
                    Console.WriteLine("Go!");
                    break;
                case TrafficLight.yellow:
                    Console.WriteLine("Actung!");
                    break;
                case TrafficLight.red:
                    Console.WriteLine("Sotp!");
                    break;

            }

            Console.ReadKey();

        }
    }
}
