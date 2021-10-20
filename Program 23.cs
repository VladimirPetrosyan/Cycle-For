using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            for (int i = 1; i <= n; i++)
            {
                a = a + i;


            }
            Console.WriteLine(a);
            Console.ReadKey();

        }
    }
}
