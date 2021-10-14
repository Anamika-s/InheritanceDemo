using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    class FullTimeEmployeeWithMO : Employee
    {
        string manager;
        
        public void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("Enter Manager");
            manager = Console.ReadLine();
            
        }
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Manager Name " + manager);
        }
    }
}
