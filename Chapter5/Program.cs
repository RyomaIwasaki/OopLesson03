using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5 {
    class Program {
        static void Main(string[] args) {
#if false
#region 5-1
            Console.WriteLine("---5.1---");
            Console.WriteLine("文字列を二回入力");
            var str1 = Console.ReadLine();
            var str2 = Console.ReadLine();
            if (string.Compare(str1, str2, true) == 0)
                Console.WriteLine("等しい");
            else
                Console.WriteLine("等しくない");
#endregion

#region 5-2
            Console.WriteLine("---5.2---");
            Console.WriteLine("数字を入力");
            var num = Console.ReadLine();
            if (int.TryParse(num, out var line))
            {
                var number = line.ToString("#,0");
                Console.WriteLine(number);
            }
#endregion

#region 5-3
            Console.WriteLine("---5.3---");
            var jack = "Jackdaws love my big sphinx of quartz";

            //5-3-1
            Console.WriteLine("---5.3.1---");
            Console.WriteLine(jack.Count(s => s == ' '));


            Console.WriteLine("---5.3.2---");
            var replased = jack.Replace("big", "small");
            Console.WriteLine(replased);

            //5-3-3
            Console.WriteLine("---5.3.3---");
            int words = jack.Split(' ').Count();
            Console.WriteLine($"単語の数：{words}");

            //5-3-4
            Console.WriteLine("---5.3.4---");
            var word = jack.Split(' ').Where(s => s.Length <= 4);
            Console.WriteLine(word);

            //5-3-5
            Console.WriteLine("---5.3.5---");
            var array = jack.Split(' ').ToArray();
            if (array.Length > 0)
            {
                var sb = new StringBuilder(array[0]);
            }
            #endregion

            #region 5.4
            var lines = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";

            //5-4
            Console.WriteLine("---5.4---");
            foreach (var item in lines.Split(';'))
            {
                var word = item.Split('=');
                Console.WriteLine("{0}:{1}", Tojapanese(word[0]), word[1]);
            }
            #endregion
        }
        static string Tojapanese(string key) {
            switch (key)
            {
                case "Novelist":
                    return "作家　";
                case "BestWork":
                    return "代表作";
                case "Born":
                    return "誕生年";
                default:
                    return "      ";
            }
        }
#endif


    }
}
