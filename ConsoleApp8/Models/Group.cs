using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8.Models
{
    class Group
    {
        public string Groupno { get; set; }
        public Group(string groupno, int studentlimit)
        {
            Groupno = groupno;
            StudentLimit = studentlimit;
        }
        public int StudentLimit
        {
            get
            {
                return 0;
            }
            set
            {
                if (value > 5 && value < 18)
                {

                }
            }
        }
        Student[] students = new Student[0];
        public bool CheckGroupno(string groupno)
        {
            if (groupno.Length == 5)
            {
                bool isDigit = false;
                bool isUpper = false;
                foreach (var item in groupno)
                {
                    if (char.IsDigit(item))
                    {
                        isDigit = true;
                    }
                    else if (char.IsUpper(item))
                    {
                        isUpper = true;
                    }
                    if (isDigit && isUpper)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public string AddStudent(Student students)
        {
            return "";
        }
    }
}
