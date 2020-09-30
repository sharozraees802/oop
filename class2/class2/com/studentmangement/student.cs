using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class2.com.studentmangement
{
    class student
    {
        public int age;
        public string name;

        public void detail()
        {
            Console.WriteLine("student name is {0} and its age is {1}",name,age);
            Console.ReadLine();
        }
    }
}
