using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname = "Steven Clark";
            string lastname = "Clark";

            Console.WriteLine(firstname.Clone());
            Console.WriteLine(firstname.CompareTo(lastname));

            Console.WriteLine(firstname.Contains("ven")); //Check whether specified value exists or not in string

            Console.WriteLine(firstname.EndsWith("n")); 
            //Check whether specified value is the last character of string
            Console.WriteLine(firstname.Equals(lastname));
            //Compare two string and returns true and false


            Console.WriteLine(firstname.GetHashCode());
            //Returns HashCode of String

            Console.WriteLine(firstname.GetType());
            //Returns type of string

            Console.WriteLine(firstname.GetTypeCode());
            //Returns type of string

            Console.WriteLine(firstname.IndexOf("e")); 
            //Returns the first index position of specified value the first index position of specified value

            Console.WriteLine(firstname.ToLower());
            //Covert string into lower case

            Console.WriteLine(firstname.ToUpper());
            //Convert string into Upper case

            Console.WriteLine(firstname.Insert(0, "Hello")); //Insert substring into string

            Console.WriteLine(firstname.IsNormalized());
            //Check Whether string is in Unicode normalization from C


            Console.WriteLine(firstname.LastIndexOf("e")); //Returns the last index position of specified value

            Console.WriteLine(firstname.Length);
            //Returns the Length of String

            Console.WriteLine(firstname.Remove(5));
            //Deletes all the characters from begining to specified index.

            Console.WriteLine(firstname.Replace('e', 'i')); // Replace the character

            string[] split = firstname.Split(new char[] { 'e' }); //Split the string based on specified value


            Console.WriteLine(split[0]);
            Console.WriteLine(split[1]);
            Console.WriteLine(split[2]);

            Console.WriteLine(firstname.StartsWith("S")); //Check wheter first character of string is same as specified value

            Console.WriteLine(firstname.Substring(2, 5));
            //Returns substring

            Console.WriteLine(firstname.ToCharArray());
            //Converts an string into char array.

            Console.WriteLine(firstname.Trim());
            //It removes starting and ending white spaces from string.

            Console.ReadLine();

        }
    }
}
