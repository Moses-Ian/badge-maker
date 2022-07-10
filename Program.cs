using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
  {
		static void Main(string[] args)
		{
			List<Employee> employees = GetEmployees();
			Util.PrintEmployees(employees);
			Util.MakeCSV(employees);
			Util.MakeBadges(employees);
		}
		
		static List<Employee> GetEmployees()
		{
			List<Employee> employees = new List<Employee>();
			while(true)
			{
				Console.WriteLine("Please enter a first name: ");
				string firstName = Console.ReadLine();
				if (firstName == "")
				{
					break;
				}
				Console.WriteLine("Please enter a last name: ");
				string lastName = Console.ReadLine();
				Console.WriteLine("Please enter an id: ");
				int id = Int32.Parse(Console.ReadLine());
				// Console.WriteLine("Please enter a photo url: ");
				// string photoUrl = Console.ReadLine();
				string photoUrl = "https://placekitten.com/300/300";
				
				Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
				employees.Add(currentEmployee);
			}
			return employees;
		}
		
  }
}