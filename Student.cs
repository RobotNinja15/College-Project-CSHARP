using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Student
    {
        int studentID;
        string firstName;
        string lastName;
        string email;
        int phoneNumber;
        string programCode;

        public Student(int studentID, string firstName, string lastName,
            string email, int phoneNumber, string programCode)
        {
            this.studentID = studentID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.programCode = programCode;
        }
        public int StudentID()
        {
            return this.studentID;
        }
        public string getFirstName()
        {
            return this.firstName;
        }
        public string getLastName()
        {
            return this.lastName;
        }
        public string getEmail()
        {
            return this.email;

        }
        public int getPhoneNumber()
        {
            return this.phoneNumber;

        }
        public string getProgramCode()
        {
            return this.programCode;

        }
        public String toString()
        {
            return "First Name: " + firstName + "\tLast Name: " + lastName + "\nEmail: " + email + "\nStudent ID: " + studentID + "\nPhone Number: " + phoneNumber + "\nProgram Code: " + programCode;
        }
    }
}
