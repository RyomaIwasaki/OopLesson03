using Chaper7;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("**********************");
            Console.WriteLine("* 辞書登録プログラム *");
            Console.WriteLine("**********************");
            int num;
            var dict = new Dictionary<string, List<string>>();

            do
            {
                Console.WriteLine("1．登録　2．内容を表示　3．終了");
                Console.Write(">");
                var flag = Console.ReadLine();
                Console.WriteLine();
                if (int.TryParse(flag, out num))
                {
                    switch (num)
                    {
                        case 1:
                            // ディクショナリに追加
                            Console.Write("KEYを入力:");
                            var key = Console.ReadLine();
                            Console.Write("VALUEを入力:");
                            var value = Console.ReadLine();
                            if (dict.ContainsKey(key))
                            {
                                dict[key].Add(value);
                            }
                            else
                            {
                                dict[key] = new List<string> { value };
                            }
                            Console.WriteLine("登録しました");
                            break;
                        case 2:
                            // ディクショナリの内容を列挙
                            foreach (var item in dict)
                            {
                                foreach (var term in item.Value)
                                {
                                    Console.WriteLine("{0} : {1}", item.Key, term);
                                }
                            }
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }
                }
            } while (true);
        }

        
    }
}
