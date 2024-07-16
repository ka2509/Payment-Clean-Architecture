using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentCleanArchitecture.Domain.Entities
{
    public class PaymentDestination
    {
        public int Id { get; set; }
        public string? DesLogo { get; set; } = string.Empty; 
        public string? DesShortName { get; set; } = string.Empty;    
        public string? DesName { get; set; } = string.Empty;
        public int? DesSortIndex { get; set; }
        public string? ParentId { get; set; } = string.Empty;
        public bool IsActive { get; set; }


        //navigation
        public List<Payment> Payments { get; set; } = new List<Payment>();
        public List<PaymentDestination> PaymentDestinations { get; set; } = new List<PaymentDestination>();
    }
}
