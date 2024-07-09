using MediatR;
using PaymentCleanArchitecture.Application.Features.User.DTOs;
using PaymentCleanArchitecture.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentCleanArchitecture.Application.Features.User.Commands
{
    public record ICreateUserCommand(CreateUserDto userDto) : IRequest<ResponseService>;
}
