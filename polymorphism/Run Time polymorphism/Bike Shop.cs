using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run_Time_polymorphism
{
    class Bike_Shop
    {
        public string brandname, model, year,color;
        public double price;
        public virtual void BikeDetails(string brandname,string model,string year,string color,double price)
        {
            brandname = "Royal field";
            model="25ddx";
            year = "2008";
            price = 15000;
        }
    }
}
