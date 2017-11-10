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
            StreamWriter sw = new StreamWriter("file1");
            string str1 = Convert.ToString(Console.ReadLine());
            sw.WriteLine(str1);
            sw.Close();
            StreamReader sr = new StreamReader("file1");
            str = sr.ReadToEnd();
            Regex reg = new Regex(@"(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d");
            Match match = reg.Match(str);
            sr.Close();
            Console.WriteLine("\n");
            StreamWriter f1 = new StreamWriter("file2");
            while (match.Success)
            {
                Console.WriteLine(match.Value);
                f1.WriteLine(match.Value);
                match = match.NextMatch();
            }
            f1.Close();
            Console.WriteLine("\n");
            StreamReader f2 = new StreamReader("file2");
            Console.WriteLine(f2.ReadToEnd());
            f2.Close();
            Console.ReadKey();
        }
    }
}
