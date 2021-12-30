using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Course
    {
        string courseCode;
        string courseName;
        int facultyId;
        double creditHours;

        public Course(string courseCode, string courseName, int facultyId,
            double creditHours)
        {
            this.courseCode = courseCode;
            this.courseName = courseName;
            this.facultyId = facultyId;
            this.creditHours = creditHours;
        }
        public string getCourseCode()
        {
            return this.courseCode;
        }
        public string getCourseName()
        {
            return this.courseName;
        }
        public int getFacultyId()
        {
            return this.facultyId;
        }
        public double getCreditHours()
        {
            return this.creditHours;
        }
        public String toString()
        {
            return "Course Name: " + courseName + "\t Course Code: " + courseCode + "\nFaculty Id: " + facultyId + "\nCredit Hours: " + creditHours;
        }

    }
}

