using PaymentCleanArchitecture.Domain.Entities;
using PaymentCleanArchitecture.Domain.Repositories;

namespace PaymentCleanArchitecture.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        public Task<bool> Register(User user)
        {
            throw new NotImplementedException();
        }
    }
}
