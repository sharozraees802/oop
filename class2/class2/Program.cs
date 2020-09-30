using class2.com.studentmangement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class2
{
    //lesson part1
    //struct student
    //{
    //    public int age;
    //}


        //lesson part1
    //class student
    //{
    //    public int age;
    //}
    class Program
    {
        static void Main(string[] args)
        {
            //lesson 1 part 2
            //    student std = new student();
            //    std.age = 22;

            //    student std2 = std;

            //    student std3 = std;

            //    std.age = 18;
            //    Console.WriteLine("std value is{0}",std.age);
            //    Console.WriteLine("std2 valus is {0}",std2.age);
            //    Console.ReadLine();

            //lesson 2 part2
            //student std = new student();
            //std.age = 12;

            //student std1 = std;
            //student std2 = std;

            //std.age = 22;
            //Console.WriteLine("std2 valus is {0}", std2.age);
            //Console.ReadLine();
            student std = new student();
            std.age = 22;
            std.name = "sharoz" ;
            std.detail();


        }
    }
}
