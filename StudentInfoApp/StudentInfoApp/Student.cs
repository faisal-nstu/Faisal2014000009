using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoApp
{
    class Student
    {
        public string firstName;
        public string lastName;
        public string regNo;

        public string GetFullName()
        {

            return String.Concat(firstName," ",lastName);
        }
    }
}
