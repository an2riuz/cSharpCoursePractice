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
            Console.WriteLine(KonvertuotiISkaiciu(skaicius));
            Console.WriteLine("Ivestas skaicius " + SkaiciaiITeksta(Convert.ToInt32(skaicius)));
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
        static string KonvertuotiISkaiciu(string skaicius)
        {
            int konvertuotas = Convert.ToInt32(skaicius);
            if (konvertuotas > -10 && konvertuotas < 10)
            {
                string komentaras = "Skaicius yra teisinguose reziuose";
                return komentaras;
            }
            else
            {
                string komentaras = "Skaicius yra neteisinguose reziuose";
                return komentaras;
            }
        }
        static string SkaiciaiITeksta(int skaicius)
        {
            if (skaicius >= 0)
            {
                switch (skaicius)
                {
                    case 0:
                        return "nulis";
                    case 1:
                        return "vienas";
                    case 2:
                        return "du";
                    case 3:
                        return "trys";
                    case 4:
                        return "keturi";
                    case 5:
                        return "penki";
                    case 6:
                        return "sesi";
                    case 7:
                        return "septyni";
                    case 8:
                        return "astuoni";
                    case 9:
                        return "devyni";
                    case 10:
                        return "desimt";
                    case 11:
                        return "vienuolika";
                    case 12:
                        return "dvylika";
                    case 13:
                        return "trylika";
                    case 14:
                        return "keturiolika";
                    case 15:
                        return "penkiolika";
                    case 16:
                        return "sesiolika";
                    case 17:
                        return "septyniolika";
                    case 18:
                        return "astuoniolika";
                    case 19:
                        return "devyniolika";
                    default:
                        return "Skaicius nera tarp -19 ir 19";
                }
            }
            else
            {
                skaicius *= -1;
                return "minus " + SkaiciaiITeksta(skaicius);
            }
                
            
        }
    }
}
