using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "abcd", "efgh", "ijklmn", "opqrs" };
            
            int i = words.Length;
            Console.WriteLine("string array length:"+i);
            int j = 0;
            for(int k=0;k<i;k++)
            {
                j += words[k].Length;
            }
            Console.WriteLine("Character count length in string array :"+j);
             
            string s1 = "anantha";
            string s2 = "Kumar";
            string s5 = "Anantha Kumar";
            string s3 = string.Concat(s1, s2);
            string s4 = string.Copy(s1);
            Console.WriteLine("Concat of string1,srtring 2 :"+ s3);
            Console.WriteLine("Contains"+s2.Contains("t"));
            Console.WriteLine("copy :"+s4);
            Console.WriteLine(" index of "+s2.LastIndexOf("a"));
            Console.WriteLine("last index of "+s2.LastIndexOf("r"));
            Console.WriteLine(s1.Remove(5));
            Console.WriteLine("to upper:"+s2.ToUpper());
            Console.WriteLine("to upper:" + s2.ToLower());
            Console.WriteLine("trim:"+s5.Trim());
           Console.WriteLine("insert :"+s1.Insert(7,"k"));
            Console.WriteLine("Replace:"+s1.Replace("k","a"));

            string spilts = "adhg,hjkfgdf,jdgsf,dsdfhj";
            string[] array1 = spilts.Split(',');
            for (int m = 0; m < array1.Length; m++)
            {
                Console.WriteLine(array1[m]);
            }

           foreach(string s in words)
            {
               char[] chararray=s.ToCharArray();
           
           }
              
           Console.WriteLine(s1.Substring(2,5));



           
        }
    }
}
