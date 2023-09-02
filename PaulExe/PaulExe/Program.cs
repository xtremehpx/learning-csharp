using BookDataModel;
using Paul1TxtLib;
using Paul2CsvLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaulExe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(new string('*', 20));
            Console.WriteLine("Text file example (Paul1)");
            Console.WriteLine(new string('*', 20));

            // simple text file 
            string txtfile = "sample.txt";

            // Text to write to the file
            string content = "Hello, this is some text to write to the file.";

            Paul1Txt paul1Txt = new Paul1Txt(txtfile);  

            // Write the text to the file
            paul1Txt.WriteAllTextToFile(content);

            // Read all lines from the file
            paul1Txt.ReadAllTextFromFile();



            Console.WriteLine(new string('*', 20));
            Console.WriteLine("CSV example (Paul2)");
            Console.WriteLine(new string('*', 20));

            int n = 20;
            List<Book> books = Books.GenerateRandomBooks(n);

            string csvfile = "book.csv";

            Paul2Csv paul2Csv = new Paul2Csv(csvfile);

            // save to a csv file
            paul2Csv.WriteBooksToCsv(books);
            Console.WriteLine("A CSV file is generated successfully.");
            Console.WriteLine();

            // read the csv and query
            var rbooks = paul2Csv.ReadBooksFromCsv();
            Console.WriteLine("Number of records read: " + rbooks.Count());
            if (rbooks.Count() > 0)
            {
                Console.WriteLine("Here is the books with price over $20:");
                Console.WriteLine();

                var selBooks = rbooks.Where(s => s.Price > 20);

                if (selBooks.Any())
                {
                    foreach (var item in selBooks)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
            }

            Console.ReadKey();

        }
    }
}
