using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using University.Users;

namespace University.Courses
{
    interface ICourse
    {

        bool AddStudent(Student student);
        bool AddStudents(List<Student> roster);
        bool RemoveStudent(int id);
        bool RemoveStudent(Student student);
        bool RemoveStudent(string firstname, string lastname);

        bool isFull { get; }

        int rosterCount { get; }
        string Title { get; }

        List<Student> GetStudentRoster();
        
    }
}
