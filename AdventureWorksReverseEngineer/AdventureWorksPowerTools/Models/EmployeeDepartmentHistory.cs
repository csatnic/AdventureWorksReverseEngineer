using System;
using System.Collections.Generic;

namespace AdventureWorksPowerTools.Models
{
    public partial class EmployeeDepartmentHistory
    {
        public int BusinessEntityID { get; set; }
        public short DepartmentID { get; set; }
        public byte ShiftID { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual Department Department { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Shift Shift { get; set; }
    }
}
