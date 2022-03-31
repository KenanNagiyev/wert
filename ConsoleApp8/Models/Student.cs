using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8.Models
{
    class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Point { get; set; }
        private static int _id;

        public Student(string fullname, int point)
        {
            FullName = fullname;

            Point = point;
        }
        public Student()
        {
            ++_id;
            Id = _id;
        }
        public void StudentInfo()
        {
            Console.WriteLine($"fullname:{FullName},Id:{Id}");
        }
    }
}
