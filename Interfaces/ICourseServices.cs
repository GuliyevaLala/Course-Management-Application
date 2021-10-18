using CourseManagment_Application.Enums;
using CourseManagment_Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagment_Application.Interfaces
{
    interface ICourseServices
    {
        public List<Group>Groups {get;}
        public List<Student>Students { get; }
        string CreateGroup( GroupCategory category, int limit);
        void ShowAllGroups();
        void EditGroup(string no, string newNo);
        void ShowGroupStudent(string no);
        void ShowAllStudents(string no);
        void CreateStudent(string fullName, string NO, EducationType Info);
    }
}
