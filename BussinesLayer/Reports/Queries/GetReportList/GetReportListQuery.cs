using MediatR;

namespace BussinesLayer.Reports.Queries.GetReportList
{
    public class GetReportListQuery : IRequest<ReportListVM>
    {
        public Guid UserId { get; set; }
    }
}
