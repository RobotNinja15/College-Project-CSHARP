using System;
using System.Collections.Generic;
using System.Text;
// Name: Maxuz Obtinario ID: 301093477
namespace Project
{
    class CollegeRegistration
    {
            static void Main(string[] args)
            {
                //Declare lists and variables
                List<Student> studentList = new List<Student>();
                List<Course> courseList = new List<Course>();
                List<Enrolment> enrolmentList = new List<Enrolment>();
                List<Faculty> facultyList = new List<Faculty>();
                List<CollegeProgram> programList = new List<CollegeProgram>();
                String firstName, lastName, email, programCode, courseCode, courseName, programName, degreeType, specialization;
                int select = 0, studentId = 0, sectionNumber = 0, facultyId = 0, phoneNumber = 0;
                double creditHours = 0;

                Console.WriteLine("Welcome to College Regrisation Software 2021, please select an option");
                do //Reapeat Until User exits using option 12.
                {
                    select = 0; //Reset select variable
                    while (select < 1 || select > 12) //User cannot enter number outside of range
                        try
                        {
                            Console.WriteLine("\n1.Enter Student\n2.Display Students\n3.Display courses taken by a student\n4.Enter Course\n5.Display Courses\n6.Display all students taking a course" +
                                "\n7.Enter Faculty\n8.Display courses taught by a Faculty\n9.Enter Program\n10.All students in a program\n11.Enrolment\n12.Exit");
                            select = int.Parse(Console.ReadLine());
                            if (select < 1 || select > 12)
                                Console.WriteLine("Enter a selection on screen!");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Please enter a valid selection!");
                        }
                    switch (select)
                    {
                        case 1: //Enter Student
                            studentId = 0;
                            while (studentId < 1) //User cannot enter a student ID below 1
                                try
                                {
                                    Console.WriteLine("Enter Student ID: ");
                                    studentId = int.Parse(Console.ReadLine());
                                    if (studentId < 1)
                                        Console.WriteLine("Student ID cannot be lower than 1.");
                                }
                                catch (Exception)
                                {
                                    Console.Write("Please enter a valid selection!");
                                }
                            Console.WriteLine("Enter First Name: ");
                            firstName = Console.ReadLine();
                            Console.WriteLine("Enter Last Name: ");
                            lastName = Console.ReadLine();
                            Console.WriteLine("Enter Email: ");
                            email = Console.ReadLine();
                            phoneNumber = 0;
                            while (phoneNumber < 1) //User cannot enter a phonenumber below 1
                                try
                                {
                                    Console.WriteLine("Enter Phone Number: ");
                                    phoneNumber = int.Parse(Console.ReadLine());
                                    if (phoneNumber < 1)
                                        Console.WriteLine("Phone Number cannot be lower than 1.");
                                }
                                catch (Exception)
                                {
                                    Console.Write("Please enter a valid selection!");
                                }
                            Console.WriteLine("Enter Program Code: ");
                            programCode = Console.ReadLine();
                            studentList.Add(new Student(studentId, firstName, lastName, email, phoneNumber, programCode)); break; //Create a new student object
                        case 2: //Display Students
                            if (studentList.Count == 0) //Output there are 0 students
                                Console.WriteLine("There are 0 students in the system.");
                            else //Output all ths students
                                foreach (Student s in studentList)
                                    Console.WriteLine(s.toString());
                            break;
                        case 3: //Display courses taken by a student
                            foreach (Enrolment e in enrolmentList) //Output studentID is taking coursecode
                                Console.WriteLine(e.getStudentId() + " is taking: " + e.getCourseCode());
                            break;
                        case 4: //Enter Course
                            Console.WriteLine("Enter Course Code: ");
                            courseCode = Console.ReadLine();
                            Console.WriteLine("Enter Course Name: ");
                            courseName = Console.ReadLine();
                            facultyId = 0;
                            while (facultyId < 1) //User cannot enter a faculty ID below 1
                                try
                                {
                                    Console.WriteLine("Enter Faculty ID: ");
                                    facultyId = int.Parse(Console.ReadLine());
                                    if (facultyId < 1)
                                        Console.WriteLine("Faculty ID cannot be lower than 1.");
                                }
                                catch (Exception)
                                {
                                    Console.Write("Please enter a valid selection!");
                                }
                            creditHours = 0;
                            while (creditHours < 1) //User cannot enter amount of credithours below 1
                                try
                                {
                                    Console.WriteLine("Enter amount of Credit Hours: ");
                                    creditHours = int.Parse(Console.ReadLine());
                                    if (creditHours < 1)
                                        Console.WriteLine("Credit Hours cannot be lower than 1.");
                                }
                                catch (Exception)
                                {
                                    Console.Write("Please enter a valid selection!");
                                }
                            courseList.Add(new Course(courseCode, courseName, facultyId, creditHours)); break;  //Create a new course object
                        case 5: //Display courses
                            if (courseList.Count == 0) //Output there are 0 courses
                                Console.WriteLine("There are 0 courses in the system.");
                            else //Output all courses
                                foreach (Course c in courseList)
                                    Console.WriteLine(c.toString());
                            break;

                        case 6: //Display all students taking a course
                            Console.WriteLine("Enter course code: ");
                            courseCode = Console.ReadLine();
                            Console.WriteLine("The students taking " + courseCode + " are: ");
                            foreach (Enrolment e in enrolmentList) //Output each student taking the specific coursecode inputed by user
                                if (e.getCourseCode().Contains(courseCode) == true)
                                {
                                    Console.WriteLine(e.getStudentId() + ", ");
                                }
                            break;
                        case 7: //Enter faculty
                            facultyId = 0;
                            while (facultyId < 1) //User cannot enter a faculty ID below 1
                                try
                                {
                                    Console.WriteLine("Enter Faculty ID: ");
                                    facultyId = int.Parse(Console.ReadLine());
                                    if (facultyId < 1)
                                        Console.WriteLine("Faculty ID cannot be lower than 1.");
                                }
                                catch (Exception)
                                {
                                    Console.Write("Please enter a valid selection!");
                                }
                            Console.WriteLine("Enter First Name: ");
                            firstName = Console.ReadLine();
                            Console.WriteLine("Enter Last Name: ");
                            lastName = Console.ReadLine();
                            Console.WriteLine("Enter Email: ");
                            email = Console.ReadLine();
                            phoneNumber = 0;
                            while (phoneNumber < 1) //User cannot enter a phone number below 1
                                try
                                {
                                    Console.WriteLine("Enter Phone Number: ");
                                    phoneNumber = int.Parse(Console.ReadLine());
                                    if (phoneNumber < 1)
                                        Console.WriteLine("Phone Number cannot be lower than 1.");
                                }
                                catch (Exception)
                                {
                                    Console.Write("Please enter a valid selection!");
                                }
                            facultyList.Add(new Faculty(facultyId, firstName, lastName, email, phoneNumber)); break;  //Create a new faculty object
                        case 8: //Display courses taught by a faculty
                            foreach (Course c in courseList)
                                Console.WriteLine(c.getFacultyId() + " is teaching: " + c.getCourseName());
                            break;
                        case 9: //Enter program
                            Console.WriteLine("Enter Program Code: ");
                            programCode = Console.ReadLine();
                            Console.WriteLine("Enter Program Name: ");
                            programName = Console.ReadLine();
                            select = 0;
                            while (select < 1 || select > 4) //User cannot enter number outside of range
                                try
                                {
                                    Console.WriteLine("\n1.Certificate\n2.Diploma\n3.Advanced Diploma\n4.Degree"); //Selecting credentials
                                    select = int.Parse(Console.ReadLine());
                                    if (select < 1 || select > 4)
                                        Console.WriteLine("Enter a selection on screen!");
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Please enter a valid selection!");
                                }
                            switch (select)
                            {
                                case 1:
                                    programList.Add(new CollegeProgram(programCode, programName, "Certificate"));
                                    break;
                                case 2:
                                    programList.Add(new CollegeProgram(programCode, programName, "Diploma"));
                                    break;
                                case 3:
                                    Console.WriteLine("Enter Specialization: ");
                                    specialization = Console.ReadLine();
                                    programList.Add(new CollegeAdvancedDegreeProgram(programCode, programName, "Advanced Diploma", specialization));
                                    break;
                                case 4:
                                    Console.WriteLine("Enter Degree Type: ");
                                    degreeType = Console.ReadLine();
                                    programList.Add(new CollegeAdvancedDegreeProgram(programCode, programName, "Degree", degreeType)); break;  //Create a new program object
                            }
                            break;
                        case 10: //All students in a program
                            Console.WriteLine("Enter program code: ");
                            programCode = Console.ReadLine();
                            Console.WriteLine("The students taking " + programCode + " are: ");
                            foreach (Student s in studentList) //Output each student taking the specific programcodez inputed by user
                                if (s.getProgramCode().Contains(programCode) == true)
                                {
                                    Console.WriteLine(s.StudentID() + ", ");
                                }
                            break;
                        case 11: //Enrolment
                            studentId = 0;
                            while (studentId < 1) //User cannot enter a student ID below 1
                                try
                                {
                                    Console.WriteLine("Enter Student ID: ");
                                    studentId = int.Parse(Console.ReadLine());
                                    if (studentId < 1)
                                        Console.WriteLine("Student Id cannot be lower than 1.");
                                }
                                catch (Exception)
                                {
                                    Console.Write("Please enter a valid selection!");
                                }
                            Console.WriteLine("Enter Course Code: ");
                            courseCode = Console.ReadLine();
                            sectionNumber = 0;
                            while (sectionNumber < 1) //User cannot enter a section number below 1
                                try
                                {
                                    Console.WriteLine("Enter Section Number: ");
                                    sectionNumber = int.Parse(Console.ReadLine());
                                    if (sectionNumber < 1)
                                        Console.WriteLine("Section Number cannot be lower than 1.");
                                }
                                catch (Exception)
                                {
                                    Console.Write("Please enter a valid selection!");
                                }
                            enrolmentList.Add(new Enrolment(studentId, courseCode, sectionNumber)); //Create a new enrolment object
                            break;
                        case 12: break; //Exit
                    }
                } while (select != 12); //Closes when user selects option 12
            }
    }
}



