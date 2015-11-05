using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run_Time_polymorphism_method_overloading_
{
    class Student
    {
        public string studentDetails(string name)
        {
           return name;
        }
        public int studentDetails(int regno)
        {
            return regno;
        }
    }

}
