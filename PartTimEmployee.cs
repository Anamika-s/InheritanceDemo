using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    class PartTimeEmployee : Employee
    {
        string duration;
        string projectName;
        public void GetPartTimeDetails()
        {
            Console.WriteLine("Enter Duration");
            duration = Console.ReadLine();
            Console.WriteLine("Enter ProjectName");
            projectName = Console.ReadLine();
        }
        public void DisplayParTimeDetails()
        {
            Console.WriteLine("Project Name " + projectName);
            Console.WriteLine("Duration is " + duration);

        }
    }
}
