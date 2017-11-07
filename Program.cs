using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
namespace Ex_0_TsN
{
    class Program
    {
        static void Main(string[] args)
        {
            string str=String.Empty;
            StreamWriter sw = new StreamWriter("file1.txt");
            string str1 = Convert.ToString(Console.ReadLine());
            sw.WriteLine(str1);
            sw.Close();
            StreamReader sr = new StreamReader("file1.txt");
            str = sr.ReadToEnd();
            Regex reg = new Regex(@"[0-9]{2}\.[0-9]{2}\.[0-9]{4}");
            Match match = reg.Match(str);
            sr.Close();
            Console.WriteLine("\n");
            StreamWriter f1 = new StreamWriter("file2.txt");
            while (match.Success)
            {
                Console.WriteLine(match.Value);
                f1.WriteLine(match.Value);
                match = match.NextMatch();
            }
            f1.Close();
            Console.WriteLine("\n");
            StreamReader f2 = new StreamReader("file2.txt");
            Console.WriteLine(f2.ReadToEnd());
            f2.Close();
            Console.ReadKey();
        }
    }
}
