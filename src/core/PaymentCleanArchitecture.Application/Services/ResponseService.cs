using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentCleanArchitecture.Application.Services
{
    public record ResponseService(bool Sucess, string? Message);
}