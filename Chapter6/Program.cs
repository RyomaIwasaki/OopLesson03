using Chapter06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6 {
    class Program {
        static void Main(string[] args) {
            //6.1
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };
            //6.1.1
            Console.WriteLine(numbers.Max(num => num));
            Console.WriteLine();
            //6.1.2
            var results = numbers.Length - 2;
            foreach (var item in numbers.Skip(results))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            //6.1.3
            var ress = numbers.Select(n => n.ToString("000")).ToList();
            foreach (var item in ress)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine();
            //6.1.4
            var sort=numbers.OrderBy(n=>n).Take(3);
            foreach (var s in sort)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            //6.1.5
            var counts = numbers.Distinct().Count(n => n > 10);
            Console.WriteLine($"10以上の数は{counts}個です");
            Console.WriteLine();

        }
    }
}
