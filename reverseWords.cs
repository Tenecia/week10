using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWordReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "EM edit Tenecia "; // your string text
            string reversed = ReverseText(text);// Method that reverses  "EM edit"
            Console.WriteLine(reversed); // Console writes out " tide me"
            // console output: tide ME
            System.Console.ReadLine(); // stops the program 
        }

        static string ReverseText(string text)  // creating ReverseText Method 
        {
            StringBuilder sb = new StringBuilder(); // instantiating a new object called "sb" 
            for (int i = text.Length -1; i >= 0; i--) // the loop that reverses the text, starting at text.Length & keeps subtracting 1 untill it gets to the end 
			{
			 sb.Append(text[i]);// takes i and put it at the end of text
			}
            return sb.ToString(); // exits 
            
        }
        
    }

}
