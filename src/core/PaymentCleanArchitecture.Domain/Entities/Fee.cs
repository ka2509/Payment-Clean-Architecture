using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentCleanArchitecture.Domain.Entities
{
    public class Fee
    {
        public int Id { get; set; }
        public string? FeeName { get; set; } = string.Empty;
    }
}
