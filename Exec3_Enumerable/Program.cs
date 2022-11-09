using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec3_Enumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> item110 = Enumerable.Range(1, 10);
            foreach (var item in item110)
            {
                Console.WriteLine(item);
            }
                       


        }
            
    }
}
