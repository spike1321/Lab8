using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            
         string path = Directory.GetCurrentDirectory() + @"\numbers.txt";
            int resolt=0;
         Random rnd = new Random();
            StreamWriter writer = new StreamWriter(path, false,System.Text.Encoding.UTF8);
            for (int i = 0; i < 10; i++)
            {
                writer.Write(rnd.Next(-50, 50)+ writer.NewLine);
                
            }
            writer.Close();
            string[] lines = File.ReadAllLines(path, System.Text.Encoding.UTF8);
            for(int j = 0; j< lines.Length;j++)
            {
                resolt += int.Parse(lines[j]);
            }
            
            Console.WriteLine("Сумма чисел равна: {0}",resolt);
           Console.ReadKey();
        }
    }
}
