using System;

namespace _4_paskaitos_namu_darbai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite skaiciu nuo -9 iki 9: ");
            string skaicius = Console.ReadLine();
            Console.WriteLine(ArSkaicius(skaicius));
            Console.ReadKey();
        }

        static bool ArSkaicius(string skaicius)
        {
            int number;
            bool yraSkaicius = Int32.TryParse(skaicius, out number);

            if (yraSkaicius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
