using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;

namespace lesson7_fileio
{
    internal class Books
    {
        static Random random = new Random();

        internal static List<Book> GenerateRandomBooks(int count)
        {
            Random random = new Random();
            List<Book> books = new List<Book>();

            for (int i = 1; i <= count; i++)
            {
                Book book = new Book
                {
                    Name = GenerateRandomName(),
                    Year = random.Next(2000, 2023),
                    Genre = GetRandomGenre(),
                    Author = GenerateRandomAuthor(),
                    Publish = "Publisher " + i,
                    Sales = random.Next(1000, 1000000),
                    Link = "https://example.com/book" + i,
                    Price = random.Next(5, 50) + random.NextDouble()
                };

                books.Add(book);
            }

            return books;
        }

        static string GenerateRandomName()
        {
            string[] prefixes = { "The", "A", "My", "Your", "Our" };
            string[] nouns = { "Sun", "Moon", "Star", "Sea", "Mountain", "River", "Book", "Tree", "Wind" };

            string prefix = prefixes[random.Next(prefixes.Length)];
            string noun = nouns[random.Next(nouns.Length)];

            return $"{prefix} {noun}";
        }

        static string GenerateRandomAuthor()
        {
            string[] firstNames = { "John", "Emma", "Michael", "Sophia", "William", "Olivia", "James", "Ava", "Robert", "Mia" };
            string[] lastNames = { "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Davis", "Rodriguez", "Martinez" };

            string firstName = firstNames[random.Next(firstNames.Length)];
            string lastName = lastNames[random.Next(lastNames.Length)];

            return $"{firstName} {lastName}";
        }

        static string GetRandomGenre()
        {
            string[] genres = { "Fiction", "Mystery", "Science Fiction", "Fantasy", "Thriller", "Romance", "Horror", "Adventure" };
            return genres[random.Next(genres.Length)];
        }


        internal static void WriteBooksToCsv(List<Book> books, string filePath)
        {
            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                csv.WriteRecords(books);
            }
        }

        internal static IEnumerable<Book> GetBooksFromCsv(string csvFilePath)
        {
            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                var records = csv.GetRecords<Book>();
                foreach (var csvRecord in records)
                {
                    yield return csvRecord;
                }
            }
        }


        internal static void WriteBooksToExcel(List<Book> books, string filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Books");

                // Add headers
                worksheet.Cells[1, 1].Value = "Name";
                worksheet.Cells[1, 2].Value = "Year";
                worksheet.Cells[1, 3].Value = "Genre";
                worksheet.Cells[1, 4].Value = "Author";
                worksheet.Cells[1, 5].Value = "Publish";
                worksheet.Cells[1, 6].Value = "Sales";
                worksheet.Cells[1, 7].Value = "Link";
                worksheet.Cells[1, 8].Value = "Price";

                // Add data
                for (int i = 0; i < books.Count; i++)
                {
                    var book = books[i];
                    worksheet.Cells[i + 2, 1].Value = book.Name;
                    worksheet.Cells[i + 2, 2].Value = book.Year;
                    worksheet.Cells[i + 2, 3].Value = book.Genre;
                    worksheet.Cells[i + 2, 4].Value = book.Author;
                    worksheet.Cells[i + 2, 5].Value = book.Publish;
                    worksheet.Cells[i + 2, 6].Value = book.Sales;
                    worksheet.Cells[i + 2, 7].Value = book.Link;
                    worksheet.Cells[i + 2, 8].Value = book.Price;
                }

                package.SaveAs(new FileInfo(filePath));
            }
        }

        internal static List<Book> GetBooksFromExcel(string filePath)
        {
            List<Book> books = new List<Book>();

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                var worksheet = package.Workbook.Worksheets[0];
                int rowCount = worksheet.Dimension.Rows;

                for (int row = 2; row <= rowCount; row++)
                {
                    Book book = new Book
                    {
                        Name = worksheet.Cells[row, 1].Value?.ToString(),
                        Year = Convert.ToInt32(worksheet.Cells[row, 2].Value),
                        Genre = worksheet.Cells[row, 3].Value?.ToString(),
                        Author = worksheet.Cells[row, 4].Value?.ToString(),
                        Publish = worksheet.Cells[row, 5].Value?.ToString(),
                        Sales = Convert.ToInt32(worksheet.Cells[row, 6].Value),
                        Link = worksheet.Cells[row, 7].Value?.ToString(),
                        Price = Convert.ToDouble(worksheet.Cells[row, 8].Value)
                    };

                    books.Add(book);
                }
            }

            return books;
        }

    }

    public class Book
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public string Publish { get; set; }
        public int Sales { get; set; }
        public string Link { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return string.Format("{0}: {1}, {2}, ${3:F2}", Name, Author, Genre, Price);
        }
    }


}
