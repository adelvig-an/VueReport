using MediatR;

namespace BussinesLayer.Reports.Commands.UpdateReport
{
    public class UpdateReportCommand : IRequest
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
        public string Number { get; set; }
    }
}
