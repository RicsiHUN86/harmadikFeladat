using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harmadikFeladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] homersekletek = new int[7];
            bool voltFagypontAlatti = false;  

            for (int i = 0; i < 7; i++)
            {
                Console.Write("Add meg a(z) {0}. nap hőmérsékletét: ", i + 1);
                homersekletek[i] = int.Parse(Console.ReadLine());

                if (homersekletek[i] < 0)
                {
                    voltFagypontAlatti = true;
                }
            }

            double atlagHomerseklet = homersekletek.Average();

            int legmagasabbHomerseklet = homersekletek.Max();

            int legalacsonyabbHomerseklet = homersekletek.Min();

            Console.WriteLine("A hét átlaghőmérséklete: {0:F2}°C", atlagHomerseklet);
            Console.WriteLine("A legmelegebb nap hőmérséklete: {0}°C", legmagasabbHomerseklet);
            Console.WriteLine("A leghidegebb nap hőmérséklete: {0}°C", legalacsonyabbHomerseklet);

            if (voltFagypontAlatti)
            {
                Console.WriteLine("Fagypont alatti nap is volt!");
            }
            else
            {
                Console.WriteLine("Nem volt fagypont alatti nap.");
            }
        }
    }
}
