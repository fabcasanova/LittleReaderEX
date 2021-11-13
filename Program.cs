using System;
using System.IO;
using System.Text;

namespace MemoryStreamReaderLastLineAlgo
{
    class Program
    {
        private static string file = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "testData.txt");
        static void Main(string[] args)
        {
            readInputFromFile();
        }

        private static void readInputFromFile() 
        {
            using (FileStream fs = File.OpenRead(file))
            {
                using (StreamReader sw = new StreamReader(fs))
                {
                    long end = fs.Length;
                    fs.Seek(-82, SeekOrigin.End);

                    Console.WriteLine(sw.ReadLine());

                }
            }
        }
    }
}
