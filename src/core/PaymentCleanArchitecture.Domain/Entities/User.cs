﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentCleanArchitecture.Domain.Entities
{
    public class User
    {
        public string Id { get; set; } = string.Empty;
        public string? Name { get; set; } = string.Empty;
        public string? Class { get; set; } = string.Empty;
        public string? Password { get; set; } = string.Empty;
    }
}
