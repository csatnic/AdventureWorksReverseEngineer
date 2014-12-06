using System;
using System.Collections.Generic;

namespace AdventureWorksPowerTools.Models
{
    public partial class Password
    {
        public int BusinessEntityID { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual Person Person { get; set; }
    }
}
