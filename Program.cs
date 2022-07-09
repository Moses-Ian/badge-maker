using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
  {
		static void Main(string[] args)
		{
			List<Employee> employees = GetEmployees();
			PrintEmployees(employees);
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
				Console.WriteLine("Please enter a photo url: ");
				string photoUrl = Console.ReadLine();
				
				Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
				employees.Add(currentEmployee);
			}
			return employees;
		}
		
		static void PrintEmployees(List<Employee> employees)
		{
			string template = "{0,-10}\t{1,-20}\t{2}";
			for (int i = 0; i < employees.Count; i++) 
			{
				Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoUrl()));
			}
		}
  }
}