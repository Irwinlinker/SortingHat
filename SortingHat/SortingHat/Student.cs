using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingHat
{
    class Student
    {
        public string firstName;
        public string lastName;
        //public int year;
        public string house;

        //constructor
        public Student(string fname, string lname, string ahouse)
        {
            firstName = fname;
            lastName = lname;   
            //year = ayear;
            house = ahouse;

        }
    }
}
