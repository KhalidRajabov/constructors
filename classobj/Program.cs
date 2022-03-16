using System;
using classobj.Model;

namespace classobj
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region anonymous
            /*string name1 = "Xalid";
            string surname1 = "Recebov";
            int age1 = 27;

            string name2 = "Noone";
            string surname2 = "Nobody";
            int age2 = 55;

            var obj1 = new
            {
                name1 = "Xalid",
                surname1 = "Recebov",
                age1 = 27

            };

            
            Console.WriteLine(obj1.name1 + obj1.surname1 + obj1.age1);*/
            #endregion

            #region class
            /*Student stu1 = new Student();
            stu1.name = "Xalid";
            stu1.surname = "Recebov";
            //stu1.age = 27;

            Student stu2 = new Student();
            stu2.name = "Elshad";
            stu2.surname = "Jabiyev";
            stu2.age = 23;
            //Console.WriteLine(stu1.age);
            //Console.WriteLine(stu2.age);
            //stu1.FullName();
            //stu2.FullName();
            Console.WriteLine(stu1.GetAge());
            Console.WriteLine(stu2.GetAge());


            class Student
        {

        }*/
            #endregion

            #region constructor
            //Student stu3 = new Student("lorem", "ipsum", 24);
            /*stu3.name = "lorem";
            stu3.surname = "ipsum";
            stu3.age = 27;*/

            //Student stu4 = new Student("Xalid", "Recebov", 27);

            //Console.WriteLine(stu3.name);
            //stu4.Info();

            //Student stu5 = new Student("Xalid", "Recebov", 27, 5);

            #endregion

            #region inheritance
            Developer dev1 = new Developer();
            dev1.salary = 50;
            Student stu6 = new Student();
            stu6.profession = "proqramci";
            Console.WriteLine(dev1.salary);
            Console.WriteLine(stu6.profession);
            #endregion
        }
    }
  
}
