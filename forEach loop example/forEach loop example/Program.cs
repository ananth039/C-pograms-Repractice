using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forEach_loop_example
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors=new string[5];
            colors[0] = "red";
            colors[1] = "green";
            colors[2] = "blue";
            colors[3] = "balck";
            colors[4] = "brown";
            foreach(string color in colors)
            {
                Console.WriteLine(color);
            }


        }
    }
}
