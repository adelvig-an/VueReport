using MediatR;

namespace BussinesLayer.Reports.Queries.GetReportDetails
{
    public class GetReportDetailsQuery : IRequest<ReportDetailsVM>
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
    }
}
