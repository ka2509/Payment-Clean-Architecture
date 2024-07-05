using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PaymentCleanArchitecture.Domain.Entities
{
    public class PaymentSignature
    {
        public string Id { get; set; } = String.Empty;
        public string? SignAlgo { get; set; } = String.Empty;
        public string? SignValue { get; set; } = String.Empty;
        public DateTime? SignDate { get; set; }
        public string? SignOwn { get; set; } = String.Empty;
        public string? PaymentId { get; set; } = String.Empty;
        public bool IsValid { get; set; }

    }
}
