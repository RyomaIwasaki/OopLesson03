using Chapter06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6 {
    class Program {
        static void Main(string[] args) {
            //整数の例
            var numbrs = new List<int> { 19, 17, 15, 24, 12, 17, 14, 20, 12, 28, 19, 30, 24 };

            //var strings = numbrs.Select(n => n.ToString("0000")).ToArray();
            //foreach (var str in strings)
            //{
            //    Console.Write(str + "  ");
            //}

            numbrs.Select(n => n.ToString("0000")).ToList().ForEach(s => Console.Write(s + " "));
            //並べ替え
            var sortNumber = numbrs.OrderBy(n => n);
            foreach (var nums in sortNumber)
            {
                Console.WriteLine(nums + " ");
            }
            Console.WriteLine();


            //文字列の例
            var words = new List<string> {
                "Microsoft","Apple","Google","Oracle","FaceBook",};
            var lower = words.Select(name => name.ToLower()).ToArray();
            //オブジェクトの例
            var books = Books.GetBooks();
            //タイトルリスト
            var titles = books.Select(name=>name.Title);
            foreach (var title in titles)
            {
                Console.WriteLine(title + "  ");
            }
            Console.WriteLine();
            //ページ数の多い順に並べ替え（または金額の高い順）           
            var sortBooks = books.OrderByDescending(book=>book.Pages);
            foreach (var book in sortBooks)
            {
                Console.WriteLine(book.Title + " "+book.Pages);
            }
            Console.WriteLine();

        }
    }
}
