using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Courses;

namespace University.Users
{
    public class Student : User
    {
        private string major;
        private bool isFullTime;
       // List<Course> classes = new List<Course>();
        private bool isFulltime;
        Dictionary<string, Course> classes = new Dictionary<string, Course>();

        //enum year
        //array of courses

        public Student(string firstname, string lastname, string password, string email, int id, string major = "undecided") : base(firstname, lastname, password, email, id)
        {
            this.major = major;
            this.isFulltime = false;
        }

        public override string GetInfo()
        {
            StringBuilder info = new StringBuilder(base.ToString());
            info.Append($"\n{major}");
            info.Append($"\nfulltime: {isFulltime}");

            if(classes.Count == 0)
            {
                info.Append($"not registered for classes");
            }
            else
            {
                foreach (KeyValuePair<string, Course> item in classes)
                {
                    info.Append("\n");
                    info.Append(item.Value.Title);

                }
            }
            return "";
        }
    }
}
