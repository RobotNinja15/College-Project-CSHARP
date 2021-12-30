using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class CollegeAdvancedDegreeProgram : CollegeProgram
    {
        string _Specialization;

        public CollegeAdvancedDegreeProgram(String program_code, String program_name, String credentials, String Specialization) : base(program_code, program_name, credentials)
        {
            this._Specialization = Specialization; 
        }
    }
}
