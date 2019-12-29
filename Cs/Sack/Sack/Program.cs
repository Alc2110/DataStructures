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
            // pick something from the sack 10 times
            /*
            for (int i = 0; i < 10; i++)
            {
                var test = testSack.Retrieve(false);
                Console.WriteLine(test);
            }
            */
            // empty the sack into this list, and check
            List<object> myThings = testSack.Empty();
            foreach (var obj in myThings)
            {
                Console.WriteLine(obj);
            }

            Console.ReadKey();
        }
    }
}
