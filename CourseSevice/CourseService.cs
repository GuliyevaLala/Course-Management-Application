using CourseManagment_Application.Enums;
using CourseManagment_Application.Interfaces;
using CourseManagment_Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagment_Application.CourseSevice
{
    class CourseService : ICourseServices
    {
        public List<Group> groupObject = new List<Group>();
        public List<Group> Groups => groupObject;


        public List<Student> studentObject = new List<Student>();
        public List<Student> Students => studentObject;
        public string CreateGroup(GroupCategory category, int limit)
        {     
            Group group = new Group(category, limit);
            groupObject.Add(group);
            return group.GroupNo;            
        }

        public void CreateStudent(string fullName,string NO, EducationType Info)
        {
            Group group = groupObject.Find(c => c.GroupNo.ToUpper().Trim() == NO.ToUpper().Trim());
            Student telebe = new Student(fullName,NO, Info);            
            if (group == null)
            {
                Console.WriteLine($"{NO} group does not exist");
                Console.WriteLine("_____________________________________________________________");

            }
            else
            {
                studentObject.Add(telebe);
            }
        }

        public void EditGroup(string no, string newNo)
        {
            Group existedGroup = FindGroup(no);

            if (existedGroup == null)
            {
                Console.WriteLine($"{no} group does not exist");
                Console.WriteLine("_____________________________________________________________");

                return;
            }
            foreach (Group group in groupObject)
            {
                if (group.GroupNo.ToLower().Trim() == newNo.ToLower().Trim())
                {
                    Console.WriteLine($"{newNo} group is already existed");
                    Console.WriteLine("_____________________________________________________________");

                    return;
                }
            }
            existedGroup.GroupNo = newNo.ToUpper();

            Console.WriteLine($"{no.ToUpper()} succesfully is updated to {newNo.ToUpper()}");
            Console.WriteLine("_____________________________________________________________");

        }


        public Group FindGroup(string no)
        {
            foreach (Group group in groupObject)
            {
                if (group.GroupNo.ToLower().Trim() == no.ToLower().Trim())
                {
                    return group;
                }
            }
            return null;
        }
        public void ShowAllGroups()
        {
            foreach (Group group in groupObject)
            {
                Console.WriteLine($"{group.Category},{group.GroupNo},{group.studentInfo}");
                return;
            }
        }

        public void ShowAllStudents(string no)
        {
            Group group = groupObject.Find(g => g.GroupNo.ToLower().Trim() == no.ToLower().Trim());
            if (group == null)
            {
                Console.WriteLine($"{no} group does not exist");
                Console.WriteLine("_____________________________________________________________");

                return;
            }
            foreach (Student telebe in group.studentInfo)
            {
                Console.WriteLine(telebe.fullName, telebe.NO);
                Console.WriteLine("_____________________________________________________________");

            }
        }
        public void ShowGroupStudent(string no)
        {
            foreach (Group group1 in groupObject)
            {
                if (group1.GroupNo.ToLower().Trim() != no.ToLower().Trim())
                {
                    Console.WriteLine("Sorry!There is no any group!");
                    Console.WriteLine("_____________________________________________________________");

                    return;
                }

                Console.WriteLine(group1.studentInfo);

            }
        }
}    }