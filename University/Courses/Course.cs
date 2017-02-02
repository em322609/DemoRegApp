using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using University.Users;


namespace University.Courses
{
    public class Course : ICourse
    {
        private string title;
        private string major;
        private DateTime timeOfDay;
        private int creditHour;

        private List<Student> studentRoster = new List<Student>();

        public Course(string title, DateTime timeOfDay, int creditHour = 1, string major = "elective")
        {
            this.title = title;
            this.timeOfDay = timeOfDay;
            this.creditHour = creditHour;
            this.major = major;
        }
        public bool isFull
        {
            get
            {
                return studentRoster.Count == Global.maxStudents;
            }

        }

        public int rosterCount
        {
            get
            {
                return studentRoster.Count;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }

          
        }

        public bool AddStudent(Student student)
        {
            SpaceCheck(studentRoster.Count + 1);
            studentRoster.Add(student);
            return true;
        }

        public bool AddStudent(User usr)
        {
            throw new NotImplementedException();
        }

        public bool AddStudents(List<Student> roster)
        {

            SpaceCheck(studentRoster.Count + roster.Count);
            foreach (Student item in roster)
            {
                AddStudent(item);
            }
            return true;
        }

        public List<Student> GetStudentRoster()
        {
            throw new NotImplementedException();
        }

        public bool RemoveStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public bool RemoveStudent(int id)
        {
            throw new NotImplementedException();
        }

        public bool RemoveStudent(string firstname, string lastname)
        {
            throw new NotImplementedException();
        }

        private bool SpaceCheck(int newCount)
        {
            if(newCount > Global.maxStudents)
            {
                throw new Exception(Errors.notEnough);
            }
            return true;
        }
    }

   
}
