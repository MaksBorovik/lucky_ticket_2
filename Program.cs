using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Щасливий_квиток
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            Console.Write("\t");
            for (int i = 1; i <= 999999; i++)
            {
                int position1 = i / 100000;
                int position2 = (i % 100000) / 10000;
                int position3 = (i % 10000) / 1000;
                int position4 = (i % 1000) / 100;
                int position5 = (i % 100) / 10;
                int position6 = i % 10;

                if (position1 + position2 + position3 == position4 + position5 + position6)
                {
                    counter++;
                    Console.Write(i.ToString("D6") + ";\t");
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("\t" + counter + "   Щасливих квиткiв");
            Console.ReadKey();
        }
    }
}
