using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Constructor.model.studentmangementsystem;

namespace Constructor
{
    class Program
    {

        static void Main(string[] args)
        {
            student srd = new student(10);
            srd.detail();
            Console.ReadLine();
        }
    }
}
