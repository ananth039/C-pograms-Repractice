using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    class Program
    {
        struct Electronics
        {
            public string brand;
            public string model;
            public string waranty;
            public int price;

        }
        static void Main(string[] args)
        {
            Electronics Phone;
            Phone.brand = "Nokia";
            Phone.model = "lumia 625";
            Phone.price = 9999;
            Phone.waranty = "2 years";
            Console.WriteLine(Phone.brand+Phone.model+Phone.price+Phone.waranty);



        }
    }
}
