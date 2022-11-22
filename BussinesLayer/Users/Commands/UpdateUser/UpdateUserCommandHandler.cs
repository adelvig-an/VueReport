using BussinesLayer.Common.Exceptions;
using DbLayer.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Model;

namespace BussinesLayer.Users.Commands.UpdateUser
{
    public class UpdateUserCommandHandler 
        : IRequestHandler<UpdateUserCommand>
    {
        private readonly IUsersDbContext _dbContext;
        public UpdateUserCommandHandler(IUsersDbContext dbContext) => 
            _dbContext = dbContext;
        public async Task<Unit> Handle(UpdateUserCommand request,
            CancellationToken cancellationToken)
        {
            var entity =
                await _dbContext.Users.FirstOrDefaultAsync(user => 
                user.Id == request.Id, cancellationToken);

            if (entity == null || entity.Id != request.Id) 
            {
                throw new NotFoundException(nameof(User), request.Id);
            }

            entity.Login = request.Login;
            entity.Password = request.Password;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
