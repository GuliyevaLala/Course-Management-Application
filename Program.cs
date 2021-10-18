using CourseManagment_Application.CourseSevice;
using System;

namespace CourseManagment_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("    ***Welcome to My Course Application***    ");
            Console.WriteLine("**************************************************");

            int selection;

            do
            {
                Console.WriteLine("                                                    ");
                Console.WriteLine("The following selections will assist you in the program: ");
                Console.WriteLine("______________________________________________");
                
                Console.WriteLine("               1. Create a Group"                );
                Console.WriteLine("______________________________________________");

                Console.WriteLine("                2. Get All Group"                 );
                Console.WriteLine("______________________________________________");

                Console.WriteLine("            3. Edit Group Information");
                Console.WriteLine("______________________________________________");

                Console.WriteLine("             4. Show Group Students");
                Console.WriteLine("______________________________________________");

                Console.WriteLine("             5. Show All Students");
                Console.WriteLine("______________________________________________");

                Console.WriteLine("               6. Create Student");
                Console.WriteLine("______________________________________________");

                Console.WriteLine("                   0. Exit");
                Console.WriteLine("______________________________________________");

                string selectValue = Console.ReadLine();

                bool result = int.TryParse(selectValue, out selection);

                if (result)
                {
                    switch (selection)
                    {
                        case 1:
                            Operation.CreateGroupOperation();
                            break;
                        case 2:
                            Operation.ShowAllGroupsOperation();
                            break;
                        case 3:
                            Operation.EditGroupOperation();
                            break;
                        case 4:
                            Operation.ShowAllStudentsOperation();
                            break;
                        case 5:
                            Operation.ShowGroupStudentOperation();
                            break;
                        case 6:
                            Operation.CreateStudentOperation();
                            break;
                        default:
                            break;

                    }

                }

            } while (selection != 0);
        }
    }
}