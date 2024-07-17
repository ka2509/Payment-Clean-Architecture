using MediatR;
using PaymentCleanArchitecture.Application.Features.User.DTOs;
using PaymentCleanArchitecture.Application.Services;

namespace PaymentCleanArchitecture.Application.Features.User.Commands
{
    public record CreateUserCommand(CreateUserDto userDto) : IRequest<ResponseService>;
}
