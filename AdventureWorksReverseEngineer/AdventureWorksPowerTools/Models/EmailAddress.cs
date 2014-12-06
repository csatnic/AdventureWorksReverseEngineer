using System;
using System.Collections.Generic;

namespace AdventureWorksPowerTools.Models
{
    public partial class EmailAddress
    {
        public int BusinessEntityID { get; set; }
        public int EmailAddressID { get; set; }
        public string EmailAddress1 { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual Person Person { get; set; }
    }
}
