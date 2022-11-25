using MediatR;

namespace BussinesLayer.Reports.Commands.UpdateReport
{
    public class UpdateReportCommand : IRequest
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Number { get; set; }
    }
}
