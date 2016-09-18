using System;
using System.Linq;
using EmployeeBook.Data;

namespace EmployeeBook.Site
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var dbContext = new EmployeeBookEntities())
            {
                var a = dbContext.Employees.Count();

            }
        }
    }
}