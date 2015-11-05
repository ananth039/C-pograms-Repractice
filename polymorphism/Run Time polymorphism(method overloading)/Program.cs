using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run_Time_polymorphism_method_overloading_
{
  
    class Program:Student 

    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Console.WriteLine(s.studentDetails("Ananth"));
            Console.WriteLine(s.studentDetails(152));
        }
    }
}
