using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBook.Data
{

    public enum BusinessObjectEnum { Employee, Position, Skill }

    public class BusinessObjectException : Exception
    {
        public BusinessObjectEnum BusinessObject { get; private set; }
        public BusinessObjectException(BusinessObjectEnum businessObject)
        {
            BusinessObject = businessObject;
        }
    }

    public class NotFindInCollectionException : BusinessObjectException
    {
        public NotFindInCollectionException(BusinessObjectEnum businessObject) : base(businessObject)
        { }
    }

    public class DuplicateInCollectionException : BusinessObjectException
    {
        public DuplicateInCollectionException(BusinessObjectEnum businessObject) : base(businessObject)
        { }
    }
}
