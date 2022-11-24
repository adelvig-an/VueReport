using AutoMapper;
using AutoMapper.QueryableExtensions;
using BussinesLayer.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BussinesLayer.Reports.Queries.GetReportList
{
    public class GetReportListQueryHandler
        : IRequestHandler<GetReportListQuery, ReportListVM>
    {
        private readonly IReportDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetReportListQueryHandler(IReportDbContext dbContext, IMapper mapper) =>
            (_dbContext, _mapper) = (dbContext, mapper);
        public async Task<ReportListVM> Handle(GetReportListQuery request,
            CancellationToken cancellationToken)
        {
            var reportQuery = await _dbContext.Reports
                .Where(report => report.UserId == request.UserId)
                .ProjectTo<ReportLookupDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new ReportListVM { Reports = reportQuery };
        }


    }
}
