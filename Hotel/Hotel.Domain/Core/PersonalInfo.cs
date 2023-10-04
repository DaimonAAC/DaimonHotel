using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Domain.Core
{
    public class PersonalInfo : BaseEntity
    {
        public string? FullName { get; set; }
        public string? Email { get; set; }

        public DateTime? CreationDate { get; set; }
    }
}
