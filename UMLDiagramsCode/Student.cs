using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDiagramsCode
{
    public class Student
    {
        private string studentId;
        private string name;
        private string major;
        private double gpa;
        private string[] enrolledCourses = new string[10];

        public Student(string studentId, string name, string major, double gpa)
        {
            this.studentId = studentId;
            this.name = name;
            this.major = major;
            this.gpa = gpa;
            this.enrolledCourses = new string[10]; // Initialize empty array
        }

        public void enroll(string newCourse)
        {
            for (int i = 0; i < enrolledCourses.Length; i++)
            {
                if (enrolledCourses[i] == null)
                {
                    enrolledCourses[i] = newCourse;
                    break;
                }
            }
        }

        public void drop(string dropCourse)
        {
            for (int i = 0; i < enrolledCourses.Length; i++)
            {
                if (enrolledCourses[i] == dropCourse)
                {
                    enrolledCourses[i] = " ";
                    break;
                }
            }
        }

        public double calculateGPA()
        {
            for (int i = 0; i < enrolledCourses.Length; i++)
            {
                // Assuming each course has a fixed weight of 4.0 for simplicity
                gpa += 4.0;
            }
            int totalCourses = enrolledCourses.Length;
            return (gpa/totalCourses);
        }

        public string StudentId { get => studentId; set => studentId = value; }
        public string Name { get => name; set => name = value; }
        public string Major { get => major; set => major = value; }
        public double GPA { get => gpa; set => gpa = value; }
        public string[] EnrolledCourses { get => enrolledCourses; set => enrolledCourses = value; }
    }
}
