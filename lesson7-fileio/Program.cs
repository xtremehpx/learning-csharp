using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7_fileio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(new string('*', 20));
            Console.WriteLine("Text file example");
            Console.WriteLine(new string('*', 20));

            // simple text file 
            string txtfile = "sample.txt";

            // Text to write to the file
            string textToWrite = "Hello, this is some text to write to the file.";

            // Write the text to the file
            File.WriteAllText(txtfile, textToWrite);
            Console.WriteLine("Text written to the file.");
            Console.WriteLine(  );

            // Read all lines from the file
            Console.WriteLine( "Reading from the text file:" );
            string[] lines = File.ReadAllLines(txtfile);
            // Display each line
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.ReadKey();

            // generate random data
            int n = 20;
            List<Book> books = Books.GenerateRandomBooks(n);


            Console.WriteLine( new string('*', 20));
            Console.WriteLine( "CSV example" );
            Console.WriteLine(new string('*', 20));

            // save to a csv file
            string csvfile = "book.csv";
            Books.WriteBooksToCsv(books, csvfile);
            Console.WriteLine("A CSV file is generated successfully.");
            Console.WriteLine();

            // read the csv and query
            var rbooks = Books.GetBooksFromCsv(csvfile);            
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

            Console.WriteLine(new string('*', 20));
            Console.WriteLine("Excel example");
            Console.WriteLine(new string('*', 20));

            string excelfile = "book.xlsx";
            Books.WriteBooksToExcel(books,excelfile);
            Console.WriteLine("An Excel file is generated successfully.");
            Console.WriteLine();

            var ebooks = Books.GetBooksFromExcel(excelfile);
            Console.WriteLine("Number of records read: " + ebooks.Count());
            if (ebooks.Count() > 0)
            {
                Console.WriteLine("Here is the books with price over $40:");
                Console.WriteLine();
                var selBooks = rbooks.Where(s => s.Price > 40);
                if (selBooks.Any())
                {
                    foreach (var item in selBooks)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
            Console.ReadKey();


            System.IO.File.Delete(txtfile);
            System.IO.File.Delete(csvfile);
            System.IO.File.Delete(excelfile);
        }
    }
}
