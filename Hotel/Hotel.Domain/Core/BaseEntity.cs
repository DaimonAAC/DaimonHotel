using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Domain.Core
{
    public class BaseEntity
    {
        public bool? Status { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int CreationUserId { get; set; }
        public DateTime? ModDate { get; set; }
        public int? ModUserId { get; set; }
        public int? DeleteUserId { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool Deleted { get; set; }
    }
}
