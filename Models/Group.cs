using CourseManagment_Application.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagment_Application.Models
{
    class Group
    {
        public static int Count = 50;
        public string GroupNo { get; set; }
        public GroupCategory Category { get; set; }
        public bool IsOnline { get; set; }
        public int Limit { get; set; }
        public List<Student> studentInfo = new List<Student>();

        

        public Group( GroupCategory category, int limit)
        {
            switch (category)
            {
                case GroupCategory.Programming:
                    GroupNo = "Pro" + "-" + Count;
                    break;
                case GroupCategory.Design:
                    GroupNo = "D" + "-" + Count;
                    break;
                case GroupCategory.System_Administration:
                    GroupNo = "SA" + "-" + Count;
                    break;
                   default:
                    break;
            }
            Category = category;
            Limit = limit;
        }  
            public override string ToString()
            {
            return $"No: {GroupNo}, Category: {Category}";
            }
    }

   
}
