using System;
using System.Collections.Generic;
using System.IO;

namespace CatWorx.BadgeMaker
{
  class Util
  {
		public static void PrintEmployees(List<Employee> employees)
		{
			string template = "{0,-10}\t{1,-20}\t{2}";
			for (int i = 0; i < employees.Count; i++) 
			{
				Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoUrl()));
			}
		}
		
		public static void MakeCSV(List<Employee> employees)
		{
			if (!Directory.Exists("data"))
			{
				Directory.CreateDirectory("data");
			}
			
			using (StreamWriter file = new StreamWriter("data/employees.csv"))
			{
				file.WriteLine("Id,Name,PhotoUrl");
				string template = "{0,-10}\t{1,-20}\t{2}";
				for (int i=0; i<employees.Count; i++)
				{
					file.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoUrl()));
				}
			}
		}
  }
}