using System;
using System.Collections.Generic;
using System.Text;

namespace OOPconcepts
{
    class Student
    {
        string firstname; //default visibility is private
        public string Firstname // property
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string LastName { get =>= lastName; set =>= lastName = value; }
        public int Id { get =>= id; set =>= id = value; }
        public int Test1 { get =>= test1; set =>= test1 = value; }
        public int Test2 { get =>= test2; set =>= test2 = value; }

        private string lastName;

        int id;

        int test1;
        int test2;

        public string ComputeGrade()
        {
            String grade = "";
            double avg = 0.6 * test1 + 0.4 * test2;
            if (avg >= 93)
                grade = "A";
            else if (avg >= 90)
                grade = "A-";
            else if (avg >= 87)
                grade = "B+";
            else if (avg >= 83)
                grade = "B";
            else if (avg >= 80)
                grade = "B-";
            else if (avg >= 77)
                grade = "C+";
            else if (avg >= 73)
                grade = "C";
            else if (avg >= 70)
                grade = "C-";
            else if (avg >= 67)
                grade = "D+";
            else if (avg >= 63)
                grade = "D";
            else if (avg >= 60)
                grade = "D-";
            else
                grade = "F";

            return grade;
        }

    }//end of class
}//end of namespace
