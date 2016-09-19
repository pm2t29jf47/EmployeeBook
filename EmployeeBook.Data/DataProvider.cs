using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EmployeeBook.Data
{
    public class DataProvider : IDataProvider
    {
        public void InsertExampleData()
        {
            using (var context = new EmployeeBookEntities())
            {
                ExampleDataGenerator.InsertExampleData(context);
                context.SaveChanges();
            }
        }
    }
}