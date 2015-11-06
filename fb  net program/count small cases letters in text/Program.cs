using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count_small_cases_letters_in_text
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string...");
string s = Console.ReadLine();
int ctr = 0;
            int cap=0;
foreach (char r in s)
{
if (Char.IsLower(r))
    
{
ctr++;
}
else if(char.IsUpper(r))
{
    cap++;
}
}

Console.WriteLine(" small letters in a given string are::" + ctr);
            Console.WriteLine(" captial letters in a given string are::" + cap);
Console.ReadLine();
}
}
        }
 
