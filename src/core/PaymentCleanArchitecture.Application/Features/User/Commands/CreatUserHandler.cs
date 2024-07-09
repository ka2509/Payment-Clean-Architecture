using MediatR;
using PaymentCleanArchitecture.Application.Services;
using PaymentCleanArchitecture.Domain.Entities;
using PaymentCleanArchitecture.Domain.Repositories;

namespace PaymentCleanArchitecture.Application.Features.User.Commands
{
    public class CreatUserHandler : IRequestHandler<ICreateUserCommand, ResponseService>
    {
        private readonly IUserRepository _repo;

        public CreatUserHandler(IUserRepository repo)
        {
            _repo = repo;   
        }
        public async Task<ResponseService> Handle(ICreateUserCommand request, CancellationToken cancellationToken)
        {
            var userDto = request.userDto;
            var createUser = new Domain.Entities.User()
            {
                Id = userDto.Id,
                Name = userDto.Name,
            };
            return new ResponseService(true, "create user successful!");
        }
    }
}
