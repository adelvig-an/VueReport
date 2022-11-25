using MediatR;

namespace BussinesLayer.Reports.Queries.GetReportDetails
{
    public class GetReportDetailsQuery : IRequest<ReportDetailsVM>
    {
        public int UserId { get; set; }
        public int Id { get; set; }
    }
}
