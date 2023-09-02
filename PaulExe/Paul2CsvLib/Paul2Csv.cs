using BookDataModel;
using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paul2CsvLib
{
    public class Paul2Csv
    {
        public Paul2Csv(string filename)
        {
                FileName = filename;
        }
        public string FileName { get; set; }

        
        public void WriteBooksToCsv(List<Book> books)
        {
            using (var writer = new StreamWriter(FileName))
            using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {

                csv.WriteRecords(books);
            }
        }

        public IEnumerable<Book> ReadBooksFromCsv()
        {
            using (var reader = new StreamReader(FileName))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                var records = csv.GetRecords<Book>();
                foreach (var csvRecord in records)
                {
                    yield return csvRecord;
                }
            }
        }
    }
}
