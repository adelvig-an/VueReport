using BussinesLayer.Common.Exceptions;
using BussinesLayer.Interfaces;
using MediatR;
using Model;

namespace BussinesLayer.Reports.Commands.DeleteReport
{
    public class DeleteReportCommandHandler 
        : IRequestHandler<DeleteReportCommand> 
    {
        private readonly IReportDbContext _dbContext;
        public DeleteReportCommandHandler(IReportDbContext dbContext) =>
            _dbContext = dbContext;
        public async Task<Unit> Handle(DeleteReportCommand request,
            CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Reports
                .FindAsync(new object[] { request.Id }, cancellationToken);
            if (entity == null || entity.UserId != request.UserId)
            {
                throw new NotFoundException(nameof(Report), request.Id);
            }

            _dbContext.Reports.Remove(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
