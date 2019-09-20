using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liigaasta
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int aasta;
            string name;
            

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Enter your birth of year?");
            aasta = int.Parse(Console.ReadLine());

            /*if (aasta % 4 == 0)// 0 tähendab, et jääki ei ole.
            {
                Console.WriteLine($"{name} oled sündinud liigaastal");
            }

            else
            {
                Console.WriteLine($"{name} ei ole sündinud liigaastal.");
            }
            Console.ReadLine(); // Ternary Operator kasutades ei ole vaja IF kasutada.

            ///Ternary Operator töötab kui on kaks võimalust, siis pole vaja IF-i kasutada.
            string answer = (aasta % 4 == 0) ? "Leap year" : "Not a Leap Year"; // ta küsib kas true või false. koolon on põhimõtteliselt else.
            Console.WriteLine(answer);
            Console.ReadLine();*/

            string valik;

            Console.WriteLine("What would be your poison? wisky or wine?");
            valik = Console.ReadLine();

            string choice = (valik == "wine") ? "Please, here is your wine." : "Please, here is your wisky.";
            Console.WriteLine(choice);
            Console.ReadLine();
            
        }

        





    }
}
