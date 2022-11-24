using AutoMapper;
using BussinesLayer.Common.Exceptions;
using BussinesLayer.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Model;

namespace BussinesLayer.Reports.Queries.GetReportDetails
{
    public class GetReportDetailsQueryHandler
        : IRequestHandler<GetReportDetailsQuery, ReportDetailsVM>
    {
        private readonly IReportDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetReportDetailsQueryHandler(IReportDbContext dbContext, IMapper mapper) =>
            (_dbContext, _mapper) = (dbContext, mapper);

        public async Task<ReportDetailsVM> Handle(GetReportDetailsQuery request, 
            CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Reports
                .FirstOrDefaultAsync(report => report.Id == request.Id, cancellationToken);
            if (entity == null || entity.UserId != request.UserId) 
            {
                throw new NotFoundException(nameof(Report), request.Id);
            }

            return _mapper.Map<ReportDetailsVM>(entity);
        }
    }
}
