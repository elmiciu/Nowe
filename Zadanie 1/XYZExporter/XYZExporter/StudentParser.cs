using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZExporter
{
    class StudentParser
    {
        private HashSet<Student> _students;

        public static async Task<StudentParser> Parse(List<string> studentDataList)
        {
            var students = new HashSet<Student>(new StudentComparer());
            foreach (var student in studentDataList)
            {
                await ParseStudentAsync(student, students);
            }
            return new StudentParser { _students = students };
        }

        public static async Task ParseStudentAsync(string student, HashSet<Student> students)
        {
            students.Add(new Student { });
        }

        public string ToJson()
        {
            return "";
        }
    }
}
