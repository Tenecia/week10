using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStringBuilderTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            StringBuilder sb = new StringBuilder();
            sb.Append("Numbers: ");// new string builder object

            for(int index = 1; index <= 200000; index++)            
            {
            sb.Append(index);
            }
            Console.WriteLine(sb.ToString().Substring(0, 1024)); // "0" is what place you want to start at, "1024" how many places you want to go out to. 
            Console.ReadLine();                                  // Substring lets you tell the string where to start and where to end 
        }
    }
}
