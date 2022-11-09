using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> item1015 = Enumerable.Range(10, 6);
            foreach (var item in item1015)
            {
                Console.WriteLine(item);
            }
        }
    }
}
