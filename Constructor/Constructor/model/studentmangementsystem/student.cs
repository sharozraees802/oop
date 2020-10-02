using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor.model.studentmangementsystem
{
    class student
    {
        //without parameter constructor
        //public student()
        //{
        //    Console.WriteLine("sharoz constructor");

        //}

        private int age;
        public student(int a)
        {
            age = a;

        }
        public void detail()
        {
            Console.WriteLine("my age is {0}",age);
        }
    }
}
