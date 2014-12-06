using System;
using System.Collections.Generic;

namespace AdventureWorksPowerTools.Models
{
    public partial class ContactType
    {
        public ContactType()
        {
            this.BusinessEntityContacts = new List<BusinessEntityContact>();
        }

        public int ContactTypeID { get; set; }
        public string Name { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; }
    }
}
