using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeBook.Data;

namespace EmployeeBook.Site.ViewModels
{
    public class EmployeeViewModel
    {
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string MainPhoneNumber { get; set; }
        public string Comment { get; set; }

        public EmployeeViewModel() { }

        public EmployeeViewModel(Employee employee)
        {
            ID = employee.ID;
            FirstName = employee.FirstName;
            SecondName = employee.SecondName;
            ThirdName = employee.ThirdName;
            MainPhoneNumber = employee.MainPhoneNumber;
            Comment = employee.Comment;
        }
    }
}