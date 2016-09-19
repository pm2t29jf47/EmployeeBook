using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeBook.Site.ViewModels;

namespace EmployeeBook.Site.Pages
{
    public partial class EmployeeList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RewriteDBButton_OnClick(object sender, EventArgs e)
        {
            
        }

        public EmployeeViewModel SelectDefaultEmployeeViewModel()
        {
            return new EmployeeViewModel();
        }

        public void InsertEmployee()
        {
            throw new NotImplementedException();
        }
    }
}