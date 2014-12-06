using System;
using System.Collections.Generic;

namespace AdventureWorksPowerTools.Models
{
    public partial class PhoneNumberType
    {
        public PhoneNumberType()
        {
            this.PersonPhones = new List<PersonPhone>();
        }

        public int PhoneNumberTypeID { get; set; }
        public string Name { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<PersonPhone> PersonPhones { get; set; }
    }
}
