using DbLayer.Interfaces;
using MediatR;
using Model;
using System.Threading;
using System.Threading.Tasks;

namespace BussinesLayer.Users.Commands.CreateUser
{
    public class CreateUserCommandHandler
        : IRequestHandler<CreateUserCommand, Guid>
    {
        private readonly IUsersDbContext _dbContext;
        public CreateUserCommandHandler(IUsersDbContext dbContext) => 
            _dbContext = dbContext;
        public async Task<Guid> Handle (CreateUserCommand request,
            CancellationToken cancellationToken)
        {
            var user = new User
            {
                Login= request.Login,
                Password= request.Password,
                Id= Guid.NewGuid(),
            };

            await _dbContext.Users.AddAsync(user, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return user.Id;
        }
    }
}
