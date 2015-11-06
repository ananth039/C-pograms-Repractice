using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_builder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder s = new StringBuilder();
            s.Append("hai");
            s.Insert(3, "hello");
            Console.WriteLine(s);
            s.Remove(7, 8);
            Console.WriteLine(s); 
        }
    }
}
