using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            
         
            string path = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string[] files =  Directory.GetFiles(path, "*.*",SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
            Console.ReadKey();
        }
    }
}
