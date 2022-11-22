using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesLayer.Common.Exceptions;
using DbLayer.Interfaces;
using MediatR;
using Model;

namespace BussinesLayer.Users.Commands.DeleteUser
{
    internal class DeleteUserCommandHandler 
        : IRequestHandler<DeleteUserCommand>
    {
        private readonly IUsersDbContext _dbContext;

        public DeleteUserCommandHandler(IUsersDbContext dbContext) => 
            _dbContext = dbContext;
        public async Task<Unit> Handle(DeleteUserCommand request, 
            CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Users
                .FindAsync(new object[] { request.Id }, cancellationToken);

            if (entity == null || entity.Id != request.Id) 
            {
                throw new NotFoundException(nameof(User), request.Id);
            }

            _dbContext.Users.Remove(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
