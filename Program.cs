using System;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("For Employee ");
            //Employee employee = new Employee();
            //employee.GetDetails();
            //employee.DisplayDetails();

            //Console.WriteLine("For PartTime Employee ");
            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            //partTimeEmployee.GetDetails();
            //partTimeEmployee.GetPartTimeDetails();
            //partTimeEmployee.DisplayDetails();
            //partTimeEmployee.DisplayParTimeDetails();


            //Console.WriteLine("For Full Time Employee ");
            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
            //fullTimeEmployee.GetDetails();
            //fullTimeEmployee.GetFullTimeDetails();
            //fullTimeEmployee.DisplayDetails();
            //fullTimeEmployee.DisplayFullimeDetails();



            Console.WriteLine("For Employee ");
            Employee employee = new Employee();
            employee.GetDetails();
            employee.DisplayDetails();

            Console.WriteLine("For PartTime Employee ");
            PartTimeEmployeeWithMO partTimeEmployee = new PartTimeEmployeeWithMO();
            partTimeEmployee.GetDetails();
            partTimeEmployee.DisplayDetails();
            


            Console.WriteLine("For Full Time Employee ");
            FullTimeEmployeeWithMO fullTimeEmployee = new FullTimeEmployeeWithMO();
            fullTimeEmployee.GetDetails();
            fullTimeEmployee.DisplayDetails();
            
        }
    }
}
