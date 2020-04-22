/*
 * Created by SharpDevelop.
 * User: Vendip
 * Date: 4/22/2020
 * Time: 8:21 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Test
{
	class Program
	{
		public static void Main(string[] args)
		{
			Details EmployeeDetails = new Details();
			EmployeeDetails.FirstName = "Vendip ";
			EmployeeDetails.LastName = "Nanpyal";
			Console.Write(EmployeeDetails.FirstName);
			Console.WriteLine(EmployeeDetails.LastName);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}