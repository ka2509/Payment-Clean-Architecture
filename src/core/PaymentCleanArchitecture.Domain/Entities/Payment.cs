using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentCleanArchitecture.Domain.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public string? PaymentContent { get; set; } = string.Empty;
        public string? PaymentCurrency { get; set; } = string.Empty;
        public string? PaymentRefId { get; set; } = string.Empty;
        public decimal? RequiredAmount { get; set; }
        public DateTime? PaymentDate { get; set; } = DateTime.Now;
        public DateTime? ExpireDate { get; set; }
        public string? PaymentDestinationId { get; set; } = string.Empty;
        public decimal? PaidAmount { get; set; }
        public string? PaymentStatus { get; set; } = string.Empty;
        public string? PaymentLastMessage { get; set; } = string.Empty;

        //navigation
        public PaymentDestination PaymentDestination { get; set; }
        public List<PaymentTransaction> PaymentTransactions { get; set; } = new List<PaymentTransaction>();
        public List<PaymentSignature> PaymentSignatures { get; set; } = new List<PaymentSignature>();

    }
}
