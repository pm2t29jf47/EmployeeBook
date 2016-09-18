using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeBook.Data;

namespace EmployeeBook.TestDBAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new EmployeeBookEntities())
            {
                dbContext.Employees.Add(new Employee
                {
                    FirstName = "Иван",
                    SecondName = "Иванов",
                    ThirdName = "Иванович"
                });
                dbContext.SaveChanges();
                var id = dbContext.Employees.First().ID;
                var count = dbContext.Employees.Count();
            }
        }
    }
}
