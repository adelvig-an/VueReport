using BussinesLayer.Common.Exceptions;
using DbLayer.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Model;

namespace BussinesLayer.Reports.Commands.UpdateReport
{
    public class UpdateReportCommandHandler
        : IRequestHandler<UpdateReportCommand>
    {
        private readonly IReportDbContext _dbContext;
        public UpdateReportCommandHandler(IReportDbContext dbContext) =>
            _dbContext = dbContext;
        public async Task<Unit> Handle(UpdateReportCommand request,
            CancellationToken cancellationToken)
        {
            var entity = 
                await _dbContext.Reports.FirstOrDefaultAsync(report =>
                report.Id == request.Id, cancellationToken);

            if (entity == null || entity.UserId != request.UserId) 
            {
                throw new NotFoundException(nameof(Report), request.Id);
            }

            entity.Number = request.Number;
            entity.CreationDate = DateTime.Now;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
