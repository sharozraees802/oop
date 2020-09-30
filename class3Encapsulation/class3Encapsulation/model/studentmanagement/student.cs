using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class3Encapsulation.model.studentmanagement
{
    class student
    {
        private int age;
        private string name;

        public void SetAge (int a)
        {
            if (a > 0)
            {
                age = a;
            }
            else
            {
                Console.WriteLine("you've  entered an invalid value,please try again");
            }
        }

        public void SetName(string n)
        {
            if (!string.IsNullOrEmpty(n))
            {
                name = n;
            }
            else
            {
                Console.WriteLine("Can not enter empty or null value in name");
            }
        }
        public void detail()
        {
            Console.WriteLine("your name is {0} and your age is {1}",name,age);
            Console.ReadLine();
        }

    }
}
