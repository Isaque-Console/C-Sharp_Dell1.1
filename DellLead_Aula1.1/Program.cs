using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DellLead_Aula1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How much data will you enter? ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0,n1;
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Number #" + i + ": ");
                n1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                sum +=n1;
            }
            Console.WriteLine("Sum: " + sum.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
