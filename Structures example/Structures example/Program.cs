using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures_example
{
    class Program
    {
        struct book
        {
            public string BookName;
            public int price;
            public string category;


        }
        static void Main(string[] args)
        {
            book language, database;
            Console.WriteLine("Enter Book Name");
            language.BookName = Console.ReadLine();
            Console.WriteLine("enter book price");
            language.price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Book category");
            language.category = Console.ReadLine();

            Console.WriteLine("Enter Book Name");
            database.BookName = Console.ReadLine();
            Console.WriteLine("enter book price");
            database.price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Book category");
            database.category = Console.ReadLine();


            Console.WriteLine("_______________________________________");
            Console.WriteLine("               Langugae                ");
            Console.WriteLine("_______________________________________");

            Console.WriteLine("Book Name: {0}",language.BookName);
            Console.WriteLine("Book price:{0}",language.price);
            Console.WriteLine("Book Category:{0}",language.category);
            Console.WriteLine("_______________________________________");


            Console.WriteLine("_______________________________________");
            Console.WriteLine("                 Database              ");
            Console.WriteLine("_______________________________________");
            Console.WriteLine("Book Name: {0}", database.BookName);
            Console.WriteLine("Book price:{0}", database.price);
            Console.WriteLine("Book Category:{0}", database.category);
            Console.WriteLine("_______________________________________");
        }
    }
}
