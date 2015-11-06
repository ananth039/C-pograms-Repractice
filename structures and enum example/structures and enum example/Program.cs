using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structures_and_enum_example
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneInfo pi = new PhoneInfo();
            Console.WriteLine("phone Operating Systems");
            Console.WriteLine("0.ios \n 1.Android \n 2.Windows \n 3.firefox");
            Console.WriteLine("select your mobile operating System");
            int choice=int.Parse(Console.ReadLine());
            Operatingsystem os = (Operatingsystem)choice;
            switch(os)
            {
                case Operatingsystem.ios:
                    pi.id = 1;
                    pi.brand = "apple";
                    pi.model = "5";
                    pi.price = 80000;
                    Console.WriteLine("id: {0}  brand: {1}  model: {2} price: {3} opearting system: {4}", pi.id,pi.brand,  pi.model, pi.price,Operatingsystem.ios);
                    break;
                case Operatingsystem.android:
                    pi.id = 2;
                    pi.brand = "Lenovo";
                    pi.model = "A6";
                    pi.price = 10000;
                    Console.WriteLine("id: {0}  brand: {1}  model: {2} price: {3} opearting system: {4}", pi.id, pi.brand, pi.model, pi.price, Operatingsystem.android);
                    break;
                case Operatingsystem.windows:
                    pi.id = 3;
                    pi.brand = "Windows";
                    pi.model = "Lumia 625";
                    pi.price = 9999;
                    Console.WriteLine("id: {0}  brand: {1}  model: {2} price: {3} opearting system: {4}", pi.id, pi.brand, pi.model, pi.price, Operatingsystem.windows);
                    break;

                case Operatingsystem.firefox:
                    pi.id = 1;
                    pi.brand = "intex";
                    pi.model = "g45";
                    pi.price = 2500;
                    Console.WriteLine("id: {0}  brand: {1}  model: {2} price: {3} opearting system: {4}", pi.id, pi.brand, pi.model, pi.price, Operatingsystem.firefox);
                    break;
            }

        }
    }
}
