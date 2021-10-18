using CourseManagment_Application.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagment_Application.Models
{
    class Student
    {
        public string fullName { get; set; }
        public string NO { get; set; } 
        public EducationType Info { get; set; }

        public Student(string fullName, string NO, EducationType Info)
        {
            this.fullName = fullName;
            this.NO= NO;
            this.Info = Info;
        }
    }
}
