using MediatR;

namespace BussinesLayer.Users.Commands.CreateUser
{
    public class CreateUserCommand : IRequest<Guid>
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
