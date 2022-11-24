using BussinesLayer.Interfaces;
using MediatR;
using Model;

namespace BussinesLayer.Reports.Commands.CreateReport
{
    public class CreateReportCommandHandler 
        : IRequestHandler<CreateReportCommand, Guid>
    {
        private readonly IReportDbContext _dbContext;
        public CreateReportCommandHandler(IReportDbContext dbContext) =>
            _dbContext = dbContext;
        public async Task<Guid> Handle(CreateReportCommand request,
            CancellationToken cancellationToken)
        {
            var report = new Report
            {
                UserId = request.UserId,
                Number = request.Number,
                Id = Guid.NewGuid(),
                CreationDate = DateTime.Now
            };

            await _dbContext.Reports.AddAsync(report, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return report.Id;
        }
    }
}
