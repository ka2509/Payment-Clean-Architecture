using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentCleanArchitecture.Domain.Entities
{
    public class StudentFee
    {
        public int Id { get; set; }
        public string? StudentId { get; set; } = string.Empty;
        public int? FeeId { get; set; }
        public decimal? PayAmount { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string? PaymentStatus { get; set; } = string.Empty;


        //navigation
        public User Student {  get; set; }
        public Fee Fee { get; set; }
    }
}
