using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_6
{
    internal class Course
    {
        private string courseName;
        private string courseCode;
        private int courseCredit;

        public Course()
        {
            //Empty Constructor
        }

        public Course(string cName, string cCode, int cCredit)
        {
            this.CourseName = cName;
            this.CourseCode = cCode;
            this.CourseCredit = cCredit;
        }
        public string CourseName
        {
            get
            {
                return courseName;
            }
            set
            {
                courseName = value;
            }
        }
        public string CourseCode
        {
            get
            {
                return courseCode;
            }
            set
            {
                courseCode = value;
            }
        }
        public int CourseCredit
        {
            get
            {
                return courseCredit;
            }
            set
            {
                courseCredit = value;
            }
        }

        public void ShowCourseInfo()
        {
            Console.WriteLine("Course Name: " + CourseName);
            Console.WriteLine("Course Code: " + CourseCode);
            Console.WriteLine("Course Credit: " + CourseCredit);
        }
    }
}
