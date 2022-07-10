using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;

namespace  CatWorx.BadgeMaker {
  class PeopleFetcher 
  {
    // code from GetEmployees() in Program.cs
		public static List<Employee> GetEmployees()
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
		
		public static List<Employee> GetFromAPI() 
		{
			List<Employee> employees = new List<Employee>();
			
			using (WebClient client = new WebClient())
			{
				string response = client.DownloadString("https://randomuser.me/api/?results=10&nat=us&inc=name,id,picture");
				JObject json = JObject.Parse(response);
				foreach (JToken token in json.SelectToken("results"))
				{
					Employee emp = new Employee
					(
						token.SelectToken("name.first").ToString(),
						token.SelectToken("name.last").ToString(),
						Int32.Parse(token.SelectToken("id.value").ToString().Replace("-", "")),
						token.SelectToken("picture.large").ToString()
					);
					employees.Add(emp);
				}
			}
			
			
			return employees;
		}
  }
}