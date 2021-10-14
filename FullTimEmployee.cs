using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    class FullTimeEmployee : Employee
    {
        string manager;
        
        public void GetFullTimeDetails()
        {
            Console.WriteLine("Enter Manager");
            manager = Console.ReadLine();
            
        }
        public void DisplayFullimeDetails()
        {
            Console.WriteLine("Manager Name " + manager);
        }
    }
}
