using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        List<Employee> emplist = new List<Employee>();  

        emplist.Add(new Employee() { Id = 101, Name = "AAA", Salary = 5000, Experience = 5 });
        emplist.Add(new Employee() { Id = 102, Name = "BBB", Salary = 4000, Experience = 2 });
        emplist.Add(new Employee() { Id = 103, Name = "CCC", Salary = 3000, Experience = 6 });
        emplist.Add(new Employee() { Id = 104, Name = "DDD", Salary = 2000, Experience = 3 });

       /*
        IsPromotable isPromotable = new IsPromotable(Promote);

        Employee.PromoteEmployee(emplist, isPromotable);*/

        Employee.PromoteEmployee(emplist, emp => emp.Experience >= 5);
    }



    /*public static bool Promote(Employee emp)
    {
        if (emp.Experience >=5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }*/
}



delegate bool IsPromotable(Employee empl);


class Employee
{
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public int Salary { get; set; }
    
    public int Experience { get; set; }



    public static void PromoteEmployee(List<Employee> employeeList, IsPromotable ISEligibleToPromote)
    {
        foreach (Employee employee in employeeList)
        {
            if (ISEligibleToPromote(employee)) 
            {
                Console.WriteLine(employee.Name + " promoted");
            }
        }
    }
}