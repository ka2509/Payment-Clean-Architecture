using Microsoft.EntityFrameworkCore;
using PaymentCleanArchitecture.Domain.Entities;

namespace PaymentCleanArchitecture.Persistence.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Fee> Fees { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentDestination> PaymentDestinations { get; set; }
        public DbSet<PaymentSignature> PaymentSignatures { get; set; }
        public DbSet<PaymentTransaction> PaymentTransactions { get; set; }
        public DbSet<StudentFee> StudentFees { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<StudentFee>()
                .HasOne(u => u.Student)
                .WithMany(p => p.StudentFees)
                .HasForeignKey(p => p.StudentId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<StudentFee>()
                .HasOne(s => s.Fee)
                .WithMany(p => p.StudentFees)
                .HasForeignKey(s => s.FeeId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
