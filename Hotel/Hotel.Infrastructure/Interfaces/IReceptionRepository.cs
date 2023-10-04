﻿using Hotel.Domain.Entities;
using Hotel.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Infrastructure.Interfaces
{
    public interface IReceptionRepository : IBaseRepository<Reception>
    {
    }
}