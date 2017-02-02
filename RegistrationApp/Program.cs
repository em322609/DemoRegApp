using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using University.Courses;
using University.Users;

namespace RegistrationApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Course testCourse = new Course("course100", new DateTime());
            Student s = new Student("f", "l", "pwd", "a@a.com", 1);
            List<Student> slist = new List<Student>();
            Administrator admin = new Administrator();

            Console.WriteLine(s.GetInfo());
            Console.WriteLine(testCourse.rosterCount);
            testCourse.AddStudent(s);
            Console.WriteLine(testCourse.rosterCount);

            for (int i = 0; i < 3; i++)
            {

            }
        }
    }
}
