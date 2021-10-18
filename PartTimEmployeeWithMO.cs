using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    class PartTimeEmployeeWithMO : Employee
    {
        string duration;
        string projectName;
        public PartTimeEmployeeWithMO():base (){}
        public PartTimeEmployeeWithMO(int id, 
            string name, 
            string dept, 
            int salary,
            string projectName,
            string duration) : base (id, name, dept , salary)
        { 
            this.projectName = projectName;
            this.duration = duration;
        }
        
        public void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("Enter Duration");
            duration = Console.ReadLine();
            Console.WriteLine("Enter ProjectName");
            projectName = Console.ReadLine();
        }
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Project Name " + projectName);
            Console.WriteLine("Duration is " + duration);

        }
    }
}
