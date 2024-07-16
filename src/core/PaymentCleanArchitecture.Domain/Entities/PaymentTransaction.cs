
namespace PaymentCleanArchitecture.Domain.Entities
{
    public class PaymentTransaction
    {
        public string Id { get; set; } = String.Empty;
        public string? TranMessage { get; set; } = String.Empty;
        public string? TranPayload { get; set; } = String.Empty;
        public string? TranStatus { get; set; } = String.Empty;
        public decimal? TranAmount { get; set; }
        public DateTime? TranDate { get; set; }
        public string? PaymentId { get; set; } = String.Empty;

        //navigation
        public Payment Payment { get; set; }

    }
}
