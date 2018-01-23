using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj numer sztuki: ");
            int nrsztuki = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj gatunek: ");
            Console.WriteLine("1. Świerk/Jodła");
            Console.WriteLine("2. Sosna/Modrzew/Brzoza");
            Console.WriteLine("3. Buk/Grab/Klon");
            Console.WriteLine("4. Jesion, jawor, lipa, olcha, osika, topola, wiąz");
            Console.WriteLine("5. Dąb/Akacja");
            Console.WriteLine("6. Brzoza");
            int gatunek = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Podaj długość sztuki (w metrach bieżących): ");
            double dlsztuki = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj średnice w połowie długości sztuki (w centymetrach).");
            double srsztuki = Convert.ToDouble(Console.ReadLine());
            int odbkory = new int();
            odbkory = OdbicieKory (gatunek, srsztuki, odbkory);

            double srednica = srsztuki - odbkory;
            double miazszosc = ((3.14 * (Math.Pow(srednica, 2)) * dlsztuki) / 40000);

            Console.WriteLine("miazszosc: {0:F2}", miazszosc);






            Console.ReadKey();
        }

        private static int OdbicieKory (int gatunek, double srsztuki, int odbkory)
        {
            //1 gatunek;
            if (gatunek == 1 && srsztuki <= 24)
            {
                odbkory = 1;
            }
            else if (gatunek == 1 && srsztuki >= 25 && srsztuki <= 34)
            {
                odbkory = 2;
            }
            else if (gatunek == 1 && srsztuki >= 35 && srsztuki <= 49)
            {
                odbkory = 2;

            }
            else if (gatunek == 1 && srsztuki >= 50)
            {
                odbkory = 3;
            }

            //2 gatunek;
            else if ((gatunek == 2) && (srsztuki <= 24))
            {
                odbkory = 2;
            }
            else if ((gatunek == 2) && (srsztuki >= 25) && (srsztuki <= 34))
            {
                odbkory = 2;
            }
            else if ((gatunek == 2) && (srsztuki >= 35) && (srsztuki <= 49))
            {
                odbkory = 3;
            }
            else if ((gatunek == 2) && (srsztuki >= 50))
            {
                odbkory = 4;
            }

            //3 gatunek;
            else if ((gatunek == 3) && (srsztuki <= 24))
            {
                odbkory = 1;
            }
            else if ((gatunek == 3) && (srsztuki >= 25) && (srsztuki <= 34))
            {
                odbkory = 1;
            }
            else if ((gatunek == 3) && (srsztuki >= 35) && (srsztuki <= 49))
            {
                odbkory = 2;
            }
            else if ((gatunek == 3) && (srsztuki >= 50))
            {
                odbkory = 2;
            }


            //4 gatunek;
            else if ((gatunek == 4) && (srsztuki <= 24))
            {
                odbkory = 2;
            }
            else if ((gatunek == 4) && (srsztuki >= 25) && (srsztuki <= 34))
            {
                odbkory = 3;
            }
            else if ((gatunek == 4) && (srsztuki >= 35) && (srsztuki <= 49))
            {
                odbkory = 3;
            }
            else if ((gatunek == 4) && (srsztuki >= 50))
            {
                odbkory = 4;
            }


            //5 gatunek;
            else if ((gatunek == 5) && (srsztuki <= 24))
            {
                odbkory = 3;
            }
            else if ((gatunek == 5) && (srsztuki >= 25) && (srsztuki <= 34))
            {
                odbkory = 4;
            }
            else if ((gatunek == 5) && (srsztuki >= 35) && (srsztuki <= 49))
            {
                odbkory = 5;
            }
            else if ((gatunek == 5) && (srsztuki >= 50))
            {
                odbkory = 6;
            }


            //6 gatunek;
            else if ((gatunek == 6) && (srsztuki <= 24))
            {
                odbkory = 2;
            }
            else if ((gatunek == 6) && (srsztuki >= 25) && (srsztuki <= 34))
            {
                odbkory = 2;
            }
            else if ((gatunek == 6) && (srsztuki >= 35) && (srsztuki <= 49))
            {
                odbkory = 3;
            }
            else if ((gatunek == 6) && (srsztuki >= 50))
            {
                odbkory = 4;
            }

            return odbkory;
        }
    }
}
