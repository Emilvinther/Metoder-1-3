using System;

namespace Metoder_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("first number");
            int tala = int.Parse(Console.ReadLine());

            Console.WriteLine("\nsecond number");
            int talb = int.Parse(Console.ReadLine());

            ALittleMath(tala, talb);

            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Insert A value");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("\nInsert B value");
            double b = double.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("a is bigger than b");
            }
            else if (a < b)
            {
                Console.WriteLine("\nb is bigger than a");
            }

            double c = Pythagoras(a, b);
            Console.WriteLine("\nC = {0}", c);

            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Write your name");
            string name = Console.ReadLine();

            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine(Age(name, age));

            Console.ReadKey();



        }

        public static void ALittleMath(int tala, int talb)
        {
            int add = tala + talb;

            float div = (float)tala / talb;

            int divwhole = tala / talb;

            double pow = Math.Pow(tala, talb);

            Console.WriteLine(pow);

            Console.WriteLine("a + b = {0}", add);
            Console.WriteLine("a / b = {0}", div);
            Console.WriteLine("a / b = {0}(rounded)", divwhole);
            Console.WriteLine("a ^ b = {0}", pow);
        }

        public static double Pythagoras(double a, double b)
        {
            double cpow = Math.Pow(a, 2) + Math.Pow(b, 2);

            double c = Math.Round(Math.Sqrt(cpow), 2);

            return c;
        }

        public static string Age(string name, int age)
        {
            if (age < 3)
            {
                 return $"{name} du må gå med ble";
            }
            else if (age > 3 && age <= 15)
            {
                return $"{name}, du må ingenting";
            }
            else if (age > 15 && age < 18)
            {
                 return $"{name}, du må drikke";
            }
            else return $"{name}, du må stemme og køre bil";

        }


        

    }
}
