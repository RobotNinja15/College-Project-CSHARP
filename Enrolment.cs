using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Enrolment
    {
        int studentId;
        string courseCode;
        int sectionNumber;


        public Enrolment(int studentID, string courseCode, int sectionNumber)
        {
            this.studentId = studentId;
            this.courseCode = courseCode;
            this.sectionNumber = sectionNumber;
        }
        public int getStudentId()
        {
            return this.studentId;
        }
        public string getCourseCode()
        {
            return this.courseCode;
        }
        public int getSectionNumber()
        {
            return this.sectionNumber;
        }
    }
}
