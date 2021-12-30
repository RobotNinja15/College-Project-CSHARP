using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Faculty
    {
        int facultyID;
        string firstName;
        string lastName;
        string email;
        int phoneNumber;


        public Faculty(int facultytID, string firstName, string lastName,
            string email, int phoneNumber)
        {
            this.facultyID = facultyID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phoneNumber = phoneNumber;

        }
        public int FacultytID()
        {
            return this.facultyID;
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
    }
}
