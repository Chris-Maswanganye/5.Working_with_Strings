using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Working_with_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This will write same line");
            Console.WriteLine("This will \n wrap to next line");
            Console.WriteLine("This will \" print out the quotation mark,");

            string firstname = "Evans";
            string lastname = "Fundira";
            //concatination
            Console.WriteLine(lastname + " " + firstname);

            //functions with strings
            Console.WriteLine(lastname.Length);
            //methods on strings
            Console.WriteLine(firstname.ToUpper());
            //methods with a parameter eg the contains(), its case sensitive
            Console.WriteLine(lastname.Contains("Fu"));
            //access characters using index
            Console.WriteLine(firstname[0]);
            //index of will tell you if the value is there and at what position
            Console.WriteLine("index of a is ");
            Console.WriteLine(lastname.IndexOf('a'));//can use double quotes too
            //substring, to grab from an index onwards
            Console.WriteLine(firstname.Substring(1));
            //you can also give index and length ie how many chars u wanna grab
            Console.WriteLine(firstname.Substring(1,2));
            Console.ReadLine();

        }
    }
}
