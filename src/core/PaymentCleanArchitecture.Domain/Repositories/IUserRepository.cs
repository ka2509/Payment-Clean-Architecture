using PaymentCleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentCleanArchitecture.Domain.Repositories
{
    public interface IUserRepository
    {
        public Task<bool> Register(User user);
    }
}
