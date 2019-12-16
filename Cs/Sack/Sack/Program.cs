using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sack
{
    class Program
    {
        static void Main(string[] args)
        {
            Sack testSack = new Sack();
            testSack.Add(3);
            testSack.Add("hello");
            testSack.Add(false);
            var test = testSack.Retrieve(false);
            Console.WriteLine(test);

            Console.ReadKey();
        }
    }
}
