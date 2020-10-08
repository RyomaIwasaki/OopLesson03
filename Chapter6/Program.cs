using Chapter06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6 {
    class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 9, 7, -5, 4, 2, 5, 4, 2, -4, 8, -1, 6, 4, };
            Console.WriteLine($"平均値：{numbers.Average()}");
            Console.WriteLine($"合計値：{numbers.Sum()}");
            Console.WriteLine($"最大値：{numbers.Max()}");
            Console.WriteLine($"最小値：{numbers.Where(s => s >= 0).Min()}");

            bool exists = numbers.Any(n => n % 7 == 0);

            var results = numbers.Where(n => n > 0).Take(6);
            foreach (var result in results)
            {
                Console.Write(result + "  ");
            }

            Console.WriteLine();
            var books = Books.GetBooks();
            Console.WriteLine($"本の平均価格：{books.Average(s => s.Price)}");
            Console.WriteLine($"本の合計価格：{books.Sum(s => s.Price)}");
            Console.WriteLine($"本のページが最大：{books.Max(s => s.Pages)}");
            Console.WriteLine($"一番高価な本：{books.Max(s => s.Price)}");
            Console.WriteLine($"タイトルに「物語」がある冊数：{books.Count(x => x.Title.Contains("物語"))}");

            //600ページを超える書籍があるか？
            Console.WriteLine("600ページを超える書籍は");
            Console.WriteLine(books.Any(n => 600 <= n.Pages) ? "ある" : "ない");

            //すべてが200ページ以上の書籍か？
            Console.WriteLine("すべてが200ページ以上の書籍か？");
            Console.WriteLine(books.All(n => 200 <= n.Pages) ? "すべて200ページ以上です" : "違います");

            //400ページを超える本は何冊目か？
            //var book = books.FirstOrDefault(n => n.Pages >= 400);
            //int count;
            //for (count = 0; i < books.Count; i++)
            //{
            //    if (books[i].Title.Contains(book.Title))
            //    {
            //        break;
            //    }
            //}

            var count = books.FindIndex(n => n.Pages > 400);
            Console.WriteLine($"400ページを超える本は{count + 1}冊目");
            Console.WriteLine();
            //本の値段が400円以上のものを3冊表示
            var pricemore = books.Where(n => n.Price >= 400).Take(3);
            foreach (var item in pricemore)
            {
                Console.WriteLine($"400円以上の本は{item.Title}です。");
            }
            

        }
    }
}
