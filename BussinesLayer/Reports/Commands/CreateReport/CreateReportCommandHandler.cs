using BussinesLayer.Interfaces;
using MediatR;
using Model;

namespace BussinesLayer.Reports.Commands.CreateReport
{
    public class CreateReportCommandHandler 
        : IRequestHandler<CreateReportCommand, int>
    {
        private readonly IReportDbContext _dbContext;
        public CreateReportCommandHandler(IReportDbContext dbContext) =>
            _dbContext = dbContext;
        public async Task<int> Handle(CreateReportCommand request,
            CancellationToken cancellationToken)
        {
            var report = new Report
            {
                UserId = request.UserId,
                Number = request.Number,
                Id = request.Id,
                CreationDate = DateTime.Now
            };

            await _dbContext.Reports.AddAsync(report, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return report.Id;
        }
    }
}
