using System;
using System.Linq;
using EmployeeBook.Data;

namespace EmployeeBook.Site.Pages
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void InsertDefaultDataButton_OnClick(object sender, EventArgs e)
        {
            var a = new DataProvider();
            a.InsertExampleData();
        }
    }
}