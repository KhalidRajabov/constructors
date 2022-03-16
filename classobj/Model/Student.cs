using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classobj.Model
{
    internal class Student:Person
    {
        //fields
        
        public string profession;

        public Student()
        {
            Console.WriteLine("ctor without a name");
        }


        public Student(string name) : this()
        {
            this.name = name;
        }

        public Student(string name, string surname, int age) : this(name)
        {
            this.surname = surname;
            this.age = age;
        }
        public Student(string name, string surname, int age, int id) : this("test", "test1", 25)
        {
            this.id = id;
        }
        public void Info()
        {
            Console.WriteLine($"{this.name} {surname} {age}");
        }
        /*public void FullName()
        {
            Console.WriteLine($"{name} {surname}");
        }*/

        /*public int GetAge()
        {
            return age;
        }*/
    }
}
