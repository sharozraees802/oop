using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using class3Encapsulation.model.studentmanagement;

namespace class3Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            student std = new student();
            std.SetAge(-10);
            std.SetName("");
            std.detail();
           
        }
    }
}
