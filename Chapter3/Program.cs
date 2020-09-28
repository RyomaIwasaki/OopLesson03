using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter3 {
    class Program {
        static void Main(string[] args) {
            var names = new List<string>
            {
                "Tokyo","New Delhi","Bangkok","London","Paris","Berlin","Canberra","Hong Kong",
            };

            //問題3 - 2 - 1  
            Boolean sekine = true;
            do
            {
                Console.WriteLine($"都市名を入力。空行で終了");
                var line = Console.ReadLine();
                var index = names.FindIndex(s => s == line);
                Console.WriteLine(index);
                Console.WriteLine();
                if (line=="")
                {
                    sekine = false;
                }
            } while (sekine);

            //Console.WriteLine($"都市名を入力。空行で終了");
            //do
            //{
            //    var line = Console.ReadLine();
            //    if (string.IsNullOrEmpty(line))
            //    {
            //        break;
            //    }
            //    var index = names.FindIndex(s => s == line);
            //    Console.WriteLine(index);
            //    Console.WriteLine();
            //} while (true);

            //問題3 - 2 - 2
            var cnt = names.Count(s => s.Contains('o'));
            Console.WriteLine(cnt);
            Console.WriteLine();

            //問題3 - 2 - 3
            var list = names.Where(s => s.Contains('o')).ToList();
            var citys = new List<string>();
            citys = list;

            foreach (var item in citys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //問題3-2-4
            var find = names.Where(s => s.Contains('B')).Select(s => s.Length);
            foreach (var item in find)
            {
                Console.WriteLine(item);
            }

            //var nameCounts = names.Where(s => s.StartsWith("B")).Select(s => s.Length);
            //foreach (var length in nameCounts)
            //{
            //    Console.WriteLine(length);
            //}
        }
    }
}
