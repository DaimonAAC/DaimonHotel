﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Domain.Core
{
    public class BDescription : BaseEntity
    {
        public string? Description { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
