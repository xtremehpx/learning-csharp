using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paul1TxtLib
{
    /// <summary>
    /// Paul1 Class Library to read text file
    /// </summary>
    public class Paul1Txt
    {
        public Paul1Txt(string filename)
        {
                FileName = filename;
        }
        public string FileName { get; set; }

        public string[] ReadAllTextFromFile()
        {

            Console.WriteLine("Reading from the text file:");
            string[] lines = File.ReadAllLines(FileName);
            // Display each line
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            return lines;
        }

        public void WriteAllTextToFile(string content )
        {
            File.WriteAllText(FileName, content);
            Console.WriteLine("Text written to the file.");
            Console.WriteLine();
        }

    }
}
