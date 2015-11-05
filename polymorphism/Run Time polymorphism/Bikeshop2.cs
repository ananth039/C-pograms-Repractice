using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run_Time_polymorphism
{
    class Bikeshop2:Bike_Shop
    {
        public override void BikeDetails(string brandname, string model, string year, string color, double price)
        {
            Console.WriteLine("Brand Name: " + brandname);
            Console.WriteLine("Brand Name: " + model);
            Console.WriteLine("year:" + year);
            Console.WriteLine("Color:" + color);
            Console.WriteLine("price:" + price);

        }
    }
}
