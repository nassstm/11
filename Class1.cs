using System;

using System.Linq;

//Задание 1

namespace Mat
{

    internal class Program
    {

        private static void Main()
        {
            string s = "Slave";

            var arr = s.ToCharArray();

            var qu = arr.Distinct();

            foreach (var z in qu)
            {
                Console.WriteLine("{0} повторяется {1} раз", z, s.Count(c => c == z));
            }
            Console.ReadKey();

        }
    }

}
