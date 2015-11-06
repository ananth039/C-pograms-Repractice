using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticn_constructor_and_internal_construcrtor_example
{
    class student
    {
        readonly ulong id;
        readonly string name;
        ulong ph;
        static string clgname;
        static string clgloc;
        static ulong clgphno;
        const int clgeyear = 2013;
        const string clgperson = "vasavi ";
        static student()
        {
            clgname = "Sri vasavi Engineering College";
            clgloc = "Tadepalliudem";
            clgphno = 9000994007;
        }
        internal student(ulong stid, string stname, ulong stph)
        {
            id = stid;
            name = stname;
            ph = stph;
        }
        internal void stinfo()
        {
            Console.WriteLine("student Id is:" + id);
            Console.WriteLine("student Name is:" + name);
            Console.WriteLine("student phno is:" + ph);
        }
        internal void clginfo()
        {
            Console.WriteLine("student clg name is:" + clgname);
            Console.WriteLine("student clg loc is:" + clgloc);
            Console.WriteLine("student clg ph no is:" + clgphno);
            Console.WriteLine(" clg established year is:" + clgeyear);
            Console.WriteLine(" clg established person is:" + clgperson);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student obj = new student(513, "Anantha Kumar",8374286062);
            obj.stinfo();
            obj.clginfo();

            Console.ReadLine();
        }
    }
}
