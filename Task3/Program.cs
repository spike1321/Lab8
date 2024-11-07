using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\file.txt";
            string[] lines = File.ReadAllLines(path, System.Text.Encoding.UTF8);
            int countLines = lines.Length;
            int countChar = 0;
            int countWords = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                
                countChar += lines[i].Length;

                string[] arrayString = lines[i].Split();
                for (int j = 0; j < arrayString.Length; j++)
                {
                    if(arrayString[j] != "—" && arrayString[j].Length !=0)
                    countWords += 1;
                }
            }
            Console.WriteLine("Статистика по file.txt\n количество символов равно: {0}, количество строк равно: {1}, количество слов равно: {2} ", countChar, countLines, countWords);
            Console.ReadKey();
        }
    }
}
