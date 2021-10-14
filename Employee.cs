using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    
    class Employee
    {
        int id;
        string name;
        string dept;
        int salary;
        
         
        public void GetDetails()
        {
            Console.WriteLine("Enter Id");
            id = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Department");
            dept = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            salary = Convert.ToInt16(Console.ReadLine());
        }
        public void DisplayDetails()
        {
            Console.WriteLine("ID is " + id);
            Console.WriteLine("Name is " + name);
            Console.WriteLine("Department is " + dept);
            Console.WriteLine("Salary is " + salary);
        }
        
    }
}
