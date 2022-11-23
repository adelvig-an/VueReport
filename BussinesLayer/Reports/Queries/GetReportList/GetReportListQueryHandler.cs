using AutoMapper;
using AutoMapper.QueryableExtensions;
using DbLayer.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

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
            //var reportQuery = await _dbContext.Reports
            //    .FirstOrDefaultAsync(report => report.UserId == request.UserId, cancellationToken: cancellationToken);

            //var mepresult = _mapper.Map<ReportLookupDto>(reportQuery);

            //return new ReportListVM { Reports = null };


            var reportQuery = await _dbContext.Reports
                .Where(report => report.UserId == request.UserId)
                .ProjectTo<ReportLookupDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new ReportListVM { Reports = reportQuery };
        }


    }
}
