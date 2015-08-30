using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSBExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            string mystring = "Hola World!";
            string result = Program.ExtractCapitals(mystring);
            System.Console.WriteLine(result);
            System.Console.ReadLine();

        }
        public static string ExtractCapitals(string str)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (char.IsUpper(ch))
                {
                    result.Append(ch);
                }
            }
            return result.ToString();

        }

    }
}
