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
            //var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };
            ////6.1.1
            //Console.WriteLine(numbers.Max(num => num));
            //Console.WriteLine();
            ////6.1.2
            //var results = numbers.Length - 2;
            //foreach (var item in numbers.Skip(results))
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();
            ////6.1.3
            //var ress = numbers.Select(n => n.ToString("000")).ToList();
            //foreach (var item in ress)
            //{
            //    Console.WriteLine(item);

            //}
            //Console.WriteLine();
            ////6.1.4
            //var sort=numbers.OrderBy(n=>n).Take(3);
            //foreach (var s in sort)
            //{
            //    Console.WriteLine(s);
            //}
            //Console.WriteLine();
            ////6.1.5
            //var counts = numbers.Distinct().Count(n => n > 10);
            //Console.WriteLine($"10以上の数は{counts}個です");
            //Console.WriteLine();

            ////6.2.1
            var books = Books.GetBooks();
            //var book = books.Where(n => n.Title == "ワンダフル・C#ライフ");
            //foreach (var item in book)
            //{
            //    Console.WriteLine($"価格:{item.Price}  ページ{item.Pages}");
            //}
            //Console.WriteLine();
            ////6.2.2
            //Console.WriteLine($"タイトルに「C#」がある冊数：{books.Count(x => x.Title.Contains("C#"))}");
            //Console.WriteLine();
            ////6.2.3
            //var title = books.Where(n => n.Title.Contains("C#"));
            //Console.WriteLine(title.Average(a => a.Pages));
            //Console.WriteLine();
            ////6.2.4
            //var bookIndex = books.FirstOrDefault(m => m.Price >= 4000);
            //if (bookIndex!=null)
            //{
            //    Console.WriteLine(bookIndex.Title);
            //}
            //Console.WriteLine();
            ////6.2.5
            //var bookmans = books.Where(m => m.Price < 4000).Max(n=>n.Pages);
            //Console.WriteLine(bookmans);
            //Console.WriteLine();
            ////6.2.6
            //var bookoff = books.Where(m => m.Pages >= 400).OrderByDescending(n => n.Price);
            //foreach (var item in bookoff)
            //{
            //    Console.WriteLine("{0},{1}", item.Title, item.Price);
            //}
            //Console.WriteLine();
            ////6.2.7
            //var selected = books.Where(n => n.Title.Contains("C#") && n.Pages <= 500);
            //foreach (var item in selected)
            //{
            //    Console.WriteLine(item.Title);
            //}
            //Console.WriteLine();
            //全ての書籍から「C#」の文字がいくつあるかカウントする
            int count = 0;

            foreach (var book in books.Where(b => b.Title.Contains("C#")))
            {
                for (int i = 0; i < book.Title.Length - 1; i++)
                {
                    if ((book.Title[i] == 'C') && (book.Title[i + 1] == '#'))
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"文字列「C#」の個数は{count}です");

        }
    }
}
