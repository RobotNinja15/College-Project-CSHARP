using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class CollegeProgram
    {
        String _Program_code;
        String _Program_Name;
        String _Credentials;

        public CollegeProgram(String program_code, String program_name, string credentials)
        {

            this._Program_code = program_code;
            this._Program_Name = program_name;
            this._Credentials = credentials;


        }
        public String getProgram()
        {
            return this._Program_code;
        }
        public String getprogramName()
        {
            return this._Program_Name;
        }
        public String getCredentials()
        {
            return this._Credentials;
        }
    }

}
