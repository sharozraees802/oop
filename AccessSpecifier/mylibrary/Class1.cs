using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mylibrary
{
    // internal
    //public class person
    //{
    //    public int age;
    //    internal string name;
    //}

    class person
    {
        protected internal int age;
    }
    class student:person
    {
        public void show()
        {
            Console.WriteLine(age);
        }

    }

    class other
    {
        person p = new person();
       public void show()
        {
            p.age();
        }

    }
}
