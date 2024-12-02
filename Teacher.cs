using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAssignment4_2
{
    public class Teacher : SchoolPerson
    {
        // List of students
        List<Student> students;

        // Holds class and the students in the class
        Dictionary<string, List<Student>> studentsDictionary;
    }
}
