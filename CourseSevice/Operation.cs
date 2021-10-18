using CourseManagment_Application.Enums;
using CourseManagment_Application.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CourseManagment_Application.CourseSevice
{
	static class Operation
	{
		public static CourseService serviceObject = new CourseService();

		public static void CreateGroupOperation()
		{
			Console.WriteLine("_____________________________________________________________");
			Console.WriteLine("How many students do you want in this group 10 or 15?");
			Console.WriteLine("_____________________________________________________________");

			int lim;
			string limitValue = Console.ReadLine();
			bool limitResult = int.TryParse(limitValue, out lim);
			
			if (limitResult)
			{
				if (lim == 15)
				{
					Console.WriteLine("_____________________________________________________________");
					Console.WriteLine("Your group will be Online.");
					Console.WriteLine("_____________________________________________________________");
				}

				else if (lim == 10)
				{
					Console.WriteLine("_____________________________________________________________");
					Console.WriteLine("Your group will be Offline.");
					Console.WriteLine("_____________________________________________________________");
				}
				else
				{
					Console.WriteLine("_____________________________________________________________");
					Console.WriteLine("You must make the right choice! Sorry, you should try again.");
					Console.WriteLine("_____________________________________________________________");

					return;
				}


				Console.WriteLine("Select the category of the group you want to create.");
				foreach (var cat in Enum.GetValues(typeof(GroupCategory)))
				{
					Console.WriteLine("_____________________________________________________________");
					Console.WriteLine($"{(int)cat}. {cat}");
					Console.WriteLine("_____________________________________________________________");
				}

				int category;
				string categoryValue = Console.ReadLine();
				bool categoryResult = int.TryParse(categoryValue, out category);

				if (categoryResult)
				{
					switch (category)
					{
						case 1:
							string GroupNo = serviceObject.CreateGroup(GroupCategory.Programming, lim);
							Console.WriteLine($"{GroupNo} your group is succesfully created.Congrats");
							Console.WriteLine("_____________________________________________________________");
							break;
						case 2:
							GroupNo = serviceObject.CreateGroup(GroupCategory.Design, lim);
							Console.WriteLine($"{GroupNo} your group is succesfully created.Congrats");
							Console.WriteLine("_____________________________________________________________");
							break;
						case 3:
							GroupNo = serviceObject.CreateGroup(GroupCategory.System_Administration, lim);
							Console.WriteLine($"{GroupNo} your group is succesfully created. Congrats");
							break;
						default:
							break;
					}
				}
			}
		}
		public static void EditGroupOperation()
		{
			Console.WriteLine("_____________________________________________________________");
			Console.WriteLine("Please enter valid group No.");
			Console.WriteLine("_____________________________________________________________");
			string groupNo = Console.ReadLine();			

			Console.WriteLine("Now! Enter the number you want to change.");

			string newGroupNo = Console.ReadLine();

			serviceObject.EditGroup(groupNo, newGroupNo);
		}
		public static void ShowAllGroupsOperation()
		{
			serviceObject.ShowAllGroups();

		}
		public static void ShowAllStudentsOperation()
		{
			Console.WriteLine("Please enter student info");
			Console.WriteLine("_____________________________________________________________");

			string info = Console.ReadLine();
			serviceObject.ShowGroupStudent(info);
		}
		public static void ShowGroupStudentOperation()
		{
			Console.WriteLine($"Please enter student info");
			Console.WriteLine("_____________________________________________________________");

			string info = Console.ReadLine();
			serviceObject.ShowGroupStudent(info);

			String NO = Console.ReadLine();
			serviceObject.ShowGroupStudent(NO);
		}

		public static void CreateStudentOperation()
		{
			Console.WriteLine("_____________________________________________________________");
			Console.WriteLine("Please enter Student fullname");
			Console.WriteLine("_____________________________________________________________");

			string name = Console.ReadLine();
            Regex regex = new Regex(@"[A-Z][a-z]* [A-Z][a-z]");
            if (!regex.IsMatch(name))
            {
                Console.WriteLine("You must make the right choice! Sorry, you should try again.");
                return;
            }
			Console.WriteLine("Please enter Group Number");
			Console.WriteLine("_____________________________________________________________");

			string no = Console.ReadLine();

			Console.WriteLine("Please choose the Type of Education");
			Console.WriteLine("_____________________________________________________________");

			foreach (var I in Enum.GetValues(typeof(EducationType)))
			{
				Console.WriteLine($"{(int)I}. {I}");
			}

			int information;
			string informationValue = Console.ReadLine();
			bool informationResult = int.TryParse(informationValue, out information);

			if (informationResult)
			{
				switch (information)
				{
					case 1:
						serviceObject.CreateStudent(name, no.ToUpper(), EducationType.isWaranty);

						Console.WriteLine($"{name} will receive training provided that is guaranteed.");
						Console.WriteLine("_____________________________________________________________");
						break;
					case 2:
						serviceObject.CreateStudent(name, no.ToUpper(), EducationType.noWarranty);

						Console.WriteLine($"{name} will receive training provided that is no guaranteed.");
						Console.WriteLine("_____________________________________________________________");
						break;
					default:
						break;
				}
			}
		}
	}
}
